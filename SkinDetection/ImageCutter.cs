using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    public partial class ImageCutter : Form
    {
        private Image<Bgr, byte> img;
        private Image<Gray, byte> imgChrB, imgChrR, imgMixed, imgChrBCpy, imgChrRCpy, imgMixedCpy;

        public ImageCutter()
        {
            InitializeComponent();
        }

        private void btnImgLoad_Click(object sender, EventArgs e)
        {
            if (dlgImgLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img = new Image<Bgr, byte>(dlgImgLoad.FileName);
                img = img.Resize(0.5, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
                pbImgStart.Image = img.ToBitmap();
                var data = img.Data;

                imgChrR = new Image<Gray, byte>(img.Size);
                imgChrB = new Image<Gray, byte>(img.Size);
                imgMixed = new Image<Gray, byte>(img.Size);
                var dataChrR = imgChrR.Data;
                var dataChrB = imgChrB.Data;
                var dataMixed = imgMixed.Data;
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        byte nr, nb, nm;
                        ColorSet(cbColorSet.SelectedIndex, data[i, j, 0], data[i, j, 1], data[i, j, 2], out nb, out nr, out nm);
                        dataChrR[i, j, 0] = nr;
                        dataChrB[i, j, 0] = nb;
                        dataMixed[i, j, 0] = nm;
                    }
                }
                pbImgChrB.Image = imgChrB.ToBitmap();
                pbImgChrR.Image = imgChrR.ToBitmap();
                pbImgMix.Image = imgMixed.ToBitmap();
            }
        }

        private void pbImgStart_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkFloodFill.Checked)
            {
                imgChrBCpy = new Image<Gray, byte>(img.Size);
                imgChrRCpy = new Image<Gray, byte>(img.Size);
                imgMixedCpy = new Image<Gray, byte>(img.Size);
            }
            else
            {
                imgChrBCpy = imgChrB.Copy();
                imgChrRCpy = imgChrR.Copy();
                imgMixedCpy = imgMixed.Copy();
            }

            var dataChrBCpy = imgChrBCpy.Data;
            var dataChrRCpy = imgChrRCpy.Data;
            var dataMixedCpy = imgMixedCpy.Data;

            int x = e.X, y = e.Y;

            if (chkFloodFill.Checked)
            {
                byte th = byte.Parse(txtThreshold.Text);
                FloodFill(imgChrB, y, x, th, dataChrBCpy);
                FloodFill(imgChrR, y, x, th, dataChrRCpy);
                FloodFill(imgMixed, y, x, th, dataMixedCpy);
            }
            else
            {
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        if (i != y || j != x)
                        {
                            dataChrBCpy[i, j, 0] = (byte)(255 - (dataChrBCpy[i, j, 0] > dataChrBCpy[y, x, 0] ? (byte)(dataChrBCpy[i, j, 0] - dataChrBCpy[y, x, 0]) : (byte)(dataChrBCpy[y, x, 0] - dataChrBCpy[i, j, 0])));
                            dataChrRCpy[i, j, 0] = (byte)(255 - (dataChrRCpy[i, j, 0] > dataChrRCpy[y, x, 0] ? (byte)(dataChrRCpy[i, j, 0] - dataChrRCpy[y, x, 0]) : (byte)(dataChrRCpy[y, x, 0] - dataChrRCpy[i, j, 0])));
                            dataMixedCpy[i, j, 0] = (byte)(255 - (dataMixedCpy[i, j, 0] > dataMixedCpy[y, x, 0] ? (byte)(dataMixedCpy[i, j, 0] - dataMixedCpy[y, x, 0]) : (byte)(dataMixedCpy[y, x, 0] - dataMixedCpy[i, j, 0])));
                        }
                    }
                }
                dataChrBCpy[y, x, 0] = 255;
                dataChrRCpy[y, x, 0] = 255;
                dataMixedCpy[y, x, 0] = 255;
            }

            pbImgChrB.Image = imgChrBCpy.ToBitmap();
            pbImgChrR.Image = imgChrRCpy.ToBitmap();
            pbImgMix.Image = imgMixedCpy.ToBitmap();
        }

        private void btnSetThreshold_Click(object sender, EventArgs e)
        {
            byte t = byte.Parse(txtThreshold.Text);

            var imgChrBTh = imgChrBCpy.ThresholdBinary(new Gray(255 - t), new Gray(255));
            var imgChrRTh = imgChrRCpy.ThresholdBinary(new Gray(255 - t), new Gray(255));
            var imgMixedTh = imgMixedCpy.ThresholdBinary(new Gray(255 - t), new Gray(255));

            pbImgChrB.Image = imgChrBTh.ToBitmap();
            pbImgChrR.Image = imgChrRTh.ToBitmap();
            pbImgMix.Image = imgMixedTh.ToBitmap();
        }

        public static void FloodFill(Image<Gray, byte> img, int pr, int pc, byte th, byte[,,] outData)
        {
            var data = img.Data;
            outData[pr, pc, 0] = 255;
            int l = 0, t = 0, r = img.Width, b = img.Height;
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
                                outData[pNew.X, pNew.Y, 0] == 0)
                            {
                                int dif = data[p.X, p.Y, 0] - data[pNew.X, pNew.Y, 0];
                                dif = dif < 0 ? -dif : dif;
                                if (dif < th)
                                {
                                    outData[pNew.X, pNew.Y, 0] = 255;
                                    q.Enqueue(pNew);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void ColorSet(int type, byte b, byte g, byte r, out byte nb, out byte nr, out byte nm)
        {
            int mix;
            switch (type)
            {
                case 0:
                    nb = b;
                    nr = r;
                    mix = b + r;
                    nm = mix > 255 ? (byte)255 : (byte)mix;
                    break;
                case 1:
                    int sum = b + g + r;
                    nr = (byte)(255.0 * r / sum);
                    nb = (byte)(255.0 * b / sum);
                    mix = nb + nr;
                    nm = mix > 255 ? (byte)255 : (byte)mix;
                    break;
                default:
                    throw new NotImplementedException();
            }
            
        }
    }
}
