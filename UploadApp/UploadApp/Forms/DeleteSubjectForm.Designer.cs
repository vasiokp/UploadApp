namespace UploadApp.Forms
{
	partial class DeleteSubjectForm
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
			this.yesBtn = new System.Windows.Forms.Button();
			this.noBtn = new System.Windows.Forms.Button();
			this.questLbl = new System.Windows.Forms.Label();
			this.subjLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// yesBtn
			// 
			this.yesBtn.Location = new System.Drawing.Point(12, 112);
			this.yesBtn.Name = "yesBtn";
			this.yesBtn.Size = new System.Drawing.Size(75, 23);
			this.yesBtn.TabIndex = 0;
			this.yesBtn.Text = "Yes";
			this.yesBtn.UseVisualStyleBackColor = true;
			this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
			// 
			// noBtn
			// 
			this.noBtn.Location = new System.Drawing.Point(264, 112);
			this.noBtn.Name = "noBtn";
			this.noBtn.Size = new System.Drawing.Size(75, 23);
			this.noBtn.TabIndex = 1;
			this.noBtn.Text = "No";
			this.noBtn.UseVisualStyleBackColor = true;
			this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
			// 
			// questLbl
			// 
			this.questLbl.AutoSize = true;
			this.questLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.questLbl.Location = new System.Drawing.Point(64, 9);
			this.questLbl.Name = "questLbl";
			this.questLbl.Size = new System.Drawing.Size(194, 18);
			this.questLbl.TabIndex = 2;
			this.questLbl.Text = "Are you sure want to delete :";
			// 
			// subjLbl
			// 
			this.subjLbl.AutoSize = true;
			this.subjLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.subjLbl.Location = new System.Drawing.Point(64, 42);
			this.subjLbl.Name = "subjLbl";
			this.subjLbl.Size = new System.Drawing.Size(57, 18);
			this.subjLbl.TabIndex = 3;
			this.subjLbl.Text = "Subject";
			// 
			// DeleteSubjectForm
			// 
			this.AcceptButton = this.yesBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 146);
			this.Controls.Add(this.subjLbl);
			this.Controls.Add(this.questLbl);
			this.Controls.Add(this.noBtn);
			this.Controls.Add(this.yesBtn);
			this.Name = "DeleteSubjectForm";
			this.Text = "DeleteSubjectForm";
			this.Load += new System.EventHandler(this.DeleteSubjectForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button yesBtn;
		private System.Windows.Forms.Button noBtn;
		private System.Windows.Forms.Label questLbl;
		private System.Windows.Forms.Label subjLbl;
	}
}