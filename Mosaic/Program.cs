using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic
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
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\Public\\Pictures\\HeM FOTOS");
            foreach (var item in dir.GetFiles())
            {
                EmguWrapper.RCFFaces.GetFaceRectangle(item.FullName, "C:\\Source\\fabiana\\Mosaic\\EmguWrapper\\bin\\x64\\Debug\\");
            }
        }
    }
}
