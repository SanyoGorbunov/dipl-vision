using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

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
            return Math.Exp(0.5 * (v * InvertCovariance * v));
        }
        public double GetLikelihood(Bgr bgr)
        {
            double sum = bgr.Blue + bgr.Green + bgr.Red;
            return GetLikelihood(bgr.Red / sum, bgr.Blue / sum);
        }
    }
}
