﻿namespace UploadApp
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
			this.components = new System.ComponentModel.Container();
			this.closeBtn = new System.Windows.Forms.Button();
			this.selectBtn = new System.Windows.Forms.Button();
			this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.presentationsGrid = new System.Windows.Forms.DataGridView();
			this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slidesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uploadBtn = new System.Windows.Forms.Button();
			this.itemDropDown = new System.Windows.Forms.ComboBox();
			this.addItemBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.albumListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.albumModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.albumModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.albumListItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.presentationsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.albumListItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.albumModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.albumModelBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.albumListItemBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(370, 481);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(96, 28);
			this.closeBtn.TabIndex = 0;
			this.closeBtn.Text = "Close";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// selectBtn
			// 
			this.selectBtn.Location = new System.Drawing.Point(47, 481);
			this.selectBtn.Name = "selectBtn";
			this.selectBtn.Size = new System.Drawing.Size(96, 28);
			this.selectBtn.TabIndex = 1;
			this.selectBtn.Text = "Select";
			this.selectBtn.UseVisualStyleBackColor = true;
			this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
			// 
			// presentationsGrid
			// 
			this.presentationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.presentationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.slidesCount});
			this.presentationsGrid.Location = new System.Drawing.Point(47, 214);
			this.presentationsGrid.Name = "presentationsGrid";
			this.presentationsGrid.Size = new System.Drawing.Size(493, 185);
			this.presentationsGrid.TabIndex = 2;
			// 
			// title
			// 
			this.title.HeaderText = "Title";
			this.title.Name = "title";
			this.title.Width = 400;
			// 
			// slidesCount
			// 
			this.slidesCount.HeaderText = "Slides count";
			this.slidesCount.Name = "slidesCount";
			this.slidesCount.Width = 50;
			// 
			// uploadBtn
			// 
			this.uploadBtn.Location = new System.Drawing.Point(243, 481);
			this.uploadBtn.Name = "uploadBtn";
			this.uploadBtn.Size = new System.Drawing.Size(96, 28);
			this.uploadBtn.TabIndex = 3;
			this.uploadBtn.Text = "Upload";
			this.uploadBtn.UseVisualStyleBackColor = true;
			this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
			// 
			// itemDropDown
			// 
			this.itemDropDown.FormattingEnabled = true;
			this.itemDropDown.Location = new System.Drawing.Point(12, 12);
			this.itemDropDown.Name = "itemDropDown";
			this.itemDropDown.Size = new System.Drawing.Size(200, 21);
			this.itemDropDown.TabIndex = 4;
			this.itemDropDown.SelectedIndexChanged += new System.EventHandler(this.itemDropDown_SelectedIndexChanged);
			// 
			// addItemBtn
			// 
			this.addItemBtn.Location = new System.Drawing.Point(243, 10);
			this.addItemBtn.Name = "addItemBtn";
			this.addItemBtn.Size = new System.Drawing.Size(84, 23);
			this.addItemBtn.TabIndex = 5;
			this.addItemBtn.Text = "Add new";
			this.addItemBtn.UseVisualStyleBackColor = true;
			this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(243, 53);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(84, 23);
			this.deleteBtn.TabIndex = 6;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// albumListItemBindingSource
			// 
			this.albumListItemBindingSource.DataSource = typeof(UploadApp.AlbumModel.AlbumListItem);
			// 
			// albumModelBindingSource
			// 
			this.albumModelBindingSource.DataSource = typeof(UploadApp.AlbumModel);
			// 
			// albumModelBindingSource1
			// 
			this.albumModelBindingSource1.DataSource = typeof(UploadApp.AlbumModel);
			// 
			// albumListItemBindingSource1
			// 
			this.albumListItemBindingSource1.DataSource = typeof(UploadApp.AlbumModel.AlbumListItem);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 569);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.addItemBtn);
			this.Controls.Add(this.itemDropDown);
			this.Controls.Add(this.uploadBtn);
			this.Controls.Add(this.presentationsGrid);
			this.Controls.Add(this.selectBtn);
			this.Controls.Add(this.closeBtn);
			this.Name = "MainForm";
			this.Text = "UploadApp";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.presentationsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.albumListItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.albumModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.albumModelBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.albumListItemBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button selectBtn;
		private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
		private System.Windows.Forms.DataGridView presentationsGrid;
		private System.Windows.Forms.Button uploadBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn slidesCount;
		private System.Windows.Forms.ComboBox itemDropDown;
		private System.Windows.Forms.Button addItemBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.BindingSource albumListItemBindingSource;
		private System.Windows.Forms.BindingSource albumModelBindingSource;
		private System.Windows.Forms.BindingSource albumModelBindingSource1;
		private System.Windows.Forms.BindingSource albumListItemBindingSource1;
	}
}

