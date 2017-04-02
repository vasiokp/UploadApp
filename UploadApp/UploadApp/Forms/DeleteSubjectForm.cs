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
	public partial class DeleteSubjectForm : Form
	{
		public DeleteSubjectForm()
		{
			InitializeComponent();
		}

		private string SubjName { get; set; }
		private string SubjId { get; set; }
		public DeleteSubjectForm(string subjId,string subjName)
		{
			InitializeComponent();
			SubjName = subjName;
			SubjId = subjId;
		}

		private void DeleteSubjectForm_Load(object sender, EventArgs e)
		{
			subjLbl.Text = SubjName;
		}

		private void noBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void yesBtn_Click(object sender, EventArgs e)
		{
			DataService.DeleteAlbum(SubjId);
		}
	}
}
