using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			DataService.GetServiceFile();
			DataService.CreateAlbum();
		}

		private void selectBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
