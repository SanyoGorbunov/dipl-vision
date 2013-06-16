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
        private ChangRobles model = new ChangRobles();

        private Image<Bgr, Byte> imgTest;
        private Image<Gray, Byte> imgLikelihood;
        private Image<Gray, Byte> imgBinary;
        private Image<Gray, Byte> imgFaceTemplate;

        public FaceColorLib()
        {
            InitializeComponent();
        }

        #region Select Area on pbFace

        private List<List<Rectangle>> personRects = new List<List<Rectangle>>();
        private Rectangle tmpRect;

        private Point RectStartPoint;
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        private void pbFace_Paint(object sender, PaintEventArgs e)
        {
            if (pbFace.Image != null && showLib)
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
                showLib = true;
                pbFace.Image = new Bitmap(path);
            }
        }

        #endregion

        #region Lib manipulations

        bool showLib;
        private void btnLibAdd_Click(object sender, EventArgs e)
        {
            if (dlgLibOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbLib.Items.Add(dlgLibOpen.FileName);
                personRects.Add(new List<Rectangle>());
            }
        }

        private void btnSaveLib_Click(object sender, EventArgs e)
        {
            if (dlgSaveLib.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var fileStream = File.OpenWrite(dlgSaveLib.FileName))
                {
                    using (var sw = new StreamWriter(fileStream))
                    {
                        sw.WriteLine(lbLib.Items.Count);
                        for (int i = 0; i < lbLib.Items.Count; i++)
                        {
                            sw.WriteLine(lbLib.Items[i].ToString());
                            sw.WriteLine(personRects[i].Count);
                            for (int j = 0; j < personRects[i].Count; j++)
                            {
                                sw.WriteLine(string.Format("{0} {1} {2} {3}", personRects[i][j].Left,
                                    personRects[i][j].Top, personRects[i][j].Width, personRects[i][j].Height));
                            }
                        }
                    }
                }
            }
        }

        private void btnLoadLib_Click(object sender, EventArgs e)
        {
            if (dlgLoadLib.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbLib.Items.Clear();
                personRects.Clear();
                using (var fileStream = File.OpenRead(dlgLoadLib.FileName))
                {
                    using (var sr = new StreamReader(fileStream))
                    {
                        int cnt = int.Parse(sr.ReadLine());
                        for (int i = 0; i < cnt; i++)
                        {
                            string fileName = sr.ReadLine();
                            lbLib.Items.Add(fileName);
                            personRects.Add(new List<Rectangle>());
                            int rects = int.Parse(sr.ReadLine());
                            for (int j = 0; j < rects; j++)
                            {
                                string[] points = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                personRects[i].Add(new Rectangle(int.Parse(points[0]), int.Parse(points[1]), int.Parse(points[2]), int.Parse(points[3])));
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Color model

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<double> cr = new List<double>();
            List<double> cb = new List<double>();
            for (int k = 0; k < lbLib.Items.Count; k++)
            {
                Image<Bgr, Byte> img = new Image<Bgr, byte>(lbLib.Items[k].ToString());
                img = Utils.ApplyKernel(img, new float[,] {
                    {1f/9, 1f/9, 1f,9},
                    {1f/9, 1f/9, 1f,9},
                    {1f/9, 1f/9, 1f,9}
                });
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

        #endregion

        #region Load test image

        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            if (dlgLoadTestImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                showLib = false;
                imgTest = new Image<Bgr, byte>(dlgLoadTestImage.FileName);
                pbFace.Image = imgTest.ToBitmap();
            }
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

        #endregion

        #region Thresholding

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

        #endregion

        #region Skin Regions

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
                lblSkinRegionRatio.Text = string.Format("Skin Region ratio is {0}.", skinRegions[selectedIndex].Ratio);
            }
        }

        private void btnFilterByHoles_Click(object sender, EventArgs e)
        {
            skinRegions = model.FilterSkinRegionsByHoles(skinRegions);
            FillSkinRegions();
        }

        #endregion

        private void btnLoadFaceTemplate_Click(object sender, EventArgs e)
        {
            if (dlgLoadFaceTemplate.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgFaceTemplate = new Image<Gray, byte>(dlgLoadFaceTemplate.FileName);
                pbFaceTemplate.Image = imgFaceTemplate.ToBitmap();
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(txtAngle.Text);
            pbFaceTemplate.Image = imgFaceTemplate.Rotate(angle, new Gray(0)).ToBitmap();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            int newWidth = int.Parse(txtNewWidth.Text);
            int newHeight = int.Parse(txtNewHeight.Text);
            pbFaceTemplate.Image = imgFaceTemplate.Resize(newWidth, newHeight, Emgu.CV.CvEnum.INTER.CV_INTER_AREA).ToBitmap();
        }

        private Image<Gray, byte> imgFinalTest;
        private void btnShowRegion_Click(object sender, EventArgs e)
        {
            var skinRegion = skinRegions[lbSkinRegions.SelectedIndex];
            imgFinalTest = skinRegion.FindMask(imgTest);
            pbFace.Image = imgFinalTest.ToBitmap();
        }

        private void btnApplyTemplate_Click(object sender, EventArgs e)
        {
            var skinRegion = skinRegions[lbSkinRegions.SelectedIndex];

            double angle = 180 * skinRegion.Inclination / Math.PI;
            double.TryParse(txtAngle.Text, out angle);

            int newWidth = skinRegion.Width;
            int.TryParse(txtNewWidth.Text, out newWidth);
            int newHeight = skinRegion.Height;
            int.TryParse(txtNewHeight.Text, out newHeight);
            var imgCroppedTemplate = imgFaceTemplate.Resize(newWidth, newHeight, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);

            var imgRotatedTemplate = imgCroppedTemplate.Rotate(-angle, new Gray(0));
            var data = imgRotatedTemplate.Data;
            int l = imgRotatedTemplate.Width, t = imgRotatedTemplate.Height, w = 0, h = 0;
            
            for (int i = 0; i < imgRotatedTemplate.Height; i++)
            {
                for (int j = 0; j < imgRotatedTemplate.Width; j++)
                {
                    if (data[i, j, 0] > 0)
                    {
                        if (j < l)
                        {
                            l = j;
                        }
                        if (j > w)
                        {
                            w = j;
                        }
                        if (i < t)
                        {
                            t = i;
                        }
                        if (i > h)
                        {
                            h = i;
                        }
                    }
                }
            }
            w -= l;
            h -= t;

            imgCroppedTemplate = imgRotatedTemplate.GetSubRect(new Rectangle(l, t, w, h));

            data = imgCroppedTemplate.Data;
            int x = 0, y = 0, area = 0;
            for (int i = 0; i < imgCroppedTemplate.Height; i++)
            {
                for (int j = 0; j < imgCroppedTemplate.Width; j++)
                {
                    if (data[i, j, 0] > 0)
                    {
                        x += j;
                        y += i;
                        area++;
                    }
                }
            }
            x /= area;
            y /= area;

            int tx = skinRegion.Left + skinRegion.Centroid.X - x,
                ty = skinRegion.Top + skinRegion.Centroid.Y - y;
            tx = tx >= 0 ? tx : 0;
            ty = ty >= 0 ? ty : 0;
            tx = (tx + newWidth <= imgFinalTest.Width) ? tx : (imgFinalTest.Width - newWidth);
            ty = (ty + newHeight <= imgFinalTest.Height) ? ty : (imgFinalTest.Height - newHeight);

            var imgFinalTemplate = new Image<Gray, byte>(imgTest.Size);
            imgFinalTemplate.ROI = new Rectangle(tx, ty, imgCroppedTemplate.Width, imgCroppedTemplate.Height);
            CvInvoke.cvCopy(imgCroppedTemplate, imgFinalTemplate, IntPtr.Zero);
            CvInvoke.cvResetImageROI(imgFinalTemplate);
            pbFace.Image = imgFinalTemplate.ToBitmap();

            var match = imgFinalTest.MatchTemplate(imgFinalTemplate, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCORR_NORMED);
            lblCrossCorellationValue.Text = match.Data[0, 0, 0].ToString();
        }

        private void btnFilterByRatio_Click(object sender, EventArgs e)
        {
            skinRegions = skinRegions.Where(sr => sr.Ratio >= 0.8 && sr.Ratio <= 1.6).ToList();
            FillSkinRegions();
        }

        private void btnFilterByTemplate_Click(object sender, EventArgs e)
        {
            skinRegions = skinRegions.Where(sr => model.MatchTemplate(imgTest, sr, imgFaceTemplate) >= 0.7).ToList();
            FillSkinRegions();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var imgResult = imgTest.Clone();
            foreach (var rect in model.Execute(imgTest, imgFaceTemplate))
            {
                imgResult.Draw(rect, new Bgr(Color.Red), 2);
            }
            pbFace.Image = imgResult.ToBitmap();
        }

        private void btnLibAddDir_Click(object sender, EventArgs e)
        {
            if (dlgLibOpenDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var file in Directory.GetFiles(dlgLibOpenDir.SelectedPath))
                {
                    lbLib.Items.Add(file);
                    personRects.Add(new List<Rectangle>());
                }
            }
        }

    }
}
