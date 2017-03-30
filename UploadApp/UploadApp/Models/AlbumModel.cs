using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadApp
{
	public class AlbumModel
	{
		public static string AlbumId { get; set; }
		public static string AlbumName { get; set; }
		public static string AlbumDesc { get; set; }
		public static List<AlbumModel> AlbumsList { get; set; }

		public  AlbumModel(string id, string name, string desc)
		{
			AlbumId = id;
			AlbumName = name;
			AlbumDesc = desc;
		}
	}


}
