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
                var fs = new List<TraceTransformFunctional>();
                fs.Add(TraceTransformFunctional.SimpleSquareRoot); fs.Add(TraceTransformFunctional.Sum);
                //fs.Add(TraceTransformFunctional.Delta);
                var p = db.FindPerson(tt, imgTest, fs);
                pbTestImage.Image = imgTest.ToBitmap();
            }
        }

        private void btnTransformImage_Click(object sender, EventArgs e)
        {
            pbTrasformImage.Image = tt.GetTransformImage(imgTest, tt.Dist, tt.NAngles, tt.TraceLines, TraceTransformFunctional.Sum).ToBitmap();
        }

        private string dbPath;
        private void btnOpenDatabaseDir_Click(object sender, EventArgs e)
        {
            if (dlgOpenDatabaseDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dbPath = dlgOpenDatabaseDir.SelectedPath;
            }
        }

        private TraceTransformDb db;
        private void btnDatabaseLearn_Click(object sender, EventArgs e)
        {
            byte t = byte.Parse(txtDatabaseWeightThreshold.Text);

            List<TraceTransformFunctional> functionals = new List<TraceTransformFunctional>();
            foreach (var item in lbDatabaseFunctionals.CheckedIndices)
            {
                functionals.Add((TraceTransformFunctional)((int)item));
            }

            db = tt.Learn(db, tt, t, functionals);
        }

        private void btnSaveTransforms_Click(object sender, EventArgs e)
        {
            if (dlgSaveTransformed.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveTransformedImages(dlgSaveTransformed.FileName);
            }
        }

        private void btnSaveWeights_Click(object sender, EventArgs e)
        {
            if (dlgSaveWeights.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.SaveWeights(dlgSaveWeights.FileName);
            }
        }

        private void btnDatabaseCreate_Click(object sender, EventArgs e)
        {
            int nImages = int.Parse(txtDatabaseLearnImages.Text);

            db = tt.Create(dbPath, nImages);
        }

        private void btnLoadTransforms_Click(object sender, EventArgs e)
        {
            if (dlgLoadTransforms.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.LoadTransformedImages(dlgLoadTransforms.FileName);
            }
        }

        private void btnLoadWeights_Click(object sender, EventArgs e)
        {
            if (dlgLoadWeights.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void btnTestDb_Click(object sender, EventArgs e)
        {
            List<TraceTransformFunctional> functionals = new List<TraceTransformFunctional>();
            foreach (var item in lbDatabaseFunctionals.CheckedIndices)
            {
                functionals.Add((TraceTransformFunctional)((int)item));
            }


            lblRate.Text = string.Format("Correct Rate: {0}", db.TestDb(dbPath, tt, functionals));
        }
    }
}
