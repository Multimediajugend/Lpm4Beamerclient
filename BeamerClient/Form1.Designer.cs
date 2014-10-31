namespace BeamerClient
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.checkBoxStartWithWindows = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.timerAntiIdle = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSecondaryDisplay = new System.Windows.Forms.CheckBox();
            this.UDPSocketListener = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // textBoxID
            // 
            resources.ApplyResources(this.textBoxID, "textBoxID");
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // labelURL
            // 
            resources.ApplyResources(this.labelURL, "labelURL");
            this.labelURL.Name = "labelURL";
            // 
            // textBoxURL
            // 
            resources.ApplyResources(this.textBoxURL, "textBoxURL");
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Leave += new System.EventHandler(this.textBoxURL_Leave);
            // 
            // checkBoxAutoStart
            // 
            resources.ApplyResources(this.checkBoxAutoStart, "checkBoxAutoStart");
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.Leave += new System.EventHandler(this.checkBoxAutoStart_Leave);
            // 
            // checkBoxStartWithWindows
            // 
            resources.ApplyResources(this.checkBoxStartWithWindows, "checkBoxStartWithWindows");
            this.checkBoxStartWithWindows.Name = "checkBoxStartWithWindows";
            this.checkBoxStartWithWindows.UseVisualStyleBackColor = true;
            this.checkBoxStartWithWindows.Leave += new System.EventHandler(this.checkBoxStartWithWindows_Leave);
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxUsername
            // 
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.textBoxUsername.Name = "textBoxUsername";
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.Name = "labelUsername";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // timerAntiIdle
            // 
            this.timerAntiIdle.Interval = 10000;
            this.timerAntiIdle.Tick += new System.EventHandler(this.timerAntiIdle_Tick);
            // 
            // checkBoxSecondaryDisplay
            // 
            resources.ApplyResources(this.checkBoxSecondaryDisplay, "checkBoxSecondaryDisplay");
            this.checkBoxSecondaryDisplay.Name = "checkBoxSecondaryDisplay";
            this.checkBoxSecondaryDisplay.UseVisualStyleBackColor = true;
            this.checkBoxSecondaryDisplay.Leave += new System.EventHandler(this.checkBoxSecondaryDisplay_Leave);
            // 
            // UDPSocketListener
            // 
            this.UDPSocketListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UDPSocketListener_DoWork);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxSecondaryDisplay);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxStartWithWindows);
            this.Controls.Add(this.checkBoxAutoStart);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.CheckBox checkBoxStartWithWindows;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Timer timerAntiIdle;
        private System.Windows.Forms.CheckBox checkBoxSecondaryDisplay;
        private System.ComponentModel.BackgroundWorker UDPSocketListener;
    }
}

