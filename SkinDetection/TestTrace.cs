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
        }

        private void btnLoadTraceLines_Click(object sender, EventArgs e)
        {
            if (dlgLoadTraceLines.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tt.TraceLines = tt.LoadTraceLines(dlgLoadTraceLines.FileName);
            }
        }

        private void btnSaveTraceLines_Click(object sender, EventArgs e)
        {
            if (dlgSaveTraceLines.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tt.SaveTraceLines(tt.TraceLines, dlgSaveTraceLines.FileName);
            }
        }
    }
}
