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
			this.label2 = new System.Windows.Forms.Label();
			this.subjectDescTxt = new System.Windows.Forms.TextBox();
			this.closeAddItemFormBtn = new System.Windows.Forms.Button();
			this.CreateItemBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// subjectNameTxt
			// 
			this.subjectNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.subjectNameTxt.Location = new System.Drawing.Point(68, 34);
			this.subjectNameTxt.Multiline = true;
			this.subjectNameTxt.Name = "subjectNameTxt";
			this.subjectNameTxt.Size = new System.Drawing.Size(234, 20);
			this.subjectNameTxt.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Опис";
			// 
			// subjectDescTxt
			// 
			this.subjectDescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.subjectDescTxt.Location = new System.Drawing.Point(68, 73);
			this.subjectDescTxt.Multiline = true;
			this.subjectDescTxt.Name = "subjectDescTxt";
			this.subjectDescTxt.Size = new System.Drawing.Size(234, 49);
			this.subjectDescTxt.TabIndex = 3;
			// 
			// closeAddItemFormBtn
			// 
			this.closeAddItemFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeAddItemFormBtn.Location = new System.Drawing.Point(218, 145);
			this.closeAddItemFormBtn.Name = "closeAddItemFormBtn";
			this.closeAddItemFormBtn.Size = new System.Drawing.Size(84, 32);
			this.closeAddItemFormBtn.TabIndex = 4;
			this.closeAddItemFormBtn.Text = "Відмінити";
			this.closeAddItemFormBtn.UseVisualStyleBackColor = true;
			this.closeAddItemFormBtn.Click += new System.EventHandler(this.closeAddItemFormBtn_Click);
			// 
			// CreateItemBtn
			// 
			this.CreateItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CreateItemBtn.Location = new System.Drawing.Point(9, 145);
			this.CreateItemBtn.Name = "CreateItemBtn";
			this.CreateItemBtn.Size = new System.Drawing.Size(75, 32);
			this.CreateItemBtn.TabIndex = 5;
			this.CreateItemBtn.Text = "Додати";
			this.CreateItemBtn.UseVisualStyleBackColor = true;
			this.CreateItemBtn.Click += new System.EventHandler(this.CreateItemBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Coral;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.closeAddItemFormBtn);
			this.groupBox1.Controls.Add(this.CreateItemBtn);
			this.groupBox1.Controls.Add(this.subjectNameTxt);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.subjectDescTxt);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(24, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(320, 183);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Новий предмет";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Назва";
			// 
			// AddItemForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(369, 208);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddItemForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Предмет";
			this.Load += new System.EventHandler(this.AddItemForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox subjectNameTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox subjectDescTxt;
		private System.Windows.Forms.Button closeAddItemFormBtn;
		private System.Windows.Forms.Button CreateItemBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
	}
}