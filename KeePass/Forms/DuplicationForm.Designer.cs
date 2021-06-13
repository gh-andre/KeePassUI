﻿namespace KeePass.Forms
{
	partial class DuplicationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuplicationForm));
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_cbAppendCopy = new System.Windows.Forms.CheckBox();
			this.m_cbFieldRefs = new System.Windows.Forms.CheckBox();
			this.m_lblFieldRefs = new System.Windows.Forms.Label();
			this.m_lblSep = new System.Windows.Forms.Label();
			this.m_lnkFieldRefs = new System.Windows.Forms.LinkLabel();
			this.m_cbCopyHistory = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(546, 428);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(200, 56);
			this.m_btnOK.TabIndex = 0;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(762, 428);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(200, 56);
			this.m_btnCancel.TabIndex = 1;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_cbAppendCopy
			// 
			this.m_cbAppendCopy.AutoSize = true;
			this.m_cbAppendCopy.Location = new System.Drawing.Point(32, 30);
			this.m_cbAppendCopy.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbAppendCopy.Name = "m_cbAppendCopy";
			this.m_cbAppendCopy.Size = new System.Drawing.Size(385, 34);
			this.m_cbAppendCopy.TabIndex = 2;
			this.m_cbAppendCopy.Text = "&Append \"- Copy\" to entry titles";
			this.m_cbAppendCopy.UseVisualStyleBackColor = true;
			// 
			// m_cbFieldRefs
			// 
			this.m_cbFieldRefs.AutoSize = true;
			this.m_cbFieldRefs.Location = new System.Drawing.Point(32, 86);
			this.m_cbFieldRefs.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbFieldRefs.Name = "m_cbFieldRefs";
			this.m_cbFieldRefs.Size = new System.Drawing.Size(621, 34);
			this.m_cbFieldRefs.TabIndex = 3;
			this.m_cbFieldRefs.Text = "&Replace user names and passwords by references";
			this.m_cbFieldRefs.UseVisualStyleBackColor = true;
			// 
			// m_lblFieldRefs
			// 
			this.m_lblFieldRefs.Location = new System.Drawing.Point(74, 136);
			this.m_lblFieldRefs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblFieldRefs.Name = "m_lblFieldRefs";
			this.m_lblFieldRefs.Size = new System.Drawing.Size(888, 132);
			this.m_lblFieldRefs.TabIndex = 4;
			this.m_lblFieldRefs.Text = resources.GetString("m_lblFieldRefs.Text");
			// 
			// m_lblSep
			// 
			this.m_lblSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_lblSep.Location = new System.Drawing.Point(2, 402);
			this.m_lblSep.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblSep.Name = "m_lblSep";
			this.m_lblSep.Size = new System.Drawing.Size(992, 4);
			this.m_lblSep.TabIndex = 7;
			// 
			// m_lnkFieldRefs
			// 
			this.m_lnkFieldRefs.AutoSize = true;
			this.m_lnkFieldRefs.Location = new System.Drawing.Point(74, 276);
			this.m_lnkFieldRefs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lnkFieldRefs.Name = "m_lnkFieldRefs";
			this.m_lnkFieldRefs.Size = new System.Drawing.Size(274, 30);
			this.m_lnkFieldRefs.TabIndex = 5;
			this.m_lnkFieldRefs.TabStop = true;
			this.m_lnkFieldRefs.Text = "Help: Field References";
			this.m_lnkFieldRefs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnFieldRefsLinkClicked);
			// 
			// m_cbCopyHistory
			// 
			this.m_cbCopyHistory.AutoSize = true;
			this.m_cbCopyHistory.Location = new System.Drawing.Point(32, 330);
			this.m_cbCopyHistory.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cbCopyHistory.Name = "m_cbCopyHistory";
			this.m_cbCopyHistory.Size = new System.Drawing.Size(188, 34);
			this.m_cbCopyHistory.TabIndex = 6;
			this.m_cbCopyHistory.Text = "Copy &history";
			this.m_cbCopyHistory.UseVisualStyleBackColor = true;
			// 
			// DuplicationForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(994, 514);
			this.Controls.Add(this.m_cbCopyHistory);
			this.Controls.Add(this.m_lnkFieldRefs);
			this.Controls.Add(this.m_lblSep);
			this.Controls.Add(this.m_lblFieldRefs);
			this.Controls.Add(this.m_cbFieldRefs);
			this.Controls.Add(this.m_cbAppendCopy);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DuplicationForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Duplication Options";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.CheckBox m_cbAppendCopy;
		private System.Windows.Forms.CheckBox m_cbFieldRefs;
		private System.Windows.Forms.Label m_lblFieldRefs;
		private System.Windows.Forms.Label m_lblSep;
		private System.Windows.Forms.LinkLabel m_lnkFieldRefs;
		private System.Windows.Forms.CheckBox m_cbCopyHistory;
	}
}