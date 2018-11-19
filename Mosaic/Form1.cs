using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class Form1 : Form
    {
        List<Bitmap> images;
        Bitmap baseImage;
        Bitmap resultImage;
        Bitmap resultImageBW;
        public Form1()
        {
            InitializeComponent();
            tabWizard.Appearance = TabAppearance.FlatButtons;
            tabWizard.ItemSize = new Size(0, 1);
            tabWizard.SizeMode = TabSizeMode.Fixed;
            btnPrevious.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tabWizard.SelectedIndex + 1 < tabWizard.TabCount)
            {
                switch (tabWizard.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (!string.IsNullOrWhiteSpace(txtFolder.Text))
                            {
                                DirectoryInfo dir = new DirectoryInfo(txtFolder.Text);
                                if (dir.Exists)
                                {

                                    // create image list and fill it 
                                    var imageList = new ImageList();
                                    imageList.ImageSize = new Size(100, 100);
                                    imageList.ColorDepth = ColorDepth.Depth32Bit;
                                    images = ImageHelper.ImageHelper.LoadFolder(txtFolder.Text);
                                    imageList.Images.AddRange(images.ToArray());
                                    // tell your ListView to use the new image list
                                    listViewImages.LargeImageList = imageList;
                                    for (int i = 0; i < listViewImages.LargeImageList.Images.Count; i++)
                                    {
                                        listViewImages.Items.Add("", i);
                                    }
                                    tabWizard.SelectTab(tabWizard.SelectedIndex + 1);
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case 1:
                        if (images.Count > 0)
                        {
                            tabWizard.SelectTab(tabWizard.SelectedIndex + 1);
                        }
                        break;
                    case 2:
                        if (baseImage != null)
                        {
                            resultImage = ImageHelper.ImageHelper.ConcatenateImages(
                                 new DirectoryInfo(txtFolder.Text).EnumerateFiles(),
                                3000,
                                3000,
                                167,
                                baseImage,
                                0.5f,
                                false
                                );
                            pbResultImage.Image = resultImage;

                            resultImageBW = ImageHelper.ImageHelper.ConcatenateImages(
                                 new DirectoryInfo(txtFolder.Text).EnumerateFiles(),
                                3000,
                                3000,
                                167,
                                baseImage,
                                0.5f,
                                true
                                );
                            pbResultImageBW.Image = resultImageBW;

                            tabWizard.SelectTab(tabWizard.SelectedIndex + 1);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (tabWizard.SelectedIndex - 1 >= 0)
            {
                tabWizard.SelectedIndex--;
            }

        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void txtFolder_MouseClick(object sender, MouseEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtFolder.Text = dialog.FileName;
            }
        }

        private void tabWizard_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            if (tabWizard.SelectedIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
            if (tabWizard.SelectedIndex == tabWizard.TabCount-1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnBaseImage_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.EnsureFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                baseImage = (Bitmap)Image.FromFile(dialog.FileName);
                pbBaseImage.Image = baseImage;
            }

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.AlwaysAppendDefaultExtension = true;
            dialog.DefaultExtension = "png";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                resultImage.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                resultImageBW.Save(dialog.FileName.Replace(".","-BW."), System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
