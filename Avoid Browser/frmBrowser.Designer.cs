namespace Avoid_Browser
{
    partial class frmBrowser
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
            this.gpBrowser = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.webAvoid = new System.Windows.Forms.WebBrowser();
            this.tlsAddr = new System.Windows.Forms.ToolStrip();
            this.tlsBack = new System.Windows.Forms.ToolStripButton();
            this.tlsForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tlsRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cbSearchEngine = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gpBrowser.SuspendLayout();
            this.tlsAddr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBrowser
            // 
            this.gpBrowser.Controls.Add(this.lblCopyRight);
            this.gpBrowser.Controls.Add(this.webAvoid);
            this.gpBrowser.Location = new System.Drawing.Point(0, 38);
            this.gpBrowser.Name = "gpBrowser";
            this.gpBrowser.Size = new System.Drawing.Size(1262, 595);
            this.gpBrowser.TabIndex = 0;
            this.gpBrowser.TabStop = false;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(1021, 570);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(213, 16);
            this.lblCopyRight.TabIndex = 1;
            this.lblCopyRight.Text = "Made with ❤️ by yarzardhiyit © 2022";
            // 
            // webAvoid
            // 
            this.webAvoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webAvoid.Location = new System.Drawing.Point(3, 18);
            this.webAvoid.MinimumSize = new System.Drawing.Size(20, 20);
            this.webAvoid.Name = "webAvoid";
            this.webAvoid.ScriptErrorsSuppressed = true;
            this.webAvoid.Size = new System.Drawing.Size(1256, 574);
            this.webAvoid.TabIndex = 0;
            // 
            // tlsAddr
            // 
            this.tlsAddr.AutoSize = false;
            this.tlsAddr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsAddr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBack,
            this.tlsForward,
            this.toolStripSeparator,
            this.tlsRefresh});
            this.tlsAddr.Location = new System.Drawing.Point(0, 0);
            this.tlsAddr.Name = "tlsAddr";
            this.tlsAddr.Padding = new System.Windows.Forms.Padding(0);
            this.tlsAddr.Size = new System.Drawing.Size(1262, 35);
            this.tlsAddr.TabIndex = 1;
            this.tlsAddr.Text = "toolStrip1";
            // 
            // tlsBack
            // 
            this.tlsBack.AutoSize = false;
            this.tlsBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBack.Image = global::Avoid_Browser.Properties.Resources.imgBack;
            this.tlsBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBack.Name = "tlsBack";
            this.tlsBack.Size = new System.Drawing.Size(29, 24);
            this.tlsBack.Text = "Back";
            this.tlsBack.Click += new System.EventHandler(this.tlsBack_Click);
            // 
            // tlsForward
            // 
            this.tlsForward.AutoSize = false;
            this.tlsForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsForward.Image = global::Avoid_Browser.Properties.Resources.imgForward;
            this.tlsForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsForward.Name = "tlsForward";
            this.tlsForward.Size = new System.Drawing.Size(29, 24);
            this.tlsForward.Text = "Forward";
            this.tlsForward.Click += new System.EventHandler(this.tlsForward_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // tlsRefresh
            // 
            this.tlsRefresh.AutoSize = false;
            this.tlsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsRefresh.Image = global::Avoid_Browser.Properties.Resources.imgRefresh;
            this.tlsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsRefresh.Name = "tlsRefresh";
            this.tlsRefresh.Size = new System.Drawing.Size(29, 24);
            this.tlsRefresh.Text = "Refresh";
            this.tlsRefresh.Click += new System.EventHandler(this.tlsRefresh_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(140, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(736, 22);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // cbSearchEngine
            // 
            this.cbSearchEngine.FormattingEnabled = true;
            this.cbSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Yahoo",
            "Baidu",
            "Yandex"});
            this.cbSearchEngine.Location = new System.Drawing.Point(1149, 4);
            this.cbSearchEngine.Name = "cbSearchEngine";
            this.cbSearchEngine.Size = new System.Drawing.Size(94, 24);
            this.cbSearchEngine.TabIndex = 4;
            this.cbSearchEngine.Text = "Google";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(882, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 633);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchEngine);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.tlsAddr);
            this.Controls.Add(this.gpBrowser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 680);
            this.Name = "frmBrowser";
            this.Text = "Avoid Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrowser_FormClosing);
            this.gpBrowser.ResumeLayout(false);
            this.gpBrowser.PerformLayout();
            this.tlsAddr.ResumeLayout(false);
            this.tlsAddr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBrowser;
        private System.Windows.Forms.WebBrowser webAvoid;
        private System.Windows.Forms.ToolStrip tlsAddr;
        private System.Windows.Forms.ToolStripButton tlsBack;
        private System.Windows.Forms.ToolStripButton tlsForward;
        private System.Windows.Forms.ToolStripButton tlsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cbSearchEngine;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

