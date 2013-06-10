using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SkinDetection
{
    public partial class TestForm : Form
    {
        private IAlgorithm alg;

        private string dir;
        private string[] files;
        private int fileIndex;

        private double scale;

        private int cTrue, cNotExact, cFalse;

        public TestForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dlgSelectDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dir = dlgSelectDir.SelectedPath;
                Run();
            }
        }

        private object GetOptions()
        {
            throw new NotImplementedException();
        }

        private void Run()
        {
            files = Directory.GetFiles(dir);
            fileIndex = 0;
            cTrue = 0;
            cFalse = 0;
            cNotExact = 0;
            Display();
        }

        private void Display()
        {
            var img = new Image<Bgr, byte>(files[fileIndex]);
            var rects = alg.Execute(img, GetOptions());

            foreach (var rect in rects)
            {
                img.Draw(rect, new Bgr(Color.Red), 2);
            }

            double xscale = 1.0 * pbImgTest.Width / img.Width;
            double yscale = 1.0 * pbImgTest.Height / img.Height;
            scale = xscale < yscale ? xscale : yscale;

            pbImgTest.Image = img.Resize(scale, Emgu.CV.CvEnum.INTER.CV_INTER_AREA).ToBitmap();

            lblStats.Text = string.Format("{0} from {1}", fileIndex + 1, files.Length);
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            cTrue++;
            fileIndex++;
            Display();
        }

        private void btnInExact_Click(object sender, EventArgs e)
        {
            cNotExact++;
            fileIndex++;
            Display();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            cFalse++;
            fileIndex++;
            Display();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            chartResults.Series["SeriesTrue"].Points.AddY(1.0 * cTrue / files.Length);
            chartResults.Series["SeriesNotExact"].Points.AddY(1.0 * cNotExact / files.Length);
            chartResults.Series["SeriesFalse"].Points.AddY(1.0 * cFalse / files.Length);
        }


    }
}
