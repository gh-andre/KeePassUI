﻿namespace KeePass.Forms
{
	partial class EcasActionForm
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
			this.m_cmbActions = new System.Windows.Forms.ComboBox();
			this.m_lblAction = new System.Windows.Forms.Label();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_dgvParams = new System.Windows.Forms.DataGridView();
			this.m_lblParamHint = new System.Windows.Forms.Label();
			this.m_lblSep = new System.Windows.Forms.Label();
			this.m_btnHelp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.m_dgvParams)).BeginInit();
			this.SuspendLayout();
			// 
			// m_cmbActions
			// 
			this.m_cmbActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbActions.FormattingEnabled = true;
			this.m_cmbActions.Location = new System.Drawing.Point(32, 74);
			this.m_cmbActions.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_cmbActions.Name = "m_cmbActions";
			this.m_cmbActions.Size = new System.Drawing.Size(1354, 38);
			this.m_cmbActions.TabIndex = 0;
			this.m_cmbActions.SelectedIndexChanged += new System.EventHandler(this.OnActionsSelectedIndexChanged);
			// 
			// m_lblAction
			// 
			this.m_lblAction.AutoSize = true;
			this.m_lblAction.Location = new System.Drawing.Point(24, 34);
			this.m_lblAction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblAction.Name = "m_lblAction";
			this.m_lblAction.Size = new System.Drawing.Size(91, 30);
			this.m_lblAction.TabIndex = 7;
			this.m_lblAction.Text = "Action:";
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(976, 712);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(200, 56);
			this.m_btnOK.TabIndex = 5;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(1192, 712);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(200, 56);
			this.m_btnCancel.TabIndex = 6;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_dgvParams
			// 
			this.m_dgvParams.AllowUserToAddRows = false;
			this.m_dgvParams.AllowUserToDeleteRows = false;
			this.m_dgvParams.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_dgvParams.Location = new System.Drawing.Point(32, 140);
			this.m_dgvParams.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_dgvParams.Name = "m_dgvParams";
			this.m_dgvParams.RowHeadersWidth = 82;
			this.m_dgvParams.Size = new System.Drawing.Size(1360, 444);
			this.m_dgvParams.TabIndex = 1;
			// 
			// m_lblParamHint
			// 
			this.m_lblParamHint.Location = new System.Drawing.Point(24, 612);
			this.m_lblParamHint.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblParamHint.Name = "m_lblParamHint";
			this.m_lblParamHint.Size = new System.Drawing.Size(1368, 36);
			this.m_lblParamHint.TabIndex = 2;
			this.m_lblParamHint.Text = "<>";
			// 
			// m_lblSep
			// 
			this.m_lblSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_lblSep.Location = new System.Drawing.Point(0, 690);
			this.m_lblSep.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblSep.Name = "m_lblSep";
			this.m_lblSep.Size = new System.Drawing.Size(1426, 4);
			this.m_lblSep.TabIndex = 3;
			// 
			// m_btnHelp
			// 
			this.m_btnHelp.Location = new System.Drawing.Point(32, 712);
			this.m_btnHelp.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnHelp.Name = "m_btnHelp";
			this.m_btnHelp.Size = new System.Drawing.Size(200, 56);
			this.m_btnHelp.TabIndex = 4;
			this.m_btnHelp.Text = "&Help";
			this.m_btnHelp.UseVisualStyleBackColor = true;
			this.m_btnHelp.Click += new System.EventHandler(this.OnBtnHelp);
			// 
			// EcasActionForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(1424, 798);
			this.Controls.Add(this.m_btnHelp);
			this.Controls.Add(this.m_lblSep);
			this.Controls.Add(this.m_lblParamHint);
			this.Controls.Add(this.m_dgvParams);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.Controls.Add(this.m_lblAction);
			this.Controls.Add(this.m_cmbActions);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EcasActionForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<>";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.m_dgvParams)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox m_cmbActions;
		private System.Windows.Forms.Label m_lblAction;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.DataGridView m_dgvParams;
		private System.Windows.Forms.Label m_lblParamHint;
		private System.Windows.Forms.Label m_lblSep;
		private System.Windows.Forms.Button m_btnHelp;
	}
}