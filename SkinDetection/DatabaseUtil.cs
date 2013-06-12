using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkinDetection
{
    public partial class DatabaseUtil : Form
    {
        public DatabaseUtil()
        {
            InitializeComponent();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            if (dlgSelectDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDir.Text = dlgSelectDir.SelectedPath;
            }   
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtCount.Text);
            string dirName = txtNewDir.Text;
            if (!Directory.Exists(txtDir.Text + "/" + dirName))
            {
                Directory.CreateDirectory(txtDir.Text + "/" + dirName);
            }

            List<string> candidates = new List<string>();
            foreach (var dir in Directory.GetDirectories(txtDir.Text))
            {
                foreach (var img in Directory.GetFiles(dir))
                {
                    candidates.Add(img);
                }
            }

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                string src = candidates[r.Next(candidates.Count)];
                File.Copy(src, txtDir.Text + "/" + dirName + "/img" + i + ".jpg");
                candidates.Remove(src);
            }
        }
    }
}
