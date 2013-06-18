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
        Sum
    }

    class TraceTransform
    {
        public List<TraceLine> TraceLines { get; set; }
        public int NAngles { get; set; }
        public int Dist { get; set; }

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
    }
}
