namespace SkinDetection
{
    partial class EllipseCutter
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
            this.dlgOpenDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.lblNumFolders = new System.Windows.Forms.Label();
            this.txtNumFolders = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.chkTens = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgOpenDir
            // 
            this.dlgOpenDir.SelectedPath = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\male";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(12, 12);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 37);
            this.btnOpenDir.TabIndex = 0;
            this.btnOpenDir.Text = "Обрати директорію";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // lblNumFolders
            // 
            this.lblNumFolders.AutoSize = true;
            this.lblNumFolders.Location = new System.Drawing.Point(93, 24);
            this.lblNumFolders.Name = "lblNumFolders";
            this.lblNumFolders.Size = new System.Drawing.Size(89, 13);
            this.lblNumFolders.TabIndex = 1;
            this.lblNumFolders.Text = "Кількість папок:";
            // 
            // txtNumFolders
            // 
            this.txtNumFolders.Location = new System.Drawing.Point(188, 21);
            this.txtNumFolders.Name = "txtNumFolders";
            this.txtNumFolders.Size = new System.Drawing.Size(80, 20);
            this.txtNumFolders.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(274, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Почати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(12, 55);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(256, 218);
            this.pbImg.TabIndex = 4;
            this.pbImg.TabStop = false;
            this.pbImg.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImg_Paint);
            // 
            // chkTens
            // 
            this.chkTens.AutoSize = true;
            this.chkTens.Location = new System.Drawing.Point(274, 55);
            this.chkTens.Name = "chkTens";
            this.chkTens.Size = new System.Drawing.Size(43, 17);
            this.chkTens.TabIndex = 5;
            this.chkTens.Text = "x10";
            this.chkTens.UseVisualStyleBackColor = true;
            // 
            // EllipseCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 285);
            this.Controls.Add(this.chkTens);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNumFolders);
            this.Controls.Add(this.lblNumFolders);
            this.Controls.Add(this.btnOpenDir);
            this.KeyPreview = true;
            this.Name = "EllipseCutter";
            this.Text = "Вирізання еліпсів";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EllipseCutter_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dlgOpenDir;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Label lblNumFolders;
        private System.Windows.Forms.TextBox txtNumFolders;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.CheckBox chkTens;
    }
}