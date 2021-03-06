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
            this.cbColorSet = new System.Windows.Forms.ComboBox();
            this.chkFloodFill = new System.Windows.Forms.CheckBox();
            this.pbImgMix = new System.Windows.Forms.PictureBox();
            this.btnSetThreshold = new System.Windows.Forms.Button();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.pbImgChrR = new System.Windows.Forms.PictureBox();
            this.pbImgChrB = new System.Windows.Forms.PictureBox();
            this.btnImgLoad = new System.Windows.Forms.Button();
            this.pbImgStart = new System.Windows.Forms.PictureBox();
            this.dlgImgLoad = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cbColorSet);
            this.pnlMain.Controls.Add(this.chkFloodFill);
            this.pnlMain.Controls.Add(this.pbImgMix);
            this.pnlMain.Controls.Add(this.btnSetThreshold);
            this.pnlMain.Controls.Add(this.lblThreshold);
            this.pnlMain.Controls.Add(this.txtThreshold);
            this.pnlMain.Controls.Add(this.pbImgChrR);
            this.pnlMain.Controls.Add(this.pbImgChrB);
            this.pnlMain.Controls.Add(this.btnImgLoad);
            this.pnlMain.Controls.Add(this.pbImgStart);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(533, 370);
            this.pnlMain.TabIndex = 0;
            // 
            // cbColorSet
            // 
            this.cbColorSet.FormattingEnabled = true;
            this.cbColorSet.Items.AddRange(new object[] {
            "RGB",
            "Chromatic"});
            this.cbColorSet.Location = new System.Drawing.Point(398, 6);
            this.cbColorSet.Name = "cbColorSet";
            this.cbColorSet.Size = new System.Drawing.Size(121, 21);
            this.cbColorSet.TabIndex = 8;
            // 
            // chkFloodFill
            // 
            this.chkFloodFill.AutoSize = true;
            this.chkFloodFill.Location = new System.Drawing.Point(109, 8);
            this.chkFloodFill.Name = "chkFloodFill";
            this.chkFloodFill.Size = new System.Drawing.Size(87, 17);
            this.chkFloodFill.TabIndex = 7;
            this.chkFloodFill.Text = "Заповнення";
            this.chkFloodFill.UseVisualStyleBackColor = true;
            // 
            // pbImgMix
            // 
            this.pbImgMix.Location = new System.Drawing.Point(177, 197);
            this.pbImgMix.Name = "pbImgMix";
            this.pbImgMix.Size = new System.Drawing.Size(168, 159);
            this.pbImgMix.TabIndex = 6;
            this.pbImgMix.TabStop = false;
            // 
            // btnSetThreshold
            // 
            this.btnSetThreshold.Location = new System.Drawing.Point(302, 5);
            this.btnSetThreshold.Name = "btnSetThreshold";
            this.btnSetThreshold.Size = new System.Drawing.Size(90, 23);
            this.btnSetThreshold.TabIndex = 5;
            this.btnSetThreshold.Text = "Встановити";
            this.btnSetThreshold.UseVisualStyleBackColor = true;
            this.btnSetThreshold.Click += new System.EventHandler(this.btnSetThreshold_Click);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(202, 9);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(37, 13);
            this.lblThreshold.TabIndex = 4;
            this.lblThreshold.Text = "Поріг:";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(245, 6);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(51, 20);
            this.txtThreshold.TabIndex = 3;
            // 
            // pbImgChrR
            // 
            this.pbImgChrR.Location = new System.Drawing.Point(351, 32);
            this.pbImgChrR.Name = "pbImgChrR";
            this.pbImgChrR.Size = new System.Drawing.Size(168, 159);
            this.pbImgChrR.TabIndex = 2;
            this.pbImgChrR.TabStop = false;
            // 
            // pbImgChrB
            // 
            this.pbImgChrB.Location = new System.Drawing.Point(177, 32);
            this.pbImgChrB.Name = "pbImgChrB";
            this.pbImgChrB.Size = new System.Drawing.Size(168, 159);
            this.pbImgChrB.TabIndex = 1;
            this.pbImgChrB.TabStop = false;
            // 
            // btnImgLoad
            // 
            this.btnImgLoad.Location = new System.Drawing.Point(3, 3);
            this.btnImgLoad.Name = "btnImgLoad";
            this.btnImgLoad.Size = new System.Drawing.Size(100, 23);
            this.btnImgLoad.TabIndex = 1;
            this.btnImgLoad.Text = "Завантажити";
            this.btnImgLoad.UseVisualStyleBackColor = true;
            this.btnImgLoad.Click += new System.EventHandler(this.btnImgLoad_Click);
            // 
            // pbImgStart
            // 
            this.pbImgStart.Location = new System.Drawing.Point(3, 32);
            this.pbImgStart.Name = "pbImgStart";
            this.pbImgStart.Size = new System.Drawing.Size(168, 159);
            this.pbImgStart.TabIndex = 0;
            this.pbImgStart.TabStop = false;
            this.pbImgStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImgStart_MouseClick);
            // 
            // ImageCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 394);
            this.Controls.Add(this.pnlMain);
            this.Name = "ImageCutter";
            this.Text = "Перевірка алгоритму заповнення";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgChrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnImgLoad;
        private System.Windows.Forms.PictureBox pbImgStart;
        private System.Windows.Forms.OpenFileDialog dlgImgLoad;
        private System.Windows.Forms.PictureBox pbImgChrR;
        private System.Windows.Forms.PictureBox pbImgChrB;
        private System.Windows.Forms.Button btnSetThreshold;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.PictureBox pbImgMix;
        private System.Windows.Forms.CheckBox chkFloodFill;
        private System.Windows.Forms.ComboBox cbColorSet;
    }
}