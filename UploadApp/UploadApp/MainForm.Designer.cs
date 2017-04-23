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
			System.Windows.Forms.GroupBox subjectBox;
			this.itemDropDown = new System.Windows.Forms.ComboBox();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.addItemBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.selectBtn = new System.Windows.Forms.Button();
			this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.presentationsGrid = new System.Windows.Forms.DataGridView();
			this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slidesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uploadBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.progressUpload = new System.Windows.Forms.ProgressBar();
			subjectBox = new System.Windows.Forms.GroupBox();
			subjectBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.presentationsGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// subjectBox
			// 
			subjectBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			subjectBox.Controls.Add(this.itemDropDown);
			subjectBox.Controls.Add(this.deleteBtn);
			subjectBox.Controls.Add(this.addItemBtn);
			subjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			subjectBox.ForeColor = System.Drawing.SystemColors.ControlText;
			subjectBox.Location = new System.Drawing.Point(15, 15);
			subjectBox.Name = "subjectBox";
			subjectBox.Padding = new System.Windows.Forms.Padding(30, 30, 30, 3);
			subjectBox.Size = new System.Drawing.Size(240, 110);
			subjectBox.TabIndex = 7;
			subjectBox.TabStop = false;
			subjectBox.Text = "Вибір предмету";
			subjectBox.Enter += new System.EventHandler(this.subjectBox_Enter);
			// 
			// itemDropDown
			// 
			this.itemDropDown.BackColor = System.Drawing.SystemColors.Window;
			this.itemDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.itemDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemDropDown.FormattingEnabled = true;
			this.itemDropDown.Location = new System.Drawing.Point(21, 32);
			this.itemDropDown.Name = "itemDropDown";
			this.itemDropDown.Size = new System.Drawing.Size(200, 24);
			this.itemDropDown.TabIndex = 4;
			this.itemDropDown.SelectedIndexChanged += new System.EventHandler(this.itemDropDown_SelectedIndexChanged);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.Red;
			this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteBtn.Location = new System.Drawing.Point(125, 61);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(84, 35);
			this.deleteBtn.TabIndex = 6;
			this.deleteBtn.Text = "Видалити";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// addItemBtn
			// 
			this.addItemBtn.BackColor = System.Drawing.Color.SpringGreen;
			this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addItemBtn.ForeColor = System.Drawing.Color.Black;
			this.addItemBtn.Location = new System.Drawing.Point(21, 62);
			this.addItemBtn.Name = "addItemBtn";
			this.addItemBtn.Size = new System.Drawing.Size(84, 32);
			this.addItemBtn.TabIndex = 5;
			this.addItemBtn.Text = "Додати";
			this.addItemBtn.UseVisualStyleBackColor = false;
			this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeBtn.Location = new System.Drawing.Point(196, 383);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(96, 28);
			this.closeBtn.TabIndex = 0;
			this.closeBtn.Text = "Вихід";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// selectBtn
			// 
			this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.selectBtn.Location = new System.Drawing.Point(50, 28);
			this.selectBtn.Name = "selectBtn";
			this.selectBtn.Size = new System.Drawing.Size(107, 28);
			this.selectBtn.TabIndex = 1;
			this.selectBtn.Text = "Каталог";
			this.selectBtn.UseVisualStyleBackColor = true;
			this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
			// 
			// presentationsGrid
			// 
			this.presentationsGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
			this.presentationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.presentationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.slidesCount});
			this.presentationsGrid.GridColor = System.Drawing.Color.CornflowerBlue;
			this.presentationsGrid.Location = new System.Drawing.Point(12, 152);
			this.presentationsGrid.Name = "presentationsGrid";
			this.presentationsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.presentationsGrid.Size = new System.Drawing.Size(502, 185);
			this.presentationsGrid.TabIndex = 2;
			// 
			// title
			// 
			this.title.HeaderText = "Заголовок теми";
			this.title.Name = "title";
			this.title.Width = 400;
			// 
			// slidesCount
			// 
			this.slidesCount.HeaderText = "Слайдів";
			this.slidesCount.Name = "slidesCount";
			this.slidesCount.Width = 50;
			// 
			// uploadBtn
			// 
			this.uploadBtn.Enabled = false;
			this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.uploadBtn.Location = new System.Drawing.Point(50, 64);
			this.uploadBtn.Name = "uploadBtn";
			this.uploadBtn.Size = new System.Drawing.Size(107, 28);
			this.uploadBtn.TabIndex = 3;
			this.uploadBtn.Text = "Завантажити";
			this.uploadBtn.UseVisualStyleBackColor = true;
			this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Controls.Add(this.selectBtn);
			this.groupBox1.Controls.Add(this.uploadBtn);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(306, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(205, 110);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Теми";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(15, 343);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(496, 14);
			this.progressBar.TabIndex = 9;
			// 
			// progressUpload
			// 
			this.progressUpload.Location = new System.Drawing.Point(15, 363);
			this.progressUpload.Name = "progressUpload";
			this.progressUpload.Size = new System.Drawing.Size(496, 14);
			this.progressUpload.TabIndex = 10;
			this.progressUpload.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(529, 417);
			this.Controls.Add(this.progressUpload);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(subjectBox);
			this.Controls.Add(this.presentationsGrid);
			this.Controls.Add(this.closeBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Посібник";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.Load += new System.EventHandler(this.MainForm_Load);
			subjectBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.presentationsGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button selectBtn;
		private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
		private System.Windows.Forms.DataGridView presentationsGrid;
		private System.Windows.Forms.Button uploadBtn;
		private System.Windows.Forms.ComboBox itemDropDown;
		private System.Windows.Forms.Button addItemBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn slidesCount;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.ProgressBar progressUpload;
	}
}

