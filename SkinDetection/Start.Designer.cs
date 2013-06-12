namespace SkinDetection
{
    partial class Start
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
            this.btnFaceColorLib = new System.Windows.Forms.Button();
            this.lblDetection = new System.Windows.Forms.Label();
            this.btnShapeInfo = new System.Windows.Forms.Button();
            this.lblUtils = new System.Windows.Forms.Label();
            this.btnDatabaseUtil = new System.Windows.Forms.Button();
            this.btnFaceColorModels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaceColorLib
            // 
            this.btnFaceColorLib.Location = new System.Drawing.Point(12, 51);
            this.btnFaceColorLib.Name = "btnFaceColorLib";
            this.btnFaceColorLib.Size = new System.Drawing.Size(75, 23);
            this.btnFaceColorLib.TabIndex = 0;
            this.btnFaceColorLib.Text = "Face Color";
            this.btnFaceColorLib.UseVisualStyleBackColor = true;
            this.btnFaceColorLib.Click += new System.EventHandler(this.btnFaceColorLib_Click);
            // 
            // lblDetection
            // 
            this.lblDetection.AutoSize = true;
            this.lblDetection.Location = new System.Drawing.Point(12, 25);
            this.lblDetection.Name = "lblDetection";
            this.lblDetection.Size = new System.Drawing.Size(83, 13);
            this.lblDetection.TabIndex = 1;
            this.lblDetection.Text = "Face Detection:";
            // 
            // btnShapeInfo
            // 
            this.btnShapeInfo.Location = new System.Drawing.Point(12, 80);
            this.btnShapeInfo.Name = "btnShapeInfo";
            this.btnShapeInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShapeInfo.TabIndex = 2;
            this.btnShapeInfo.Text = "Shape Info";
            this.btnShapeInfo.UseVisualStyleBackColor = true;
            this.btnShapeInfo.Click += new System.EventHandler(this.btnShapeInfo_Click);
            // 
            // lblUtils
            // 
            this.lblUtils.AutoSize = true;
            this.lblUtils.Location = new System.Drawing.Point(101, 25);
            this.lblUtils.Name = "lblUtils";
            this.lblUtils.Size = new System.Drawing.Size(30, 13);
            this.lblUtils.TabIndex = 3;
            this.lblUtils.Text = "Utils:";
            // 
            // btnDatabaseUtil
            // 
            this.btnDatabaseUtil.Location = new System.Drawing.Point(104, 51);
            this.btnDatabaseUtil.Name = "btnDatabaseUtil";
            this.btnDatabaseUtil.Size = new System.Drawing.Size(75, 35);
            this.btnDatabaseUtil.TabIndex = 4;
            this.btnDatabaseUtil.Text = "Database Util";
            this.btnDatabaseUtil.UseVisualStyleBackColor = true;
            this.btnDatabaseUtil.Click += new System.EventHandler(this.btnDatabaseUtil_Click);
            // 
            // btnFaceColorModels
            // 
            this.btnFaceColorModels.Location = new System.Drawing.Point(105, 92);
            this.btnFaceColorModels.Name = "btnFaceColorModels";
            this.btnFaceColorModels.Size = new System.Drawing.Size(75, 35);
            this.btnFaceColorModels.TabIndex = 5;
            this.btnFaceColorModels.Text = "Face Color Models";
            this.btnFaceColorModels.UseVisualStyleBackColor = true;
            this.btnFaceColorModels.Click += new System.EventHandler(this.btnFaceColorModels_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 262);
            this.Controls.Add(this.btnFaceColorModels);
            this.Controls.Add(this.btnDatabaseUtil);
            this.Controls.Add(this.lblUtils);
            this.Controls.Add(this.btnShapeInfo);
            this.Controls.Add(this.lblDetection);
            this.Controls.Add(this.btnFaceColorLib);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaceColorLib;
        private System.Windows.Forms.Label lblDetection;
        private System.Windows.Forms.Button btnShapeInfo;
        private System.Windows.Forms.Label lblUtils;
        private System.Windows.Forms.Button btnDatabaseUtil;
        private System.Windows.Forms.Button btnFaceColorModels;
    }
}