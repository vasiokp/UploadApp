using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace UploadApp
{
	public static class DataService
	{
		public static string AlbumCollectionUrl;
		public const string BaseUrl = "https://api-fotki.yandex.ru/api/users/textbook-book/";
		private const string ID = "f0afaac6ebaa43cd94fabdfb02bb65a9";
		private const string Password = "f6d1762f82704c099bbc8d9ee5e5747f";
		private const string token = "AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";
		private const string Token = "?oauth_token=AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";

		public static void DeleteAlbum(string albumId)
		{
			using (var client = new HttpClient())
			{
				var request = new HttpRequestMessage();
				request.RequestUri = new Uri(BaseUrl+"album/" + albumId + "/" +Token);
				request.Method = HttpMethod.Delete;
				request.Headers.Add("Accept", "application /json");
				var response = client.SendAsync(request).GetAwaiter().GetResult();
			}
		}
		public static void GetServiceFile()
		{
			using (var client = new HttpClient())
			{
				HttpRequestMessage request = new HttpRequestMessage();
				request.RequestUri = new Uri(BaseUrl);
				request.Method = HttpMethod.Get;
				request.Headers.Add("Accept", "application /json");

				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
				var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				dynamic js = JsonConvert.DeserializeObject(content);
				AlbumCollectionUrl = js.collections["album-list"].href;
			}
		}

		public static string CreateAlbum(string albumName,string albumDesc, string parrentAlbumId = "0")
		{
			string atomXmlCreateAlbum;
			if (parrentAlbumId != "0")
				atomXmlCreateAlbum = "<entry xmlns=\"http://www.w3.org/2005/Atom\" xmlns:f=\"yandex:fotki\"> " +
				                     "<link href=\"" + BaseUrl + $"album\"{parrentAlbumId}\" rel=\"album\"/>" +
									 $"<title>{albumName}</title> <summary>{albumDesc}</summary> </entry>";
			else
				atomXmlCreateAlbum = "<entry xmlns=\"http://www.w3.org/2005/Atom\" xmlns:f=\"yandex:fotki\"> " +
									 $"<title>{albumName}</title> <summary>{albumDesc}</summary> </entry>";
				using (var client = new HttpClient())
			{
				var content = new StringContent(atomXmlCreateAlbum, Encoding.UTF8);
				var typeEntry = new System.Net.Http.Headers.NameValueHeaderValue("type")
				{
					Value = "entry"
				};
				content.Headers.ContentType.MediaType = "application/atom+xml";
				content.Headers.ContentType.Parameters.Add(typeEntry);
				var result = client.PostAsync(AlbumCollectionUrl + Token, content).GetAwaiter().GetResult();
				return result.Content.Headers.ContentLocation.ToString().Split('/')[6]; // index of id album in uri
			}
		}

		public static async Task Upload(string albumId,string imgPath)
		{
			byte[] image = File.ReadAllBytes(imgPath);
			var imgName = imgPath.Split('\\').Last();

			string url = BaseUrl+"album/"+albumId+"/photos/"+Token;
			using (var client = new HttpClient())
			{
				var requestContent = new MultipartFormDataContent();
				var imageContent = new ByteArrayContent(image);
				imageContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("image/jpeg");
				requestContent.Add(imageContent, "image", imgName);
				await client.PostAsync(url, requestContent);
			}
		}
	}

	}

