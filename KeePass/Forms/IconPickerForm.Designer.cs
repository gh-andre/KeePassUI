﻿namespace KeePass.Forms
{
	partial class IconPickerForm
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
			this.m_radioStandard = new System.Windows.Forms.RadioButton();
			this.m_radioCustom = new System.Windows.Forms.RadioButton();
			this.m_lblSeparator = new System.Windows.Forms.Label();
			this.m_btnCustomAdd = new System.Windows.Forms.Button();
			this.m_btnCustomDelete = new System.Windows.Forms.Button();
			this.m_btnCustomMore = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblFind = new System.Windows.Forms.Label();
			this.m_tbFind = new System.Windows.Forms.TextBox();
			this.m_lvCustomIcons = new KeePass.UI.CustomListViewEx();
			this.m_lvIcons = new KeePass.UI.CustomListViewEx();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(1014, 1210);
			this.m_btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(224, 64);
			this.m_btnOK.TabIndex = 10;
			this.m_btnOK.Text = "OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_radioStandard
			// 
			this.m_radioStandard.AutoSize = true;
			this.m_radioStandard.Location = new System.Drawing.Point(36, 30);
			this.m_radioStandard.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_radioStandard.Name = "m_radioStandard";
			this.m_radioStandard.Size = new System.Drawing.Size(295, 40);
			this.m_radioStandard.TabIndex = 0;
			this.m_radioStandard.TabStop = true;
			this.m_radioStandard.Text = "Use &standard icon:";
			this.m_radioStandard.UseVisualStyleBackColor = true;
			this.m_radioStandard.CheckedChanged += new System.EventHandler(this.OnStandardRadioCheckedChanged);
			// 
			// m_radioCustom
			// 
			this.m_radioCustom.AutoSize = true;
			this.m_radioCustom.Location = new System.Drawing.Point(36, 668);
			this.m_radioCustom.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_radioCustom.Name = "m_radioCustom";
			this.m_radioCustom.Size = new System.Drawing.Size(696, 40);
			this.m_radioCustom.TabIndex = 2;
			this.m_radioCustom.TabStop = true;
			this.m_radioCustom.Text = "Use &custom icon (stored in the current database):";
			this.m_radioCustom.UseVisualStyleBackColor = true;
			// 
			// m_lblSeparator
			// 
			this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_lblSeparator.Location = new System.Drawing.Point(-4, 1190);
			this.m_lblSeparator.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblSeparator.Name = "m_lblSeparator";
			this.m_lblSeparator.Size = new System.Drawing.Size(1520, 6);
			this.m_lblSeparator.TabIndex = 9;
			// 
			// m_btnCustomAdd
			// 
			this.m_btnCustomAdd.Location = new System.Drawing.Point(92, 1102);
			this.m_btnCustomAdd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCustomAdd.Name = "m_btnCustomAdd";
			this.m_btnCustomAdd.Size = new System.Drawing.Size(224, 64);
			this.m_btnCustomAdd.TabIndex = 4;
			this.m_btnCustomAdd.Text = "&Add...";
			this.m_btnCustomAdd.UseVisualStyleBackColor = true;
			this.m_btnCustomAdd.Click += new System.EventHandler(this.OnBtnCustomAdd);
			// 
			// m_btnCustomDelete
			// 
			this.m_btnCustomDelete.Location = new System.Drawing.Point(336, 1102);
			this.m_btnCustomDelete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCustomDelete.Name = "m_btnCustomDelete";
			this.m_btnCustomDelete.Size = new System.Drawing.Size(224, 64);
			this.m_btnCustomDelete.TabIndex = 5;
			this.m_btnCustomDelete.Text = "&Delete";
			this.m_btnCustomDelete.UseVisualStyleBackColor = true;
			this.m_btnCustomDelete.Click += new System.EventHandler(this.OnBtnCustomRemove);
			// 
			// m_btnCustomMore
			// 
			this.m_btnCustomMore.Location = new System.Drawing.Point(580, 1102);
			this.m_btnCustomMore.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCustomMore.Name = "m_btnCustomMore";
			this.m_btnCustomMore.Size = new System.Drawing.Size(224, 64);
			this.m_btnCustomMore.TabIndex = 6;
			this.m_btnCustomMore.Text = "&More...";
			this.m_btnCustomMore.UseVisualStyleBackColor = true;
			this.m_btnCustomMore.Click += new System.EventHandler(this.OnBtnCustomMore);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(1256, 1210);
			this.m_btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(224, 64);
			this.m_btnCancel.TabIndex = 11;
			this.m_btnCancel.Text = "Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			// 
			// m_lblFind
			// 
			this.m_lblFind.AutoSize = true;
			this.m_lblFind.Location = new System.Drawing.Point(908, 1116);
			this.m_lblFind.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.m_lblFind.Name = "m_lblFind";
			this.m_lblFind.Size = new System.Drawing.Size(82, 36);
			this.m_lblFind.TabIndex = 7;
			this.m_lblFind.Text = "&Find:";
			// 
			// m_tbFind
			// 
			this.m_tbFind.Location = new System.Drawing.Point(1016, 1108);
			this.m_tbFind.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_tbFind.Name = "m_tbFind";
			this.m_tbFind.Size = new System.Drawing.Size(454, 41);
			this.m_tbFind.TabIndex = 8;
			// 
			// m_lvCustomIcons
			// 
			this.m_lvCustomIcons.HideSelection = false;
			this.m_lvCustomIcons.LabelEdit = true;
			this.m_lvCustomIcons.Location = new System.Drawing.Point(96, 732);
			this.m_lvCustomIcons.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_lvCustomIcons.Name = "m_lvCustomIcons";
			this.m_lvCustomIcons.ShowItemToolTips = true;
			this.m_lvCustomIcons.Size = new System.Drawing.Size(1376, 348);
			this.m_lvCustomIcons.TabIndex = 3;
			this.m_lvCustomIcons.UseCompatibleStateImageBehavior = false;
			this.m_lvCustomIcons.View = System.Windows.Forms.View.List;
			this.m_lvCustomIcons.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.OnCustomIconsAfterLabelEdit);
			this.m_lvCustomIcons.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.OnCustomIconsBeforeLabelEdit);
			this.m_lvCustomIcons.ItemActivate += new System.EventHandler(this.OnCustomIconsItemActivate);
			this.m_lvCustomIcons.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnCustomIconsItemSelectionChanged);
			// 
			// m_lvIcons
			// 
			this.m_lvIcons.HideSelection = false;
			this.m_lvIcons.Location = new System.Drawing.Point(96, 94);
			this.m_lvIcons.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.m_lvIcons.MultiSelect = false;
			this.m_lvIcons.Name = "m_lvIcons";
			this.m_lvIcons.Size = new System.Drawing.Size(1376, 536);
			this.m_lvIcons.TabIndex = 1;
			this.m_lvIcons.UseCompatibleStateImageBehavior = false;
			this.m_lvIcons.View = System.Windows.Forms.View.List;
			this.m_lvIcons.ItemActivate += new System.EventHandler(this.OnIconsItemActivate);
			this.m_lvIcons.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnIconsItemSelectionChanged);
			// 
			// IconPickerForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(1518, 1308);
			this.Controls.Add(this.m_tbFind);
			this.Controls.Add(this.m_lblFind);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnCustomMore);
			this.Controls.Add(this.m_btnCustomDelete);
			this.Controls.Add(this.m_btnCustomAdd);
			this.Controls.Add(this.m_lblSeparator);
			this.Controls.Add(this.m_radioCustom);
			this.Controls.Add(this.m_radioStandard);
			this.Controls.Add(this.m_lvCustomIcons);
			this.Controls.Add(this.m_btnOK);
			this.Controls.Add(this.m_lvIcons);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "IconPickerForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Icon Picker";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private KeePass.UI.CustomListViewEx m_lvIcons;
		private System.Windows.Forms.Button m_btnOK;
		private KeePass.UI.CustomListViewEx m_lvCustomIcons;
		private System.Windows.Forms.RadioButton m_radioStandard;
		private System.Windows.Forms.RadioButton m_radioCustom;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.Button m_btnCustomAdd;
		private System.Windows.Forms.Button m_btnCustomDelete;
		private System.Windows.Forms.Button m_btnCustomMore;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblFind;
		private System.Windows.Forms.TextBox m_tbFind;
	}
}