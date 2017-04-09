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
					progressBar.Maximum = files.Length;
					progressBar.Step = 1;

					for (int i = 0; i < files.Length; i++)
					{
						progressBar.PerformStep();
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
						file.SaveCopyAs(SelectedPath + "\\presentation" + (i+1).ToString(), PowerPoint.PpSaveAsFileType.ppSaveAsJPG, MsoTriState.msoTrue);
						string[] presentations = Directory.GetFiles(SelectedPath + "\\presentation" + (i + 1).ToString());
						presentationsGrid.Rows.Add(AlbumName.Trim() + ". " + AlbumDesc.Trim(), presentations.Length);
					}
				}
			}
		}

		private async void uploadBtn_Click(object sender, EventArgs e)
		{
			dynamic selectedItem = itemDropDown.SelectedItem;
			AlbumName = selectedItem.Name;
			AlbumId = selectedItem.Id;
			AlbumId = selectedItem.Id == "0"
				? AlbumId = DataService.CreateAlbum(AlbumName, AlbumDesc)
				: AlbumId = selectedItem.Id;

			var album = new AlbumListItem(AlbumId, AlbumName);
			bindinglist.Add(album);
			itemDropDown.SelectedItem = album;
			bindinglist.Remove(selectedItem);
			progressBar.Value = 0;
			progressBar.Maximum = presentationsGrid.Rows.Count - 1;
			progressBar.Step = 1;

			for (int i = 0; i < presentationsGrid.Rows.Count-1; i++)
			{
				progressBar.PerformStep();
				string[] presentations = Directory.GetFiles(SelectedPath + "\\presentation" + (i + 1).ToString());
				progressUpload.Value = 0;
				progressUpload.Maximum = presentations.Length;
				progressUpload.Step = 1;
				var titleInGrid = presentationsGrid.Rows[i].Cells[0].EditedFormattedValue;
				AlbumName = titleInGrid.ToString().Split('.').FirstOrDefault()+".";
				AlbumDesc = titleInGrid.ToString().Split('.').LastOrDefault();
				var newAlbumId = DataService.CreateAlbum(AlbumName, AlbumDesc, AlbumId);
					for (int j = 0; j < presentations.Length; j++)
						{
							await DataService.Upload(newAlbumId, presentations[j]);
							progressUpload.PerformStep();
						}
				Directory.Delete(SelectedPath + "\\presentation" + (i + 1).ToString(),true);
			}
		}

		private void addItemBtn_Click(object sender, EventArgs e)
		{
			var itemForm = new AddItemForm();
			itemForm.ShowDialog();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			bindinglist = new BindingList<AlbumListItem>();
			bSource = new BindingSource();
			DataService.GetServiceFile();
			DataService.GetAlbumList();
			bSource.DataSource = bindinglist;
			itemDropDown.DataSource = bSource;
			itemDropDown.DisplayMember = "Name";
			itemDropDown.ValueMember = "Id";
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			dynamic subjName = itemDropDown.SelectedItem;
			var deleteForm  = new DeleteSubjectForm(subjName.Id, subjName.Name);
			deleteForm.ShowDialog();
		}

		private void itemDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void subjectBox_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
