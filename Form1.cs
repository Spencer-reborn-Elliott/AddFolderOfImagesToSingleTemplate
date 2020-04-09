using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace ImageResizerAndLogoAdder
{
    public partial class Form1 : Form
    {
        DirectoryInfo InputFolderDir;
        bool InputFolderSet = false;
        string TemplatePath = "";
        bool TemplatePathSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (InputFolderSet == true)
            {

                if (TemplatePathSet == true)
                {
                    Convert();
                    WarningMessage.Text = "";
                }
                else
                {
                    WarningMessage.Text = "You must choose the master file first.";
                }
            }
            else
            {
                WarningMessage.Text = "You must set the input folder first before trying to convert files.";
            }
        }



        void Convert()
        {
            var ext = new List<string> { ".jpg", ".gif", ".png" };
            if (IncludeSubDirsCheck.Checked == true)
            {
                foreach (var file in InputFolderDir.GetFiles("*.*", SearchOption.AllDirectories).Where(s => ext.Contains(Path.GetExtension(s.FullName).ToLowerInvariant())))
                {
                    using (var srcImage = Image.FromFile(TemplatePath.ToString()))
                    {
                        using (var newImage = new Bitmap(srcImage.Width, srcImage.Height))
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.DrawImage(srcImage, new Rectangle(0, 0, srcImage.Width, srcImage.Height));

                            using (Image watermarkImage = Image.FromFile(file.FullName))
                            using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                            {
                                watermarkBrush.TranslateTransform((int)Xaxis.Value, (int)Yaxis.Value);
                                //graphics.FillRectangle(watermarkBrush, new Rectangle(new Point((int)XaxisPos.Value, (int)yAxisPos.Value), new Size((int)Xaxis.Value, (int)Yaxis.Value)));
                                graphics.DrawImage(watermarkImage, new Rectangle(new Point((int)XaxisPos.Value, (int)yAxisPos.Value), new Size((int)Xaxis.Value, (int)Yaxis.Value)));
                            }
                            newImage.Save("Merged_" + file.ToString() + ".JPEG", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                }
            }
            else
            {
                foreach (var file in InputFolderDir.GetFiles("*.*", SearchOption.AllDirectories).Where(s => ext.Contains(Path.GetExtension(s.FullName).ToLowerInvariant())))
                {
                    using (var srcImage = Image.FromFile(TemplatePath.ToString()))
                    {
                        using (var newImage = new Bitmap(srcImage.Width, srcImage.Height))
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.DrawImage(srcImage, new Rectangle(0, 0, srcImage.Width, srcImage.Height));

                            using (Image watermarkImage = Image.FromFile(file.FullName))
                            using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                            {
                                watermarkBrush.TranslateTransform((int)Xaxis.Value, (int)Yaxis.Value);
                                //graphics.FillRectangle(watermarkBrush, new Rectangle(new Point((int)XaxisPos.Value, (int)yAxisPos.Value), new Size((int)Xaxis.Value, (int)Yaxis.Value)));
                                graphics.DrawImage(watermarkImage, new Rectangle(new Point((int)XaxisPos.Value, (int)yAxisPos.Value), new Size((int)Xaxis.Value, (int)Yaxis.Value)));
                            }
                            newImage.Save("Merged_" + file.ToString() + ".JPEG", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                }
            }
        }


        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = InputFolder.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(InputFolder.SelectedPath))
            {
                InputFolderDir = new DirectoryInfo(InputFolder.SelectedPath);
                InputFolderSet = true;
            }
        }

        private void ChooseLogoBtn_Click(object sender, EventArgs e)
        {
            TemplateChooser.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            TemplateChooser.FileName = "";
            DialogResult result = TemplateChooser.ShowDialog();
            TemplatePath = TemplateChooser.FileName.ToString();
            TemplatePathSet = true;
        }

    }
}
