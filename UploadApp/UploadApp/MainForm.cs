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
using UploadApp.Forms;
using static UploadApp.AlbumModel;
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

		private string	SelectedPath { get; set; }

		

		private void selectBtn_Click(object sender, EventArgs e)
		{
			var app = new PowerPoint.Application();
			var pres = app.Presentations;
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();
				SelectedPath = fbd.SelectedPath;

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(SelectedPath))
				{
					var files = Directory.GetFiles(SelectedPath);
					for (int i = 0; i < files.Length; i++)
					{
						var file = pres.Open(files[i], MsoTriState.msoTrue, MsoTriState.msoTrue, MsoTriState.msoFalse);
						char[] symbols = { '\\', '\0', '\a', '\b', '\f', '\n', '\r', '\t', '\v' };
						if (file.Slides[1].Shapes.Title.TextEffect.Text.IndexOfAny(symbols) != -1)
							{
								var title = file.Slides[1].Shapes.Title.TextEffect.Text.Substring(0, file.Slides[1].Shapes.Title.TextEffect.Text.IndexOfAny(symbols));
								AlbumName = title.Split(':', '.').FirstOrDefault();
								AlbumDesc = title.Split(':', '.').LastOrDefault();
							}
						else
							{
								AlbumName = file.Slides[1].Shapes.Title.TextEffect.Text.Split(':', '.').FirstOrDefault();
								AlbumDesc = file.Slides[1].Shapes.Title.TextEffect.Text.Split(':', '.').LastOrDefault();
							}
						file.SaveCopyAs(SelectedPath + "\\presentation" + i+1, PowerPoint.PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoTrue);
						string[] presentations = Directory.GetFiles(SelectedPath + "\\presentation" + i+1);
						presentationsGrid.Rows.Add(AlbumName.Trim() + ". " + AlbumDesc.Trim(), presentations.Length);
					}
				}
			}
		}

		private void uploadBtn_Click(object sender, EventArgs e)
		{
			//for (int i = 0; i < presentationsGrid.Rows.Count-1; i++)
			//{
			//	string[] presentations = Directory.GetFiles(SelectedPath + "\\presentation" + i + 1);

			//	var titleInGrid = presentationsGrid.Rows[i].Cells[0].EditedFormattedValue;
			//	//newAlbumID = DataService.CreateAlbum(selectItem.se,titleInGrid.ToString().Split('.').FirstOrDefault(), titleInGrid.ToString().Split('.').LastOrDefault());
			//					//	for (int j = 0; j < presentations.Length; j++)
			//			//{
			//			//await DataService.Upload(newAlbumID,presentations[j]);
			//		//	}
			//}
		}

		private void addItemBtn_Click(object sender, EventArgs e)
		{
			var itemForm = new AddItemForm();
			itemForm.ShowDialog();
			var a = AlbumId;
			
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DataService.GetServiceFile();
		}
	}
}
