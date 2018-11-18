using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageHelper
{
    public class ImageHelper
    {
        public static Bitmap ConvertToGrayScale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
         new float[] {.3f, .3f, .3f, 0, 0},
         new float[] {.59f, .59f, .59f, 0, 0},
         new float[] {.11f, .11f, .11f, 0, 0},
         new float[] {0, 0, 0, 1, 0},
         new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }
        public static Bitmap TestImage(Bitmap baseImage,
            float opacity,
            int amountOfImages = 132,
            int size = 167)
        {
            Bitmap flag = new Bitmap(
                size * 12,
                size * 11);
            Graphics flagGraphics = Graphics.FromImage(flag);
            var localWidth = 0;
            var localHeight = 0;
            int index = 1;
            while (localHeight < flag.Height)
            {
                if (localWidth + size > flag.Width)
                {
                    localWidth = 0;
                    localHeight += size;
                }
                Color color = Color.FromArgb(
                    localWidth * 255 / (flag.Width),
                    localHeight * 255 / (flag.Width),
                    localWidth * 255 / (flag.Width));
                flagGraphics.FillRectangle(
                    new SolidBrush(color), 
                    new Rectangle(new Point(localWidth, localHeight), new Size(size, size))
                    );
                flagGraphics.DrawString(
                    index.ToString(),
                    new Font("arial", 16f),
                    new SolidBrush(Color.Black),
                    new Rectangle(new Point(localWidth, localHeight), new Size(size, size)));
                localWidth += size;
                index++;
            }

            //create a color matrix object  
            ColorMatrix matrix = new ColorMatrix();

            //set the opacity  
            matrix.Matrix33 = opacity;

            //create image attributes  
            ImageAttributes attributes = new ImageAttributes();

            //set the color(opacity) of the image  
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            flagGraphics.DrawImage(baseImage,
                new Rectangle(
                    (flag.Width/2)- baseImage.Width/2, 
                    (flag.Height/2) - baseImage.Height/2,
                    baseImage.Width, 
                    baseImage.Height),
                0, 0, baseImage.Width, baseImage.Height,
                GraphicsUnit.Pixel,
                attributes);
            return flag;
        }
        public static Bitmap ConcatenateImages(IEnumerable<FileInfo> files,
            int finalWidth,
            int finalHeight,
            int imageSize,
            Bitmap baseImage,
            float opacity,
            bool grayScale)
        {
            Bitmap newBitmap;
            int imageCount = files.Count();
            List<Bitmap> list = new List<Bitmap>(imageCount);
            int height = 0;
            int width = 0;
            int max_w = 0;
            int max_h = 0;
            foreach (var file in files)
            {
                Bitmap current = (Bitmap)Image.FromFile(file.FullName);
                height += current.Height;
                width += current.Width;
                if (grayScale)
                {
                    list.Add(ImageHelper.ConvertToGrayScale(current));
                }
                else
                {
                    list.Add(current);
                }
                if (max_w < current.Width)
                {
                    max_w = current.Width;
                }
                if (max_h < current.Height)
                {
                    max_h = current.Height;
                }
            }
            int rows = (int) Math.Ceiling(Math.Sqrt(imageCount));
            int columns = (int)Math.Ceiling(Math.Sqrt(imageCount));
            height /= imageCount;
            width /= imageCount;
            int square  = (int)(Math.Ceiling( Math.Sqrt(imageCount)));
            //newBitmap = new Bitmap(finalWidth, finalHeight);
            newBitmap = new Bitmap(imageSize*columns, imageSize*rows);
            using (var g = Graphics.FromImage(newBitmap))
            {
                // Create solid brush.
                g.Clear(Color.White);
                var localWidth = 0;
                var localHeight = 0;
                int index = 0;
                while (localHeight < newBitmap.Height)
                {
                    if (localWidth + imageSize > newBitmap.Width)
                    {
                        localWidth = 0;
                        localHeight += imageSize;
                    }
                    g.DrawImage(list[index],
                        new Rectangle(new Point(localWidth, localHeight), new Size(imageSize, imageSize))
                        );
                    localWidth += imageSize;
                    index++;
                    if (index == list.Count)
                    {
                        index = 0;
                    }
                }
                //create a color matrix object  
                ColorMatrix matrix = new ColorMatrix();

                //set the opacity  
                matrix.Matrix33 = opacity;

                //create image attributes  
                ImageAttributes attributes = new ImageAttributes();

                //set the color(opacity) of the image  
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(baseImage,
                    new Rectangle(
                        (newBitmap.Width / 2) - baseImage.Width / 2,
                        (newBitmap.Height / 2) - baseImage.Height / 2,
                        baseImage.Width,
                        baseImage.Height),
                    0, 0, baseImage.Width, baseImage.Height,
                    GraphicsUnit.Pixel,
                    attributes);

            }
            return newBitmap;
        }
        public static List<Bitmap> LoadFolder(string path)
        {
            List<Bitmap> list = new List<Bitmap>();
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                // load the files
                foreach (var file in dir.EnumerateFiles())
                {
                    if (file.Exists)
                    {
                        try
                        {
                            list.Add((Bitmap)Image.FromFile(file.FullName));
                        }
                        catch (Exception)
                        {
                            //just skip this image
                        }
                    }
                }
            }
            return list;
        }

        public static Bitmap CutImage(Image image, Point main, float aspectRatio)
        {
            var imageSize = image.Size;
            Size newSize;
            Point newMain = main;

            // calculate the new main point
            if (imageSize.Height >= imageSize.Width)
            {
                newSize = new Size(imageSize.Width, imageSize.Width);
                
                newMain.Y -= newSize.Height / 2;
                if (newMain.Y < 0)
                {
                    newMain.Y = 0;
                }
                else if (newMain.Y+ newSize.Height > imageSize.Height)
                {
                    newMain.Y = imageSize.Height - newSize.Height;
                }
                newMain.X = 0;
            }
            else
            {
                newSize = new Size(imageSize.Height, imageSize.Height);
                newMain.X -= newSize.Width / 2;
                if (newMain.X < 0)
                {
                    newMain.X = 0;
                }
                else if (newMain.X + newSize.Width > imageSize.Width)
                {
                    newMain.Y = imageSize.Width - newSize.Width;
                }
                newMain.Y = 0;
            }
            Bitmap cut = new Bitmap(newSize.Width,newSize.Height);
            Graphics g = Graphics.FromImage(cut);
            g.DrawImage(image,
                new Rectangle(new Point(0, 0), newSize),
                new Rectangle(newMain, newSize),
                GraphicsUnit.Pixel);
            return cut;
        }
    }
}
