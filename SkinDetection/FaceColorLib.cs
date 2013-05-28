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
    public partial class FaceColorLib : Form
    {
        public FaceColorLib()
        {
            InitializeComponent();
        }

        private void btnLibAdd_Click(object sender, EventArgs e)
        {
            if (dlgLibOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbLib.Items.Add(dlgLibOpen.FileName);
                personRects.Add(new List<Rectangle>());
            }
        }

        #region Select Area on pbFace

        private List<List<Rectangle>> personRects = new List<List<Rectangle>>();
        private Rectangle tmpRect;

        private Point RectStartPoint;
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        private void pbFace_Paint(object sender, PaintEventArgs e)
        {
            if (pbFace.Image != null)
            {
                if (!tmpRect.IsEmpty)
                {
                    e.Graphics.FillRectangle(selectionBrush, tmpRect);
                }
                if (lbLib.SelectedIndex > -1)
                {
                    foreach (var Rect in personRects[lbLib.SelectedIndex])
                    {
                        if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                        {
                            e.Graphics.FillRectangle(selectionBrush, Rect);
                        }
                    }
                }
            }
        }

        private void pbFace_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point tempEndPoint = e.Location;

                var Rect = new Rectangle();
                Rect.Location = new Point(
                    Math.Min(RectStartPoint.X, tempEndPoint.X),
                    Math.Min(RectStartPoint.Y, tempEndPoint.Y)
                    );
                Rect.Size = new Size(
                    Math.Abs(RectStartPoint.X - tempEndPoint.X),
                    Math.Abs(RectStartPoint.Y - tempEndPoint.Y)
                    );

                if (lbLib.SelectedIndex > -1)
                {
                    personRects[lbLib.SelectedIndex].Add(Rect);
                }
                tmpRect = new Rectangle();
            }
        }

        private void pbFace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }
            Point tempEndPoint = e.Location;

            tmpRect = new Rectangle();
            tmpRect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y)
                );
            tmpRect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y)
                );

            pbFace.Invalidate();
        }

        private void pbFace_MouseDown(object sender, MouseEventArgs e)
        {
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void lbLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = lbLib.SelectedItem.ToString();
            if (File.Exists(path))
            {
                pbFace.Image = new Bitmap(path);
            }
        }

        #endregion

        private ChangRobles model = new ChangRobles();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<double> cr = new List<double>();
            List<double> cb = new List<double>();
            for (int k = 0; k < lbLib.Items.Count; k++)
            {
                Image<Bgr, Byte> img = new Image<Bgr, byte>(lbLib.Items[k].ToString());
                foreach (var Rect in personRects[k])
                {
                    for (int i = Rect.Top; i < Rect.Top + Rect.Height; i++)
                    {
                        for (int j = Rect.Left; j < Rect.Left + Rect.Width; j++)
                        {
                            double s = img[i, j].Red + img[i, j].Green + img[i, j].Blue;
                            double r = img[i, j].Red / s;
                            double b = img[i, j].Blue / s;
                            cr.Add(r);
                            cb.Add(b);
                        }
                    }   
                }
            }
            model.SetModel(cr, cb);
            PrintColorModel();
        }

        private void PrintColorModel()
        {
            lblMean.Text = string.Format("{0:0.000000} {1:0.000000}", model.Mean.a1, model.Mean.a2);
            lblCov1.Text = string.Format("{0:0.000000} {1:0.000000}", model.Covariance.a, model.Covariance.b);
            lblCov2.Text = string.Format("{0:0.000000} {1:0.000000}", model.Covariance.c, model.Covariance.d);
        }

        private void btnSaveColorModel_Click(object sender, EventArgs e)
        {
            if (dlgSaveColorModel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                model.Save(dlgSaveColorModel.FileName);
            }
        }

        private void btnLoadColorModel_Click(object sender, EventArgs e)
        {
            if (dlgLoadColorModel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                model = ChangRobles.Load(dlgLoadColorModel.FileName);
                PrintColorModel();
            }
        }

        private Image<Bgr, Byte> imgTest;
        private Image<Gray, Byte> imgLikelihood;
        private Image<Gray, Byte> imgBinary;
        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            if (dlgLoadTestImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgTest = new Image<Bgr, byte>(dlgLoadTestImage.FileName);
                pbFace.Image = imgTest.ToBitmap();
            }
        }

        private void btnDisplayLikelihood_Click(object sender, EventArgs e)
        {
            imgLikelihood = model.GetLikelihoodImage(imgTest);
            pbFace.Image = imgLikelihood.ToBitmap();
        }

        private void btnSetTreshold_Click(object sender, EventArgs e)
        {
            byte bound = byte.Parse(txtTreshBound.Text);
            imgBinary = model.GetBinaryThreshold(imgLikelihood, bound);
            pbFace.Image = imgBinary.ToBitmap();
        }

        private void btnRunThresh_Click(object sender, EventArgs e)
        {
            imgBinary = model.GetAdaptiveBinaryThreshold(imgLikelihood);
            pbFace.Image = imgBinary.ToBitmap();
        }

        private List<SkinRegion> skinRegions;
        private void btnFindSkinRegions_Click(object sender, EventArgs e)
        {
            skinRegions = model.GetSkinRegions(imgBinary);
            FillSkinRegions();
        }
        private void FillSkinRegions()
        {
            lbSkinRegions.Items.Clear();
            for (int i = 0; i < skinRegions.Count; i++)
            {
                lbSkinRegions.Items.Add("SkinRegion #" + i);
            }
        }

        private void lbSkinRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbSkinRegions.SelectedIndex;
            if (skinRegions != null && selectedIndex >= 0 && selectedIndex < skinRegions.Count)
            {
                pbFace.Image = skinRegions[selectedIndex].Region.ToBitmap();

                lblSkinRegionPixels.Text = string.Format("Skin Region has {0} pixels.", skinRegions[selectedIndex].Pixels);
                lblSkinRegionLeft.Text = string.Format("Skin Region Left is {0}.", skinRegions[selectedIndex].Left);
                lblSkinRegionWidth.Text = string.Format("Skin Region Width is {0}.", skinRegions[selectedIndex].Width);
                lblSkinRegionTop.Text = string.Format("Skin Region Top is {0}.", skinRegions[selectedIndex].Top);
                lblSkinRegionHeight.Text = string.Format("Skin Region Height is {0}.", skinRegions[selectedIndex].Height);
                lblSkinRegionHoles.Text = string.Format("Skin Region has {0} holes.", skinRegions[selectedIndex].Holes);
                lblSkinRegionCentroid.Text = string.Format("Skin Region centroid is ({0},{1}).", skinRegions[selectedIndex].Centroid.X, skinRegions[selectedIndex].Centroid.Y);
                lblSkinRegionInclination.Text = string.Format("Skin Region inclination is {0}.", skinRegions[selectedIndex].Inclination);
            }
        }

        private void btnFilterByHoles_Click(object sender, EventArgs e)
        {
            skinRegions = model.FilterSkinRegionsByHoles(skinRegions);
            FillSkinRegions();
        }

        private void btnApplyKernel_Click(object sender, EventArgs e)
        {
            float[,] k = new float[,] {
                {1f/9, 1f/9, 1f,9},
                {1f/9, 1f/9, 1f,9},
                {1f/9, 1f/9, 1f,9}
            };

            imgTest = Utils.ApplyKernel(imgTest, k);
            pbFace.Image = imgTest.ToBitmap();
        }
    }
}
