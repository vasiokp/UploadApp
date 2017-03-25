namespace UploadApp
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.closeBtn = new System.Windows.Forms.Button();
			this.selectBtn = new System.Windows.Forms.Button();
			this.uploadBtn = new System.Windows.Forms.Button();
			this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.txtBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(354, 277);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(96, 28);
			this.closeBtn.TabIndex = 0;
			this.closeBtn.Text = "Close";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// selectBtn
			// 
			this.selectBtn.Location = new System.Drawing.Point(12, 277);
			this.selectBtn.Name = "selectBtn";
			this.selectBtn.Size = new System.Drawing.Size(96, 28);
			this.selectBtn.TabIndex = 1;
			this.selectBtn.Text = "Select";
			this.selectBtn.UseVisualStyleBackColor = true;
			this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
			// 
			// uploadBtn
			// 
			this.uploadBtn.Location = new System.Drawing.Point(175, 277);
			this.uploadBtn.Name = "uploadBtn";
			this.uploadBtn.Size = new System.Drawing.Size(96, 28);
			this.uploadBtn.TabIndex = 2;
			this.uploadBtn.Text = "Upload";
			this.uploadBtn.UseVisualStyleBackColor = true;
			this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
			// 
			// txtBox
			// 
			this.txtBox.Location = new System.Drawing.Point(12, 12);
			this.txtBox.Multiline = true;
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(438, 259);
			this.txtBox.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 317);
			this.Controls.Add(this.txtBox);
			this.Controls.Add(this.uploadBtn);
			this.Controls.Add(this.selectBtn);
			this.Controls.Add(this.closeBtn);
			this.Name = "MainForm";
			this.Text = "UploadApp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button selectBtn;
		private System.Windows.Forms.Button uploadBtn;
		private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
		private System.Windows.Forms.TextBox txtBox;
	}
}

