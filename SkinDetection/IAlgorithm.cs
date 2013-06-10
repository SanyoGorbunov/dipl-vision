using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    interface IAlgorithm
    {
        List<Rectangle> Execute(Image<Bgr, byte> img, object options);
    }
}
