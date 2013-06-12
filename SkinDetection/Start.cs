﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkinDetection
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnFaceColorLib_Click(object sender, EventArgs e)
        {
            var frm = new FaceColorLib();
            frm.Show();
        }

        private void btnShapeInfo_Click(object sender, EventArgs e)
        {
            var frm = new ShapeInfoLib();
            frm.Show();
        }

        private void btnDatabaseUtil_Click(object sender, EventArgs e)
        {
            var frm = new DatabaseUtil();
            frm.Show();
        }

        private void btnFaceColorModels_Click(object sender, EventArgs e)
        {
            var frm = new FaceColorModelCharts();
            frm.Show();
        }
    }
}
