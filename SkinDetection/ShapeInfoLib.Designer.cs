namespace SkinDetection
{
    partial class ShapeInfoLib
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
            this.pnlTest = new System.Windows.Forms.Panel();
            this.btnSmoothMedian = new System.Windows.Forms.Button();
            this.btnEqualizeTestImage = new System.Windows.Forms.Button();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.dlgLoadTestImage = new System.Windows.Forms.OpenFileDialog();
            this.lblSmoothMedianSize = new System.Windows.Forms.Label();
            this.txtSmoothMedianSize = new System.Windows.Forms.TextBox();
            this.pnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTest
            // 
            this.pnlTest.Controls.Add(this.txtSmoothMedianSize);
            this.pnlTest.Controls.Add(this.lblSmoothMedianSize);
            this.pnlTest.Controls.Add(this.btnSmoothMedian);
            this.pnlTest.Controls.Add(this.btnEqualizeTestImage);
            this.pnlTest.Controls.Add(this.pbTestImage);
            this.pnlTest.Controls.Add(this.btnLoadTestImage);
            this.pnlTest.Location = new System.Drawing.Point(12, 12);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(268, 312);
            this.pnlTest.TabIndex = 0;
            // 
            // btnSmoothMedian
            // 
            this.btnSmoothMedian.Location = new System.Drawing.Point(160, 259);
            this.btnSmoothMedian.Name = "btnSmoothMedian";
            this.btnSmoothMedian.Size = new System.Drawing.Size(105, 23);
            this.btnSmoothMedian.TabIndex = 3;
            this.btnSmoothMedian.Text = "Smooth Median";
            this.btnSmoothMedian.UseVisualStyleBackColor = true;
            this.btnSmoothMedian.Click += new System.EventHandler(this.btnSmoothMedian_Click);
            // 
            // btnEqualizeTestImage
            // 
            this.btnEqualizeTestImage.Location = new System.Drawing.Point(160, 230);
            this.btnEqualizeTestImage.Name = "btnEqualizeTestImage";
            this.btnEqualizeTestImage.Size = new System.Drawing.Size(105, 23);
            this.btnEqualizeTestImage.TabIndex = 2;
            this.btnEqualizeTestImage.Text = "Equalize";
            this.btnEqualizeTestImage.UseVisualStyleBackColor = true;
            this.btnEqualizeTestImage.Click += new System.EventHandler(this.btnEqualizeTestImage_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Location = new System.Drawing.Point(3, 3);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(262, 221);
            this.pbTestImage.TabIndex = 1;
            this.pbTestImage.TabStop = false;
            // 
            // btnLoadTestImage
            // 
            this.btnLoadTestImage.Location = new System.Drawing.Point(3, 230);
            this.btnLoadTestImage.Name = "btnLoadTestImage";
            this.btnLoadTestImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTestImage.TabIndex = 0;
            this.btnLoadTestImage.Text = "Load";
            this.btnLoadTestImage.UseVisualStyleBackColor = true;
            this.btnLoadTestImage.Click += new System.EventHandler(this.btnLoadTestImage_Click);
            // 
            // dlgLoadTestImage
            // 
            this.dlgLoadTestImage.FileName = "openFileDialog1";
            // 
            // lblSmoothMedianSize
            // 
            this.lblSmoothMedianSize.AutoSize = true;
            this.lblSmoothMedianSize.Location = new System.Drawing.Point(43, 264);
            this.lblSmoothMedianSize.Name = "lblSmoothMedianSize";
            this.lblSmoothMedianSize.Size = new System.Drawing.Size(30, 13);
            this.lblSmoothMedianSize.TabIndex = 4;
            this.lblSmoothMedianSize.Text = "Size:";
            // 
            // txtSmoothMedianSize
            // 
            this.txtSmoothMedianSize.Location = new System.Drawing.Point(79, 261);
            this.txtSmoothMedianSize.Name = "txtSmoothMedianSize";
            this.txtSmoothMedianSize.Size = new System.Drawing.Size(37, 20);
            this.txtSmoothMedianSize.TabIndex = 5;
            // 
            // ShapeInfoLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 430);
            this.Controls.Add(this.pnlTest);
            this.Name = "ShapeInfoLib";
            this.Text = "ShapeInfoLib";
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Button btnLoadTestImage;
        private System.Windows.Forms.OpenFileDialog dlgLoadTestImage;
        private System.Windows.Forms.Button btnEqualizeTestImage;
        private System.Windows.Forms.Button btnSmoothMedian;
        private System.Windows.Forms.TextBox txtSmoothMedianSize;
        private System.Windows.Forms.Label lblSmoothMedianSize;
    }
}