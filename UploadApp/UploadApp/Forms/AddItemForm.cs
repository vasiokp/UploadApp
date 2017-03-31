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
			if (subjectNameTxt.Text.Trim() != "")
			{
				AlbumName = subjectNameTxt.Text.Trim();
				AlbumDesc = subjectDescTxt.Text.Trim();
				Close();
			}
		}

		private void AddItemForm_Load(object sender, EventArgs e)
		{

		}
	}
}
