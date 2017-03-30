using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UploadApp.AlbumModel;

namespace UploadApp.Forms
{
	public partial class AddItemForm : Form
	{

		public AddItemForm()
		{
			InitializeComponent();
		}


		private void closeAddItemFormBtn_Click(object sender, EventArgs e) => Close();

		private void CreateItemBtn_Click(object sender, EventArgs e)
		{
			if (subjectNameTxt.Text != "")
			{
				var id = DataService.CreateAlbum(subjectNameTxt.Text.Trim(), subjectDescTxt.Text.Trim());
				var album = new AlbumModel(
					id: id,
					name: subjectNameTxt.Text.Trim(),
					desc: subjectDescTxt.Text.Trim());
				if (id != null)
				{
					AlbumsList.Add(album);
					Close();
				}
			}

		}
	}
}
