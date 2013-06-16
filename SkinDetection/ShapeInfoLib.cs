using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace SkinDetection
{
    public partial class ShapeInfoLib : Form
    {
        private Image<Bgr, byte> imgTest;
        private Image<Gray, byte> imgActualTest;
        private Image<Gray, byte> imgFinalContours;

        public ShapeInfoLib()
        {
            InitializeComponent();
        }

        private void btnEqualizeTestImage_Click(object sender, EventArgs e)
        {
            imgActualTest = imgTest.Convert<Gray, byte>();
            imgActualTest._EqualizeHist();
            pbTestImage.Image = imgActualTest.ToBitmap();
        }

        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            if (dlgLoadTestImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgTest = new Image<Bgr, byte>(dlgLoadTestImage.FileName).Resize(0.5, INTER.CV_INTER_AREA);
                pbTestImage.Image = imgTest.ToBitmap();
            }
        }

        private void btnSmoothMedian_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtSmoothMedianSize.Text);
            imgActualTest = imgActualTest.SmoothMedian(size);
            pbTestImage.Image = imgActualTest.ToBitmap();
        }

        private List<Contour<Point>> contours;
        private void btnDetectEdges_Click(object sender, EventArgs e)
        {
            double th0 = double.Parse(txtCannyInitialThresh.Text);
            double eth = double.Parse(txtCannyEdgeThresh.Text);
            var imgEdges = imgActualTest.Canny(th0, eth);
            pbTestImage.Image = imgEdges.ToBitmap();

            var firstContour = imgEdges.FindContours(CHAIN_APPROX_METHOD.CV_LINK_RUNS, RETR_TYPE.CV_RETR_LIST);
            contours = new List<Contour<Point>>();
            lbContours.Items.Clear();
            int i = 0;
            do
            {
                contours.Add(firstContour);
                i++;
                lbContours.Items.Add("Contour #" + i);
                firstContour = firstContour.HNext;
            } while (firstContour != null);

            lblContourCount.Text = string.Format("Contours: {0}", contours.Count);
        }

        private void lbContours_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbContours.SelectedIndex;

            var imgContour = new Image<Gray, byte>(imgActualTest.Size);
            lblContourPoints.Text = string.Format("Count: {0}", contours[index].Total);
            lblContourDistance.Text = string.Format("Arc Length: {0}", GetArcLength(contours[index]));

            imgContour.Draw(contours[index], new Gray(255), 1);
            pbTestImage.Image = imgContour.ToBitmap();
        }

        private double GetArcLength(Contour<Point> contour)
        {
            double arc = 0;
            for (int i = 1; i < contour.Total; i++)
            {
                arc += Math.Sqrt((contour[i].X - contour[i - 1].X) * (contour[i].X - contour[i - 1].X) + (contour[i].Y - contour[i - 1].Y) * (contour[i].Y - contour[i - 1].Y));
            }
            return arc;
        }

        private void btnShowContours_Click(object sender, EventArgs e)
        {
            imgFinalContours = new Image<Gray, byte>(imgActualTest.Size);
            foreach (var contour in contours)
            {
                imgFinalContours.Draw(contour, new Gray(255), 1);
            }
            pbTestImage.Image = imgFinalContours.ToBitmap();
        }

        private void btnRemoveContoursByMinArc_Click(object sender, EventArgs e)
        {
            double minArc = double.Parse(txtContourMinArc.Text);
            contours = contours.Where(c => GetArcLength(c) > minArc).ToList();

            lbContours.Items.Clear();
            lblContourCount.Text = string.Format("Contours: {0}", contours.Count);
            for (int i = 0; i < contours.Count; i++)
            {
                lbContours.Items.Add("Contour #" + (i + 1));
            }
        }

        private void btnDivideContours_Click(object sender, EventArgs e)
        {
            MemStorage mem = new MemStorage();
            List<Contour<Point>> divided = new List<Contour<Point>>();
            foreach (var contour in contours)
            {
                divided.AddRange(DivideContour(contour, mem));
            }

            contours = divided;

            lbContours.Items.Clear();
            lblContourCount.Text = string.Format("Contours: {0}", contours.Count);
            for (int i = 0; i < contours.Count; i++)
            {
                lbContours.Items.Add("Contour #" + (i + 1));
            }
        }

        private List<Contour<Point>> DivideContour(Contour<Point> contour, MemStorage memStorage)
        {
            List<Contour<Point>> divided = new List<Contour<Point>>();

            if (contour.Total == 1)
            {
                divided.Add(contour);
            }
            else
            {
                int dx, dy, ndx, ndy;
                Contour<Point> newContour = new Contour<Point>(memStorage);
                newContour.Push(contour[0]);
                newContour.Push(contour[1]);
                dx = contour[1].X - contour[0].X;
                dy = contour[1].Y - contour[0].Y;
                Point lastPoint = contour[1];

                for (int i = 2; i < contour.Total; i++)
                {
                    ndx = contour[i].X - lastPoint.X;
                    ndy = contour[i].Y - lastPoint.Y;
                    if (ndx == dx && ndy == dy)
                    {
                        lastPoint = contour[i];
                        newContour.Push(lastPoint);
                    }
                    else
                    {
                        divided.Add(newContour);
                        newContour = new Contour<Point>(memStorage);
                        newContour.Push(contour[i - 1]);
                        newContour.Push(contour[i]);
                        lastPoint = contour[i];
                        dx = ndx;
                        dy = ndy;
                    }
                }
                divided.Add(newContour);
            }
            return divided;
        }

        private double GetRate(int w, int h, int X0, int Y0, int a, int b, Image<Gray, float> xSobel, Image<Gray, float> ySobel, out double G, out double N)
        {
            double c = 1.0*b/a;
            G = 0;
            N = 0;
            //for (int y = 0; y < h; y++)
            //{
            //    for (int x = 0; x < w; x++)
            //    {
            //        double teta = Math.Atan(-c * c * (x - X0) / (y - Y0));
            //        double r2i = Math.Cos(teta), r2j = Math.Sin(teta);
            //        double sum = Math.Sqrt(xSobel[y, x].Intensity * xSobel[y, x].Intensity + ySobel[y, x].Intensity * ySobel[y, x].Intensity);
            //        double r1i = xSobel[y, x].Intensity / sum, r1j = ySobel[y, x].Intensity / sum;

            //        G += r1i * r2i + r1j * r2j;
            //    }
            //}

            foreach (var contour in contours)
            {
                foreach (var point in contour)
                {
                    if (!InEllipse(point, X0, Y0, a - 5, b - 5) && InEllipse(point, X0, Y0, a + 5, b + 5))
                    {
                        N++;
                    }

                    int x = point.X, y = point.Y;

                    double teta = Math.Atan(-c * c * sf(x - X0) / sf(y - Y0));
                    double r2i = Math.Cos(teta), r2j = Math.Sin(teta);
                    double sum = Math.Sqrt(xSobel[y, x].Intensity * xSobel[y, x].Intensity + ySobel[y, x].Intensity * ySobel[y, x].Intensity);
                    double r1i = sf(xSobel[y, x].Intensity / sum), r1j = sf(ySobel[y, x].Intensity / sum);

                    G += Math.Abs(r1i * r2i + r1j * r2j);
                }
            }

            return G / N;
        }
        private bool InEllipse(Point point, int X0, int Y0, int a, int b)
        {
            double v = (point.X - X0) * (point.X - X0) / a / a + (point.Y - Y0) * (point.Y - Y0) / b / b;
            return v <= 1;
        }

        private void btnTemplateFind_Click(object sender, EventArgs e)
        {
            int X0 = int.Parse(txtTemplateX0.Text);
            int Y0 = int.Parse(txtTemplateY0.Text);
            int a = int.Parse(txtTemplateA.Text);
            int b = int.Parse(txtTemplateB.Text);
            double G, N;

            double rate = GetRate(imgFinalContours.Width, imgFinalContours.Height,
                X0, Y0, a, b,
                imgFinalContours.Sobel(1, 0, 3), imgFinalContours.Sobel(0, 1, 3),
                out G, out N);
            lblTemplateRate.Text = string.Format("Rate: {0}", rate);
            lblTemplateG.Text = string.Format("G: {0}", G);
            lblTemplateN.Text = string.Format("N: {0}", N);

            var img = imgFinalContours.Clone();
            img.Draw(new Ellipse(new PointF(X0, Y0), new SizeF(2 * a, 2 * b), 0), new Gray(255), 2);
            pbTestImage.Image = img.ToBitmap();
        }

        private double sf(double n)
        {
            return double.IsNaN(n) || n == 0 ? double.Epsilon : n;
        }

        private void btnTestTemplate_Click(object sender, EventArgs e)
        {
            if (dlgSaveTestTemplate.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image<Gray, float> xSobel = imgFinalContours.Sobel(1,0,3),
                    ySobel = imgFinalContours.Sobel(0,1,3);

                int X0Start = int.Parse(txtTestTemplateX0Start.Text),
                    X0End = int.Parse(txtTestTemplateX0End.Text),
                    X0Step = int.Parse(txtTestTemplateX0Step.Text);
                int Y0Start = int.Parse(txtTestTemplateY0Start.Text),
                    Y0End = int.Parse(txtTestTemplateY0End.Text),
                    Y0Step = int.Parse(txtTestTemplateY0Step.Text);
                int AStart = int.Parse(txtTestTemplateAStart.Text),
                    AEnd = int.Parse(txtTestTemplateAEnd.Text),
                    AStep = int.Parse(txtTestTemplateAStep.Text);
                int BStart = int.Parse(txtTestTemplateBStart.Text),
                    BEnd = int.Parse(txtTestTemplateBEnd.Text),
                    BStep = int.Parse(txtTestTemplateBStep.Text);

                using (var filestream = File.OpenWrite(dlgSaveTestTemplate.FileName))
                {
                    using (var sw = new StreamWriter(filestream))
                    {
                        for (int x = X0Start; x <= X0End; x += X0Step)
                        {
                            for (int y = Y0Start; y <= Y0End; y += Y0Step)
                            {
                                for (int a = AStart; a <= AEnd; a += AStep)
                                {
                                    for (int b = BStart; b <= BEnd; b += BStep)
                                    {
                                        double G, N;
                                        double R = GetRate(imgFinalContours.Width, imgFinalContours.Height,
                                            x, y, a, b, xSobel, ySobel, out G, out N);
                                        sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6}", x, y, a, b, G, N, R));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private List<TemplateEntry> templates;
        private void btnTestTemplateToForm_Click(object sender, EventArgs e)
        {
            templates = new List<TemplateEntry>();

            Image<Gray, float> xSobel = imgFinalContours.Sobel(1, 0, 3),
                    ySobel = imgFinalContours.Sobel(0, 1, 3);

            int X0Start = int.Parse(txtTestTemplateX0Start.Text),
                X0End = int.Parse(txtTestTemplateX0End.Text),
                X0Step = int.Parse(txtTestTemplateX0Step.Text);
            int Y0Start = int.Parse(txtTestTemplateY0Start.Text),
                Y0End = int.Parse(txtTestTemplateY0End.Text),
                Y0Step = int.Parse(txtTestTemplateY0Step.Text);
            int AStart = int.Parse(txtTestTemplateAStart.Text),
                AEnd = int.Parse(txtTestTemplateAEnd.Text),
                AStep = int.Parse(txtTestTemplateAStep.Text);
            int BStart = int.Parse(txtTestTemplateBStart.Text),
                BEnd = int.Parse(txtTestTemplateBEnd.Text),
                BStep = int.Parse(txtTestTemplateBStep.Text);

            for (int x = X0Start; x <= X0End; x += X0Step)
            {
                for (int y = Y0Start; y <= Y0End; y += Y0Step)
                {
                    for (int a = AStart; a <= AEnd; a += AStep)
                    {
                        for (int b = BStart; b <= BEnd; b += BStep)
                        {
                            double G, N;
                            double R = GetRate(imgFinalContours.Width, imgFinalContours.Height,
                                x, y, a, b, xSobel, ySobel, out G, out N);
                            templates.Add(new TemplateEntry
                            {
                                X0 = x, Y0 = y, A = a, B = b,
                                R = R, G = G, N = N
                            });
                        }
                    }
                }
            }

            FillListBoxByTemplates();
        }

        private void btnTemplateRemoveByMinCount_Click(object sender, EventArgs e)
        {
            int minPoints = int.Parse(txtTemplateMinCount.Text);
            templates = templates.Where(t => t.N > minPoints).ToList();
            FillListBoxByTemplates();
        }

        private void FillListBoxByTemplates()
        {
            lbTemplates.Items.Clear();
            foreach (var template in templates)
            {
                lbTemplates.Items.Add(template.ToString());
            }
        }

        private void btnTemplateOrderByRate_Click(object sender, EventArgs e)
        {
            templates = templates.OrderBy(t => t.R).ToList();
            FillListBoxByTemplates();
        }

        private void btnTemplateOrderByCount_Click(object sender, EventArgs e)
        {
            templates = templates.OrderBy(t => t.N).ToList();
            FillListBoxByTemplates();
        }

        private void lbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            var template = templates[lbTemplates.SelectedIndex];
            var img = imgFinalContours.Clone();
            img.Draw(new Ellipse(new PointF(template.X0, template.Y0), new SizeF(2 * template.A, 2 * template.B), 0), new Gray(255), 2);
            pbTestImage.Image = img.ToBitmap();
        }

        private void btnTemplateRemoveOutborders_Click(object sender, EventArgs e)
        {
            templates = templates.Where(t => t.X0 - t.B >= 0 && t.Y0 - t.A >= 0 &&
                t.X0 + t.B < imgFinalContours.Width && t.Y0 + t.A < imgFinalContours.Height).ToList();
            FillListBoxByTemplates();
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            double maxCount = templates.Max(t => t.N);
            var largeTemplates = templates.Where(t => t.N > (maxCount * 3 / 5));
            var topRateTemplates = largeTemplates.OrderBy(t => 1 / t.R);

            int A = 0, B = 0, X0 = 0, Y0 = 0;
            foreach (var template in topRateTemplates.Take(10))
            {
                A += template.A;
                B += template.B;
                X0 += template.X0;
                Y0 += template.Y0;
            }
            A /= 10; B /= 10; X0 /= 10; Y0 /= 10;
            var topTemplate = new TemplateEntry
            {
                A = A, B= B, X0 = X0, Y0 = Y0
            };

            var img = imgFinalContours.Clone();
            img.Draw(new Ellipse(new PointF(topTemplate.X0, topTemplate.Y0), new SizeF(2 * topTemplate.A, 2 * topTemplate.B), 0), new Gray(255), 2);
            pbTestImage.Image = img.ToBitmap();
        }
    }
}
