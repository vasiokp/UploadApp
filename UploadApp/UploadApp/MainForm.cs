using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void uploadBtn_Click(object sender, EventArgs e)
		{
			//DataService.GetServiceFile();
			//DataService.CreateAlbum();
			//DataService.UploadImg();
			//var a = DataService.Upload();
		}

		private void selectBtn_Click(object sender, EventArgs e)
		{
			string[] files;
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					files = Directory.GetFiles(fbd.SelectedPath);

					MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
					for (int i = 0; i < files.Length; i++)
					{
						DataService.Upload(files[i]);
					}
				}
			}

		}
	}
}
