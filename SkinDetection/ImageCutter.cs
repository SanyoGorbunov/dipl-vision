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
            }
        }
    }
}
