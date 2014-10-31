namespace BeamerClient_v2.Controls
{
    partial class Website
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxWebsitePreview = new System.Windows.Forms.GroupBox();
            this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
            this.groupBoxWebsiteConfig = new System.Windows.Forms.GroupBox();
            this.labelWebsiteUrl = new System.Windows.Forms.Label();
            this.labelWebsiteNews = new System.Windows.Forms.Label();
            this.buttonWebsiteRefresh = new System.Windows.Forms.Button();
            this.labelWebsiteStatus = new System.Windows.Forms.Label();
            this.labelWebsiteSecond = new System.Windows.Forms.Label();
            this.labelWebsiteDuration = new System.Windows.Forms.Label();
            this.textBoxWebsiteDuration = new System.Windows.Forms.TextBox();
            this.buttonWebsiteShow = new System.Windows.Forms.Button();
            this.textBoxWebsiteURL = new System.Windows.Forms.TextBox();
            this.comboBoxWebsiteNews = new System.Windows.Forms.ComboBox();
            this.timerUrlCheck = new System.Windows.Forms.Timer(this.components);
            this.checkBoxWebsitePolling = new System.Windows.Forms.CheckBox();
            this.timerPolling = new System.Windows.Forms.Timer(this.components);
            this.buttonWebsiteLoadNews = new System.Windows.Forms.Button();
            this.groupBoxWebsitePreview.SuspendLayout();
            this.groupBoxWebsiteConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWebsitePreview
            // 
            this.groupBoxWebsitePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWebsitePreview.Controls.Add(this.webBrowserPreview);
            this.groupBoxWebsitePreview.Location = new System.Drawing.Point(3, 133);
            this.groupBoxWebsitePreview.Name = "groupBoxWebsitePreview";
            this.groupBoxWebsitePreview.Size = new System.Drawing.Size(631, 500);
            this.groupBoxWebsitePreview.TabIndex = 3;
            this.groupBoxWebsitePreview.TabStop = false;
            this.groupBoxWebsitePreview.Text = "Preview";
            // 
            // webBrowserPreview
            // 
            this.webBrowserPreview.AllowWebBrowserDrop = false;
            this.webBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPreview.Location = new System.Drawing.Point(3, 16);
            this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPreview.Name = "webBrowserPreview";
            this.webBrowserPreview.Size = new System.Drawing.Size(625, 481);
            this.webBrowserPreview.TabIndex = 0;
            this.webBrowserPreview.WebBrowserShortcutsEnabled = false;
            this.webBrowserPreview.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowserPreview_Navigated);
            // 
            // groupBoxWebsiteConfig
            // 
            this.groupBoxWebsiteConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWebsiteConfig.Controls.Add(this.buttonWebsiteLoadNews);
            this.groupBoxWebsiteConfig.Controls.Add(this.checkBoxWebsitePolling);
            this.groupBoxWebsiteConfig.Controls.Add(this.labelWebsiteUrl);
            this.groupBoxWebsiteConfig.Controls.Add(this.labelWebsiteNews);
            this.groupBoxWebsiteConfig.Controls.Add(this.buttonWebsiteRefresh);
            this.groupBoxWebsiteConfig.Controls.Add(this.labelWebsiteStatus);
            this.groupBoxWebsiteConfig.Controls.Add(this.labelWebsiteSecond);
            this.groupBoxWebsiteConfig.Controls.Add(this.labelWebsiteDuration);
            this.groupBoxWebsiteConfig.Controls.Add(this.textBoxWebsiteDuration);
            this.groupBoxWebsiteConfig.Controls.Add(this.buttonWebsiteShow);
            this.groupBoxWebsiteConfig.Controls.Add(this.textBoxWebsiteURL);
            this.groupBoxWebsiteConfig.Controls.Add(this.comboBoxWebsiteNews);
            this.groupBoxWebsiteConfig.Location = new System.Drawing.Point(3, 3);
            this.groupBoxWebsiteConfig.Name = "groupBoxWebsiteConfig";
            this.groupBoxWebsiteConfig.Size = new System.Drawing.Size(631, 124);
            this.groupBoxWebsiteConfig.TabIndex = 2;
            this.groupBoxWebsiteConfig.TabStop = false;
            this.groupBoxWebsiteConfig.Text = "Configuration";
            // 
            // labelWebsiteUrl
            // 
            this.labelWebsiteUrl.AutoSize = true;
            this.labelWebsiteUrl.Location = new System.Drawing.Point(29, 72);
            this.labelWebsiteUrl.Name = "labelWebsiteUrl";
            this.labelWebsiteUrl.Size = new System.Drawing.Size(32, 13);
            this.labelWebsiteUrl.TabIndex = 12;
            this.labelWebsiteUrl.Text = "URL:";
            // 
            // labelWebsiteNews
            // 
            this.labelWebsiteNews.AutoSize = true;
            this.labelWebsiteNews.Location = new System.Drawing.Point(24, 45);
            this.labelWebsiteNews.Name = "labelWebsiteNews";
            this.labelWebsiteNews.Size = new System.Drawing.Size(37, 13);
            this.labelWebsiteNews.TabIndex = 11;
            this.labelWebsiteNews.Text = "News:";
            // 
            // buttonWebsiteRefresh
            // 
            this.buttonWebsiteRefresh.Location = new System.Drawing.Point(6, 95);
            this.buttonWebsiteRefresh.Name = "buttonWebsiteRefresh";
            this.buttonWebsiteRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonWebsiteRefresh.TabIndex = 10;
            this.buttonWebsiteRefresh.Text = "Refresh";
            this.buttonWebsiteRefresh.UseVisualStyleBackColor = true;
            this.buttonWebsiteRefresh.Click += new System.EventHandler(this.buttonWebsiteRefresh_Click);
            // 
            // labelWebsiteStatus
            // 
            this.labelWebsiteStatus.AutoSize = true;
            this.labelWebsiteStatus.Location = new System.Drawing.Point(87, 100);
            this.labelWebsiteStatus.Name = "labelWebsiteStatus";
            this.labelWebsiteStatus.Size = new System.Drawing.Size(98, 13);
            this.labelWebsiteStatus.TabIndex = 9;
            this.labelWebsiteStatus.Text = "Loading Preview ...";
            this.labelWebsiteStatus.Visible = false;
            // 
            // labelWebsiteSecond
            // 
            this.labelWebsiteSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebsiteSecond.AutoSize = true;
            this.labelWebsiteSecond.Location = new System.Drawing.Point(470, 100);
            this.labelWebsiteSecond.Name = "labelWebsiteSecond";
            this.labelWebsiteSecond.Size = new System.Drawing.Size(12, 13);
            this.labelWebsiteSecond.TabIndex = 8;
            this.labelWebsiteSecond.Text = "s";
            // 
            // labelWebsiteDuration
            // 
            this.labelWebsiteDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebsiteDuration.AutoSize = true;
            this.labelWebsiteDuration.Location = new System.Drawing.Point(364, 100);
            this.labelWebsiteDuration.Name = "labelWebsiteDuration";
            this.labelWebsiteDuration.Size = new System.Drawing.Size(50, 13);
            this.labelWebsiteDuration.TabIndex = 7;
            this.labelWebsiteDuration.Text = "Duration:";
            // 
            // textBoxWebsiteDuration
            // 
            this.textBoxWebsiteDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebsiteDuration.Location = new System.Drawing.Point(420, 97);
            this.textBoxWebsiteDuration.Name = "textBoxWebsiteDuration";
            this.textBoxWebsiteDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxWebsiteDuration.Size = new System.Drawing.Size(44, 20);
            this.textBoxWebsiteDuration.TabIndex = 6;
            this.textBoxWebsiteDuration.Text = "180";
            // 
            // buttonWebsiteShow
            // 
            this.buttonWebsiteShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWebsiteShow.Location = new System.Drawing.Point(488, 95);
            this.buttonWebsiteShow.Name = "buttonWebsiteShow";
            this.buttonWebsiteShow.Size = new System.Drawing.Size(137, 23);
            this.buttonWebsiteShow.TabIndex = 5;
            this.buttonWebsiteShow.Text = "Show on Projector";
            this.buttonWebsiteShow.UseVisualStyleBackColor = true;
            this.buttonWebsiteShow.Click += new System.EventHandler(this.buttonWebsiteShow_Click);
            // 
            // textBoxWebsiteURL
            // 
            this.textBoxWebsiteURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebsiteURL.Location = new System.Drawing.Point(67, 69);
            this.textBoxWebsiteURL.Name = "textBoxWebsiteURL";
            this.textBoxWebsiteURL.Size = new System.Drawing.Size(558, 20);
            this.textBoxWebsiteURL.TabIndex = 3;
            this.textBoxWebsiteURL.TextChanged += new System.EventHandler(this.textBoxWebsiteURL_TextChanged);
            // 
            // comboBoxWebsiteNews
            // 
            this.comboBoxWebsiteNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWebsiteNews.FormattingEnabled = true;
            this.comboBoxWebsiteNews.Location = new System.Drawing.Point(67, 42);
            this.comboBoxWebsiteNews.Name = "comboBoxWebsiteNews";
            this.comboBoxWebsiteNews.Size = new System.Drawing.Size(477, 21);
            this.comboBoxWebsiteNews.TabIndex = 2;
            this.comboBoxWebsiteNews.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebsiteNews_SelectedIndexChanged);
            // 
            // timerUrlCheck
            // 
            this.timerUrlCheck.Interval = 1000;
            this.timerUrlCheck.Tick += new System.EventHandler(this.timerUrlCheck_Tick);
            // 
            // checkBoxWebsitePolling
            // 
            this.checkBoxWebsitePolling.AutoSize = true;
            this.checkBoxWebsitePolling.Checked = true;
            this.checkBoxWebsitePolling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWebsitePolling.Location = new System.Drawing.Point(67, 19);
            this.checkBoxWebsitePolling.Name = "checkBoxWebsitePolling";
            this.checkBoxWebsitePolling.Size = new System.Drawing.Size(73, 17);
            this.checkBoxWebsitePolling.TabIndex = 13;
            this.checkBoxWebsitePolling.Text = "Poll News";
            this.checkBoxWebsitePolling.UseVisualStyleBackColor = true;
            this.checkBoxWebsitePolling.CheckedChanged += new System.EventHandler(this.checkBoxWebsitePolling_CheckedChanged);
            // 
            // timerPolling
            // 
            this.timerPolling.Interval = 15000;
            this.timerPolling.Tick += new System.EventHandler(this.timerPolling_Tick);
            // 
            // buttonWebsiteLoadNews
            // 
            this.buttonWebsiteLoadNews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWebsiteLoadNews.Location = new System.Drawing.Point(550, 40);
            this.buttonWebsiteLoadNews.Name = "buttonWebsiteLoadNews";
            this.buttonWebsiteLoadNews.Size = new System.Drawing.Size(75, 23);
            this.buttonWebsiteLoadNews.TabIndex = 14;
            this.buttonWebsiteLoadNews.Text = "Refresh";
            this.buttonWebsiteLoadNews.UseVisualStyleBackColor = true;
            this.buttonWebsiteLoadNews.Click += new System.EventHandler(this.buttonWebsiteLoadNews_Click);
            // 
            // Website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxWebsitePreview);
            this.Controls.Add(this.groupBoxWebsiteConfig);
            this.Name = "Website";
            this.Size = new System.Drawing.Size(637, 636);
            this.groupBoxWebsitePreview.ResumeLayout(false);
            this.groupBoxWebsiteConfig.ResumeLayout(false);
            this.groupBoxWebsiteConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWebsitePreview;
        private System.Windows.Forms.WebBrowser webBrowserPreview;
        private System.Windows.Forms.GroupBox groupBoxWebsiteConfig;
        private System.Windows.Forms.Label labelWebsiteStatus;
        private System.Windows.Forms.Label labelWebsiteSecond;
        private System.Windows.Forms.Label labelWebsiteDuration;
        private System.Windows.Forms.TextBox textBoxWebsiteDuration;
        private System.Windows.Forms.Button buttonWebsiteShow;
        private System.Windows.Forms.TextBox textBoxWebsiteURL;
        private System.Windows.Forms.ComboBox comboBoxWebsiteNews;
        private System.Windows.Forms.Timer timerUrlCheck;
        private System.Windows.Forms.Button buttonWebsiteRefresh;
        private System.Windows.Forms.Label labelWebsiteUrl;
        private System.Windows.Forms.Label labelWebsiteNews;
        private System.Windows.Forms.CheckBox checkBoxWebsitePolling;
        private System.Windows.Forms.Timer timerPolling;
        private System.Windows.Forms.Button buttonWebsiteLoadNews;
    }
}
