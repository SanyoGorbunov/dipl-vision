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
    public partial class ShapeInfoLib : Form
    {
        private Image<Bgr, byte> imgTest;
        private Image<Gray, byte> imgActualTest;

        public ShapeInfoLib()
        {
            InitializeComponent();
        }

        private void btnEqualizeTestImage_Click(object sender, EventArgs e)
        {
            imgActualTest = imgTest.Convert<Gray, byte>();
            imgActualTest._EqualizeHist();
            pbTestImage.Image = imgActualTest.ToBitmap();
        }

        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            if (dlgLoadTestImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgTest = new Image<Bgr, byte>(dlgLoadTestImage.FileName);
                pbTestImage.Image = imgTest.ToBitmap();
            }
        }

        private void btnSmoothMedian_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtSmoothMedianSize.Text);
            var imgSmooth = imgActualTest.SmoothMedian(size);
            pbTestImage.Image = imgSmooth.ToBitmap();
        }
    }
}
