namespace UploadApp.Forms
{
	partial class AddItemForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.subjectNameTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.subjectDescTxt = new System.Windows.Forms.TextBox();
			this.closeAddItemFormBtn = new System.Windows.Forms.Button();
			this.CreateItemBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// subjectNameTxt
			// 
			this.subjectNameTxt.Location = new System.Drawing.Point(12, 36);
			this.subjectNameTxt.Multiline = true;
			this.subjectNameTxt.Name = "subjectNameTxt";
			this.subjectNameTxt.Size = new System.Drawing.Size(234, 20);
			this.subjectNameTxt.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Subject name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Subject description";
			// 
			// subjectDescTxt
			// 
			this.subjectDescTxt.Location = new System.Drawing.Point(12, 98);
			this.subjectDescTxt.Multiline = true;
			this.subjectDescTxt.Name = "subjectDescTxt";
			this.subjectDescTxt.Size = new System.Drawing.Size(234, 49);
			this.subjectDescTxt.TabIndex = 3;
			// 
			// closeAddItemFormBtn
			// 
			this.closeAddItemFormBtn.Location = new System.Drawing.Point(158, 172);
			this.closeAddItemFormBtn.Name = "closeAddItemFormBtn";
			this.closeAddItemFormBtn.Size = new System.Drawing.Size(75, 23);
			this.closeAddItemFormBtn.TabIndex = 4;
			this.closeAddItemFormBtn.Text = "Close";
			this.closeAddItemFormBtn.UseVisualStyleBackColor = true;
			this.closeAddItemFormBtn.Click += new System.EventHandler(this.closeAddItemFormBtn_Click);
			// 
			// CreateItemBtn
			// 
			this.CreateItemBtn.Location = new System.Drawing.Point(12, 172);
			this.CreateItemBtn.Name = "CreateItemBtn";
			this.CreateItemBtn.Size = new System.Drawing.Size(75, 23);
			this.CreateItemBtn.TabIndex = 5;
			this.CreateItemBtn.Text = "Create";
			this.CreateItemBtn.UseVisualStyleBackColor = true;
			this.CreateItemBtn.Click += new System.EventHandler(this.CreateItemBtn_Click);
			// 
			// AddItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 226);
			this.Controls.Add(this.CreateItemBtn);
			this.Controls.Add(this.closeAddItemFormBtn);
			this.Controls.Add(this.subjectDescTxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.subjectNameTxt);
			this.Name = "AddItemForm";
			this.Text = "Add new subject";
			this.Load += new System.EventHandler(this.AddItemForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox subjectNameTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox subjectDescTxt;
		private System.Windows.Forms.Button closeAddItemFormBtn;
		private System.Windows.Forms.Button CreateItemBtn;
	}
}