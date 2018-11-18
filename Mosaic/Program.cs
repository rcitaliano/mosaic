﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
            //Application.Run(new CutImages("C:\\Users\\Public\\Pictures\\hem nuove"));
            //return;
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\Public\\Pictures\\HEM tagliate");
            //ImageHelper.ImageHelper.TestImage(
            //    (Bitmap)Image.FromFile("base.png"),
            //    0.5f).Save("test.png", System.Drawing.Imaging.ImageFormat.Png);
            ImageHelper.ImageHelper.ConcatenateImages(
                dir.EnumerateFiles(),
                3000,
                3000,
                167,
                (Bitmap)Image.FromFile("base.png"),
                0.5f,
                false
                ).Save("concatenated.png",System.Drawing.Imaging.ImageFormat.Png);
            ImageHelper.ImageHelper.ConcatenateImages(
                dir.EnumerateFiles(),
                3000,
                3000,
                167,
                (Bitmap)Image.FromFile("base.png"),
                0.5f,
                true
                ).Save("concatenatedBW.png", System.Drawing.Imaging.ImageFormat.Png);
            //foreach (var item in dir.GetFiles())
            //{
            //    EmguWrapper.RCFFaces.GetFaceRectangle(item.FullName, "C:\\Source\\fabiana\\Mosaic\\EmguWrapper\\bin\\x64\\Debug\\");
            //}
        }
    }
}
