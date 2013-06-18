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
    public partial class TestTrace : Form
    {
        private TraceTransform tt = new TraceTransform();
        private Image<Gray, byte> imgTest;

        public TestTrace()
        {
            InitializeComponent();
        }

        private void btnConfigTraceLines_Click(object sender, EventArgs e)
        {
            int dist = int.Parse(txtConfigTraceDist.Text);
            int nAngles = int.Parse(txtConfigTraceAngles.Text);
            int width = int.Parse(txtConfigTraceImgWidth.Text);
            int height = int.Parse(txtConfigTraceImgHeight.Text);

            tt.TraceLines = tt.CreateTraceLines(height, width, dist, nAngles);
            tt.NAngles = nAngles;
            tt.Dist = dist;
        }

        private void btnLoadTraceLines_Click(object sender, EventArgs e)
        {
            if (dlgLoadTraceLines.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tt = TraceTransform.LoadTraceLines(dlgLoadTraceLines.FileName);
            }
        }

        private void btnSaveTraceLines_Click(object sender, EventArgs e)
        {
            if (dlgSaveTraceLines.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tt.SaveTraceLines(tt.NAngles, tt.Dist, tt.TraceLines, dlgSaveTraceLines.FileName);
            }
        }

        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            if (dlgLoadTestImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgTest = new Image<Gray, byte>(dlgLoadTestImage.FileName);
                if (chkTestImageIsMask.Checked)
                {
                    imgTest = tt.GetMaskedShape(imgTest);
                }
                pbTestImage.Image = imgTest.ToBitmap();
            }
        }

        private void btnTransformImage_Click(object sender, EventArgs e)
        {
            pbTrasformImage.Image = tt.GetTransformImage(imgTest, tt.Dist, tt.NAngles, tt.TraceLines, TraceTransformFunctional.Sum).ToBitmap();
        }
    }
}
