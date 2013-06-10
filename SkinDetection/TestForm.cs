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
        private Image<Gray, byte> imgFaceTemplate;
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

        private object opts;
        private void SetOptions()
        {
            ChangRobles cr = alg as ChangRobles;
            WangTan wt = alg as WangTan;
            if (cr != null)
            {
                ChangRoblesOptions crOpts = new ChangRoblesOptions();
                crOpts.FaceTemplate = imgFaceTemplate;
                crOpts.AdaptiveThresholdLower = byte.Parse(txtAdaptiveThresholdLower.Text);
                crOpts.AdaptiveThresholdUpper = byte.Parse(txtAdaptiveThresholdUpper.Text);
                crOpts.AdaptiveThresholdStep = byte.Parse(txtAdaptiveThresholdStep.Text);
                crOpts.SkinRegionMinHoles = int.Parse(txtSkinRegionMinHoles.Text);
                crOpts.SkinRegionMinRatio = double.Parse(txtSkinRegionMinRatio.Text);
                crOpts.SkinRegionMaxRatio = double.Parse(txtSkinRegionMaxRatio.Text);
                crOpts.SkinRegionMinCrossCorellation = double.Parse(txtSkinRegionCrsCrltn.Text);
                opts = crOpts;
            }
            if (wt != null)
            {
                WangTanOptions wtOpts = new WangTanOptions();
                wtOpts.CannyLinkThreshold = byte.Parse(txtCannyLinkThreshold.Text);
                wtOpts.CannyThreshold = byte.Parse(txtCannyThreshold.Text);
                wtOpts.EdgeErasingA = int.Parse(txtEraseChainsA.Text);
                wtOpts.SmoothMedianSize = int.Parse(txtMedianSmoothSize.Text);
                wtOpts.ThresholdPoints = int.Parse(txtTemplateThresholdPoints.Text);
                wtOpts.ThresholdRate = double.Parse(txtTemplateThresholdRate.Text);
                wtOpts.TemplateOpts = new TemplateOptions
                {
                    A = new TemplateOptions.Param
                    {
                        Start = int.Parse(txtTestTemplateAStart.Text),
                        End = int.Parse(txtTestTemplateAEnd.Text),
                        Step = int.Parse(txtTestTemplateAStep.Text)
                    },
                    B = new TemplateOptions.Param
                    {
                        Start = int.Parse(txtTestTemplateBStart.Text),
                        End = int.Parse(txtTestTemplateBEnd.Text),
                        Step = int.Parse(txtTestTemplateBStep.Text)
                    },
                    X0 = new TemplateOptions.Param
                    {
                        Start = int.Parse(txtTestTemplateX0Start.Text),
                        End = int.Parse(txtTestTemplateX0End.Text),
                        Step = int.Parse(txtTestTemplateX0Step.Text)
                    },
                    Y0 = new TemplateOptions.Param
                    {
                        Start = int.Parse(txtTestTemplateY0Start.Text),
                        End = int.Parse(txtTestTemplateY0End.Text),
                        Step = int.Parse(txtTestTemplateY0Step.Text)
                    },
                };
                opts = wtOpts;
            }
        }

        private void Run()
        {
            SetOptions();
            files = Directory.GetFiles(dir);
            fileIndex = 0;
            cTrue = 0;
            cFalse = 0;
            cNotExact = 0;
            Display();
        }

        private void Display()
        {
            if (fileIndex == files.Length)
            {
                Finish();
            }
            else
            {

                var img = new Image<Bgr, byte>(files[fileIndex]);
                var rects = alg.Execute(img, opts);

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
        }

        private void Finish()
        {
            chartResults.Series["SeriesTrue"].Points.AddY(1.0 * cTrue / files.Length);
            chartResults.Series["SeriesNotExact"].Points.AddY(1.0 * cNotExact / files.Length);
            chartResults.Series["SeriesFalse"].Points.AddY(1.0 * cFalse / files.Length);
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
            Finish();
        }

        private void btnLoadFaceTemplate_Click(object sender, EventArgs e)
        {
            if (dlgLoadFaceTemplate.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgFaceTemplate = new Image<Gray, byte>(dlgLoadFaceTemplate.FileName);
            }
        }

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            if (dlgLoadModel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (alg is ChangRobles)
                {
                    alg = ChangRobles.Load(dlgLoadModel.FileName);
                }
            }
        }

        private void cbAlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAlg.SelectedIndex)
            {
                case 0:
                    alg = new ChangRobles();
                    break;
                case 1:
                    alg = new WangTan();
                    break;
            }
        }


    }
}
