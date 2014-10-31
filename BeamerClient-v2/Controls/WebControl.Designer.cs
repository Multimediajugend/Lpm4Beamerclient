namespace BeamerClient_v2.Controls
{
    partial class WebControl
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
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfig.Controls.Add(this.buttonStart);
            this.groupBoxConfig.Controls.Add(this.textBoxPort);
            this.groupBoxConfig.Controls.Add(this.labelPort);
            this.groupBoxConfig.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(433, 64);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Configuration";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(131, 17);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start WebControl";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(55, 19);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(42, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "45163";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(23, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port";
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(427, 264);
            this.listBoxLog.TabIndex = 1;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(3, 73);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(433, 283);
            this.groupBoxLog.TabIndex = 2;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "LogMessages";
            // 
            // WebControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "WebControl";
            this.Size = new System.Drawing.Size(439, 359);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.GroupBox groupBoxLog;
    }
}
