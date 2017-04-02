using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadApp
{
	public class AlbumModel
	{
		public static string AlbumId { get; set; }
		public static string AlbumName { get; set; }
		public static string AlbumDesc { get; set; }
		public static BindingList<AlbumListItem> bindinglist { get; set; }
		public static BindingSource bSource { get; set; }


		public AlbumModel(string id, string name, string desc)
		{
			AlbumId = id;
			AlbumName = name;
			AlbumDesc = desc;
		}

		public AlbumModel(string id, string name)
		{
			AlbumId = id;
			AlbumName = name;
		}

		public class AlbumListItem
		{
			public string Id { get; set; }
			public string Name { get; set; }

			public AlbumListItem(string id, string name)
			{
				Id = id;
				Name = name;
			}
		}
		
	}


}
