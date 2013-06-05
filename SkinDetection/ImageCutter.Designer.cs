﻿namespace SkinDetection
{
    partial class ImageCutter
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbImgStart = new System.Windows.Forms.PictureBox();
            this.btnImgLoad = new System.Windows.Forms.Button();
            this.dlgImgLoad = new System.Windows.Forms.OpenFileDialog();
            this.pbImgChrB = new System.Windows.Forms.PictureBox();
            this.pbImgChrR = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrR)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbImgChrR);
            this.pnlMain.Controls.Add(this.pbImgChrB);
            this.pnlMain.Controls.Add(this.btnImgLoad);
            this.pnlMain.Controls.Add(this.pbImgStart);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(533, 220);
            this.pnlMain.TabIndex = 0;
            // 
            // pbImgStart
            // 
            this.pbImgStart.Location = new System.Drawing.Point(3, 32);
            this.pbImgStart.Name = "pbImgStart";
            this.pbImgStart.Size = new System.Drawing.Size(168, 159);
            this.pbImgStart.TabIndex = 0;
            this.pbImgStart.TabStop = false;
            // 
            // btnImgLoad
            // 
            this.btnImgLoad.Location = new System.Drawing.Point(3, 3);
            this.btnImgLoad.Name = "btnImgLoad";
            this.btnImgLoad.Size = new System.Drawing.Size(75, 23);
            this.btnImgLoad.TabIndex = 1;
            this.btnImgLoad.Text = "Load Image";
            this.btnImgLoad.UseVisualStyleBackColor = true;
            this.btnImgLoad.Click += new System.EventHandler(this.btnImgLoad_Click);
            // 
            // pbImgChrB
            // 
            this.pbImgChrB.Location = new System.Drawing.Point(177, 32);
            this.pbImgChrB.Name = "pbImgChrB";
            this.pbImgChrB.Size = new System.Drawing.Size(168, 159);
            this.pbImgChrB.TabIndex = 1;
            this.pbImgChrB.TabStop = false;
            // 
            // pbImgChrR
            // 
            this.pbImgChrR.Location = new System.Drawing.Point(351, 32);
            this.pbImgChrR.Name = "pbImgChrR";
            this.pbImgChrR.Size = new System.Drawing.Size(168, 159);
            this.pbImgChrR.TabIndex = 2;
            this.pbImgChrR.TabStop = false;
            // 
            // ImageCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 394);
            this.Controls.Add(this.pnlMain);
            this.Name = "ImageCutter";
            this.Text = "ImageCutter";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnImgLoad;
        private System.Windows.Forms.PictureBox pbImgStart;
        private System.Windows.Forms.OpenFileDialog dlgImgLoad;
        private System.Windows.Forms.PictureBox pbImgChrR;
        private System.Windows.Forms.PictureBox pbImgChrB;
    }
}