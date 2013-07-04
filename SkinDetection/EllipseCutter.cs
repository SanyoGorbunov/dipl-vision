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
    public partial class EllipseCutter : Form
    {
        private string path;

        private string[] dirs;
        private int dirIndex;

        private string[] files;
        private int fileIndex;

        private string newPath;
        private int numFolders;

        private int x, y, a = 100, b = 120;

        private Image<Bgr, byte> imgCurrent;

        public EllipseCutter()
        {
            InitializeComponent();
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            if (dlgOpenDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = dlgOpenDir.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            numFolders = int.Parse(txtNumFolders.Text);

            if (Directory.Exists(path))
            {
                newPath = path + "/ellipse";
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }

                dirs = Directory.GetDirectories(path);
                dirIndex = 0;
                GetFiles();
            }
        }

        private void GetFiles()
        {
            files = Directory.GetFiles(dirs[dirIndex]);
            fileIndex = 0;
            DisplayImage();
        }

        private void DisplayImage()
        {
            imgCurrent = new Image<Bgr, Byte>(files[fileIndex]);
            pbImg.Image = imgCurrent.ToBitmap();
        }

        private void pbImg_Paint(object sender, PaintEventArgs e)
        {
            if (imgCurrent != null)
            {
                e.Graphics.DrawEllipse(new Pen(Color.White), x, y, a, b);
            }
        }

        private void CutImage()
        {
            Ellipse e = new Ellipse(new PointF(x + a / 2, y + b / 2), new SizeF(b, a), 0);
            Rectangle rect = new Rectangle(new Point(x, y), new Size(a, b));

            var ell = new Image<Bgr, byte>(imgCurrent.Size);
            ell.Draw(new Ellipse(new PointF(x + a / 2, y + b / 2), new SizeF(b, a), 0), new Bgr(Color.White), -1);

            var imgSave = imgCurrent.And(ell);
            imgSave.ROI = rect;
            imgSave = imgSave.Resize(100, 120, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);

            string dirName = Path.GetDirectoryName(files[fileIndex]);
            dirName = dirName.Substring(dirName.LastIndexOf('\\') + 1);
            if (!Directory.Exists(newPath + "/" + dirName))
            {
                Directory.CreateDirectory(newPath + "/" + dirName);
            }
            string newFileName = newPath + "/" + dirName + "/" + Path.GetFileName(files[fileIndex]);
            imgSave.Save(newFileName);

            fileIndex++;
            if (fileIndex == files.Length)
            {
                dirIndex++;
                if (dirIndex != dirs.Length && dirIndex < numFolders)
                {
                    GetFiles();
                }
            }
            else
            {
                DisplayImage();
            }
        }

        private void EllipseCutter_KeyUp(object sender, KeyEventArgs e)
        {
            int inc = chkTens.Checked ? 10 : 1;

            switch (e.KeyData)
            {
                case Keys.Left:
                    x-=inc;
                    break;
                case Keys.Right:
                    x+=inc;
                    break;
                case Keys.Up:
                    y-=inc;
                    break;
                case Keys.Down:
                    y+=inc;
                    break;

                case Keys.A:
                    a-=inc;
                    break;
                case Keys.D:
                    a+=inc;
                    break;
                case Keys.W:
                    b-=inc;
                    break;
                case Keys.S:
                    b+=inc;
                    break;

                case Keys.Enter:

                    CutImage();

                    break;
            }

            pbImg.Invalidate();
        }   
    }
}
