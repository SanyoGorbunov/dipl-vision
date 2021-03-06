﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    class TwoDimVector
    {
        public double a1 { get; set; }
        public double a2 { get; set; }

        public static TwoDimVector operator -(TwoDimVector v1, TwoDimVector v2)
        {
            return new TwoDimVector
            {
                a1 = v1.a1 - v2.a1,
                a2 = v1.a2 - v2.a2
            };
        }
        public static List<TwoDimVector> Convert(List<double> a1l, List<double> a2l)
        {
            return a1l.Zip(a2l, (e1, e2) =>
            {
                return new TwoDimVector
                {
                    a1 = e1,
                    a2 = e2
                };
            }).ToList();
        }
        public TwoDimMatrix MultTransp()
        {
            return new TwoDimMatrix
            {
                a = this.a1 * this.a1,
                c = this.a1 * this.a2,
                b = this.a1 * this.a2,
                d = this.a2 * this.a2
            };
        }
        public static TwoDimVector operator *(TwoDimVector v, TwoDimMatrix m)
        {
            return new TwoDimVector
            {
                a1 = v.a1 * m.a + v.a2 * m.c,
                a2 = v.a1 * m.b + v.a2 * m.d
            };
        }
        public static double operator *(TwoDimVector v1, TwoDimVector v2)
        {
            return v1.a1 * v2.a1 + v1.a2 * v2.a2;
        }
    }
    class TwoDimMatrix
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }

        public static TwoDimMatrix ExpectedValue(List<TwoDimMatrix> ms)
        {
            int cnt = ms.Count;
            TwoDimMatrix mr = new TwoDimMatrix();
            foreach (var m in ms)
            {
                mr.a += m.a;
                mr.b += m.b;
                mr.c += m.c;
                mr.d += m.d;
            }
            mr.a /= cnt;
            mr.b /= cnt;
            mr.c /= cnt;
            mr.d /= cnt;
            return mr;
        }
        public TwoDimMatrix GetInvertibleMatrix()
        {
            return new TwoDimMatrix
            {
                a = (1 + b * c / a / (d - b * c / a)) / a,
                b = -b / a / (d - b * c / a),
                c = -c / a / (d - b * c / a),
                d = 1 / (d - b * c / a)
            };
        }
    }

    class SkinRegion
    {
        public Image<Gray, byte> FindMask(Image<Bgr, byte> img)
        {
            var mask = HolesMap.ThresholdToZero(new Gray(1)).ThresholdBinary(new Gray(1), new Gray(255));
            return img.Convert<Gray, byte>().And(mask);
        }

        public Image<Gray, byte> Region { get; private set; }
        public Image<Gray, byte> HolesMap { get; private set; }

        public int Pixels { get; private set; }
        public int Left { get; private set; }
        public int Top { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Area
        {
            get
            {
                return Width * Height;
            }
        }
        public double Ratio
        {
            get
            {
                return 1.0 * Height / Width;
            }
        }

        public int Holes { get; private set; }
        public Point Centroid { get; private set; }
        public double Inclination { get; private set; }

        public SkinRegion(Image<Gray, byte> img, int r, int c)
        {
            Region = new Image<Gray, byte>(img.Size);
            byte[, ,] regionData = Region.Data;
            byte[, ,] imgData = img.Data;
            imgData[r, c, 0] = 0;

            Pixels = 1;
            Left = img.Cols - 1;
            Top = img.Rows - 1;
            int right = 0, bottom = 0;
            
            Queue<Point> points = new Queue<Point>();
            points.Enqueue(new Point(r, c));
            while (points.Count > 0)
            {
                Point p = points.Dequeue();
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (!(i == 0 && j == 0) &&
                            (p.X + i >= 0 && p.X + i < img.Rows) &&
                            (p.Y + j >= 0 && p.Y + j < img.Cols) &&
                            (imgData[p.X + i, p.Y + j, 0] == 255))
                        {
                            imgData[p.X + i, p.Y + j, 0] = 0;
                            regionData[p.X + i, p.Y + j, 0] = 255;
                            points.Enqueue(new Point(p.X + i, p.Y + j));

                            Pixels++;
                            if (p.X + i < Top)
                            {
                                Top = p.X + i;
                            }
                            if (p.X + i > bottom)
                            {
                                bottom = p.X + i;
                            }
                            if (p.Y + j < Left)
                            {
                                Left = p.Y + j;
                            }
                            if (p.Y + j > right)
                            {
                                right = p.Y + j;
                            }
                        }
                    }
                }
            }

            Width = (right == 0 ? 0 : right - Left) + 1;
            Height = (bottom == 0 ? 0 : bottom - Top) + 1;

            var hMap = GetHolesMap();
            GetCentroid(hMap);
            GetInclination(hMap, Left, Top, Width, Height);
            HolesMap = new Image<Gray, byte>(hMap);
        }

        private byte[, ,] GetHolesMap()
        {
            Image<Gray, Byte> cpy = Region.Copy();
            byte[, ,] cpyData = cpy.Data;

            for (int i = Top; i < Top + Height; i++)
            {
                if (cpyData[i, Left, 0] == 0)
                {
                    cpyData[i, Left, 0] = 1;
                    Utils.FloodFill(cpyData, i, Left, Left, Left + Width, Top, Top + Height, 0, 1);
                }
                if (cpyData[i, Left + Width - 1, 0] == 0)
                {
                    cpyData[i, Left + Width - 1, 0] = 1;
                    Utils.FloodFill(cpyData, i, Left + Width - 1, Left, Left + Width, Top, Top + Height, 0, 1);
                }
            }
            for (int j = Left; j < Left + Width; j++)
            {
                if (cpyData[Top, j, 0] == 0)
                {
                    cpyData[Top, j, 0] = 1;
                    Utils.FloodFill(cpyData, Top, j, Left, Left + Width, Top, Top + Height, 0, 1);
                }
                if (cpyData[Top + Height - 1, j, 0] == 0)
                {
                    cpyData[Top + Height - 1, j, 0] = 1;
                    Utils.FloodFill(cpyData, Top + Height - 1, j, Left, Left + Width, Top, Top + Height, 0, 1);
                }
            }

            Holes = 1;
            for (int i = Top; i < Top + Height; i++)
            {
                for (int j = Left; j < Left + Width; j++)
                {
                    if (cpyData[i, j, 0] == 0)
                    {
                        Holes++;
                        byte clrNew = (byte)(Holes + 1);
                        if (clrNew == 0)
                        {
                            clrNew = (byte) (Holes % 255 + 2);
                        }
                        cpyData[i, j, 0] = clrNew;
                        Utils.FloodFill(cpyData, i, j, Left, Left + Width, Top, Top + Height, 0, clrNew);
                    }
                }
            }

            return cpyData;
        }
        private void GetCentroid(byte[, ,] hMap)
        {
            double x = 0, y = 0;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (hMap[Top + i, Left + j, 0] > 1)
                    {
                        x += j;
                        y += i;
                    }
                }
            }
            x /= Pixels;
            y /= Pixels;
            Centroid = new Point((int)x, (int)y);
        }
        private void GetInclination(byte[,,] hMap, int l, int t, int w, int h)
        {
            double a = 0, b = 0, c = 0;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (hMap[t + i, l + j, 0] > 1)
                    {
                        a += (j - Centroid.X) * (j - Centroid.X);
                        b += (j - Centroid.X) * (i - Centroid.Y);
                        c += (i - Centroid.Y) * (i - Centroid.Y);
                    }
                }
            }

            b *= 2;
            Inclination = 0.5 * Math.Atan(b / (a - c));
        }

        public Rectangle Rect
        {
            get
            {
                return new Rectangle(Left, Top, Width, Height);
            }
        }
    }

    class ChangRobles: IAlgorithm
    {
        public TwoDimVector Mean { get; private set; }
        public TwoDimMatrix Covariance { get; private set; }
        public TwoDimMatrix InvertCovariance { get; private set; }

        public void Save(string path)
        {
            using (var stream = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                using (var sw = new StreamWriter(stream))
                {
                    sw.WriteLine(Mean.a1);
                    sw.WriteLine(Mean.a2);
                    sw.WriteLine(Covariance.a);
                    sw.WriteLine(Covariance.b);
                    sw.WriteLine(Covariance.c);
                    sw.WriteLine(Covariance.d);
                }
            }
        }

        public static ChangRobles Load(string path)
        {
            ChangRobles cr = new ChangRobles();
            cr.Mean = new TwoDimVector();
            cr.Covariance = new TwoDimMatrix();
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var sr = new StreamReader(stream))
                {
                    cr.Mean.a1 = double.Parse(sr.ReadLine().Trim());
                    cr.Mean.a2 = double.Parse(sr.ReadLine().Trim());
                    cr.Covariance.a = double.Parse(sr.ReadLine().Trim());
                    cr.Covariance.b = double.Parse(sr.ReadLine().Trim());
                    cr.Covariance.c = double.Parse(sr.ReadLine().Trim());
                    cr.Covariance.d = double.Parse(sr.ReadLine().Trim());
                }
            }
            cr.InvertCovariance = cr.Covariance.GetInvertibleMatrix();
            return cr;
        }

        public void SetModel(List<double> r, List<double> b)
        {
            Mean = new TwoDimVector
            {
                a1 = r.Average(),
                a2 = b.Average()
            };

            var vectors = TwoDimVector.Convert(r, b).Select(v => v - Mean);
            Covariance = TwoDimMatrix.ExpectedValue(vectors.Select(v => v.MultTransp()).ToList());
            InvertCovariance = Covariance.GetInvertibleMatrix();
        }

        public double GetLikelihood(double r, double b)
        {
            TwoDimVector v = new TwoDimVector
            {
                a1 = r - Mean.a1, a2 = b - Mean.a2
            };
            return Math.Exp(-0.5 * (v * InvertCovariance * v));
        }
        public double GetLikelihood(Bgr bgr)
        {
            double sum = bgr.Blue + bgr.Green + bgr.Red;
            return GetLikelihood(bgr.Red / sum, bgr.Blue / sum);
        }

        public byte GetByteLikelihood(byte b, byte g, byte r)
        {
            return (byte) (255 * GetLikelihood(1.0 * r / (1.0 * r + g + b), 1.0 * b / (1.0 * r + g + b)));
        }
        public int GetWhitePixels(Image<Gray, Byte> img)
        {
            int sum = 0;
            byte[, ,] data = img.Data;

            for (int i = img.Rows - 1; i >= 0; i--)
            {
                for (int j = img.Cols - 1; j >= 0; j--)
                {
                    if (data[i, j, 0] == 255)
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        public Image<Gray, byte> GetLikelihoodImage(Image<Bgr, byte> img)
        {
            byte[, ,] data = img.Data;

            Image<Gray, byte> imgLikelihood = new Image<Gray, byte>(img.Size);
            byte[, ,] grayData = imgLikelihood.Data;

            for (int i = img.Rows - 1; i >= 0; i--)
            {
                for (int j = img.Cols - 1; j >= 0; j--)
                {
                    grayData[i, j, 0] = GetByteLikelihood(data[i, j, 0], data[i, j, 1], data[i, j, 2]);
                }
            }
            
            return imgLikelihood;
        }
        public Image<Gray, Byte> GetBinaryThreshold(Image<Gray, byte> img, byte bound)
        {
            return img.ThresholdBinary(new Gray(bound), new Gray(255));
        }
        public Image<Gray, Byte> GetAdaptiveBinaryThreshold(Image<Gray, byte> img, byte initialBound = 180,
            byte endBound = 30, byte step = 2)
        {
            Image<Gray, byte> imgAdaptive = GetBinaryThreshold(img, initialBound);
            int whPxls0 = GetWhitePixels(imgAdaptive), whPxls1, dif, min = int.MaxValue, bound = initialBound;
            initialBound -= step;
            while (initialBound >= endBound)
            {
                imgAdaptive = GetBinaryThreshold(img, initialBound);
                whPxls1 = GetWhitePixels(imgAdaptive);
                dif = whPxls1 - whPxls0;
                Console.WriteLine(string.Format("{0} {1}", initialBound, dif));
                if (dif < min) {
                    min = dif;
                    bound = initialBound;
                }
                initialBound -= step;
                whPxls0 = whPxls1;
            }
            return GetBinaryThreshold(img, (byte) (bound + step / 2));
        }

        public List<SkinRegion> GetSkinRegions(Image<Gray, byte> img)
        {
            List<SkinRegion> regions = new List<SkinRegion>();
            byte[, ,] data = img.Data;

            for (int i = img.Rows - 1; i >= 0; i--)
            {
                for (int j = img.Cols - 1; j >= 0; j--)
                {
                    if (data[i, j, 0] == 255)
                    {
                        regions.Add(new SkinRegion(img, i, j));
                    }
                }
            }

            return regions;
        }
        public List<SkinRegion> FilterSkinRegionsByHoles(List<SkinRegion> skinRegions, int minHoles = 1)
        {
            return skinRegions.Where(skinRegion => skinRegion.Holes > 1).ToList();
        }
        public double MatchTemplate(Image<Bgr, byte> img, SkinRegion skinRegion, Image<Gray, byte> template)
        {
            var imgCroppedTemplate = template.Resize(skinRegion.Width, skinRegion.Height, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);

            var imgRotatedTemplate = imgCroppedTemplate.Rotate(-skinRegion.Inclination * 180 / Math.PI , new Gray(0));
            var data = imgRotatedTemplate.Data;
            int l = imgRotatedTemplate.Width, t = imgRotatedTemplate.Height, w = 0, h = 0;
            imgCroppedTemplate = Utils.Crop(imgCroppedTemplate);

            var centroid = Utils.GetCentroid(imgCroppedTemplate);

            int tx = skinRegion.Left + skinRegion.Centroid.X - centroid.X,
                ty = skinRegion.Top + skinRegion.Centroid.Y - centroid.Y;
            tx = tx >= 0 ? tx : 0;
            ty = ty >= 0 ? ty : 0;
            tx = (tx + skinRegion.Width <= img.Width) ? tx : (img.Width - skinRegion.Width);
            ty = (ty + skinRegion.Height <= img.Height) ? ty : (img.Height - skinRegion.Height);

            var imgFinalTemplate = new Image<Gray, byte>(img.Size);
            imgFinalTemplate.ROI = new Rectangle(tx, ty, imgCroppedTemplate.Width, imgCroppedTemplate.Height);
            CvInvoke.cvCopy(imgCroppedTemplate, imgFinalTemplate, IntPtr.Zero);
            CvInvoke.cvResetImageROI(imgFinalTemplate);

            var match = skinRegion.FindMask(img).MatchTemplate(imgFinalTemplate, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCORR_NORMED);
            return match.Data[0, 0, 0];
        }

        public List<Rectangle> Execute(Image<Bgr, byte> imgToTest, Image<Gray, byte> imgFaceTemplate,
            byte atUpper = 180, byte atLow = 30, byte atStep = 2,
            int fMinHoles = 1, double fMinRatio = 0.8, double fMaxRatio = 1.6, double fMinCrsCrltn = 0.6)
        {
            imgToTest = Utils.ApplyKernel(imgToTest, new float[,] {
                { 1/9f, 1/9f, 1/9f }, { 1/9f, 1/9f, 1/9f }, { 1/9f, 1/9f, 1/9f }
            });
            var imgLkhood = GetLikelihoodImage(imgToTest);
            var imgThresh = GetAdaptiveBinaryThreshold(imgLkhood, atUpper, atLow, atStep);
            var skinRegions = GetSkinRegions(imgThresh);

            return skinRegions.Where(sr => sr.Holes > fMinHoles &&
                sr.Ratio >= fMinRatio && sr.Ratio <= fMaxRatio &&
                MatchTemplate(imgToTest, sr, imgFaceTemplate) >= fMinCrsCrltn).Select(sr => sr.Rect).ToList();
        }

        public List<Rectangle> Execute(Image<Bgr, byte> img, object options)
        {
            ChangRoblesOptions opts = options as ChangRoblesOptions;
            return Execute(img,
                opts.FaceTemplate,
                opts.AdaptiveThresholdUpper,
                opts.AdaptiveThresholdLower,
                opts.AdaptiveThresholdStep,
                opts.SkinRegionMinHoles,
                opts.SkinRegionMinRatio,
                opts.SkinRegionMaxRatio,
                opts.SkinRegionMinCrossCorellation);
        }
    }

    class ChangRoblesOptions
    {
        public byte AdaptiveThresholdUpper { get; set; }
        public byte AdaptiveThresholdLower { get; set; }
        public byte AdaptiveThresholdStep { get; set; }
        public int SkinRegionMinHoles { get; set; }
        public double SkinRegionMinRatio { get; set; }
        public double SkinRegionMaxRatio { get; set; }
        public double SkinRegionMinCrossCorellation { get; set; }
        public Image<Gray, byte> FaceTemplate { get; set; }
    }

    static class Utils
    {
        /// <summary>
        /// Flood fill
        /// </summary>
        /// <param name="data">Image data</param>
        /// <param name="pr">Start point row</param>
        /// <param name="pc">Start point column</param>
        /// <param name="l">Left border</param>
        /// <param name="r">Right border</param>
        /// <param name="t">Top border</param>
        /// <param name="b">Bottom border</param>
        /// <param name="clrOld">Old color</param>
        /// <param name="clrNew">New color</param>
        public static void FloodFill(byte[, ,] data, int pr, int pc,
            int l, int r, int t, int b,
            byte clrOld, byte clrNew)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(new Point(pr, pc));
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (j != 0 || i != 0)
                        {
                            Point pNew = new Point(p.X + i, p.Y + j);
                            if (pNew.X >= t && pNew.X < b && pNew.Y >= l && pNew.Y < r &&
                                data[pNew.X, pNew.Y, 0] == clrOld)
                            {
                                data[pNew.X, pNew.Y, 0] = clrNew;
                                q.Enqueue(pNew);
                            }
                        }
                    }
                }
            }
        }

        public static Image<Bgr, byte> ApplyKernel(Image<Bgr, byte> img, float[,] k)
        {
            ConvolutionKernelF kernel = new ConvolutionKernelF(k);
            return (img * kernel).Convert<Bgr, byte>();
        }
        public static Image<Gray, byte> Crop(Image<Gray, byte> imgToCrop)
        {
            int l = imgToCrop.Width, w = 0, h = 0, t = imgToCrop.Height;
            var data = imgToCrop.Data;
            for (int i = 0; i < imgToCrop.Height; i++)
            {
                for (int j = 0; j < imgToCrop.Width; j++)
                {
                    if (data[i, j, 0] > 0)
                    {
                        if (j < l)
                        {
                            l = j;
                        }
                        if (j > w)
                        {
                            w = j;
                        }
                        if (i < t)
                        {
                            t = i;
                        }
                        if (i > h)
                        {
                            h = i;
                        }
                    }
                }
            }
            w -= l;
            h -= t;

            return imgToCrop.GetSubRect(new Rectangle(l, t, w, h));
        }
        public static Point GetCentroid(Image<Gray, byte> img)
        {
            var data = img.Data;
            int x = 0, y = 0, area = 0;
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (data[i, j, 0] > 0)
                    {
                        x += j;
                        y += i;
                        area++;
                    }
                }
            }
            x /= area;
            y /= area;

            return new Point(x, y);
        }
    }
}
