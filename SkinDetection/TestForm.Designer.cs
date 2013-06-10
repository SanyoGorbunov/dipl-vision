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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlChooseAlg = new System.Windows.Forms.Panel();
            this.cbAlg = new System.Windows.Forms.ComboBox();
            this.lblAlg = new System.Windows.Forms.Label();
            this.pnlSkinOptions = new System.Windows.Forms.Panel();
            this.pnlGeoOptions = new System.Windows.Forms.Panel();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnInExact = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.pbImgTest = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dlgSelectDir = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgLoadFaceTemplate = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadFaceTemplate = new System.Windows.Forms.Button();
            this.lblAdaptiveThresholdUpper = new System.Windows.Forms.Label();
            this.txtAdaptiveThresholdUpper = new System.Windows.Forms.TextBox();
            this.txtAdaptiveThresholdLower = new System.Windows.Forms.TextBox();
            this.lblAdaptiveThresholdLower = new System.Windows.Forms.Label();
            this.txtAdaptiveThresholdStep = new System.Windows.Forms.TextBox();
            this.lblAdaptiveThresholdStep = new System.Windows.Forms.Label();
            this.txtSkinRegionMinHoles = new System.Windows.Forms.TextBox();
            this.lblSkinRegionMinHoles = new System.Windows.Forms.Label();
            this.txtSkinRegionMinRatio = new System.Windows.Forms.TextBox();
            this.lblSkinRegionRation = new System.Windows.Forms.Label();
            this.txtSkinRegionCrsCrltn = new System.Windows.Forms.TextBox();
            this.lblSkinRegionCrsCrltn = new System.Windows.Forms.Label();
            this.txtSkinRegionMaxRatio = new System.Windows.Forms.TextBox();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.dlgLoadModel = new System.Windows.Forms.OpenFileDialog();
            this.pnlChooseAlg.SuspendLayout();
            this.pnlSkinOptions.SuspendLayout();
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
            this.cbAlg.SelectedIndexChanged += new System.EventHandler(this.cbAlg_SelectedIndexChanged);
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
            // pnlSkinOptions
            // 
            this.pnlSkinOptions.Controls.Add(this.btnLoadModel);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionMaxRatio);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionCrsCrltn);
            this.pnlSkinOptions.Controls.Add(this.lblSkinRegionCrsCrltn);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionMinRatio);
            this.pnlSkinOptions.Controls.Add(this.lblSkinRegionRation);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionMinHoles);
            this.pnlSkinOptions.Controls.Add(this.lblSkinRegionMinHoles);
            this.pnlSkinOptions.Controls.Add(this.txtAdaptiveThresholdStep);
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveThresholdStep);
            this.pnlSkinOptions.Controls.Add(this.txtAdaptiveThresholdLower);
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveThresholdLower);
            this.pnlSkinOptions.Controls.Add(this.txtAdaptiveThresholdUpper);
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveThresholdUpper);
            this.pnlSkinOptions.Controls.Add(this.btnLoadFaceTemplate);
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
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(126, 10);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(35, 13);
            this.lblStats.TabIndex = 6;
            this.lblStats.Text = "label1";
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
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(247, 92);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(75, 23);
            this.btnFalse.TabIndex = 4;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
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
            // pbImgTest
            // 
            this.pbImgTest.Location = new System.Drawing.Point(3, 34);
            this.pbImgTest.Name = "pbImgTest";
            this.pbImgTest.Size = new System.Drawing.Size(238, 211);
            this.pbImgTest.TabIndex = 1;
            this.pbImgTest.TabStop = false;
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
            chartArea2.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResults.Legends.Add(legend2);
            this.chartResults.Location = new System.Drawing.Point(3, 3);
            this.chartResults.Name = "chartResults";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "SeriesTrue";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "SeriesNotExact";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "SeriesFalse";
            this.chartResults.Series.Add(series4);
            this.chartResults.Series.Add(series5);
            this.chartResults.Series.Add(series6);
            this.chartResults.Size = new System.Drawing.Size(319, 140);
            this.chartResults.TabIndex = 0;
            // 
            // btnLoadFaceTemplate
            // 
            this.btnLoadFaceTemplate.Location = new System.Drawing.Point(87, 3);
            this.btnLoadFaceTemplate.Name = "btnLoadFaceTemplate";
            this.btnLoadFaceTemplate.Size = new System.Drawing.Size(101, 23);
            this.btnLoadFaceTemplate.TabIndex = 0;
            this.btnLoadFaceTemplate.Text = "Face Template";
            this.btnLoadFaceTemplate.UseVisualStyleBackColor = true;
            this.btnLoadFaceTemplate.Click += new System.EventHandler(this.btnLoadFaceTemplate_Click);
            // 
            // lblAdaptiveThresholdUpper
            // 
            this.lblAdaptiveThresholdUpper.AutoSize = true;
            this.lblAdaptiveThresholdUpper.Location = new System.Drawing.Point(3, 29);
            this.lblAdaptiveThresholdUpper.Name = "lblAdaptiveThresholdUpper";
            this.lblAdaptiveThresholdUpper.Size = new System.Drawing.Size(134, 13);
            this.lblAdaptiveThresholdUpper.TabIndex = 1;
            this.lblAdaptiveThresholdUpper.Text = "Upper Adaptive Threshold:";
            // 
            // txtAdaptiveThresholdUpper
            // 
            this.txtAdaptiveThresholdUpper.Location = new System.Drawing.Point(143, 26);
            this.txtAdaptiveThresholdUpper.Name = "txtAdaptiveThresholdUpper";
            this.txtAdaptiveThresholdUpper.Size = new System.Drawing.Size(45, 20);
            this.txtAdaptiveThresholdUpper.TabIndex = 2;
            // 
            // txtAdaptiveThresholdLower
            // 
            this.txtAdaptiveThresholdLower.Location = new System.Drawing.Point(143, 53);
            this.txtAdaptiveThresholdLower.Name = "txtAdaptiveThresholdLower";
            this.txtAdaptiveThresholdLower.Size = new System.Drawing.Size(45, 20);
            this.txtAdaptiveThresholdLower.TabIndex = 4;
            // 
            // lblAdaptiveThresholdLower
            // 
            this.lblAdaptiveThresholdLower.AutoSize = true;
            this.lblAdaptiveThresholdLower.Location = new System.Drawing.Point(3, 56);
            this.lblAdaptiveThresholdLower.Name = "lblAdaptiveThresholdLower";
            this.lblAdaptiveThresholdLower.Size = new System.Drawing.Size(134, 13);
            this.lblAdaptiveThresholdLower.TabIndex = 3;
            this.lblAdaptiveThresholdLower.Text = "Lower Adaptive Threshold:";
            // 
            // txtAdaptiveThresholdStep
            // 
            this.txtAdaptiveThresholdStep.Location = new System.Drawing.Point(143, 79);
            this.txtAdaptiveThresholdStep.Name = "txtAdaptiveThresholdStep";
            this.txtAdaptiveThresholdStep.Size = new System.Drawing.Size(45, 20);
            this.txtAdaptiveThresholdStep.TabIndex = 6;
            // 
            // lblAdaptiveThresholdStep
            // 
            this.lblAdaptiveThresholdStep.AutoSize = true;
            this.lblAdaptiveThresholdStep.Location = new System.Drawing.Point(3, 82);
            this.lblAdaptiveThresholdStep.Name = "lblAdaptiveThresholdStep";
            this.lblAdaptiveThresholdStep.Size = new System.Drawing.Size(127, 13);
            this.lblAdaptiveThresholdStep.TabIndex = 5;
            this.lblAdaptiveThresholdStep.Text = "Adaptive Threshold Step:";
            // 
            // txtSkinRegionMinHoles
            // 
            this.txtSkinRegionMinHoles.Location = new System.Drawing.Point(143, 106);
            this.txtSkinRegionMinHoles.Name = "txtSkinRegionMinHoles";
            this.txtSkinRegionMinHoles.Size = new System.Drawing.Size(45, 20);
            this.txtSkinRegionMinHoles.TabIndex = 8;
            // 
            // lblSkinRegionMinHoles
            // 
            this.lblSkinRegionMinHoles.AutoSize = true;
            this.lblSkinRegionMinHoles.Location = new System.Drawing.Point(3, 109);
            this.lblSkinRegionMinHoles.Name = "lblSkinRegionMinHoles";
            this.lblSkinRegionMinHoles.Size = new System.Drawing.Size(129, 13);
            this.lblSkinRegionMinHoles.TabIndex = 7;
            this.lblSkinRegionMinHoles.Text = "Min Holes in Skin Region:";
            // 
            // txtSkinRegionMinRatio
            // 
            this.txtSkinRegionMinRatio.Location = new System.Drawing.Point(118, 132);
            this.txtSkinRegionMinRatio.Name = "txtSkinRegionMinRatio";
            this.txtSkinRegionMinRatio.Size = new System.Drawing.Size(32, 20);
            this.txtSkinRegionMinRatio.TabIndex = 10;
            // 
            // lblSkinRegionRation
            // 
            this.lblSkinRegionRation.AutoSize = true;
            this.lblSkinRegionRation.Location = new System.Drawing.Point(3, 135);
            this.lblSkinRegionRation.Name = "lblSkinRegionRation";
            this.lblSkinRegionRation.Size = new System.Drawing.Size(96, 13);
            this.lblSkinRegionRation.TabIndex = 9;
            this.lblSkinRegionRation.Text = "Skin Region Ratio:";
            // 
            // txtSkinRegionCrsCrltn
            // 
            this.txtSkinRegionCrsCrltn.Location = new System.Drawing.Point(158, 158);
            this.txtSkinRegionCrsCrltn.Name = "txtSkinRegionCrsCrltn";
            this.txtSkinRegionCrsCrltn.Size = new System.Drawing.Size(30, 20);
            this.txtSkinRegionCrsCrltn.TabIndex = 12;
            // 
            // lblSkinRegionCrsCrltn
            // 
            this.lblSkinRegionCrsCrltn.AutoSize = true;
            this.lblSkinRegionCrsCrltn.Location = new System.Drawing.Point(3, 161);
            this.lblSkinRegionCrsCrltn.Name = "lblSkinRegionCrsCrltn";
            this.lblSkinRegionCrsCrltn.Size = new System.Drawing.Size(149, 13);
            this.lblSkinRegionCrsCrltn.TabIndex = 11;
            this.lblSkinRegionCrsCrltn.Text = "Skin Region Cross-Corellation:";
            // 
            // txtSkinRegionMaxRatio
            // 
            this.txtSkinRegionMaxRatio.Location = new System.Drawing.Point(156, 132);
            this.txtSkinRegionMaxRatio.Name = "txtSkinRegionMaxRatio";
            this.txtSkinRegionMaxRatio.Size = new System.Drawing.Size(32, 20);
            this.txtSkinRegionMaxRatio.TabIndex = 13;
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Location = new System.Drawing.Point(6, 3);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadModel.TabIndex = 14;
            this.btnLoadModel.Text = "Model";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
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
            this.pnlSkinOptions.ResumeLayout(false);
            this.pnlSkinOptions.PerformLayout();
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
        private System.Windows.Forms.Button btnLoadFaceTemplate;
        private System.Windows.Forms.OpenFileDialog dlgLoadFaceTemplate;
        private System.Windows.Forms.Label lblAdaptiveThresholdUpper;
        private System.Windows.Forms.TextBox txtAdaptiveThresholdStep;
        private System.Windows.Forms.Label lblAdaptiveThresholdStep;
        private System.Windows.Forms.TextBox txtAdaptiveThresholdLower;
        private System.Windows.Forms.Label lblAdaptiveThresholdLower;
        private System.Windows.Forms.TextBox txtAdaptiveThresholdUpper;
        private System.Windows.Forms.TextBox txtSkinRegionMinHoles;
        private System.Windows.Forms.Label lblSkinRegionMinHoles;
        private System.Windows.Forms.TextBox txtSkinRegionCrsCrltn;
        private System.Windows.Forms.Label lblSkinRegionCrsCrltn;
        private System.Windows.Forms.TextBox txtSkinRegionMinRatio;
        private System.Windows.Forms.Label lblSkinRegionRation;
        private System.Windows.Forms.TextBox txtSkinRegionMaxRatio;
        private System.Windows.Forms.Button btnLoadModel;
        private System.Windows.Forms.OpenFileDialog dlgLoadModel;
    }
}