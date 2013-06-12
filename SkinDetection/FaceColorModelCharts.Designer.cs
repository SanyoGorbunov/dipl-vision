namespace SkinDetection
{
    partial class FaceColorModelCharts
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
            this.dlgLoadModel = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.chartColored = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartColored)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgLoadModel
            // 
            this.dlgLoadModel.FileName = "openFileDialog1";
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Location = new System.Drawing.Point(12, 12);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadModel.TabIndex = 0;
            this.btnLoadModel.Text = "Load Model";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // chartColored
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartColored.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartColored.Legends.Add(legend1);
            this.chartColored.Location = new System.Drawing.Point(12, 41);
            this.chartColored.Name = "chartColored";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartColored.Series.Add(series1);
            this.chartColored.Series.Add(series2);
            this.chartColored.Size = new System.Drawing.Size(810, 446);
            this.chartColored.TabIndex = 1;
            this.chartColored.Text = "chart1";
            // 
            // FaceColorModelCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 499);
            this.Controls.Add(this.chartColored);
            this.Controls.Add(this.btnLoadModel);
            this.Name = "FaceColorModelCharts";
            this.Text = "FaceColorModelCharts";
            ((System.ComponentModel.ISupportInitialize)(this.chartColored)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgLoadModel;
        private System.Windows.Forms.Button btnLoadModel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColored;
    }
}