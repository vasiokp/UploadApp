using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace UploadApp
{
	public class DataService
	{
		public static string AlbumCollectionUrl;
		static string BaseUrl = "https://api-fotki.yandex.ru/api/users/textbook.book/";
		static string ID = "f0afaac6ebaa43cd94fabdfb02bb65a9";
		static string Password = "f6d1762f82704c099bbc8d9ee5e5747f";
		static string token = "AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";
		static string Token = "?oauth_token=AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";

		public static void GetServiceFile()
		{
			var reg = new Regex("href=.+album-list");
			using (var client = new HttpClient())
			{
				HttpRequestMessage request = new HttpRequestMessage();
				request.RequestUri = new Uri(BaseUrl);
				request.Method = HttpMethod.Get;
				request.Headers.Add("Accept", "application /json");
			//	request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("OAuth " + Password);

				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
				var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				dynamic js = JsonConvert.DeserializeObject(content);
				var de = js.collections["album-list"].href;
				//var serializedData = JsonConvert.SerializeObject(derializedContent[contentField]);
				//ar JsonConvert.DeserializeObject<T>(serializedData);
				//var content = Regex.Match(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), "href=.+album-list").Value;
				AlbumCollectionUrl = js.collections["album-list"].href;
			}
		}

		public static void GetAlbumCollection()
		{
			using (var client = new HttpClient())
			{
				HttpRequestMessage request = new HttpRequestMessage();
				request.RequestUri = new Uri(AlbumCollectionUrl);
				request.Method = HttpMethod.Get;
				request.Headers.Add("Accept", "application /json");

				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
				var a = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				dynamic js = JsonConvert.DeserializeObject(a);

				//var content = Regex.Match(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), "href=.+album-list").Value;
				//AlbumCollectionUrl = Regex.Match(content, "https.+/").Value;
			}
		}

		public static void CreateAlbum()
		{
			var das = " sda ";
			string atomXml = "<entry xmlns=\"http://www.w3.org/2005/Atom/\" xmlns:f=\"yandex:fotki\">< title > Горы3 </ title > < summary > Фотографии природы с разных источников</ summary > </ entry > ";
			using (var client = new HttpClient())
			{
				HttpWebRequest request= (HttpWebRequest)HttpWebRequest.Create(AlbumCollectionUrl + Token); ;
				request.Method = HttpMethod.Post.Method;
				request.ContentType = "application/atom+xml;type=entry";
				//request.

				HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
				using (System.IO.StreamReader stream = new StreamReader(
					 resp.GetResponseStream(), Encoding.UTF8))
				{
					das+= stream.ReadToEnd();
				}
				//a.ContentType=
				//request.RequestUri = new Uri(AlbumCollectionUrl+Token);
				//request.Method = HttpMethod.Post;
				//request.Headers.Add("Content-Type", "application/atom+xml;type=entry");
			//	request.Headers.Add()
				//request.Content.
				//HttpContent content = new StringContent(atomXml,Encoding.UTF8);
				//content.Headers.Add("Content-Type", "application/atom+xml;type=entry");
				//request.Content = content;
				//HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
			}
		}

	}
}
