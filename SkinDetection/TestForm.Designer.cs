namespace SkinDetection
{
    partial class TestForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlChooseAlg = new System.Windows.Forms.Panel();
            this.lblAlg = new System.Windows.Forms.Label();
            this.cbAlg = new System.Windows.Forms.ComboBox();
            this.pnlSkinOptions = new System.Windows.Forms.Panel();
            this.pnlGeoOptions = new System.Windows.Forms.Panel();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbImgTest = new System.Windows.Forms.PictureBox();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnInExact = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.dlgSelectDir = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChooseAlg.SuspendLayout();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgTest)).BeginInit();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChooseAlg
            // 
            this.pnlChooseAlg.Controls.Add(this.cbAlg);
            this.pnlChooseAlg.Controls.Add(this.lblAlg);
            this.pnlChooseAlg.Location = new System.Drawing.Point(12, 12);
            this.pnlChooseAlg.Name = "pnlChooseAlg";
            this.pnlChooseAlg.Size = new System.Drawing.Size(200, 40);
            this.pnlChooseAlg.TabIndex = 0;
            // 
            // lblAlg
            // 
            this.lblAlg.AutoSize = true;
            this.lblAlg.Location = new System.Drawing.Point(3, 10);
            this.lblAlg.Name = "lblAlg";
            this.lblAlg.Size = new System.Drawing.Size(58, 13);
            this.lblAlg.TabIndex = 0;
            this.lblAlg.Text = "Select Alg:";
            // 
            // cbAlg
            // 
            this.cbAlg.FormattingEnabled = true;
            this.cbAlg.Items.AddRange(new object[] {
            "Skin Approach",
            "Geometric Approach"});
            this.cbAlg.Location = new System.Drawing.Point(67, 7);
            this.cbAlg.Name = "cbAlg";
            this.cbAlg.Size = new System.Drawing.Size(121, 21);
            this.cbAlg.TabIndex = 1;
            // 
            // pnlSkinOptions
            // 
            this.pnlSkinOptions.Location = new System.Drawing.Point(12, 58);
            this.pnlSkinOptions.Name = "pnlSkinOptions";
            this.pnlSkinOptions.Size = new System.Drawing.Size(200, 202);
            this.pnlSkinOptions.TabIndex = 1;
            // 
            // pnlGeoOptions
            // 
            this.pnlGeoOptions.Location = new System.Drawing.Point(12, 266);
            this.pnlGeoOptions.Name = "pnlGeoOptions";
            this.pnlGeoOptions.Size = new System.Drawing.Size(200, 146);
            this.pnlGeoOptions.TabIndex = 2;
            // 
            // pnlImg
            // 
            this.pnlImg.Controls.Add(this.lblStats);
            this.pnlImg.Controls.Add(this.btnStop);
            this.pnlImg.Controls.Add(this.btnFalse);
            this.pnlImg.Controls.Add(this.btnInExact);
            this.pnlImg.Controls.Add(this.btnTrue);
            this.pnlImg.Controls.Add(this.pbImgTest);
            this.pnlImg.Controls.Add(this.btnLoad);
            this.pnlImg.Location = new System.Drawing.Point(218, 12);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(328, 248);
            this.pnlImg.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Select Directory";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbImgTest
            // 
            this.pbImgTest.Location = new System.Drawing.Point(3, 34);
            this.pbImgTest.Name = "pbImgTest";
            this.pbImgTest.Size = new System.Drawing.Size(238, 211);
            this.pbImgTest.TabIndex = 1;
            this.pbImgTest.TabStop = false;
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(247, 34);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(75, 23);
            this.btnTrue.TabIndex = 2;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnInExact
            // 
            this.btnInExact.Location = new System.Drawing.Point(247, 63);
            this.btnInExact.Name = "btnInExact";
            this.btnInExact.Size = new System.Drawing.Size(75, 23);
            this.btnInExact.TabIndex = 3;
            this.btnInExact.Text = "Not Exact";
            this.btnInExact.UseVisualStyleBackColor = true;
            this.btnInExact.Click += new System.EventHandler(this.btnInExact_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(247, 105);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(75, 23);
            this.btnFalse.TabIndex = 4;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(247, 222);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(126, 10);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(35, 13);
            this.lblStats.TabIndex = 6;
            this.lblStats.Text = "label1";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.chartResults);
            this.pnlResults.Location = new System.Drawing.Point(218, 266);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(328, 146);
            this.pnlResults.TabIndex = 4;
            // 
            // chartResults
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResults.Legends.Add(legend1);
            this.chartResults.Location = new System.Drawing.Point(3, 3);
            this.chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SeriesTrue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SeriesNotExact";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SeriesFalse";
            this.chartResults.Series.Add(series1);
            this.chartResults.Series.Add(series2);
            this.chartResults.Series.Add(series3);
            this.chartResults.Size = new System.Drawing.Size(319, 140);
            this.chartResults.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 424);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlImg);
            this.Controls.Add(this.pnlGeoOptions);
            this.Controls.Add(this.pnlSkinOptions);
            this.Controls.Add(this.pnlChooseAlg);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.pnlChooseAlg.ResumeLayout(false);
            this.pnlChooseAlg.PerformLayout();
            this.pnlImg.ResumeLayout(false);
            this.pnlImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgTest)).EndInit();
            this.pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChooseAlg;
        private System.Windows.Forms.ComboBox cbAlg;
        private System.Windows.Forms.Label lblAlg;
        private System.Windows.Forms.Panel pnlSkinOptions;
        private System.Windows.Forms.Panel pnlGeoOptions;
        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnInExact;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.PictureBox pbImgTest;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectDir;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
    }
}