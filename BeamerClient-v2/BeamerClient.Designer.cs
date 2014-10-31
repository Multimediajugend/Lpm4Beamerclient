namespace BeamerClient_v2
{
    partial class BeamerClient
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxConfigureProjector = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStartProjector = new System.Windows.Forms.Button();
            this.buttonStopProjector = new System.Windows.Forms.Button();
            this.buttonStopMovie = new System.Windows.Forms.Button();
            this.buttonPauseMovie = new System.Windows.Forms.Button();
            this.buttonPlayMovie = new System.Windows.Forms.Button();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.panelDisplays = new System.Windows.Forms.Panel();
            this.buttonToggleProjector = new System.Windows.Forms.Button();
            this.tabPageWebsite = new System.Windows.Forms.TabPage();
            this.website = new BeamerClient_v2.Controls.Website();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.tabPageWebControl = new System.Windows.Forms.TabPage();
            this.webControl1 = new BeamerClient_v2.Controls.WebControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.buttonLogCopy = new System.Windows.Forms.Button();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.timerWebsiteShowTime = new System.Windows.Forms.Timer(this.components);
            this.video = new BeamerClient_v2.Controls.Video();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxConfigureProjector.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.tabPageWebsite.SuspendLayout();
            this.tabPageVideo.SuspendLayout();
            this.tabPageWebControl.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageWebsite);
            this.tabControl1.Controls.Add(this.tabPageVideo);
            this.tabControl1.Controls.Add(this.tabPageWebControl);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 489);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxConfigureProjector);
            this.tabPageMain.Controls.Add(this.groupBoxDisplay);
            this.tabPageMain.Controls.Add(this.buttonToggleProjector);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(606, 463);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "BeamerClient";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxConfigureProjector
            // 
            this.groupBoxConfigureProjector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfigureProjector.Controls.Add(this.buttonNext);
            this.groupBoxConfigureProjector.Controls.Add(this.buttonStartProjector);
            this.groupBoxConfigureProjector.Controls.Add(this.buttonStopProjector);
            this.groupBoxConfigureProjector.Controls.Add(this.buttonStopMovie);
            this.groupBoxConfigureProjector.Controls.Add(this.buttonPauseMovie);
            this.groupBoxConfigureProjector.Controls.Add(this.buttonPlayMovie);
            this.groupBoxConfigureProjector.Location = new System.Drawing.Point(6, 119);
            this.groupBoxConfigureProjector.Name = "groupBoxConfigureProjector";
            this.groupBoxConfigureProjector.Size = new System.Drawing.Size(592, 340);
            this.groupBoxConfigureProjector.TabIndex = 6;
            this.groupBoxConfigureProjector.TabStop = false;
            this.groupBoxConfigureProjector.Text = "Configure Projector";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(296, 98);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonStartProjector
            // 
            this.buttonStartProjector.Location = new System.Drawing.Point(6, 19);
            this.buttonStartProjector.Name = "buttonStartProjector";
            this.buttonStartProjector.Size = new System.Drawing.Size(75, 23);
            this.buttonStartProjector.TabIndex = 4;
            this.buttonStartProjector.Text = "Start";
            this.buttonStartProjector.UseVisualStyleBackColor = true;
            this.buttonStartProjector.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStopProjector
            // 
            this.buttonStopProjector.Enabled = false;
            this.buttonStopProjector.Location = new System.Drawing.Point(99, 19);
            this.buttonStopProjector.Name = "buttonStopProjector";
            this.buttonStopProjector.Size = new System.Drawing.Size(75, 23);
            this.buttonStopProjector.TabIndex = 3;
            this.buttonStopProjector.Text = "Stop";
            this.buttonStopProjector.UseVisualStyleBackColor = true;
            this.buttonStopProjector.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStopMovie
            // 
            this.buttonStopMovie.Location = new System.Drawing.Point(196, 98);
            this.buttonStopMovie.Name = "buttonStopMovie";
            this.buttonStopMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonStopMovie.TabIndex = 2;
            this.buttonStopMovie.Text = "Stop";
            this.buttonStopMovie.UseVisualStyleBackColor = true;
            this.buttonStopMovie.Click += new System.EventHandler(this.buttonStopMovie_Click);
            // 
            // buttonPauseMovie
            // 
            this.buttonPauseMovie.Location = new System.Drawing.Point(99, 98);
            this.buttonPauseMovie.Name = "buttonPauseMovie";
            this.buttonPauseMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonPauseMovie.TabIndex = 1;
            this.buttonPauseMovie.Text = "Pause";
            this.buttonPauseMovie.UseVisualStyleBackColor = true;
            this.buttonPauseMovie.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlayMovie
            // 
            this.buttonPlayMovie.Location = new System.Drawing.Point(6, 98);
            this.buttonPlayMovie.Name = "buttonPlayMovie";
            this.buttonPlayMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayMovie.TabIndex = 0;
            this.buttonPlayMovie.Text = "Play";
            this.buttonPlayMovie.UseVisualStyleBackColor = true;
            this.buttonPlayMovie.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDisplay.Controls.Add(this.panelDisplays);
            this.groupBoxDisplay.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(454, 107);
            this.groupBoxDisplay.TabIndex = 4;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Select Display";
            // 
            // panelDisplays
            // 
            this.panelDisplays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplays.AutoScroll = true;
            this.panelDisplays.Location = new System.Drawing.Point(6, 19);
            this.panelDisplays.Name = "panelDisplays";
            this.panelDisplays.Size = new System.Drawing.Size(442, 82);
            this.panelDisplays.TabIndex = 3;
            // 
            // buttonToggleProjector
            // 
            this.buttonToggleProjector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToggleProjector.Location = new System.Drawing.Point(466, 53);
            this.buttonToggleProjector.Name = "buttonToggleProjector";
            this.buttonToggleProjector.Size = new System.Drawing.Size(132, 23);
            this.buttonToggleProjector.TabIndex = 5;
            this.buttonToggleProjector.Text = "Open Projectorwindow";
            this.buttonToggleProjector.UseVisualStyleBackColor = true;
            this.buttonToggleProjector.Click += new System.EventHandler(this.buttonToggleProjector_Click);
            // 
            // tabPageWebsite
            // 
            this.tabPageWebsite.Controls.Add(this.website);
            this.tabPageWebsite.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebsite.Name = "tabPageWebsite";
            this.tabPageWebsite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebsite.Size = new System.Drawing.Size(606, 463);
            this.tabPageWebsite.TabIndex = 2;
            this.tabPageWebsite.Text = "Website";
            this.tabPageWebsite.UseVisualStyleBackColor = true;
            // 
            // website
            // 
            this.website.Dock = System.Windows.Forms.DockStyle.Fill;
            this.website.Location = new System.Drawing.Point(3, 3);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(600, 457);
            this.website.TabIndex = 0;
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.Controls.Add(this.video);
            this.tabPageVideo.Location = new System.Drawing.Point(4, 22);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVideo.Size = new System.Drawing.Size(606, 463);
            this.tabPageVideo.TabIndex = 3;
            this.tabPageVideo.Text = "Video";
            this.tabPageVideo.UseVisualStyleBackColor = true;
            // 
            // tabPageWebControl
            // 
            this.tabPageWebControl.Controls.Add(this.webControl1);
            this.tabPageWebControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageWebControl.Name = "tabPageWebControl";
            this.tabPageWebControl.Size = new System.Drawing.Size(606, 463);
            this.tabPageWebControl.TabIndex = 4;
            this.tabPageWebControl.Text = "WebControl";
            this.tabPageWebControl.UseVisualStyleBackColor = true;
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(606, 463);
            this.webControl1.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.buttonLogCopy);
            this.tabPageLog.Controls.Add(this.buttonLogClear);
            this.tabPageLog.Controls.Add(this.listBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(606, 463);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // buttonLogCopy
            // 
            this.buttonLogCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogCopy.Location = new System.Drawing.Point(6, 532);
            this.buttonLogCopy.Name = "buttonLogCopy";
            this.buttonLogCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonLogCopy.TabIndex = 2;
            this.buttonLogCopy.Text = "button1";
            this.buttonLogCopy.UseVisualStyleBackColor = true;
            this.buttonLogCopy.Click += new System.EventHandler(this.buttonLogCopy_Click);
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogClear.Location = new System.Drawing.Point(523, 432);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(75, 23);
            this.buttonLogClear.TabIndex = 1;
            this.buttonLogClear.Text = "Clear";
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.buttonLogClear_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(6, 6);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(592, 420);
            this.listBoxLog.TabIndex = 0;
            // 
            // timerWebsiteShowTime
            // 
            this.timerWebsiteShowTime.Tick += new System.EventHandler(this.timerWebsiteShowTime_Tick);
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video.Location = new System.Drawing.Point(3, 3);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(600, 457);
            this.video.TabIndex = 0;
            // 
            // BeamerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "BeamerClient";
            this.Text = "BeamerClient";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxConfigureProjector.ResumeLayout(false);
            this.groupBoxDisplay.ResumeLayout(false);
            this.tabPageWebsite.ResumeLayout(false);
            this.tabPageVideo.ResumeLayout(false);
            this.tabPageWebControl.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.Panel panelDisplays;
        private System.Windows.Forms.Button buttonToggleProjector;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Button buttonLogClear;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonLogCopy;
        private System.Windows.Forms.GroupBox groupBoxConfigureProjector;
        private System.Windows.Forms.Timer timerWebsiteShowTime;
        private System.Windows.Forms.TabPage tabPageWebsite;
        //private Controls.Website website;
        private System.Windows.Forms.TabPage tabPageVideo;
        //private Controls.Video video1;
        private System.Windows.Forms.Button buttonStopProjector;
        private System.Windows.Forms.Button buttonStopMovie;
        private System.Windows.Forms.Button buttonPauseMovie;
        private System.Windows.Forms.Button buttonPlayMovie;
        private System.Windows.Forms.Button buttonStartProjector;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TabPage tabPageWebControl;
        private Controls.WebControl webControl1;
        private Controls.Website website;
        private Controls.Video video;

    }
}