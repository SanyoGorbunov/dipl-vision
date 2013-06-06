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

namespace SkinDetection
{
    public partial class TestInclination : Form
    {
        private Image<Gray, byte> img;

        public TestInclination()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dlgLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img = new Image<Gray, byte>(dlgLoad.FileName);
                pb.Image = img.ToBitmap();
            }
        }

        private void Calc()
        {
            var imgGray = img.Convert<Gray, byte>().Not();
            var data = imgGray.Data;

            double xc = 0, yc = 0;
            int area = 0;
            for (int i = 0; i < imgGray.Height; i++)
            {
                for (int j = 0; j < imgGray.Width; j++)
                {
                    if (data[i, j, 0] > 0)
                    {
                        xc += j;
                        yc += i;
                        area++;
                    }
                }
            }
            xc /= area;
            yc /= area;

            double a = 0, b = 0, c = 0;

            for (int i = 0; i < imgGray.Height; i++)
            {
                for (int j = 0; j < imgGray.Width; j++)
                {
                    if (data[i, j, 0] > 0)
                    {
                        a += (j - xc) * (j - xc);
                        b += (j - xc) * (i - yc);
                        c += (i - yc) * (i - yc);
                    }
                }
            }

            b *= 2;
            double inclination = 0.5 * Math.Atan(b / (a - c));

            var imgTest = new Image<Gray, byte>(new Size(5, 5));
            imgTest.Draw(new LineSegment2D(new Point(2, 0), new Point(2, 4)), new Gray(255), 1);
            imgTest = imgTest.Resize(img.Width, img.Height, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
            imgTest = imgTest.Rotate(-180 * inclination / Math.PI, new Gray(0));
            pbTest.Image = imgTest.ToBitmap();

            lblInclination.Text = inclination.ToString("0.00000");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
