﻿namespace KeePass.Forms
{
	partial class SingleLineEditForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_tbEdit = new System.Windows.Forms.TextBox();
			this.m_lblLongDesc = new System.Windows.Forms.Label();
			this.m_cmbEdit = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(591, 288);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(168, 48);
			this.m_btnOK.TabIndex = 3;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(774, 288);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(168, 48);
			this.m_btnCancel.TabIndex = 4;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(969, 124);
			this.m_bannerImage.TabIndex = 2;
			this.m_bannerImage.TabStop = false;
			// 
			// m_tbEdit
			// 
			this.m_tbEdit.Location = new System.Drawing.Point(27, 220);
			this.m_tbEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_tbEdit.Name = "m_tbEdit";
			this.m_tbEdit.Size = new System.Drawing.Size(910, 33);
			this.m_tbEdit.TabIndex = 1;
			// 
			// m_lblLongDesc
			// 
			this.m_lblLongDesc.Location = new System.Drawing.Point(21, 150);
			this.m_lblLongDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.m_lblLongDesc.Name = "m_lblLongDesc";
			this.m_lblLongDesc.Size = new System.Drawing.Size(922, 58);
			this.m_lblLongDesc.TabIndex = 0;
			this.m_lblLongDesc.Text = "<>";
			// 
			// m_cmbEdit
			// 
			this.m_cmbEdit.DropDownHeight = 400;
			this.m_cmbEdit.FormattingEnabled = true;
			this.m_cmbEdit.IntegralHeight = false;
			this.m_cmbEdit.Location = new System.Drawing.Point(27, 220);
			this.m_cmbEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.m_cmbEdit.Name = "m_cmbEdit";
			this.m_cmbEdit.Size = new System.Drawing.Size(910, 37);
			this.m_cmbEdit.TabIndex = 2;
			// 
			// SingleLineEditForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(969, 362);
			this.Controls.Add(this.m_cmbEdit);
			this.Controls.Add(this.m_lblLongDesc);
			this.Controls.Add(this.m_tbEdit);
			this.Controls.Add(this.m_bannerImage);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SingleLineEditForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<DYN>";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.Shown += new System.EventHandler(this.OnFormShown);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.TextBox m_tbEdit;
		private System.Windows.Forms.Label m_lblLongDesc;
		private System.Windows.Forms.ComboBox m_cmbEdit;
	}
}