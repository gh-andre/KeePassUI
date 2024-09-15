﻿namespace KeePass.Forms
{
	partial class FileBrowserForm
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
			if(disposing && (components != null))
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
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblSeparator = new System.Windows.Forms.Label();
			this.m_lblHint = new System.Windows.Forms.Label();
			this.m_lblFileName = new System.Windows.Forms.Label();
			this.m_tbFileName = new System.Windows.Forms.TextBox();
			this.m_lvFiles = new KeePass.UI.CustomListViewEx();
			this.m_tvFolders = new KeePass.UI.CustomTreeViewEx();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(1040, 828);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(168, 48);
			this.m_btnOK.TabIndex = 4;
			this.m_btnOK.Text = "<>";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(1221, 828);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(168, 48);
			this.m_btnCancel.TabIndex = 5;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_lblSeparator
			// 
			this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_lblSeparator.Location = new System.Drawing.Point(0, 900);
			this.m_lblSeparator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.m_lblSeparator.Name = "m_lblSeparator";
			this.m_lblSeparator.Size = new System.Drawing.Size(1418, 4);
			this.m_lblSeparator.TabIndex = 6;
			// 
			// m_lblHint
			// 
			this.m_lblHint.Location = new System.Drawing.Point(21, 918);
			this.m_lblHint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.m_lblHint.Name = "m_lblHint";
			this.m_lblHint.Size = new System.Drawing.Size(1371, 58);
			this.m_lblHint.TabIndex = 7;
			this.m_lblHint.Text = "<>";
			// 
			// m_lblFileName
			// 
			this.m_lblFileName.Location = new System.Drawing.Point(27, 777);
			this.m_lblFileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.m_lblFileName.Name = "m_lblFileName";
			this.m_lblFileName.Size = new System.Drawing.Size(450, 33);
			this.m_lblFileName.TabIndex = 2;
			this.m_lblFileName.Text = "File &name:";
			this.m_lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_tbFileName
			// 
			this.m_tbFileName.Location = new System.Drawing.Point(490, 774);
			this.m_tbFileName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_tbFileName.Name = "m_tbFileName";
			this.m_tbFileName.Size = new System.Drawing.Size(895, 33);
			this.m_tbFileName.TabIndex = 3;
			this.m_tbFileName.TextChanged += new System.EventHandler(this.OnFileNameTextChanged);
			// 
			// m_lvFiles
			// 
			this.m_lvFiles.FullRowSelect = true;
			this.m_lvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvFiles.HideSelection = false;
			this.m_lvFiles.Location = new System.Drawing.Point(490, 26);
			this.m_lvFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_lvFiles.MultiSelect = false;
			this.m_lvFiles.Name = "m_lvFiles";
			this.m_lvFiles.ShowGroups = false;
			this.m_lvFiles.ShowItemToolTips = true;
			this.m_lvFiles.Size = new System.Drawing.Size(895, 733);
			this.m_lvFiles.TabIndex = 1;
			this.m_lvFiles.UseCompatibleStateImageBehavior = false;
			this.m_lvFiles.View = System.Windows.Forms.View.Details;
			this.m_lvFiles.ItemActivate += new System.EventHandler(this.OnFilesItemActivate);
			this.m_lvFiles.SelectedIndexChanged += new System.EventHandler(this.OnFilesSelectedIndexChanged);
			// 
			// m_tvFolders
			// 
			this.m_tvFolders.HideSelection = false;
			this.m_tvFolders.HotTracking = true;
			this.m_tvFolders.Location = new System.Drawing.Point(27, 26);
			this.m_tvFolders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_tvFolders.Name = "m_tvFolders";
			this.m_tvFolders.ShowNodeToolTips = true;
			this.m_tvFolders.Size = new System.Drawing.Size(445, 733);
			this.m_tvFolders.TabIndex = 0;
			this.m_tvFolders.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.OnFoldersBeforeExpand);
			this.m_tvFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnFoldersAfterSelect);
			// 
			// FileBrowserForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(1418, 994);
			this.Controls.Add(this.m_tbFileName);
			this.Controls.Add(this.m_lblFileName);
			this.Controls.Add(this.m_lvFiles);
			this.Controls.Add(this.m_tvFolders);
			this.Controls.Add(this.m_lblHint);
			this.Controls.Add(this.m_lblSeparator);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileBrowserForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<>";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.Label m_lblHint;
		private KeePass.UI.CustomTreeViewEx m_tvFolders;
		private KeePass.UI.CustomListViewEx m_lvFiles;
		private System.Windows.Forms.Label m_lblFileName;
		private System.Windows.Forms.TextBox m_tbFileName;
	}
}