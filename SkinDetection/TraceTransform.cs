using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    class TraceLine
    {
        public int Distance { get; set; }
        public int AngleIndex { get; set; }

        public List<Point> Points { get; set; }
        public void CreatePoints(byte[, ,] data, int height, int width)
        {
            Points = new List<Point>();

            for (int i = 0; i < height; i++)
            {
                bool detectLine = false;
                for (int j = 0; j < width; j++)
                {
                    if (data[i, j, 0] != 0)
                    {
                        Points.Add(new Point(j - width / 2, i - height / 2));
                        detectLine = true;
                    }
                    else
                    {
                        if (detectLine)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        public void Save(StreamWriter sw)
        {
            sw.WriteLine(string.Format("{0} {1} {2}", Distance, AngleIndex, Points.Count));
            sw.WriteLine(string.Join(";", Points.Select(p => p.X + " "+ p.Y)));
        }
        public void Load(StreamReader sr)
        {
            string[] metadata = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Distance = int.Parse(metadata[0]);
            AngleIndex = int.Parse(metadata[1]);
            Points = new List<Point>();

            foreach (var pair in sr.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] pairPoints = pair.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Points.Add(new Point(int.Parse(pairPoints[0]), int.Parse(pairPoints[1])));
            }
        }

        public List<byte> GetValues(byte[, ,] data, int height, int width)
        {
            List<byte> values = new List<byte>();

            foreach (var point in Points)
            {
                int x = point.X + width / 2, y = point.Y + height / 2;
                if (x >= 0 && x < width && y >= 0 && y < height)
                {
                    values.Add(data[y, x, 0]);
                }
            }

            return values;
        }

        public bool IsApplicable(int width, int height)
        {
            foreach (var p in Points)
            {
                int x = p.X + width / 2, y = p.Y + height / 2;
                if (x >= 0 && x < width && y >= 0 && y < height)
                {
                    return true;
                }
            }
            return false;
        }
    }

    enum TraceTransformFunctional
    {
        Sum, SimpleSquareRoot, Delta, Median
    }

    class Constants
    {
        public static char[] Separators = new char[] { ' ', '\r', '\n' };
    }

    class TraceTransformDb
    {
        public TraceTransformDb(string filename, int nImages)
        {
            Persons = new List<Person>();
            foreach (var dir in Directory.GetDirectories(filename))
            {
                Person p = new Person() { Path = dir };
                p.Images = new List<string>(Directory.GetFiles(dir).Take(nImages));
                Persons.Add(p);
            }
        }

        public double TestDb(string filename, TraceTransform tt, List<TraceTransformFunctional> funcs)
        {
            int cnt = 0;
            double val = 0;
            foreach (var dir in Directory.GetDirectories(filename))
            {
                foreach (var pict in Directory.GetFiles(dir))
                {
                    cnt++;
                    Person p = FindPerson(tt, new Image<Gray, byte>(pict), funcs);
                    if (p.Path == dir)
                    {
                        val++;
                    }
                }
            }
            return val / cnt;
        }

        public void Calc(TraceTransform tt, List<TraceTransformFunctional> funcs, byte t)
        {
            foreach (var person in Persons)
            {
                person.CountTransformed(tt, funcs);
                person.CountWeights(tt, funcs, t);
            }
        }

        public List<Person> Persons { get; set; }

        public class Person {
            public string Path { get; set; }
            public string Name
            {
                get
                {
                    string dir = System.IO.Path.GetDirectoryName(Path);
                    return dir.Substring(dir.LastIndexOf('\\') + 1);
                }
            }

            public Dictionary<TraceTransformFunctional, WeightMatrix> Weights { get; set; }
            public Dictionary<string, List<TransformedImage>> Transformed { get; set; }

            public List<string> Images { get; set; }
            public void CountWeights(TraceTransform tt, List<TraceTransformFunctional> functionals, byte t)
            {
                Weights = new Dictionary<TraceTransformFunctional, WeightMatrix>();

                foreach (var functional in functionals)
                {
                    List<byte[,]> transformed = Images.Select(img =>
                        Transformed[img].Where(x=>x.Functional == functional).First().Data).ToList();
                    int flags;
                    byte[,] wm = tt.GetTraceWeightMatrix(transformed, t, out flags);
                    Weights.Add(functional, new WeightMatrix { Matrix = wm, Flags = flags });
                }
            }
            public void CountTransformed(TraceTransform tt, List<TraceTransformFunctional> functionals)
            {
                Transformed = new Dictionary<string, List<TransformedImage>>();
                foreach (var img in Images)
                {
                    byte[, ,] imgData = (new Image<Gray, byte>(img)).Data;
                    List<TransformedImage> imgTransformed = new List<TransformedImage>();
                    foreach (var func in functionals)
                    {
                        TransformedImage ti = new TransformedImage();
                        ti.Calc(tt, imgData, func);
                        imgTransformed.Add(ti);
                    }
                    Transformed.Add(img, imgTransformed);
                }
            }
        }

        public class WeightMatrix
        {
            public byte[,] Matrix { get; set; }
            public int Flags { get; set; }

            public void Save(StreamWriter sw, TraceTransformFunctional functional)
            {
                sw.WriteLine(string.Format("{0} {1} {2} {3}", Matrix.GetLength(0), Matrix.GetLength(1), Flags, functional));
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        sw.Write(Matrix[i, j]);
                        if (j < Matrix.GetLength(1) - 1)
                        {
                            sw.Write(" ");
                        }
                        else
                        {
                            sw.Write("\r\n");
                        }
                    }
                }
            }
            public void Load(StreamReader sr, out TraceTransformFunctional functional)
            {
                string[] metadata = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Matrix = new byte[int.Parse(metadata[0]), int.Parse(metadata[1])];
                Flags = int.Parse(metadata[2]);
                functional = (TraceTransformFunctional)int.Parse(metadata[3]);
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    string[] line = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Matrix[i, j] = byte.Parse(line[j]);
                    }
                }
            }
        }

        public class TransformedImage
        {
            public byte[,] Data { get; set; }
            public TraceTransformFunctional Functional { get; set; }

            public void Calc(TraceTransform tt, byte[,,] data, TraceTransformFunctional functional)
            {
                Functional = functional;
                Data = tt.GetTransformMatrix(data, tt.Dist, tt.NAngles, tt.TraceLines, functional);
            }

            public void Save(StreamWriter sw)
            {
                sw.WriteLine(string.Format("{0} {1} {2}", Data.GetLength(0), Data.GetLength(1), Functional));
                for (int i = 0; i < Data.GetLength(0); i++)
                {
                    for (int j = 0; j < Data.GetLength(1); j++)
                    {
                        sw.Write(Data[i, j]);
                        if (j < Data.GetLength(1) - 1)
                        {
                            sw.Write(" ");
                        }
                        else
                        {
                            sw.Write("\r\n");
                        }
                    }
                }
            }
            public void Load(StreamReader sr)
            {
                string[] metadata = sr.ReadLine().Split(Constants.Separators, StringSplitOptions.RemoveEmptyEntries);
                Data = new byte[int.Parse(metadata[0]), int.Parse(metadata[1])];
                Functional = (TraceTransformFunctional)int.Parse(metadata[2]);
                for (int i = 0; i < Data.GetLength(0); i++)
                {
                    string[] line = sr.ReadLine().Split(Constants.Separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < Data.GetLength(1); j++)
                    {
                        Data[i, j] = byte.Parse(line[j]);
                    }
                }
            }
        }

        public void SaveWeights(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var person in Persons)
                {
                    sw.WriteLine(string.Format("{0} {1}", person.Path, person.Weights.Count));
                    foreach (var wm in person.Weights)
                    {
                        wm.Value.Save(sw, wm.Key);
                    }
                }
            }
        }

        public void SaveTransformedImages(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var person in Persons)
                {
                    sw.WriteLine(string.Format("{0} {1}", person.Path, person.Transformed.Count));
                    foreach (var tis in person.Transformed)
                    {
                        sw.WriteLine(string.Format("{0} {1}", tis.Key, tis.Value.Count));
                        foreach (var ti in tis.Value)
                        {
                            ti.Save(sw);
                        }
                    }
                }
            }
        }

        public void LoadTransformedImages(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string[] metadata = sr.ReadLine().Split(Constants.Separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < int.Parse(metadata[2]); i++)
                {
                    string[] metadata2 = sr.ReadLine().Split(Constants.Separators, StringSplitOptions.RemoveEmptyEntries);
                    Persons[i].Transformed = new Dictionary<string, List<TransformedImage>>();
                }
            }
        }

        public Person FindPerson(TraceTransform tt, Image<Gray, byte> imgTest, List<TraceTransformFunctional> funcs)
        {
            List<byte[,]> transforms = funcs.Select(f => tt.GetTransformMatrix(imgTest, tt.Dist, tt.NAngles, tt.TraceLines, f)).ToList();
            Person p = null;

            double dMax = 0;
            foreach (var person in Persons)
            {
                foreach (var func in funcs)
                {
                    var wm = person.Weights[func];
                    var lst = person.Images.Select(img => person.Transformed[img].Where(x => x.Functional == func).First());
                    foreach (var imgRef in lst)
                    {
                        var d = tt.GetTraceDistance(transforms[(int)func], imgRef.Data, wm.Matrix, wm.Flags);
                        if (d > dMax)
                        {
                            p = person;
                            dMax = d;
                        }
                    }
                }
            }

            return p;
        }
    }

    class TraceTransform
    {
        public List<TraceLine> TraceLines { get; set; }
        public int NAngles { get; set; }
        public int Dist { get; set; }

        public List<string> Persons { get; set; }
        public List<byte[,][,]> WeightMatrixes { get; set; }

        public PointF GetBound(PointF p, float dx, float dy, int width, int height)
        {
            float times = float.MaxValue;
            if (dx > 0)
            {
                times = times > ((width - p.X) / dx) ? ((width - p.X) / dx) : times;
            }
            else if (dx < 0)
            {
                times = times > (-p.X / dx) ? (-p.X / dx) : times;
            }
            if (dy > 0)
            {
                times = times > ((height - p.Y) / dy) ? ((height - p.Y) / dy) : times;
            }
            else if (dy < 0)
            {
                times = times > (-p.Y / dy) ? (-p.Y / dy) : times;
            }
            return new PointF(p.X + times * dx, p.Y + times * dy);
        }

        public List<TraceLine> CreateTraceLines(int height, int width, int dist, int nAngles)
        {
            List<TraceLine> traceLines = new List<TraceLine>();

            Image<Gray, byte> img = new Image<Gray, byte>(width, height);
            byte[, ,] data = img.Data;

            for (int i = 0; i < nAngles; i++)
            {
                double angle = i * 2 * Math.PI / nAngles;
                for (int j = 0; j < dist; j++)
                {
                    TraceLine traceLine = new TraceLine { AngleIndex = i, Distance = j };
                    int k = j == 0 ? 1 : j;
                    float tx = k * (float) Math.Cos(angle), ty = k * (float) Math.Sin(angle);

                    PointF t = j == 0 ? new PointF(width / 2, height / 2) : new PointF(width / 2 + tx, height / 2 + ty);
                    img.Draw(new LineSegment2DF(t, GetBound(t, -tx, ty, width, height)), new Gray(255), 1);
                    img.Draw(new LineSegment2DF(t, GetBound(t, tx, -ty, width, height)), new Gray(255), 1);
                    
                    traceLine.CreatePoints(data, height, width);
                    traceLines.Add(traceLine);

                    foreach (var point in traceLine.Points)
                    {
                        data[point.Y + height / 2, point.X + width / 2, 0] = 0;
                    }
                }
            }

            return traceLines;
        }
        public void SaveTraceLines(int nAngles, int dist, List<TraceLine> traceLines, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(string.Format("{0} {1} {2}", dist, nAngles, traceLines.Count));
                foreach (var traceLine in traceLines)
                {
                    traceLine.Save(sw);
                }
            }
        }
        public static TraceTransform LoadTraceLines(string path)
        {
            TraceTransform tt = new TraceTransform();

            List<TraceLine> traceLines = new List<TraceLine>();
            using (StreamReader sr = new StreamReader(path))
            {
                string[] metadata = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                tt.Dist = int.Parse(metadata[0]);
                tt.NAngles = int.Parse(metadata[1]);
                int nTraceLines = int.Parse(metadata[2]);
                for (int i = 0; i < nTraceLines; i++)
                {
                    TraceLine traceLine = new TraceLine();
                    traceLine.Load(sr);
                    traceLines.Add(traceLine);
                }
            }
            tt.TraceLines = traceLines;

            return tt;
        }

        public byte ApplyFunctional(byte[, ,] data, int width, int height, TraceLine traceLine, TraceTransformFunctional functional)
        {
            List<byte> values = traceLine.GetValues(data, height, width);
            byte res = 0;
            
            switch (functional)
            {
                case TraceTransformFunctional.Sum:
                    if (values.Count > 0)
                    {
                        long sum = 0;
                        foreach (var val in values)
                        {
                            sum += val;
                        }
                        res = (byte)(sum / values.Count);
                    }
                    break;
                case TraceTransformFunctional.SimpleSquareRoot:
                    if (values.Count > 0)
                    {
                        long sum = 0;
                        foreach (var val in values)
                        {
                            sum += val * val;
                        }
                        res = (byte)Math.Sqrt(sum / values.Count);
                    }
                    break;
                case TraceTransformFunctional.Delta:
                    if (values.Count > 0)
                    {
                        long sum = 0;
                        for (int i = 1; i < values.Count; i++)
                        {
                            sum += Math.Abs(values[i] - values[i - 1]);
                        }
                        if (values.Count == 1)
                        {
                            res = 0;
                        }
                        else
                        {
                            res = (byte)(sum / (values.Count - 1));
                        }
                    }
                    break;
                case TraceTransformFunctional.Median:
                    break;
            }

            return res;
        }

        public byte[,] GetTransformMatrix(Image<Gray, byte> imgTest, int dist, int nAngles,
            List<TraceLine> traceLines, TraceTransformFunctional functional)
        {
            byte[,] matrix = new byte[dist, nAngles];

            byte[,,] data = imgTest.Data;
            int width = imgTest.Width;
            int height = imgTest.Height;

            foreach (var traceLine in traceLines)
            {
                if (traceLine.Distance < dist && traceLine.AngleIndex < nAngles)
                {
                    matrix[traceLine.Distance, traceLine.AngleIndex] = ApplyFunctional(data, width, height, traceLine, functional);
                }
            }

            return matrix;
        }
        public byte[,] GetTransformMatrix(byte[, ,] data, int dist, int nAngles,
    List<TraceLine> traceLines, TraceTransformFunctional functional)
        {
            byte[,] matrix = new byte[dist, nAngles];

            int width = data.GetLength(1);
            int height = data.GetLength(0);

            foreach (var traceLine in traceLines)
            {
                if (traceLine.Distance < dist && traceLine.AngleIndex < nAngles)
                {
                    matrix[traceLine.Distance, traceLine.AngleIndex] = ApplyFunctional(data, width, height, traceLine, functional);
                }
            }

            return matrix;
        }
        public Image<Gray, byte> GetTransformImage(Image<Gray, byte> imgTest, int dist, int nAngles,
            List<TraceLine> traceLines, TraceTransformFunctional functional)
        {
            Image<Gray, byte> img = new Image<Gray, byte>(nAngles, dist);
            byte[, ,] data = img.Data;
            byte[,] matrix = GetTransformMatrix(imgTest, dist, nAngles, traceLines, functional);

            for (int i = 0; i < dist; i++)
            {
                for (int j = 0; j < nAngles; j++)
                {
                    data[i, j, 0] = matrix[i, j];
                }
            }

            return img;
        }

        public List<TraceLine> GetApplicableTraces(List<TraceLine> traceLines, int width, int height)
        {
            List<TraceLine> applicableTraceLines = new List<TraceLine>();
            foreach (var traceLine in traceLines)
            {
                if (traceLine.IsApplicable(width, height))
                {
                    applicableTraceLines.Add(traceLine);
                }
            }
            return applicableTraceLines;
        }
        public Rectangle DetectMaskedShape(Image<Gray, byte> img)
        {
            byte[, ,] data = img.Data;

            int right = 0, left = int.MaxValue, bottom = 0, top = int.MaxValue;
            bool colDetect = false, rowDetect = false;
            for (int i = 0; i < img.Height; i++)
            {
                rowDetect = false;
                for (int j = 0; j < img.Width; j++)
                {
                    if (data[i, j, 0] != 0)
                    {
                        if (!rowDetect)
                        {
                            if (left > j)
                            {
                                left = j;
                            }
                            rowDetect = true;
                        }
                        else
                        {
                            if (j > right)
                            {
                                right = j;
                            }
                        }
                    }
                    else
                    {
                        if (rowDetect)
                        {
                            break;
                        }
                    }
                }
                if (rowDetect)
                {
                    if (!colDetect)
                    {
                        top = i;
                        colDetect = true;
                    }
                    else
                    {
                        bottom = i;
                    }
                }
                else
                {
                    if (colDetect)
                    {
                        break;
                    }
                }
            }

            return new Rectangle(left, top, right - top + 1, bottom - top + 1);
        }
        public Image<Gray, byte> GetMaskedShape(Image<Gray, byte> img)
        {
            Rectangle mask = DetectMaskedShape(img);
            img.ROI = mask;

            Image<Gray, byte> imgMask = new Image<Gray, byte>(mask.Size);
            CvInvoke.cvCopy(img.Ptr, imgMask.Ptr, IntPtr.Zero);
            return imgMask;
        }

        public byte[,] GetTraceWeightMatrix(List<byte[,]> ms, byte t, out int flags)
        {
            int height = ms[0].GetLength(0), width = ms[0].GetLength(1);
            byte[,] wm = new byte[height, width];
            flags = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bool fnd = false;
                    for (int i1 = 0; i1 < ms.Count - 1; i1++)
                    {
                        for (int j1 = i1 + 1; j1 < ms.Count; j1++)
                        {
                            byte dif = ms[i1][i, j] > ms[j1][i, j] ? (byte)(ms[i1][i, j] - ms[j1][i, j]) : (byte)(ms[j1][i, j] - ms[i1][i, j]);
                            if (dif > t)
                            {
                                wm[i, j] = 1;
                                flags++;
                                fnd = true;
                                break;
                            }
                        }
                        if (fnd)
                        {
                            break;
                        }
                    }
                }
            }

            return wm;
        }
        public double GetTraceDistance(byte[,] mTest, byte[,] mRef, byte[,] weights, int flags)
        {
            int dist = mTest.GetLength(0), nAngles = mTest.GetLength(1);

            double d = 0;
            for (int i = 0; i < dist; i++)
            {
                for (int j = 0; j < nAngles; j++)
                {
                    if (weights[i, j] == 1)
                    {
                        byte min = 255;
                        for (int k = 0; k < nAngles; k++)
                        {
                            byte dif = mTest[i, j] > mRef[i, k] ? (byte)(mTest[i, j] - mRef[i, k]) : (byte)(mRef[i, k] - mTest[i, j]);
                            if (dif < min)
                            {
                                min = dif;
                            }
                        }
                        d += min;
                    }
                }
            }
            return 1.0 / Math.Exp(d / flags);
        }

        public TraceTransformDb Create(string dbDir, int nImages)
        {
            return new TraceTransformDb(dbDir, nImages);
        }

        public TraceTransformDb Learn(TraceTransformDb db, TraceTransform tt, byte t, List<TraceTransformFunctional> functionals)
        {
            db.Calc(tt, functionals, t);
            return db;
        }
    }
}
