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

		private async void selectBtn_Click(object sender, EventArgs e)
		{
			DataService.GetServiceFile();
			var app = new PowerPoint.Application();
			var pres = app.Presentations;
			string newAlbumID;
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
						char[] symbols = new char[] { '\\', '\0', '\a', '\b', '\f', '\n', '\r', '\t', '\v' };
						string title;
						string newAlbumTitle;
						string newAlbumDescription;
						if (file.Slides[1].Shapes.Title.TextEffect.Text.IndexOfAny(symbols) != -1)
						{
							title = file.Slides[1].Shapes.Title.TextEffect.Text.Substring(0, file.Slides[1].Shapes.Title.TextEffect.Text.IndexOfAny(symbols));
							newAlbumTitle = title.Split(':', '.').FirstOrDefault();
							newAlbumDescription = title.Split(':', '.').LastOrDefault();
						}
						else
						{
							newAlbumTitle = file.Slides[1].Shapes.Title.TextEffect.Text.Split(':', '.').FirstOrDefault();
							newAlbumDescription = file.Slides[1].Shapes.Title.TextEffect.Text.Split(':', '.').LastOrDefault();
						}
						newAlbumID = DataService.CreateAlbum(newAlbumTitle, newAlbumDescription);
						file.SaveCopyAs(fbd.SelectedPath+"\\presentation" + i.ToString(), PowerPoint.PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoTrue);
						string[] presentations = Directory.GetFiles(fbd.SelectedPath + "\\presentation" + i.ToString());
						MessageBox.Show("slides found: " + presentations.Length.ToString(), "Message");
						for (int j = 0; j < presentations.Length; j++)
						{
						await DataService.Upload(newAlbumID,presentations[j]);
						}
					}

				}
			}
		}
	}
}
