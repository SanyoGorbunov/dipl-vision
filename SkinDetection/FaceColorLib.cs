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

            }
        }
    }
}
