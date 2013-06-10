using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    static partial class Helpers
    {
        public static double GetArcLength(this Contour<Point> contour)
        {
            double arc = 0;
            for (int i = 1; i < contour.Total; i++)
            {
                arc += Math.Sqrt((contour[i].X - contour[i - 1].X) * (contour[i].X - contour[i - 1].X) + (contour[i].Y - contour[i - 1].Y) * (contour[i].Y - contour[i - 1].Y));
            }
            return arc;
        }

        public static bool InEllipse(this Point point, int X0, int Y0, int a, int b)
        {
            double v = (point.X - X0) * (point.X - X0) / a / a + (point.Y - Y0) * (point.Y - Y0) / b / b;
            return v <= 1;
        }
    }

    class WangTan: IAlgorithm
    {
        public List<Rectangle> Execute(Image<Bgr, byte> img, object options)
        {
            WangTanOptions opts = options as WangTanOptions;

            var imgTest = Equalize(img);
            imgTest = MedianFilter(imgTest, opts.SmoothMedianSize);
            var contours = DetectEdges(imgTest, opts.CannyThreshold, opts.CannyLinkThreshold);
            contours = LinkEdges(contours, opts.EdgeErasingA);
            var templates = TestTemplates(img.Size, contours, opts.TemplateOpts, opts.ThresholdPoints, opts.ThresholdRate);
            return templates.OrderBy(t => t.R).Take(1).Select(t => t.Rect).ToList();
        }

        public Image<Gray, byte> Equalize(Image<Bgr, byte> img)
        {
            var imgGray = img.Convert<Gray, byte>();
            imgGray[0]._EqualizeHist();
            return imgGray;
        }

        public Image<Gray, byte> MedianFilter(Image<Gray, byte> img, int size)
        {
            return img.SmoothMedian(size);
        }

        public List<Contour<Point>> DetectEdges(Image<Gray, byte> img, byte t, byte tlink)
        {
            var imgCanny = img.Canny(t, tlink);
            var contour = imgCanny.FindContours();

            List<Contour<Point>> contours = new List<Contour<Point>>();
            do
            {
                contours.Add(contour);
                contour = contour.HNext;
            } while (contour != null);
            return contours;
        }

        public List<Contour<Point>> LinkEdges(List<Contour<Point>> contours, double a)
        {
            return contours.Where(c => c.GetArcLength() < a).ToList();
        }

        public List<TemplateEntry> TestTemplates(Size s, List<Contour<Point>> contours,
            TemplateOptions opts, int tN, double tR)
        {
            List<Point> points = new List<Point>();

            Image<Gray, byte> img = new Image<Gray, byte>(s);
            foreach (var contour in contours)
            {
                img.Draw(contour, new Gray(255), 1);
                for (int i = 0; i < contour.Total; i++)
			    {
			        points.Add(contour[i]); 
			    }
            }
            Image<Gray, float> xSobel = img.Sobel(1, 0, 3);
            Image<Gray, float> ySobel = img.Sobel(0, 1, 3);

            List<TemplateEntry> templates = new List<TemplateEntry>();
            for (int i = opts.Y0.Start; i < opts.Y0.End; i += opts.Y0.Step)
            {
                for (int j = opts.X0.Start; j < opts.X0.End; j += opts.X0.Step)
                {
                    for (int a = opts.A.Start; a < opts.A.End; a += opts.A.Step)
                    {
                        for (int b = opts.B.Start; b < opts.B.End; b += opts.B.Step)
                        {
                            TemplateEntry entry = new TemplateEntry(j, i, a, b);
                            if (entry.FindPoints(points, tN) &&
                                entry.FindRate(points, xSobel, ySobel, tR))
                            {
                                templates.Add(entry);
                            }
                        }
                    }
                }
            }
            return templates;
        }
    }

    class WangTanOptions
    {
        public TemplateOptions TemplateOpts { get; set; }
        public int ThresholdPoints { get; set; }
        public double ThresholdRate { get; set; }
        public int EdgeErasingA { get; set; }
        public int SmoothMedianSize { get; set; }
        public byte CannyThreshold { get; set; }
        public byte CannyLinkThreshold { get; set; }
    }

    class TemplateOptions {
        public class Param
        {
            public int Start { get; set; }
            public int End { get; set; }
            public int Step { get; set; }
        }

        public Param X0 { get; set; }
        public Param Y0 { get; set; }
        public Param A { get; set; }
        public Param B { get; set; }
    }

    class TemplateEntry
    {
        public Rectangle Rect
        {
            get
            {
                return new Rectangle(X0 - A, Y0 - B, 2 * A, 2 * B);
            }
        }

        private static double sf(double n)
        {
            return double.IsNaN(n) || n == 0 ? double.Epsilon : n;
        }

        static const int Boundary = 20;

        public TemplateEntry(int x0, int y0, int a, int b)
        {
            X0 = x0;
            Y0 = y0;
            A = a;
            B = b;
        }

        public bool FindPoints(List<Point> points, int t)
        {
            N = 0;
            foreach (var point in points)
            {
                if (!point.InEllipse(X0, Y0, A - Boundary, B - Boundary) &&
                    point.InEllipse(X0, Y0, A + Boundary, B + Boundary))
                {
                    N++;
                }
            }
            return N > t;
        }

        public bool FindRate(List<Point> points, Image<Gray, float> xSobel, Image<Gray, float> ySobel, double t)
        {
            double c = 1.0 * B / A;
            foreach (var point in points)
            {
                int x = point.X, y = point.Y;
                double teta = Math.Atan(-c * c * sf(x - X0) / sf(y - Y0));
                double r2i = Math.Cos(teta), r2j = Math.Sin(teta);
                double sum = Math.Sqrt(xSobel[y, x].Intensity * xSobel[y, x].Intensity + ySobel[y, x].Intensity * ySobel[y, x].Intensity);
                double r1i = sf(xSobel[y, x].Intensity / sum), r1j = sf(ySobel[y, x].Intensity / sum);

                G += Math.Abs(r1i * r2i + r1j * r2j);
            }

            R = G / N;
            return R > t;
        }

        public int X0 { get; set; }
        public int Y0 { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        public double R { get; set; }
        public double N { get; set; }
        public double G { get; set; }

        public override string ToString()
        {
            return string.Format("N: {0}, R: {1}", N, R);
        }
    }
}
