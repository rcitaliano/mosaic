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
        public static Bitmap TestImage()
        {
            int amountOfImages = 144;
            int size = 30;
            Bitmap flag = new Bitmap(
                amountOfImages * size,
                amountOfImages * size);
            Graphics flagGraphics = Graphics.FromImage(flag);
            var localWidth = 0;
            var localHeight = 0;
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
                localWidth += size;
            }
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
                list.Add(current);
                if (max_w < current.Width)
                {
                    max_w = current.Width;
                }
                if (max_h < current.Height)
                {
                    max_h = current.Height;
                }
            }
            height /= imageCount;
            width /= imageCount;
            int square  = (int)(Math.Ceiling( Math.Sqrt(imageCount)));
            //newBitmap = new Bitmap(finalWidth, finalHeight);
            newBitmap = new Bitmap(baseImage.Width,baseImage.Height);
            using (var g = Graphics.FromImage(newBitmap))
            {
                // Create solid brush.
                g.Clear(Color.White);
                var localWidth = 0;
                var localHeight = 0;
                int index = 0;
                while (localHeight < newBitmap.Height)
                {
                    g.DrawImage(list[index],
                        new Rectangle(new Point(localWidth, localHeight), new Size(imageSize, imageSize))
                        );
                    localWidth += imageSize;
                    index++;
                    if (index == files.Count())
                    {
                        index = 0;
                    }
                    if (localWidth > newBitmap.Width)
                    {
                        localWidth = 0;
                        localHeight += imageSize;
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
                    new Rectangle(0, 0, baseImage.Width, baseImage.Height), 
                    0, 0, baseImage.Width, baseImage.Height, 
                    GraphicsUnit.Pixel,
                    attributes);

            }
            return newBitmap;
        }
    }
}
