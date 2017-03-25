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
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

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
			var app = new PowerPoint.Application();

			var pres = app.Presentations;
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					var files = Directory.GetFiles(fbd.SelectedPath);
					for (int i = 0; i < files.Length; i++)
					{
						var file = pres.Open(files[i], MsoTriState.msoTrue, MsoTriState.msoTrue, MsoTriState.msoFalse);
						file.SaveCopyAs(@"D:\presentation"+i.ToString(), PowerPoint.PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoTrue);
					}
				}
			}
		}

		private  void selectBtn_Click(object sender, EventArgs e)
		{
			DataService.GetServiceFile();
			var app = new PowerPoint.Application();
			var pres = app.Presentations;
			string AlbumID;
			string[] files;
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					files = Directory.GetFiles(fbd.SelectedPath);
					MessageBox.Show("presentaions found: " + files.Length.ToString(), "Message");

					for (int i = 0; i < files.Length; i++)
					{
						var file = pres.Open(files[i], MsoTriState.msoTrue, MsoTriState.msoTrue, MsoTriState.msoFalse);
						//AlbumID = DataService.CreateAlbum("Тема 2 ", "чето - туто ы і");
						file.SaveCopyAs(fbd.SelectedPath+"\\presentation" + i.ToString(), PowerPoint.PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoTrue);

						string[] presentationDir = Directory.GetFiles(fbd.SelectedPath + "\\presentation" + i.ToString());
						MessageBox.Show("slides found: " + presentationDir.Length.ToString(), "Message");

						//for (int j = 0; j < presentationDir.Length; j++)
						//{
						//	//await DataService.Upload(presentationDir[j]);
						//}
					}

					//MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
					//for (int i = 0; i < files.Length; i++)
					//{
					//	//await DataService.Upload(files[i]);
					//}
				}
			}
		}
	}
}
