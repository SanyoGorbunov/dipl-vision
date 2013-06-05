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

                var imgChrR = new Image<Gray, byte>(img.Size);
                var imgChrB = new Image<Gray, byte>(img.Size);
                var dataChrR = imgChrR.Data;
                var dataChrB = imgChrB.Data;
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        int sum = data[i, j, 0] + data[i, j, 1] + data[i, j, 2];
                        dataChrR[i, j, 0] = (byte) (255.0 * data[i,j,2] / sum);
                        dataChrB[i, j, 0] = (byte)(255.0 * data[i, j, 0] / sum);
                    }
                }
                pbImgChrB.Image = imgChrB.ToBitmap();
                pbImgChrR.Image = imgChrR.ToBitmap();
            }
        }
    }
}
