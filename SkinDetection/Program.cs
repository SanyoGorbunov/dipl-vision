using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkinDetection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FaceColorLib());
            Application.Run(new ShapeInfoLib());
            //Application.Run(new ImageCutter());
            //Application.Run(new TestInclination());
            //Application.Run(new TestEdgeLinking());
            //Application.Run(new TestForm());
            Application.Run(new Start());
        }
    }
}
