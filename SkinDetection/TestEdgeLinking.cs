using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace SkinDetection
{
    public partial class TestEdgeLinking : Form
    {
        private void DisplayImage<T>(Image<T, byte> img) where T: struct, IColor
        {
            pbTest.Image = img.ToBitmap();
        }

        private Image<Bgr, byte> imgTest;
        private Image<Gray, byte> imgWithFilters;
        private List<Contour<Point>> edges;

        public TestEdgeLinking()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dlgLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgTest = new Image<Bgr, byte>(dlgLoad.FileName);
                DisplayImage(imgTest);
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            imgWithFilters = imgTest.Convert<Gray, byte>();
            imgWithFilters._EqualizeHist();
            imgWithFilters = imgWithFilters.SmoothMedian(5);
            DisplayImage(imgWithFilters);
        }

        private void btnDetectEdges_Click(object sender, EventArgs e)
        {
            int thresh = tbThreshold.Value, linkThresh = tbLinkThreshold.Value;
            var imgCanny = imgWithFilters.Canny(thresh, linkThresh);
            var edge = imgCanny.FindContours();
            edges = new List<Contour<Point>>();
            do
            {
                edges.Add(edge);
                edge = edge.HNext;
            } while (edge != null);

            var img = new Image<Gray, byte>(imgTest.Size);
            foreach (var drawEdge in edges)
            {
                img.Draw(drawEdge, new Gray(255), 1);
            }
            DisplayImage(img);
        }

        private void btnLinkEdges_Click(object sender, EventArgs e)
        {
            var memStorage = new MemStorage();
            // get segments
            var segs = new List<Seq<Point>>();
            foreach (var edge in edges)
            {
                for (int i = 1; i < edge.Total; i++)
                {
                    var seg = new Seq<Point>(memStorage);
                    seg.Push(edge[i - 1]);
                    seg.Push(edge[i]);
                    segs.Add(seg);
                }
            }

            var contours = new List<Seq<Point>>();

            int cellWidth = 5, cellHeight = 5;
            var table = new List<Seq<Point>>[imgTest.Height / cellHeight, imgTest.Width / cellWidth];

            foreach (var seg in segs)
            {
                Point p = seg[0];
                if (table[p.Y / cellHeight, p.X / cellWidth] == null)
                {
                    table[p.Y / cellHeight, p.X / cellWidth] = new List<Seq<Point>>();
                }
                table[p.Y / cellHeight, p.X / cellWidth].Add(seg);
            }

            int boundary = 2;
            for (int i = 0; i < imgTest.Height / cellHeight; i++)
            {
                for (int j = 0; j < imgTest.Width / cellWidth; j++)
                {
                    if (table[i, j] != null && table[i, j].Count > 0)
                    {
                        while (table[i, j].Count != 0)
                        {
                            var seg = table[i, j][0];
                            table[i, j].Remove(seg);
                            for (int k = table[i,j].Count - 1; k >= 0; k--)
                            {
                                var seg2 = table[i, j][k];
                                if (seg.Left() - boundary <= seg2.Left() &&
                                    seg.Right() + boundary >= seg2.Right() &&
                                    seg.Top() - boundary <= seg2.Top() &&
                                    seg.Bottom() + boundary >= seg2.Bottom() &&
                                    (seg.GetDistance(seg2[0]) <= 2 ||
                                    seg.GetDistance(seg2[1]) <= 2))
                                {
                                    seg.Push(seg2[0]);
                                    seg.Push(seg2[1]);
                                    Point topLeft = new Point(seg.Left(), seg.Top());
                                    Point bottomRight = new Point(seg.Right(), seg.Bottom());
                                    seg.Clear();
                                    seg.Push(topLeft);
                                    seg.Push(bottomRight);
                                    table[i, j].Remove(seg2);
                                    break;
                                }
                            }
                            contours.Add(seg);
                        }
                    }
                }
            }

            //var used = new List<bool>();
            //for (int i = 0; i < segs.Count; i++)
            //{
            //    used.Add(false);
            //}
            //int boundary = 2;
            //for (int i = 0; i < segs.Count; i++)
            //{
            //    if (!used[i])
            //    {
            //        used[i] = true;
            //        bool repeat = false;
            //        int sj = 0;
            //        do
            //        {
            //            for (int j = sj; j < segs.Count; j++)
            //            {
            //                if (i != j && !used[j])
            //                {
            //                    if (segs[i].Left() - boundary <= segs[j].Left() &&
            //                        segs[i].Right() + boundary >= segs[j].Right() &&
            //                        segs[i].Top() - boundary <= segs[j].Top() &&
            //                        segs[i].Bottom() + boundary >= segs[j].Bottom() &&
            //                        (segs[i].GetDistance(segs[j][0]) <= 2 ||
            //                        segs[i].GetDistance(segs[j][1]) <= 2))
            //                    {
            //                        used[j] = true;
            //                        segs[i].Push(segs[j][0]);
            //                        segs[i].Push(segs[j][1]);
            //                        Point topLeft = new Point(segs[i].Left(), segs[i].Top());
            //                        Point bottomRight = new Point(segs[i].Right(), segs[i].Bottom());
            //                        segs[i].Clear();
            //                        segs[i].Push(topLeft);
            //                        segs[i].Push(bottomRight);
            //                        repeat = true;
            //                        sj = j + 1;
            //                        break;
            //                    }
            //                }
            //            }
            //        } while (repeat);
            //        contours.Add(segs[i]);
            //    }
            //}

            List<Point> points = new List<Point>();

            var img = new Image<Gray, byte>(imgTest.Size);
            foreach (var seq in contours)
            {
                img.Draw(new LineSegment2D(seq[0], seq[1]), new Gray(255), 1);
                if (!points.Contains(seq[0]))
                {
                    points.Add(seq[0]);
                }
                if (!points.Contains(seq[1]))
                {
                    points.Add(seq[1]);
                }
            }
            DisplayImage(img);
        }
    }

    public static partial class Helpers
    {
        public static int Left(this Seq<Point> seq)
        {
            int left = int.MaxValue;
            foreach (var point in seq)
            {
                if (point.X < left)
                {
                    left = point.X;
                }
            }
            return left;
        }
        public static int Right(this Seq<Point> seq)
        {
            int right = int.MinValue;
            foreach (var point in seq)
            {
                if (point.X > right)
                {
                    right = point.X;
                }
            }
            return right;
        }

        public static int Top(this Seq<Point> seq)
        {
            int top = int.MaxValue;
            foreach (var point in seq)
            {
                if (point.Y < top)
                {
                    top = point.Y;
                }
            }
            return top;
        }
        public static int Bottom(this Seq<Point> seq)
        {
            int bottom = int.MinValue;
            foreach (var point in seq)
            {
                if (point.Y > bottom)
                {
                    bottom = point.Y;
                }
            }
            return bottom;
        }

        public static void GetLineParams(this Seq<Point> seq, out double A, out double B, out double C)
        {
            int x1 = seq[0].X, x2 = seq[1].X,
                y1 = seq[0].Y, y2 = seq[1].Y;
            A = -1.0 * (y2 - y1) / (x2 - x1);
            B = 1;
            C = -(y1 + A * x1);
        }
        public static double GetDistance(this Seq<Point> seq, Point p)
        {
            double A, B, C;
            seq.GetLineParams(out A, out B, out C);
            return Math.Abs(A * p.X + B * p.Y + C) / Math.Sqrt(A * A + B * B);
        }
    }
}
