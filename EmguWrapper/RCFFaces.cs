using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Cuda;
using System.IO;

namespace EmguWrapper
{
    public class RCFFaces
    {
        public static void GetFaceRectangle(String filePath, String baseFolder)
        {
            IImage image;

            //Read the files as an 8-bit Bgr image  

            image = new UMat(filePath, ImreadModes.Color); //UMat version
                                                             //image = new Mat("lena.jpg", ImreadModes.Color); //CPU version

            long detectionTime = 0;
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            foreach (var face_file in new DirectoryInfo(baseFolder+ "haarcascades").GetFiles("*face*"))
            {
                foreach (var eye_file in new DirectoryInfo(baseFolder + "haarcascades").GetFiles("*eye*"))
                {
                    long currentDetectionTime = 0;
                    DetectFace.Detect(
                      image, face_file.FullName, eye_file.FullName,
                      faces, eyes,
                      out currentDetectionTime);
                    if (faces.Count != 0)
                    {
                        break;
                    }
                    eyes = new List<Rectangle>();
                    detectionTime += currentDetectionTime;

                }
                if (faces.Count != 0)
                {
                    break;
                }
            }

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);

            //display the image 
            using (InputArray iaImage = image.GetInputArray())
                ImageViewer.Show(image, String.Format(
                   "Completed face and eye detection using {0} in {1} milliseconds",
                   (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
                   (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
                   : "CPU",
                   detectionTime));
        }
    }
}
