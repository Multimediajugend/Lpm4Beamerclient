namespace BeamerClient_v2.Controls
{
    partial class Video
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
            this.groupBoxPlaylist = new System.Windows.Forms.GroupBox();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSkip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPlaylist
            // 
            this.groupBoxPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlaylist.Controls.Add(this.buttonAddFolder);
            this.groupBoxPlaylist.Controls.Add(this.buttonAddFile);
            this.groupBoxPlaylist.Controls.Add(this.dataGridViewMovies);
            this.groupBoxPlaylist.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPlaylist.Name = "groupBoxPlaylist";
            this.groupBoxPlaylist.Size = new System.Drawing.Size(527, 546);
            this.groupBoxPlaylist.TabIndex = 1;
            this.groupBoxPlaylist.TabStop = false;
            this.groupBoxPlaylist.Text = "Playlist";
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(169, 19);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(157, 23);
            this.buttonAddFolder.TabIndex = 2;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(6, 19);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(157, 23);
            this.buttonAddFile.TabIndex = 1;
            this.buttonAddFile.Text = "Add File";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToResizeRows = false;
            this.dataGridViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPath,
            this.ColumnSkip,
            this.ColumnPlayed});
            this.dataGridViewMovies.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewMovies.MultiSelect = false;
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersVisible = false;
            this.dataGridViewMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovies.ShowCellErrors = false;
            this.dataGridViewMovies.ShowEditingIcon = false;
            this.dataGridViewMovies.ShowRowErrors = false;
            this.dataGridViewMovies.Size = new System.Drawing.Size(515, 492);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewMovies_RowsRemoved);
            // 
            // ColumnPath
            // 
            this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            this.ColumnPath.ReadOnly = true;
            // 
            // ColumnSkip
            // 
            this.ColumnSkip.HeaderText = "Skip";
            this.ColumnSkip.Name = "ColumnSkip";
            this.ColumnSkip.Visible = false;
            this.ColumnSkip.Width = 40;
            // 
            // ColumnPlayed
            // 
            this.ColumnPlayed.HeaderText = "Played";
            this.ColumnPlayed.Name = "ColumnPlayed";
            this.ColumnPlayed.ReadOnly = true;
            this.ColumnPlayed.Visible = false;
            this.ColumnPlayed.Width = 50;
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPlaylist);
            this.Name = "Video";
            this.Size = new System.Drawing.Size(533, 552);
            this.groupBoxPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlaylist;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSkip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayed;
    }
}
