namespace MergeMP3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listFiles = new System.Windows.Forms.ListView();
            this.ColumnPath = new System.Windows.Forms.ColumnHeader();
            this.ColumnDuration = new System.Windows.Forms.ColumnHeader();
            this.TbDir = new System.Windows.Forms.TextBox();
            this.BtnBrowseDir = new System.Windows.Forms.Button();
            this.BtnMerge = new System.Windows.Forms.Button();
            this.FolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.FileSave = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbTargetFile = new System.Windows.Forms.TextBox();
            this.BtnBrowseSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listFiles);
            this.groupBox1.Controls.Add(this.TbDir);
            this.groupBox1.Controls.Add(this.BtnBrowseDir);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Location = new System.Drawing.Point(206, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Source Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "MP3 files in this folder:";
            // 
            // listFiles
            // 
            this.listFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnPath,
            this.ColumnDuration});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listFiles.Location = new System.Drawing.Point(6, 93);
            this.listFiles.Name = "listFiles";
            this.listFiles.ShowGroups = false;
            this.listFiles.Size = new System.Drawing.Size(883, 429);
            this.listFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listFiles.TabIndex = 4;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            // 
            // ColumnPath
            // 
            this.ColumnPath.Text = "MP3 files";
            this.ColumnPath.Width = 300;
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.Text = "Duration";
            this.ColumnDuration.Width = 100;
            // 
            // TbDir
            // 
            this.TbDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbDir.Location = new System.Drawing.Point(6, 28);
            this.TbDir.Name = "TbDir";
            this.TbDir.PlaceholderText = "Choose source folder containing MP3 files...";
            this.TbDir.Size = new System.Drawing.Size(783, 27);
            this.TbDir.TabIndex = 1;
            this.TbDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDir_KeyPress);
            // 
            // BtnBrowseDir
            // 
            this.BtnBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBrowseDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBrowseDir.Location = new System.Drawing.Point(795, 26);
            this.BtnBrowseDir.Name = "BtnBrowseDir";
            this.BtnBrowseDir.Size = new System.Drawing.Size(94, 29);
            this.BtnBrowseDir.TabIndex = 0;
            this.BtnBrowseDir.Text = "Browse...";
            this.BtnBrowseDir.UseVisualStyleBackColor = true;
            this.BtnBrowseDir.Click += new System.EventHandler(this.BtnBrowseDir_Click);
            // 
            // BtnMerge
            // 
            this.BtnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMerge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMerge.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnMerge.Location = new System.Drawing.Point(981, 618);
            this.BtnMerge.Name = "BtnMerge";
            this.BtnMerge.Size = new System.Drawing.Size(120, 40);
            this.BtnMerge.TabIndex = 6;
            this.BtnMerge.Text = "MERGE";
            this.BtnMerge.UseVisualStyleBackColor = true;
            this.BtnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // FolderBrowse
            // 
            this.FolderBrowse.ShowNewFolderButton = false;
            // 
            // FileSave
            // 
            this.FileSave.Filter = "MP3 files|*.mp3";
            this.FileSave.Title = "Merged mp3 file";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TbTargetFile);
            this.groupBox2.Controls.Add(this.BtnBrowseSave);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(206, 546);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Target File";
            // 
            // TbTargetFile
            // 
            this.TbTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTargetFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbTargetFile.Location = new System.Drawing.Point(6, 28);
            this.TbTargetFile.Name = "TbTargetFile";
            this.TbTargetFile.PlaceholderText = "Choose target file path to save merged MP3 file...";
            this.TbTargetFile.Size = new System.Drawing.Size(783, 27);
            this.TbTargetFile.TabIndex = 1;
            // 
            // BtnBrowseSave
            // 
            this.BtnBrowseSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBrowseSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBrowseSave.Location = new System.Drawing.Point(795, 27);
            this.BtnBrowseSave.Name = "BtnBrowseSave";
            this.BtnBrowseSave.Size = new System.Drawing.Size(94, 29);
            this.BtnBrowseSave.TabIndex = 0;
            this.BtnBrowseSave.Text = "Browse...";
            this.BtnBrowseSave.UseVisualStyleBackColor = true;
            this.BtnBrowseSave.Click += new System.EventHandler(this.BtnBrowseSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MergeMP3.Properties.Resources.Banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1113, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnMerge);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge MP3";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox TbDir;
        private Button BtnBrowseDir;
        private FolderBrowserDialog FolderBrowse;
        private SaveFileDialog FileSave;
        private Button BtnMerge;
        private Label label1;
        private ListView listFiles;
        private GroupBox groupBox2;
        private TextBox TbTargetFile;
        private Button BtnBrowseSave;
        private ColumnHeader ColumnPath;
        private ColumnHeader ColumnDuration;
    }
}