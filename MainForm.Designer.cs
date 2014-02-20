namespace FileExtractor
{
    partial class MainPanel
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
            this.folderPathSrc = new System.Windows.Forms.TextBox();
            this.browseSrc = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderPathDest = new System.Windows.Forms.TextBox();
            this.browseRes = new System.Windows.Forms.Button();
            this.checkBoxResAsSrc = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepArch = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepEmpFolders = new System.Windows.Forms.CheckBox();
            this.checkBoxRenameFiles = new System.Windows.Forms.CheckBox();
            this.extract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderPathSrc
            // 
            this.folderPathSrc.Location = new System.Drawing.Point(107, 26);
            this.folderPathSrc.Name = "folderPathSrc";
            this.folderPathSrc.Size = new System.Drawing.Size(218, 20);
            this.folderPathSrc.TabIndex = 0;
            this.folderPathSrc.Text = "E:\\temp";
            // 
            // browseSrc
            // 
            this.browseSrc.Location = new System.Drawing.Point(331, 26);
            this.browseSrc.Name = "browseSrc";
            this.browseSrc.Size = new System.Drawing.Size(75, 23);
            this.browseSrc.TabIndex = 1;
            this.browseSrc.Text = "Browse";
            this.browseSrc.UseVisualStyleBackColor = true;
            this.browseSrc.Click += new System.EventHandler(this.browseSrc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result Folder";
            // 
            // folderPathDest
            // 
            this.folderPathDest.Location = new System.Drawing.Point(107, 65);
            this.folderPathDest.Name = "folderPathDest";
            this.folderPathDest.Size = new System.Drawing.Size(218, 20);
            this.folderPathDest.TabIndex = 4;
            this.folderPathDest.Text = "E:\\temp2";
            // 
            // browseRes
            // 
            this.browseRes.Location = new System.Drawing.Point(331, 63);
            this.browseRes.Name = "browseRes";
            this.browseRes.Size = new System.Drawing.Size(75, 23);
            this.browseRes.TabIndex = 5;
            this.browseRes.Text = "Browse";
            this.browseRes.UseVisualStyleBackColor = true;
            this.browseRes.Click += new System.EventHandler(this.browseRes_Click);
            // 
            // checkBoxResAsSrc
            // 
            this.checkBoxResAsSrc.AutoSize = true;
            this.checkBoxResAsSrc.Location = new System.Drawing.Point(412, 67);
            this.checkBoxResAsSrc.Name = "checkBoxResAsSrc";
            this.checkBoxResAsSrc.Size = new System.Drawing.Size(104, 17);
            this.checkBoxResAsSrc.TabIndex = 6;
            this.checkBoxResAsSrc.Text = "Same as Source";
            this.checkBoxResAsSrc.UseVisualStyleBackColor = true;
            this.checkBoxResAsSrc.CheckedChanged += new System.EventHandler(this.checkBoxResAsSrc_CheckedChanged);
            // 
            // checkBoxKeepArch
            // 
            this.checkBoxKeepArch.AutoSize = true;
            this.checkBoxKeepArch.Location = new System.Drawing.Point(107, 108);
            this.checkBoxKeepArch.Name = "checkBoxKeepArch";
            this.checkBoxKeepArch.Size = new System.Drawing.Size(94, 17);
            this.checkBoxKeepArch.TabIndex = 7;
            this.checkBoxKeepArch.Text = "Keep archives";
            this.checkBoxKeepArch.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeepEmpFolders
            // 
            this.checkBoxKeepEmpFolders.AutoSize = true;
            this.checkBoxKeepEmpFolders.Location = new System.Drawing.Point(107, 144);
            this.checkBoxKeepEmpFolders.Name = "checkBoxKeepEmpFolders";
            this.checkBoxKeepEmpFolders.Size = new System.Drawing.Size(116, 17);
            this.checkBoxKeepEmpFolders.TabIndex = 8;
            this.checkBoxKeepEmpFolders.Text = "Keep empty folders";
            this.checkBoxKeepEmpFolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxRenameFiles
            // 
            this.checkBoxRenameFiles.AutoSize = true;
            this.checkBoxRenameFiles.Location = new System.Drawing.Point(107, 178);
            this.checkBoxRenameFiles.Name = "checkBoxRenameFiles";
            this.checkBoxRenameFiles.Size = new System.Drawing.Size(184, 17);
            this.checkBoxRenameFiles.TabIndex = 9;
            this.checkBoxRenameFiles.Text = "Rename files with the same name";
            this.checkBoxRenameFiles.UseVisualStyleBackColor = true;
            // 
            // extract
            // 
            this.extract.Location = new System.Drawing.Point(331, 174);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(75, 23);
            this.extract.TabIndex = 10;
            this.extract.Text = "Extract";
            this.extract.UseVisualStyleBackColor = true;
            this.extract.Click += new System.EventHandler(this.extract_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 217);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.checkBoxRenameFiles);
            this.Controls.Add(this.checkBoxKeepEmpFolders);
            this.Controls.Add(this.checkBoxKeepArch);
            this.Controls.Add(this.checkBoxResAsSrc);
            this.Controls.Add(this.browseRes);
            this.Controls.Add(this.folderPathDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseSrc);
            this.Controls.Add(this.folderPathSrc);
            this.Name = "MainPanel";
            this.Text = "Files Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPathSrc;
        private System.Windows.Forms.Button browseSrc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderPathDest;
        private System.Windows.Forms.Button browseRes;
        private System.Windows.Forms.CheckBox checkBoxResAsSrc;
        private System.Windows.Forms.CheckBox checkBoxKeepArch;
        private System.Windows.Forms.CheckBox checkBoxKeepEmpFolders;
        private System.Windows.Forms.CheckBox checkBoxRenameFiles;
        private System.Windows.Forms.Button extract;
    }
}

