using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
namespace UploadApp
{
	public class DataService
	{
		public static string AlbumCollectionUrl;
		static string BaseUrl = "https://api-fotki.yandex.ru/api/users/textbook.book/";
		static string ID = "f0afaac6ebaa43cd94fabdfb02bb65a9";
		static string Password = "f6d1762f82704c099bbc8d9ee5e5747f";
		static string Token = "AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";

		public static void token()
		{
			using (var client = new HttpClient())
			{
				string atomXml = "<entry xmlns=\"http://www.w3.org/2005/Atom/\" xmlns:f=\"yandex:fotki\">< title > Горы </ title > < summary > Фотографии природы с разных источников</ summary > </ entry > ";
					HttpRequestMessage request = new HttpRequestMessage();
					request.RequestUri = new Uri(AlbumCollectionUrl);
					HttpContent content = new StringContent(atomXml);
					request.Content = content;
				request.Method = HttpMethod.Post;
				request.Headers.Add("Authorization", Token);

				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
				var content2 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

			}

		}

		public static void GetServiceFile()
		{
			var reg = new Regex("href=.+album-list");
			using (var client = new HttpClient())
			{
				HttpRequestMessage request = new HttpRequestMessage();
				request.RequestUri = new Uri(BaseUrl);
				request.Method = HttpMethod.Get;
			//	request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("OAuth " + Password);

				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
				var content = Regex.Match(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), "href=.+album-list").Value;
				AlbumCollectionUrl = Regex.Match(content, "https.+/").Value;
			}
		}

		public static void GetAlbumCollection()
		{
			using (var client = new HttpClient())
			{
				HttpRequestMessage request = new HttpRequestMessage();
				request.RequestUri = new Uri(AlbumCollectionUrl);
				request.Method = HttpMethod.Get;

				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
				var a = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				//var content = Regex.Match(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), "href=.+album-list").Value;
				//AlbumCollectionUrl = Regex.Match(content, "https.+/").Value;
			}
		}

		public static void CreateAlbum()
		{
			string atomXml = "<entry xmlns=\"http://www.w3.org/2005/Atom/\" xmlns:f=\"yandex:fotki\">< title > Горы </ title > < summary > Фотографии природы с разных источников</ summary > </ entry > ";
			using (var client = new HttpClient())
			{ 
				HttpRequestMessage request = new HttpRequestMessage();
				request.RequestUri = new Uri(AlbumCollectionUrl);
				request.Method = HttpMethod.Post;
				HttpContent content = new StringContent(atomXml);
				request.Content = content;
				HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();
			}
		}

	}
}
