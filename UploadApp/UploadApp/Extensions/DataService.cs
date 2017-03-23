﻿using System;
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
		static string BaseUrl = "https://api-fotki.yandex.ru/api/users/textbook-book/";
		static string ID = "f0afaac6ebaa43cd94fabdfb02bb65a9";
		static string Password = "f6d1762f82704c099bbc8d9ee5e5747f";
		static string token = "AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";
		static string Token = "?oauth_token=AQAAAAAcWgBoAAQiY_2AHS7QjklnuYLfJR11FJA";

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
				var de = js.collections["album-list"].href;
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
			}
		}

		public static void CreateAlbum()
		{
			string albumName = "newAlbum";
			string albumDesc = "descforAlbum";
			string atomXml = "<entry xmlns=\"http://www.w3.org/2005/Atom\" xmlns:f=\"yandex:fotki\"><title>"+albumName +"</title> <summary>"+albumDesc+"</summary> </entry> ";
			using (var client = new HttpClient())
			{
				StringContent content = new StringContent(atomXml,Encoding.UTF8);
				System.Net.Http.Headers.NameValueHeaderValue typeEntry = new System.Net.Http.Headers.NameValueHeaderValue("type");
				typeEntry.Value = "entry";
				content.Headers.ContentType.MediaType = "application/atom+xml";
				content.Headers.ContentType.Parameters.Add(typeEntry);
				var a = client.PostAsync(AlbumCollectionUrl + Token, content).GetAwaiter().GetResult();
				var b = a.Content.ReadAsStringAsync().GetAwaiter().GetResult();
			}
		}

	}
}
