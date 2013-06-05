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
                        int sum = data[i, j, 0] + data[i, j, 1] + data[i, j, 2];
                        dataChrR[i, j, 0] = (byte) (255.0 * data[i,j,2] / sum);
                        dataChrB[i, j, 0] = (byte)(255.0 * data[i, j, 0] / sum);
                        int mix = dataChrB[i, j, 0] + dataChrR[i, j, 0];
                        dataMixed[i, j, 0] = mix > 255 ? (byte)255 : (byte)mix;
                    }
                }
                pbImgChrB.Image = imgChrB.ToBitmap();
                pbImgChrR.Image = imgChrR.ToBitmap();
                pbImgMix.Image = imgMixed.ToBitmap();
            }
        }

        private void pbImgStart_MouseClick(object sender, MouseEventArgs e)
        {
            imgChrBCpy = imgChrB.Copy();
            imgChrRCpy = imgChrR.Copy();
            imgMixedCpy = imgMixed.Copy();

            var dataChrBCpy = imgChrBCpy.Data;
            var dataChrRCpy = imgChrRCpy.Data;
            var dataMixedCpy = imgMixedCpy.Data;

            int x = e.X, y = e.Y;
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
    }
}
