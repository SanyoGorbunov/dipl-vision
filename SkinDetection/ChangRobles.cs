using System;
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
        public Image<Gray, byte> Region { get; private set; }

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

        public int Holes { get; private set; }
        public Point Centroid { get; private set; }

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
                    Utils.FloodFill(cpyData, i, Left + Width, Left, Left + Width, Top, Top + Height, 0, 1);
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
                    Utils.FloodFill(cpyData, Top + Height, j, Left, Left + Width, Top, Top + Height, 0, 1);
                }
            }

            Holes = 0;
            for (int i = Top; i < Top + Height; i++)
            {
                for (int j = Left; j < Left + Width; j++)
                {
                    if (cpyData[i, j, 0] == 0)
                    {
                        Holes++;
                        byte clrNew = (byte)(Holes + 1);
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
            x /= Area;
            y /= Area;
            Centroid = new Point((int)x, (int)y);
        }
    }

    class ChangRobles
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
        public Image<Gray, Byte> GetAdaptiveBinaryThreshold(Image<Gray, byte> img, byte initialBound = 180, byte step = 5)
        {
            Image<Gray, byte> imgAdaptive = GetBinaryThreshold(img, initialBound);
            int whPxls0 = GetWhitePixels(imgAdaptive), dif0 = 0, whPxls1, dif1;
            initialBound -= step;
            while (initialBound > 0)
            {
                imgAdaptive = GetBinaryThreshold(img, initialBound);
                whPxls1 = GetWhitePixels(imgAdaptive);
                dif1 = whPxls1 - whPxls0;
                if (dif0 > 0 && dif1 > dif0)
                {
                    break;
                }
                initialBound -= step;
                whPxls0 = whPxls1;
                dif0 = dif1;
            }
            return GetBinaryThreshold(img, (byte) (initialBound + step / 2));
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
                    for (int j = -1; j < 1; j++)
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

        public static Image<Bgr, byte> ApplyKernel(Image<Bgr, byte> img, float[,] k)
        {
            ConvolutionKernelF kernel = new ConvolutionKernelF(k);
            return (img * kernel).Convert<Bgr, byte>();
        }
    }
}
