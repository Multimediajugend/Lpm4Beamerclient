namespace BeamerClient_v2
{
    partial class Projector
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(284, 261);
            this.webBrowser.TabIndex = 0;
            // 
            // panelBlack
            // 
            this.panelBlack.BackgroundImage = global::BeamerClient_v2.Properties.Resources.clanwars_desktop;
            this.panelBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBlack.Location = new System.Drawing.Point(0, 0);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(284, 261);
            this.panelBlack.TabIndex = 1;
            // 
            // Projector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panelBlack);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projector";
            this.Text = "Projector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panelBlack;
    }
}