namespace AudioUpdateLibrary
{
    partial class BulkUpdateView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnFldr = new System.Windows.Forms.Button();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAblbumAutoUpdate = new System.Windows.Forms.CheckBox();
            this.chkUpdateFNasTitle = new System.Windows.Forms.CheckBox();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGener = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBulkUpdate = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Folder";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(82, 30);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(330, 20);
            this.txtFolderPath.TabIndex = 1;
            this.txtFolderPath.Text = "C:\\Users\\Aravinth\\Documents\\Vuze Downloads\\Aaytha Ezhuthu (2004)";
            // 
            // btnFldr
            // 
            this.btnFldr.Location = new System.Drawing.Point(414, 30);
            this.btnFldr.Name = "btnFldr";
            this.btnFldr.Size = new System.Drawing.Size(30, 23);
            this.btnFldr.TabIndex = 2;
            this.btnFldr.Text = "..";
            this.btnFldr.UseVisualStyleBackColor = true;
            this.btnFldr.Click += new System.EventHandler(this.btnFldr_Click);
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Location = new System.Drawing.Point(460, 33);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(109, 17);
            this.chkSubFolders.TabIndex = 3;
            this.chkSubFolders.Text = "Include Subfolder";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAblbumAutoUpdate);
            this.groupBox1.Controls.Add(this.chkUpdateFNasTitle);
            this.groupBox1.Controls.Add(this.txtAlbumArtist);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGener);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAlbumName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtComposer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkAblbumAutoUpdate
            // 
            this.chkAblbumAutoUpdate.AutoSize = true;
            this.chkAblbumAutoUpdate.Location = new System.Drawing.Point(437, 50);
            this.chkAblbumAutoUpdate.Name = "chkAblbumAutoUpdate";
            this.chkAblbumAutoUpdate.Size = new System.Drawing.Size(204, 17);
            this.chkAblbumAutoUpdate.TabIndex = 11;
            this.chkAblbumAutoUpdate.Text = "Update Folder Name as Album Name ";
            this.chkAblbumAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAblbumAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAblbumAutoUpdate_CheckedChanged);
            // 
            // chkUpdateFNasTitle
            // 
            this.chkUpdateFNasTitle.AutoSize = true;
            this.chkUpdateFNasTitle.Location = new System.Drawing.Point(27, 108);
            this.chkUpdateFNasTitle.Name = "chkUpdateFNasTitle";
            this.chkUpdateFNasTitle.Size = new System.Drawing.Size(148, 17);
            this.chkUpdateFNasTitle.TabIndex = 10;
            this.chkUpdateFNasTitle.Text = "Update File Name as Title";
            this.chkUpdateFNasTitle.UseVisualStyleBackColor = true;
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Location = new System.Drawing.Point(82, 71);
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.Size = new System.Drawing.Size(164, 20);
            this.txtAlbumArtist.TabIndex = 9;
            this.txtAlbumArtist.Text = "A. R. Rahman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Album Artist";
            // 
            // txtGener
            // 
            this.txtGener.Location = new System.Drawing.Point(437, 74);
            this.txtGener.Name = "txtGener";
            this.txtGener.Size = new System.Drawing.Size(164, 20);
            this.txtGener.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gener";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(82, 45);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(164, 20);
            this.txtYear.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(437, 20);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(164, 20);
            this.txtAlbumName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album Name";
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(82, 19);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(164, 20);
            this.txtComposer.TabIndex = 1;
            this.txtComposer.Text = "A. R. Rahman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Composer";
            // 
            // btnBulkUpdate
            // 
            this.btnBulkUpdate.Location = new System.Drawing.Point(475, 237);
            this.btnBulkUpdate.Name = "btnBulkUpdate";
            this.btnBulkUpdate.Size = new System.Drawing.Size(152, 23);
            this.btnBulkUpdate.TabIndex = 5;
            this.btnBulkUpdate.Text = "Update";
            this.btnBulkUpdate.UseVisualStyleBackColor = true;
            this.btnBulkUpdate.Click += new System.EventHandler(this.btnBulkUpdate_Click);
            // 
            // BulkUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 288);
            this.Controls.Add(this.btnBulkUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSubFolders);
            this.Controls.Add(this.btnFldr);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label1);
            this.Name = "BulkUpdateView";
            this.Text = "BulkUpdate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnFldr;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlbumArtist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGener;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUpdateFNasTitle;
        private System.Windows.Forms.Button btnBulkUpdate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkAblbumAutoUpdate;
    }
}