using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkinDetection
{
    class TwoDimVector
    {
        public double a1 { get; set; }
        public double a2 { get; set; }
        public bool T { get; set; }
    }
    class TwoDimMatrix
    {
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double b1 { get; set; }
        public double b2 { get; set; }
    }

    class ChangRobles
    {
        public TwoDimVector Mean { get; private set; }
        public TwoDimMatrix Covariance { get; private set; }

        public void SetModel(List<double> r, List<double> b)
        {
            Mean = new TwoDimVector
            {
                T = true,
                a1 = r.Average(),
                a2 = b.Average()
            };
            
        }
    }
}
