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
        public double Angle { get; set; }

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
            sw.WriteLine(string.Format("{0} {1} {2}", Distance, Angle, Points.Count));
            sw.WriteLine(string.Join(";", Points.Select(p => p.X + " "+ p.Y)));
        }
        public void Load(StreamReader sr)
        {
            string[] metadata = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Distance = int.Parse(metadata[0]);
            Angle = double.Parse(metadata[1]);
            Points = new List<Point>();

            foreach (var pair in sr.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] pairPoints = pair.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Points.Add(new Point(int.Parse(pairPoints[0]), int.Parse(pairPoints[1])));
            }
        }
    }

    class TraceTransform
    {
        public List<TraceLine> TraceLines { get; set; }

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
                for (int j = 1; j < dist; j++)
                {
                    TraceLine traceLine = new TraceLine { Angle = angle, Distance = j };
                    float tx = j * (float) Math.Cos(angle), ty = j * (float) Math.Sin(angle);

                    PointF t = new PointF(width / 2 + tx, height / 2 + ty);
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
        public void SaveTraceLines(List<TraceLine> traceLines, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(traceLines.Count);
                foreach (var traceLine in traceLines)
                {
                    traceLine.Save(sw);
                }
            }
        }
        public List<TraceLine> LoadTraceLines(string path)
        {
            List<TraceLine> traceLines = new List<TraceLine>();
            using (StreamReader sr = new StreamReader(path))
            {
                int nTraceLines = int.Parse(sr.ReadLine());
                for (int i = 0; i < nTraceLines; i++)
                {
                    TraceLine traceLine = new TraceLine();
                    traceLine.Load(sr);
                    traceLines.Add(traceLine);
                }
            }
            return traceLines;
        }
    }
}
