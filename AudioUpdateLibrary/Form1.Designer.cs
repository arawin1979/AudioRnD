namespace AudioUpdateLibrary
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFldr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(89, 45);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(293, 20);
            this.txtFolderPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FolderPath";
            // 
            // btnFldr
            // 
            this.btnFldr.Location = new System.Drawing.Point(380, 41);
            this.btnFldr.Name = "btnFldr";
            this.btnFldr.Size = new System.Drawing.Size(25, 23);
            this.btnFldr.TabIndex = 2;
            this.btnFldr.Text = "...";
            this.btnFldr.UseVisualStyleBackColor = true;
            this.btnFldr.Click += new System.EventHandler(this.btnFldr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find Text";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(89, 83);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(293, 20);
            this.txtFind.TabIndex = 4;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(89, 121);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(293, 20);
            this.txtReplace.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Replace with";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(318, 173);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 7;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 221);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFldr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFldr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReplace;
    }
}

