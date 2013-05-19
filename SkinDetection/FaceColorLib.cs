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
            }
        }

        #region Select Area on pbFace

        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        private void pbFace_Paint(object sender, PaintEventArgs e)
        {
            if (pbFace.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        private void pbFace_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (Rect.Contains(e.Location))
                {

                }
            }
        }

        private void pbFace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y)
                );
            Rect.Size = new Size(
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

        private double crMean, cbMean, crD, cbD;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<double> cr = new List<double>();
            List<double> cb = new List<double>();
            foreach (var item in lbLib.Items)
            {
                Image<Bgr, Byte> img = new Image<Bgr, byte>(item.ToString());
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
            CalcMeanAndDisp(cr, cb);
            PrintMeanAndDisp();
        }
        private void PrintMeanAndDisp()
        {
            lblRedMeanRes.Text = crMean.ToString("0.0000");
            lblRedDispRes.Text = crD.ToString("0.0000");
            lblBlueMeanRes.Text = crMean.ToString("0.0000");
            lblBlueDispRes.Text = cbD.ToString("0.0000");
        }
        private void CalcMeanAndDisp(List<double> cr, List<double> cb)
        {
            crMean = cr.Average();
            cbMean = cr.Average();
            crD = 0; cbD = 0;
            for (int i = 0; i < cr.Count; i++)
            {
                crD += (cr[i] - crMean) * (cr[i] - crMean);
                cbD += (cb[i] - cbMean) * (cb[i] - cbMean);
            }
            crD /= (cr.Count - 1);
            cbD /= (cb.Count - 1);
        }
    }
}
