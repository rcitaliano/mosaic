using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class CutImages : Form
    {
        List<Bitmap> images;
        List<Bitmap> cutImage;
        uint currentIndex;
        public CutImages(string path)
        {
            currentIndex = 0;
            images = ImageHelper.ImageHelper.LoadFolder(path);
            InitializeComponent();
            cutImage = new List<Bitmap>(images.Count);
            pictureBox1.Image = images.ElementAt((int)currentIndex);
        }

        private void CutImages_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            lblY.Text = string.Join(",", new string[] { e.X.ToString(), e.Y.ToString() });
            Point p = pictureBox1.PointToClient(Cursor.Position);
            Point unscaled_p = GetImagePoint(p);
            SetSecondImage(pictureBox1.Image, unscaled_p);
            lblX.Text = unscaled_p.ToString();

            ++currentIndex;
            if (currentIndex == images.Count)
            {
                for (int i = 0; i < cutImage.Count; i++)
                {
                    cutImage.ElementAt(i).Save("image"+i.ToString().PadLeft(5,'0')+".png", System.Drawing.Imaging.ImageFormat.Png);
                }
                currentIndex = 0;
            }

            pictureBox1.Image = images.ElementAt((int)currentIndex);
        }
        private void SetSecondImage(Image image, Point main)
        {
            cutImage.Add(ImageHelper.ImageHelper.CutImage(image, main, 1));
            pictureBox2.Image = cutImage.Last();
        }
        private Point GetImagePoint(Point p)
        {
            Point unscaled_p = new Point();

            // image and container dimensions
            int w_i = pictureBox1.Image.Width;
            int h_i = pictureBox1.Image.Height;
            int w_c = pictureBox1.Width;
            int h_c = pictureBox1.Height;
            float imageRatio = w_i / (float)h_i; // image W:H ratio
            float containerRatio = w_c / (float)h_c; // container W:H ratio

            if (imageRatio >= containerRatio)
            {
                // horizontal image
                float scaleFactor = w_c / (float)w_i;
                float scaledHeight = h_i * scaleFactor;
                // calculate gap between top of container and top of image
                float filler = Math.Abs(h_c - scaledHeight) / 2;
                unscaled_p.X = (int)(p.X / scaleFactor);
                unscaled_p.Y = (int)((p.Y - filler) / scaleFactor);
            }
            else
            {
                // vertical image
                float scaleFactor = h_c / (float)h_i;
                float scaledWidth = w_i * scaleFactor;
                float filler = Math.Abs(w_c - scaledWidth) / 2;
                unscaled_p.X = (int)((p.X - filler) / scaleFactor);
                unscaled_p.Y = (int)(p.Y / scaleFactor);
            }

            return unscaled_p;
        }
    }
}
