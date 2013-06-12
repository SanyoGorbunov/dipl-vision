﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    public partial class FaceColorModelCharts : Form
    {
        private int[,] colored = new int[256, 256];

        private ChangRobles changRobles = null;

        private void CleanColored()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    colored[i, j] = 0;
                }
            }
        }

        public FaceColorModelCharts()
        {
            InitializeComponent();
        }

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            if (dlgLoadModel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CleanColored();

                using (var fileStream = File.OpenRead(dlgLoadModel.FileName))
                {
                    using (var sr = new StreamReader(fileStream))
                    {
                        int cnt = int.Parse(sr.ReadLine());
                        for (int k = 0; k < cnt; k++)
                        {
                            string fileName = sr.ReadLine();
                            int rects = int.Parse(sr.ReadLine());

                            Image<Bgr, byte> img = new Image<Bgr, byte>(fileName);
                            var data = img.Data;
                            for (int i = 0; i < img.Height; i++)
                            {
                                for (int j = 0; j < img.Width; j++)
                                {
                                    int sum = img.Data[i, j, 0] + img.Data[i, j, 1] + img.Data[i, j, 2];
                                    double b = 1.0 * img.Data[i, j, 0] / sum;
                                    double r = 1.0 * img.Data[i, j, 2] / sum;
                                    img.Data[i, j, 0] = (byte)(255 * b);
                                    img.Data[i, j, 2] = (byte)(255 * r);
                                }
                            }

                            for (int j = 0; j < rects; j++)
                            {
                                string[] points = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                var nextRect = new Rectangle(int.Parse(points[0]), int.Parse(points[1]), int.Parse(points[2]), int.Parse(points[3]));
                                for (int i1 = 0; i1 < nextRect.Height; i1++)
                                {
                                    for (int j1 = 0; j1 < nextRect.Width; j1++)
                                    {
                                        if (colored[img.Data[i1 + nextRect.Top, j1 + nextRect.Left, 0], img.Data[i1 + nextRect.Top, j1 + nextRect.Left, 2]] > 500)
                                        {
                                            colored[img.Data[i1 + nextRect.Top, j1 + nextRect.Left, 0], img.Data[i1 + nextRect.Top, j1 + nextRect.Left, 2]] += 2;
                                        }
                                        else
                                        {
                                            colored[img.Data[i1 + nextRect.Top, j1 + nextRect.Left, 0], img.Data[i1 + nextRect.Top, j1 + nextRect.Left, 2]] ++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                DisplayColored();
            }
        }

        private void DisplayColored()
        {
            chartColored.Series.Clear();
            chartColored.ResetAutoValues();

            int max = 0;

            for (int i = 0; i < 256; i++)
            {
                Series s = new Series
                {
                    ChartType = SeriesChartType.Spline,
                    Color = Color.DodgerBlue,
                    IsVisibleInLegend = false
                };
                for (int j = 0; j < 256; j++)
                {
                    s.Points.AddY(colored[i, j]);
                    if (colored[i, j] > max)
                    {
                        max = colored[i, j];
                    }
                }
                chartColored.Series.Add(s);
            }

            Console.WriteLine(string.Format("Max: {0}", max));
        }

        private void chkSwitchModel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSwitchModel.Checked)
            {
                DisplayGaussian();
            }
            else
            {
                DisplayColored();
            }

            btnSaveModel.Visible = chkSwitchModel.Checked;
        }

        private void DisplayGaussian()
        {
            List<double> blues = new List<double>(), reds = new List<double>();
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    for (int k = 0; k < colored[i, j]; k++)
                    {
                        reds.Add(1.0 * j / 255);
                        blues.Add(1.0 * i / 255);
                    }
                }
            }

            changRobles = new ChangRobles();
            changRobles.SetModel(reds, blues);

            chartColored.Series.Clear();
            chartColored.ResetAutoValues();
            for (int i = 0; i < 256; i++)
            {
                Series s = new Series
                {
                    ChartType = SeriesChartType.Spline,
                    Color = Color.DodgerBlue,
                    IsVisibleInLegend = false
                };
                for (int j = 0; j < 256; j++)
                {
                    s.Points.AddY(changRobles.GetLikelihood(1.0 * j / 255, 1.0 * i / 255));
                }
                chartColored.Series.Add(s);
            }
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            if (dlgSaveModel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (changRobles != null)
                {
                    changRobles.Save(dlgSaveModel.FileName);
                }
            }
        }
    }
}
