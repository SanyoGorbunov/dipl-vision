namespace SkinDetection
{
    partial class DatabaseUtil
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
            this.dlgSelectDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtNewDir = new System.Windows.Forms.TextBox();
            this.lblNewDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dlgSelectDir
            // 
            this.dlgSelectDir.SelectedPath = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(322, 10);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDir.TabIndex = 0;
            this.btnSelectDir.Text = "Select";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(66, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(250, 20);
            this.txtDir.TabIndex = 1;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(4, 15);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(56, 13);
            this.lblDir.TabIndex = 2;
            this.lblDir.Text = "Select Dir:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(4, 47);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Count:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(66, 44);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(64, 20);
            this.txtCount.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(322, 42);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtNewDir
            // 
            this.txtNewDir.Location = new System.Drawing.Point(198, 44);
            this.txtNewDir.Name = "txtNewDir";
            this.txtNewDir.Size = new System.Drawing.Size(118, 20);
            this.txtNewDir.TabIndex = 7;
            // 
            // lblNewDir
            // 
            this.lblNewDir.AutoSize = true;
            this.lblNewDir.Location = new System.Drawing.Point(146, 47);
            this.lblNewDir.Name = "lblNewDir";
            this.lblNewDir.Size = new System.Drawing.Size(48, 13);
            this.lblNewDir.TabIndex = 6;
            this.lblNewDir.Text = "New Dir:";
            // 
            // DatabaseUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 372);
            this.Controls.Add(this.txtNewDir);
            this.Controls.Add(this.lblNewDir);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnSelectDir);
            this.Name = "DatabaseUtil";
            this.Text = "DatabaseUtil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dlgSelectDir;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtNewDir;
        private System.Windows.Forms.Label lblNewDir;
    }
}