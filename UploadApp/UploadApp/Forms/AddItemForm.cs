using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadApp.Forms
{
	public partial class AddItemForm : Form
	{
		private string newAlbumId;

		public AddItemForm()
		{
			InitializeComponent();
		}

		public AddItemForm(string newAlbumId)
		{
			this.newAlbumId = newAlbumId;
		}

		private void closeAddItemFormBtn_Click(object sender, EventArgs e) => Close();

		private void CreateItemBtn_Click(object sender, EventArgs e)
		{
			if (subjectNameTxt.Text != "")
			{
			 DataService.CreateAlbum(subjectNameTxt.Text, subjectDescTxt.Text);
			}
		}
	}
}
