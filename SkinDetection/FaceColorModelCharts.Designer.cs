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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dlgLoadModel = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.chartColored = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkSwitchModel = new System.Windows.Forms.CheckBox();
            this.dlgSaveModel = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.btnLoadCalc = new System.Windows.Forms.Button();
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
            this.btnLoadModel.Size = new System.Drawing.Size(136, 23);
            this.btnLoadModel.TabIndex = 0;
            this.btnLoadModel.Text = "Завантажити набір";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // chartColored
            // 
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.WallWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chartColored.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartColored.Legends.Add(legend3);
            this.chartColored.Location = new System.Drawing.Point(12, 41);
            this.chartColored.Name = "chartColored";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 6;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chartColored.Series.Add(series5);
            this.chartColored.Series.Add(series6);
            this.chartColored.Size = new System.Drawing.Size(810, 446);
            this.chartColored.TabIndex = 1;
            this.chartColored.Text = "chart1";
            // 
            // chkSwitchModel
            // 
            this.chkSwitchModel.AutoSize = true;
            this.chkSwitchModel.Location = new System.Drawing.Point(482, 16);
            this.chkSwitchModel.Name = "chkSwitchModel";
            this.chkSwitchModel.Size = new System.Drawing.Size(137, 17);
            this.chkSwitchModel.TabIndex = 2;
            this.chkSwitchModel.Text = "Нормальний розподіл";
            this.chkSwitchModel.UseVisualStyleBackColor = true;
            this.chkSwitchModel.CheckedChanged += new System.EventHandler(this.chkSwitchModel_CheckedChanged);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Location = new System.Drawing.Point(625, 12);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(116, 23);
            this.btnSaveModel.TabIndex = 3;
            this.btnSaveModel.Text = "Завантажити";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Visible = false;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // btnLoadCalc
            // 
            this.btnLoadCalc.Location = new System.Drawing.Point(747, 12);
            this.btnLoadCalc.Name = "btnLoadCalc";
            this.btnLoadCalc.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCalc.TabIndex = 4;
            this.btnLoadCalc.Text = "Зберегти";
            this.btnLoadCalc.UseVisualStyleBackColor = true;
            this.btnLoadCalc.Click += new System.EventHandler(this.btnLoadCalc_Click);
            // 
            // FaceColorModelCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 499);
            this.Controls.Add(this.btnLoadCalc);
            this.Controls.Add(this.btnSaveModel);
            this.Controls.Add(this.chkSwitchModel);
            this.Controls.Add(this.chartColored);
            this.Controls.Add(this.btnLoadModel);
            this.Name = "FaceColorModelCharts";
            this.Text = "Перевірка кольорових моделей";
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
        private System.Windows.Forms.Button btnLoadCalc;
    }
}