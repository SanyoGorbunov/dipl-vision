namespace SkinDetection
{
    partial class TestEdgeLinking
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
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnDetectEdges = new System.Windows.Forms.Button();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.tbThreshold = new System.Windows.Forms.TrackBar();
            this.tbLinkThreshold = new System.Windows.Forms.TrackBar();
            this.lblLinkThreshold = new System.Windows.Forms.Label();
            this.btnLinkEdges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLinkThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTest
            // 
            this.pbTest.Location = new System.Drawing.Point(12, 12);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(223, 219);
            this.pbTest.TabIndex = 0;
            this.pbTest.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(241, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dlgLoad
            // 
            this.dlgLoad.FileName = "openFileDialog1";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(241, 41);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilters.TabIndex = 2;
            this.btnApplyFilters.Text = "Apply";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // btnDetectEdges
            // 
            this.btnDetectEdges.Location = new System.Drawing.Point(241, 191);
            this.btnDetectEdges.Name = "btnDetectEdges";
            this.btnDetectEdges.Size = new System.Drawing.Size(75, 40);
            this.btnDetectEdges.TabIndex = 3;
            this.btnDetectEdges.Text = "Detect Edges";
            this.btnDetectEdges.UseVisualStyleBackColor = true;
            this.btnDetectEdges.Click += new System.EventHandler(this.btnDetectEdges_Click);
            // 
            // lblThreshold
            // 
            this.lblThreshold.Location = new System.Drawing.Point(241, 67);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(75, 15);
            this.lblThreshold.TabIndex = 4;
            this.lblThreshold.Text = "Threshold";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbThreshold
            // 
            this.tbThreshold.Location = new System.Drawing.Point(241, 85);
            this.tbThreshold.Maximum = 255;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(75, 45);
            this.tbThreshold.TabIndex = 5;
            this.tbThreshold.TickFrequency = 25;
            // 
            // tbLinkThreshold
            // 
            this.tbLinkThreshold.Location = new System.Drawing.Point(241, 145);
            this.tbLinkThreshold.Maximum = 255;
            this.tbLinkThreshold.Name = "tbLinkThreshold";
            this.tbLinkThreshold.Size = new System.Drawing.Size(75, 45);
            this.tbLinkThreshold.TabIndex = 7;
            this.tbLinkThreshold.TickFrequency = 25;
            // 
            // lblLinkThreshold
            // 
            this.lblLinkThreshold.Location = new System.Drawing.Point(241, 115);
            this.lblLinkThreshold.Name = "lblLinkThreshold";
            this.lblLinkThreshold.Size = new System.Drawing.Size(75, 27);
            this.lblLinkThreshold.TabIndex = 6;
            this.lblLinkThreshold.Text = "Link Threshold";
            this.lblLinkThreshold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLinkEdges
            // 
            this.btnLinkEdges.Location = new System.Drawing.Point(241, 237);
            this.btnLinkEdges.Name = "btnLinkEdges";
            this.btnLinkEdges.Size = new System.Drawing.Size(75, 40);
            this.btnLinkEdges.TabIndex = 8;
            this.btnLinkEdges.Text = "Link Edges";
            this.btnLinkEdges.UseVisualStyleBackColor = true;
            this.btnLinkEdges.Click += new System.EventHandler(this.btnLinkEdges_Click);
            // 
            // TestEdgeLinking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 408);
            this.Controls.Add(this.btnLinkEdges);
            this.Controls.Add(this.tbLinkThreshold);
            this.Controls.Add(this.lblLinkThreshold);
            this.Controls.Add(this.tbThreshold);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.btnDetectEdges);
            this.Controls.Add(this.btnApplyFilters);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbTest);
            this.Name = "TestEdgeLinking";
            this.Text = "TestEdgeLinking";
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLinkThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog dlgLoad;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnDetectEdges;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TrackBar tbThreshold;
        private System.Windows.Forms.TrackBar tbLinkThreshold;
        private System.Windows.Forms.Label lblLinkThreshold;
        private System.Windows.Forms.Button btnLinkEdges;
    }
}