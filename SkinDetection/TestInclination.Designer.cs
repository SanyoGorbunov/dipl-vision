namespace SkinDetection
{
    partial class TestInclination
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
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lblInclination = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pbTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgLoad
            // 
            this.dlgLoad.FileName = "openFileDialog1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Завантажити";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 41);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(227, 192);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // lblInclination
            // 
            this.lblInclination.AutoSize = true;
            this.lblInclination.Location = new System.Drawing.Point(12, 236);
            this.lblInclination.Name = "lblInclination";
            this.lblInclination.Size = new System.Drawing.Size(0, 13);
            this.lblInclination.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(93, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Обчислити";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pbTest
            // 
            this.pbTest.Location = new System.Drawing.Point(245, 41);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(205, 192);
            this.pbTest.TabIndex = 4;
            this.pbTest.TabStop = false;
            // 
            // TestInclination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 305);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblInclination);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnLoad);
            this.Name = "TestInclination";
            this.Text = "Перевірка відхилення";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lblInclination;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox pbTest;
    }
}