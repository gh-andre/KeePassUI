﻿namespace KeePass.Forms
{
	partial class OptionsEnfForm
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
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_lblEnforce = new System.Windows.Forms.Label();
			this.m_lvMain = new KeePass.UI.CustomListViewEx();
			this.m_lblInfo = new System.Windows.Forms.Label();
			this.m_lnkConfigEnf = new System.Windows.Forms.LinkLabel();
			this.m_lnkEnfAll = new System.Windows.Forms.LinkLabel();
			this.m_lnkEnfNone = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.m_btnOK.Location = new System.Drawing.Point(1108, 1138);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(224, 64);
			this.m_btnOK.TabIndex = 6;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.m_btnCancel.Location = new System.Drawing.Point(1350, 1138);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(224, 64);
			this.m_btnCancel.TabIndex = 7;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(1612, 166);
			this.m_bannerImage.TabIndex = 2;
			this.m_bannerImage.TabStop = false;
			// 
			// m_lblEnforce
			// 
			this.m_lblEnforce.AutoSize = true;
			this.m_lblEnforce.Location = new System.Drawing.Point(28, 202);
			this.m_lblEnforce.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblEnforce.Name = "m_lblEnforce";
			this.m_lblEnforce.Size = new System.Drawing.Size(49, 36);
			this.m_lblEnforce.TabIndex = 0;
			this.m_lblEnforce.Text = "<>";
			// 
			// m_lvMain
			// 
			this.m_lvMain.CheckBoxes = true;
			this.m_lvMain.FullRowSelect = true;
			this.m_lvMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvMain.HideSelection = false;
			this.m_lvMain.Location = new System.Drawing.Point(36, 260);
			this.m_lvMain.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_lvMain.Name = "m_lvMain";
			this.m_lvMain.ShowItemToolTips = true;
			this.m_lvMain.Size = new System.Drawing.Size(1532, 694);
			this.m_lvMain.TabIndex = 1;
			this.m_lvMain.UseCompatibleStateImageBehavior = false;
			this.m_lvMain.View = System.Windows.Forms.View.Details;
			// 
			// m_lblInfo
			// 
			this.m_lblInfo.Location = new System.Drawing.Point(28, 996);
			this.m_lblInfo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblInfo.Name = "m_lblInfo";
			this.m_lblInfo.Size = new System.Drawing.Size(1548, 36);
			this.m_lblInfo.TabIndex = 4;
			this.m_lblInfo.Text = "<>";
			// 
			// m_lnkConfigEnf
			// 
			this.m_lnkConfigEnf.AutoSize = true;
			this.m_lnkConfigEnf.Location = new System.Drawing.Point(28, 1068);
			this.m_lnkConfigEnf.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lnkConfigEnf.Name = "m_lnkConfigEnf";
			this.m_lnkConfigEnf.Size = new System.Drawing.Size(49, 36);
			this.m_lnkConfigEnf.TabIndex = 5;
			this.m_lnkConfigEnf.TabStop = true;
			this.m_lnkConfigEnf.Text = "<>";
			this.m_lnkConfigEnf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnConfigEnfLinkClicked);
			// 
			// m_lnkEnfAll
			// 
			this.m_lnkEnfAll.AutoSize = true;
			this.m_lnkEnfAll.Location = new System.Drawing.Point(1404, 202);
			this.m_lnkEnfAll.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lnkEnfAll.Name = "m_lnkEnfAll";
			this.m_lnkEnfAll.Size = new System.Drawing.Size(50, 36);
			this.m_lnkEnfAll.TabIndex = 2;
			this.m_lnkEnfAll.TabStop = true;
			this.m_lnkEnfAll.Text = "All";
			this.m_lnkEnfAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkEnfAll);
			// 
			// m_lnkEnfNone
			// 
			this.m_lnkEnfNone.AutoSize = true;
			this.m_lnkEnfNone.Location = new System.Drawing.Point(1476, 202);
			this.m_lnkEnfNone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lnkEnfNone.Name = "m_lnkEnfNone";
			this.m_lnkEnfNone.Size = new System.Drawing.Size(87, 36);
			this.m_lnkEnfNone.TabIndex = 3;
			this.m_lnkEnfNone.TabStop = true;
			this.m_lnkEnfNone.Text = "None";
			this.m_lnkEnfNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkEnfNone);
			// 
			// OptionsEnfForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(1612, 1236);
			this.Controls.Add(this.m_lnkEnfNone);
			this.Controls.Add(this.m_lnkEnfAll);
			this.Controls.Add(this.m_lnkConfigEnf);
			this.Controls.Add(this.m_lblInfo);
			this.Controls.Add(this.m_lvMain);
			this.Controls.Add(this.m_lblEnforce);
			this.Controls.Add(this.m_bannerImage);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsEnfForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<>";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Label m_lblEnforce;
		private KeePass.UI.CustomListViewEx m_lvMain;
		private System.Windows.Forms.Label m_lblInfo;
		private System.Windows.Forms.LinkLabel m_lnkConfigEnf;
		private System.Windows.Forms.LinkLabel m_lnkEnfAll;
		private System.Windows.Forms.LinkLabel m_lnkEnfNone;
	}
}