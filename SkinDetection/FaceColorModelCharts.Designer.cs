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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dlgLoadModel = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.chartColored = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkSwitchModel = new System.Windows.Forms.CheckBox();
            this.dlgSaveModel = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveModel = new System.Windows.Forms.Button();
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
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartColored.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartColored.Legends.Add(legend2);
            this.chartColored.Location = new System.Drawing.Point(12, 41);
            this.chartColored.Name = "chartColored";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 6;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chartColored.Series.Add(series3);
            this.chartColored.Series.Add(series4);
            this.chartColored.Size = new System.Drawing.Size(810, 446);
            this.chartColored.TabIndex = 1;
            this.chartColored.Text = "chart1";
            // 
            // chkSwitchModel
            // 
            this.chkSwitchModel.AutoSize = true;
            this.chkSwitchModel.Location = new System.Drawing.Point(671, 16);
            this.chkSwitchModel.Name = "chkSwitchModel";
            this.chkSwitchModel.Size = new System.Drawing.Size(70, 17);
            this.chkSwitchModel.TabIndex = 2;
            this.chkSwitchModel.Text = "Gaussian";
            this.chkSwitchModel.UseVisualStyleBackColor = true;
            this.chkSwitchModel.CheckedChanged += new System.EventHandler(this.chkSwitchModel_CheckedChanged);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Location = new System.Drawing.Point(747, 12);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveModel.TabIndex = 3;
            this.btnSaveModel.Text = "Save";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Visible = false;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // FaceColorModelCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 499);
            this.Controls.Add(this.btnSaveModel);
            this.Controls.Add(this.chkSwitchModel);
            this.Controls.Add(this.chartColored);
            this.Controls.Add(this.btnLoadModel);
            this.Name = "FaceColorModelCharts";
            this.Text = "FaceColorModelCharts";
            ((System.ComponentModel.ISupportInitialize)(this.chartColored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgLoadModel;
        private System.Windows.Forms.Button btnLoadModel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColored;
        private System.Windows.Forms.CheckBox chkSwitchModel;
        private System.Windows.Forms.SaveFileDialog dlgSaveModel;
        private System.Windows.Forms.Button btnSaveModel;
    }
}