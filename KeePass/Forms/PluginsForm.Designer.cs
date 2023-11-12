﻿namespace KeePass.Forms
{
	partial class PluginsForm
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
            this.m_btnClose = new System.Windows.Forms.Button();
            this.m_lvPlugins = new KeePass.UI.CustomListViewEx();
            this.m_lblSeparator = new System.Windows.Forms.Label();
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_grpPluginDesc = new System.Windows.Forms.GroupBox();
            this.m_lblSelectedPluginDesc = new System.Windows.Forms.Label();
            this.m_grpCache = new System.Windows.Forms.GroupBox();
            this.m_cbCacheDeleteOld = new System.Windows.Forms.CheckBox();
            this.m_btnClearCache = new System.Windows.Forms.Button();
            this.m_lblCacheSize = new System.Windows.Forms.Label();
            this.m_btnMore = new System.Windows.Forms.Button();
            this.m_btnOpenFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.m_grpPluginDesc.SuspendLayout();
            this.m_grpCache.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnClose
            // 
            this.m_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnClose.Location = new System.Drawing.Point(1197, 896);
            this.m_btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(168, 48);
            this.m_btnClose.TabIndex = 6;
            this.m_btnClose.Text = "Close";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.OnBtnClose);
            // 
            // m_lvPlugins
            // 
            this.m_lvPlugins.FullRowSelect = true;
            this.m_lvPlugins.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.m_lvPlugins.HideSelection = false;
            this.m_lvPlugins.Location = new System.Drawing.Point(27, 136);
            this.m_lvPlugins.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_lvPlugins.Name = "m_lvPlugins";
            this.m_lvPlugins.ShowItemToolTips = true;
            this.m_lvPlugins.Size = new System.Drawing.Size(1333, 338);
            this.m_lvPlugins.TabIndex = 0;
            this.m_lvPlugins.UseCompatibleStateImageBehavior = false;
            this.m_lvPlugins.View = System.Windows.Forms.View.Details;
            this.m_lvPlugins.SelectedIndexChanged += new System.EventHandler(this.OnPluginListSelectedIndexChanged);
            // 
            // m_lblSeparator
            // 
            this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lblSeparator.Location = new System.Drawing.Point(0, 876);
            this.m_lblSeparator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblSeparator.Name = "m_lblSeparator";
            this.m_lblSeparator.Size = new System.Drawing.Size(1392, 4);
            this.m_lblSeparator.TabIndex = 3;
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(1392, 124);
            this.m_bannerImage.TabIndex = 0;
            this.m_bannerImage.TabStop = false;
            // 
            // m_grpPluginDesc
            // 
            this.m_grpPluginDesc.Controls.Add(this.m_lblSelectedPluginDesc);
            this.m_grpPluginDesc.Location = new System.Drawing.Point(27, 492);
            this.m_grpPluginDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpPluginDesc.Name = "m_grpPluginDesc";
            this.m_grpPluginDesc.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpPluginDesc.Size = new System.Drawing.Size(1338, 212);
            this.m_grpPluginDesc.TabIndex = 1;
            this.m_grpPluginDesc.TabStop = false;
            // 
            // m_lblSelectedPluginDesc
            // 
            this.m_lblSelectedPluginDesc.Location = new System.Drawing.Point(14, 33);
            this.m_lblSelectedPluginDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblSelectedPluginDesc.Name = "m_lblSelectedPluginDesc";
            this.m_lblSelectedPluginDesc.Size = new System.Drawing.Size(1311, 134);
            this.m_lblSelectedPluginDesc.TabIndex = 0;
            this.m_lblSelectedPluginDesc.Text = "<>";
            // 
            // m_grpCache
            // 
            this.m_grpCache.Controls.Add(this.m_cbCacheDeleteOld);
            this.m_grpCache.Controls.Add(this.m_btnClearCache);
            this.m_grpCache.Controls.Add(this.m_lblCacheSize);
            this.m_grpCache.Location = new System.Drawing.Point(27, 717);
            this.m_grpCache.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpCache.Name = "m_grpCache";
            this.m_grpCache.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_grpCache.Size = new System.Drawing.Size(1338, 135);
            this.m_grpCache.TabIndex = 2;
            this.m_grpCache.TabStop = false;
            this.m_grpCache.Text = "Plugin Cache";
            // 
            // m_cbCacheDeleteOld
            // 
            this.m_cbCacheDeleteOld.AutoSize = true;
            this.m_cbCacheDeleteOld.Location = new System.Drawing.Point(21, 82);
            this.m_cbCacheDeleteOld.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_cbCacheDeleteOld.Name = "m_cbCacheDeleteOld";
            this.m_cbCacheDeleteOld.Size = new System.Drawing.Size(469, 33);
            this.m_cbCacheDeleteOld.TabIndex = 2;
            this.m_cbCacheDeleteOld.Text = "&Delete old files from cache automatically";
            this.m_cbCacheDeleteOld.UseVisualStyleBackColor = true;
            // 
            // m_btnClearCache
            // 
            this.m_btnClearCache.Location = new System.Drawing.Point(1146, 39);
            this.m_btnClearCache.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnClearCache.Name = "m_btnClearCache";
            this.m_btnClearCache.Size = new System.Drawing.Size(168, 48);
            this.m_btnClearCache.TabIndex = 1;
            this.m_btnClearCache.Text = "&Clear";
            this.m_btnClearCache.UseVisualStyleBackColor = true;
            this.m_btnClearCache.Click += new System.EventHandler(this.OnBtnClearCache);
            // 
            // m_lblCacheSize
            // 
            this.m_lblCacheSize.Location = new System.Drawing.Point(14, 39);
            this.m_lblCacheSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblCacheSize.Name = "m_lblCacheSize";
            this.m_lblCacheSize.Size = new System.Drawing.Size(1119, 38);
            this.m_lblCacheSize.TabIndex = 0;
            this.m_lblCacheSize.Text = "Data in cache (size):";
            // 
            // m_btnMore
            // 
            this.m_btnMore.Location = new System.Drawing.Point(27, 896);
            this.m_btnMore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnMore.Name = "m_btnMore";
            this.m_btnMore.Size = new System.Drawing.Size(258, 48);
            this.m_btnMore.TabIndex = 4;
            this.m_btnMore.Text = "&Get More Plugins...";
            this.m_btnMore.UseVisualStyleBackColor = true;
            this.m_btnMore.Click += new System.EventHandler(this.OnBtnGetMore);
            // 
            // m_btnOpenFolder
            // 
            this.m_btnOpenFolder.Location = new System.Drawing.Point(300, 896);
            this.m_btnOpenFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_btnOpenFolder.Name = "m_btnOpenFolder";
            this.m_btnOpenFolder.Size = new System.Drawing.Size(186, 48);
            this.m_btnOpenFolder.TabIndex = 5;
            this.m_btnOpenFolder.Text = "Open &Folder";
            this.m_btnOpenFolder.UseVisualStyleBackColor = true;
            this.m_btnOpenFolder.Click += new System.EventHandler(this.OnBtnOpenFolder);
            // 
            // PluginsForm
            // 
            this.AcceptButton = this.m_btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.m_btnClose;
            this.ClientSize = new System.Drawing.Size(1392, 968);
            this.Controls.Add(this.m_btnOpenFolder);
            this.Controls.Add(this.m_btnMore);
            this.Controls.Add(this.m_grpCache);
            this.Controls.Add(this.m_grpPluginDesc);
            this.Controls.Add(this.m_lblSeparator);
            this.Controls.Add(this.m_lvPlugins);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_bannerImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plugins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.m_grpPluginDesc.ResumeLayout(false);
            this.m_grpCache.ResumeLayout(false);
            this.m_grpCache.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnClose;
		private KeePass.UI.CustomListViewEx m_lvPlugins;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.GroupBox m_grpPluginDesc;
		private System.Windows.Forms.Label m_lblSelectedPluginDesc;
		private System.Windows.Forms.GroupBox m_grpCache;
		private System.Windows.Forms.Button m_btnClearCache;
		private System.Windows.Forms.Label m_lblCacheSize;
		private System.Windows.Forms.CheckBox m_cbCacheDeleteOld;
		private System.Windows.Forms.Button m_btnMore;
		private System.Windows.Forms.Button m_btnOpenFolder;
	}
}