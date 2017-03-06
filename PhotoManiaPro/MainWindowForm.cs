using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Accord.Vision.Detection;
using MetroFramework.Forms;
using Accord.Vision.Detection.Cascades;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System.Drawing.Drawing2D;


namespace PhotoManiaPro
{
    public partial class MainWindowForm : MetroForm
    {
        public class MyDataObj
        {
            public int x { get; set; }
            public int y { get; set; }
            public int h { get; set; }

            public int w { get; set; }
        }




        public int yPosition;
        public int xPosition;
        public int height;
        public int width;

        private string[] _filePathNames;
        private int _index;
        private string _currentImagePath;
        readonly private HaarObjectDetector _detector;
        private Rectangle[] _faceObjects;
        private FileInfo _fileInfo;
        private bool _isSlideShowOn;
        private FileSize _size;

        private Bitmap sourceImage;
        private Bitmap filteredImage;


        private void LoadTheme()
        {
            // Main Form
            Style = Properties.Settings.Default.AppStyle;

            // Textboxes
            /*TxtHorizontalResolution.Style = Properties.Settings.Default.AppStyle;
            TxtImageHeight.Style = Properties.Settings.Default.AppStyle;
            TxtImageName.Style = Properties.Settings.Default.AppStyle;
            TxtImageSize.Style = Properties.Settings.Default.AppStyle;
            TxtImageType.Style = Properties.Settings.Default.AppStyle;
            TxtImageWidth.Style = Properties.Settings.Default.AppStyle;
            TxtPalletteFlags.Style = Properties.Settings.Default.AppStyle;
            TxtPixelFormat.Style = Properties.Settings.Default.AppStyle;
            TxtRawFormat.Style = Properties.Settings.Default.AppStyle;
            TxtVerticalResolution.Style = Properties.Settings.Default.AppStyle;

            // Labels
            metroLabel1.Style = Properties.Settings.Default.AppStyle;
            metroLabel2.Style = Properties.Settings.Default.AppStyle;
            metroLabel3.Style = Properties.Settings.Default.AppStyle;
            metroLabel4.Style = Properties.Settings.Default.AppStyle;
            metroLabel5.Style = Properties.Settings.Default.AppStyle;
            metroLabel6.Style = Properties.Settings.Default.AppStyle;
            metroLabel7.Style = Properties.Settings.Default.AppStyle;
            metroLabel8.Style = Properties.Settings.Default.AppStyle;
            metroLabel9.Style = Properties.Settings.Default.AppStyle;
            metroLabel10.Style = Properties.Settings.Default.AppStyle;
            metroLabel11.Style = Properties.Settings.Default.AppStyle;
            metroLabel12.Style = Properties.Settings.Default.AppStyle;*/
        }

        public MainWindowForm()
        {
            InitializeComponent();
            LoadTheme();
            var cascade = new FaceHaarCascade();
            _detector = new HaarObjectDetector(cascade, 30)
            {
                SearchMode = ObjectDetectorSearchMode.Average,
                ScalingFactor = 1.5f,
                ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller,
                UseParallelProcessing = true,
                Suppression = 3
            };
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do You want to quit", "Really Quit?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }
            Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                _currentImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;

                sourceImage = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                pictureBox1.Image = sourceImage;
                //GetImageDetails();
            }
            catch (Exception)
            {
                MessageBox.Show(this,
                    "There Was Error Processing your file.\nFile is not a valid image file",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {  
            //panel2.Location = tableLayoutPanel2.Location;
            // panel2.Location = new Point(672, 3);
            //tableLayoutPanel2.Visible = false;
            // File Chooser Dialog Setup
            openFileDialog.Multiselect = false;
            //openFileDialog.Filter =
            //     "ALL Files (*.*)|*.*" + "JPEG Files (*.jpeg)|*.jpeg|" +
            //                        "BMP Files (*.bmp)|*.bmp|" +
            //                        "JPG Files (*.jpg)|*.jpg|" +
            //                        "PNG Files (*.png)|*.png|";
            this.openFileDialog.Filter = "Image files (*.jpg,*.png,*.tif,*.bmp,*.gif)|*.jpg;*.png;*.tif;*.bmp;*.gif|JPG fil" +
                "es (*.jpg)|*.jpg|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|BMP files (*.bm" +
                "p)|*.bmp|GIF files (*.gif)|*.gif";
            this.openFileDialog.Title = "Open image";
            openFileDialog.FileName = "Select A Valid Picture File";
            openFileDialog.Title = "Photo Mania Pro Picture Selector";
            // openFileDialog.InitialDirectory = "C:";

            // Folder Chooser Dialog Setup
            folderBrowserDialog.Description = "Select a folder containing image files";
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                _index = 0;
                _filePathNames = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                try
                {
                    _currentImagePath = _filePathNames[_index];
                    pictureBox1.ImageLocation = _filePathNames[_index];
                }
                catch (Exception)
                {
                    MessageBox.Show(this,
                       "There Was Error Processing your file.\nFile is not a valid image file",
                       "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NextPicture()
        {
            try
            {
                if (_index == _filePathNames.Length - 1)
                {
                    _index = -1;
                }
                _index++;
                _currentImagePath = _filePathNames[_index];
                pictureBox1.ImageLocation = _filePathNames[_index];
            }
            catch (Exception)
            {
                //
            }
        }

        private void PreviousPicture()
        {
            try
            {
                if (_index == 0)
                {
                    _index = _filePathNames.Length;
                }
                _index--;
                _currentImagePath = _filePathNames[_index];
                pictureBox1.ImageLocation = _filePathNames[_index];
            }
            catch (Exception)
            {
                //
            }
        }

        private void ZoomPictureAndRedraw()
        {
            throw new NotImplementedException("Function is currently not implemented");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                PreviousPicture();
            }// sourceImage = (Bitmap)Bitmap.FromStream(pictureBox.ImageLocation);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                NextPicture();
                // sourceImage = (Bitmap)Bitmap.FromFile(pictureBox.Image);
            }
        }
        private void DetectFaces()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show(this, "Open Image file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var bit = new Bitmap(pictureBox1.Image);
            _faceObjects = _detector.ProcessFrame(bit);
            MessageBox.Show(this,
                "Face[s] detectes -> " + _faceObjects.Length,
                "Face Detection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            var graphics = Graphics.FromImage(pictureBox1.Image);
            foreach (var face in _faceObjects)
            {
                graphics.DrawRectangle(Pens.Red, face);
            }
            graphics.Dispose();
            pictureBox1.Invalidate();
        }

        private void faceDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetectFaces();
        }

        /*private void GetImageDetails()
        {
            TxtImageName.Text = Path.GetFileNameWithoutExtension(pictureBox2.ImageLocation);
            TxtImageType.Text = Path.GetExtension(pictureBox2.ImageLocation);
            _fileInfo = new FileInfo(pictureBox2.ImageLocation);

            _size = FileSizeSuffixRetriever.GetSuffix(_fileInfo.Length);
            TxtImageSize.Text = String.Format("{0} {1}", _size.Size, _size.Suffix);

             TxtImageWidth.Text = pictureBox2.Image.Width.ToString();
             TxtImageHeight.Text = pictureBox2.Image.Height.ToString();
             TxtVerticalResolution.Text = pictureBox2.Image.VerticalResolution.ToString();
             TxtHorizontalResolution.Text = pictureBox2.Image.HorizontalResolution.ToString();
             TxtPixelFormat.Text = pictureBox2.Image.PixelFormat.ToString();
             TxtRawFormat.Text = pictureBox2.Image.RawFormat.ToString();
             TxtPalletteFlags.Text = pictureBox2.Image.Palette.Flags.ToString();
             _fileInfo = null;
        }*/

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            else
            {
                System.GC.Collect();
                //GetImageDetails();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void BtnSlideshow_Click(object sender, EventArgs e)
        {
            if (_isSlideShowOn)
            {
                BtnSlideshow.Text = "Slideshow ON";
                _isSlideShowOn = false;
                timer.Stop();
            }
            else
            {
                BtnSlideshow.Text = "Slideshow OFF";
                _isSlideShowOn = true;
                timer.Start();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                if (MessageBox.Show(this, "Are you sure to delete this picture?\nImage once deleted cannot be recovered",
                    "Delete? Read Carefully",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    pictureBox1.Image = null;
                    File.Delete(pictureBox1.ImageLocation);
                }
                else
                {
                    return;
                }
            }
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            LevelsLinear filter = new LevelsLinear();

            filter.InRed = new IntRange(30, 230);
            filter.InGreen = new IntRange(50, 240);
            filter.InBlue = new IntRange(10, 210);

            ApplyFilter(filter);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //  ApplyFilter(Grayscale.CommonAlgorithms.BT709);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                Bitmap temp = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)temp.Clone();
                Color c;
                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                        bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    }
                }
                temp = (Bitmap)bmap.Clone();
                pictureBox1.Image = temp;
            }
        }

        private void ApplyFilter(IFilter filter)
        {
            ClearCurrentImage();
            // apply filter
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
                filteredImage = filter.Apply(sourceImage);
            // display filtered image
            pictureBox1.Image = filteredImage;
        }

        private void ClearCurrentImage()
        {
            // clear current image from picture box
            //  pictureBox.Image = null;
            // free current image

            //filteredImage.Dispose();
            //filteredImage = null;

            // uncheck all menu items

        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = sourceImage;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }

           //ApplyFilter(new Sepia());
            else
            {
                Bitmap temp1 = sourceImage;
                Bitmap bmp = temp1;

                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    System.Drawing.Imaging.PixelFormat.Format32bppRgb);

                IntPtr ptr = bmpData.Scan0;

                int numPixels = bmpData.Width * bmp.Height;
                int numBytes = numPixels * 4;
                byte[] rgbValues = new byte[numBytes];

                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, numBytes);
                for (int i = 0; i < rgbValues.Length; i += 4)
                {
                    rgbValues[i + 2] = (byte)((.393 * rgbValues[i + 2]) + (.769 * rgbValues[i + 1]) + (.189 * (rgbValues[i + 0]))); //red
                    rgbValues[i + 1] = (byte)((.349 * rgbValues[i + 2]) + (.686 * rgbValues[i + 1]) + (.168 * (rgbValues[i + 0]))); //green
                    rgbValues[i + 0] = (byte)((.272 * rgbValues[i + 2]) + (.534 * rgbValues[i + 1]) + (.131 * (rgbValues[i + 0]))); //blue

                    if ((rgbValues[i + 2]) > 255)
                    {
                        rgbValues[i + 2] = 255;
                    }

                    if ((rgbValues[i + 1]) > 255)
                    {
                        rgbValues[i + 1] = 255;
                    }
                    if ((rgbValues[i + 0]) > 255)
                    {
                        rgbValues[i + 0] = 255;
                    }
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, numBytes);
                this.Invalidate();
                bmp.UnlockBits(bmpData);
                Bitmap temp = bmp;

                pictureBox1.Image = temp;

            }

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            //ApplyFilter(new Invert());
            else
            {
                Bitmap temp = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)temp.Clone();
                Color c;
                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        bmap.SetPixel(i, j,
          Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                    }
                }
                temp = (Bitmap)bmap.Clone();
                pictureBox1.Image = temp;
            }
        }


        private void metroButton11_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ColorFiltering(new IntRange(25, 230), new IntRange(25, 230), new IntRange(25, 230)));

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateChannels());
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            ApplyFilter(new HueModifier(50));

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

            ApplyFilter(new SaturationCorrection(0.15f));
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            //  ApplyFilter(new BrightnessCorrection());
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                frmBright adjust = new frmBright();
                adjust.ShowDialog();
                Bitmap temp = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)temp.Clone();
                if (adjust.brightness < -255) adjust.brightness = -255;
                if (adjust.brightness > 255) adjust.brightness = 255;
                Color c;
                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        int cR = c.R +adjust. brightness;
                        int cG = c.G +adjust. brightness;
                        int cB = c.B +adjust. brightness;

                        if (cR < 0) cR = 1;
                        if (cR > 255) cR = 255;

                        if (cG < 0) cG = 1;
                        if (cG > 255) cG = 255;

                        if (cB < 0) cB = 1;
                        if (cB > 255) cB = 255;

                        bmap.SetPixel(i, j,
            Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                    }
                }
                temp = (Bitmap)bmap.Clone();
                pictureBox1.Image = temp;


            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            // ApplyFilter(new ContrastCorrection());
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                double contrast;
                contrast = System.Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter Value", "Contrast Adjustment", "0", 200, 200));
                Bitmap temp = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)temp.Clone();
                if (contrast < -100) contrast = -100;
                if (contrast > 100) contrast = 100;
                contrast = (100.0 + contrast) / 100.0;
                contrast *= contrast;
                Color c;
                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        double pR = c.R / 255.0;
                        pR -= 0.5;
                        pR *= contrast;
                        pR += 0.5;
                        pR *= 255;
                        if (pR < 0) pR = 0;
                        if (pR > 255) pR = 255;

                        double pG = c.G / 255.0;
                        pG -= 0.5;
                        pG *= contrast;
                        pG += 0.5;
                        pG *= 255;
                        if (pG < 0) pG = 0;
                        if (pG > 255) pG = 255;

                        double pB = c.B / 255.0;
                        pB -= 0.5;
                        pB *= contrast;
                        pB += 0.5;
                        pB *= 255;
                        if (pB < 0) pB = 0;
                        if (pB > 255) pB = 255;

                        bmap.SetPixel(i, j,
            Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                    }
                }
                temp = (Bitmap)bmap.Clone();
                pictureBox1.Image = temp;


            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                ApplyFilter(new HSLFiltering(new IntRange(330, 30), new Range(0, 1), new Range(0, 1)));
            }
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            YCbCrLinear filter = new YCbCrLinear();

            filter.InCb = new Range(-0.3f, 0.3f);

            ApplyFilter(filter);
        }

        private void metroButton25_Click(object sender, EventArgs e)
        {

            ApplyFilter(new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f)));
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                // save original image
                Bitmap originalImage = sourceImage;
                // get grayscale image
                sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
                // apply threshold filter
                ApplyFilter(new Threshold());
                // delete grayscale image and restore original
                sourceImage.Dispose();
                sourceImage = originalImage;
            }
        }
        private void metroButton23_Click(object sender, EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply threshold filter
            ApplyFilter(new FloydSteinbergDithering());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                // save original image
                Bitmap originalImage = sourceImage;
                // get grayscale image
                sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
                // apply threshold filter
                ApplyFilter(new OrderedDithering());
                // delete grayscale image and restore original
                sourceImage.Dispose();
                sourceImage = originalImage;
            }
        }
        private void metroButton17_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Convolution(new int[,] {
								{ 1, 2, 3, 2, 1 },
								{ 2, 4, 5, 4, 2 },
								{ 3, 5, 6, 5, 3 },
								{ 2, 4, 5, 4, 2 },
								{ 1, 2, 3, 2, 1 } }));
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpen());
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GaussianBlur(2.0, 7));
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {

            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new DifferenceEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                // save original image
                Bitmap originalImage = sourceImage;
                // get grayscale image
                sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
                // apply edge filter
                ApplyFilter(new HomogenityEdgeDetector());
                // delete grayscale image and restore original
                sourceImage.Dispose();
                sourceImage = originalImage;
            }
        }
        private void metroButton20_Click(object sender, EventArgs e)
        {
            // save original image
            Bitmap originalImage = sourceImage;
            // get grayscale image
            sourceImage = Grayscale.CommonAlgorithms.RMY.Apply(sourceImage);
            // apply edge filter
            ApplyFilter(new SobelEdgeDetector());
            // delete grayscale image and restore original
            sourceImage.Dispose();
            sourceImage = originalImage;

        }

        private void metroButton26_Click(object sender, EventArgs e)
        {
            ApplyFilter(new OilPainting());
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Texturer(new TextileTexture(), 1.0, 0.8));
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Jitter());
        }

        private void BtnEditImage_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }





        private void metroButton20_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                FrmCrop cropForm = new FrmCrop();
                cropForm.ShowDialog();
                Bitmap _bitmapPrevCropArea = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)_bitmapPrevCropArea.Clone();
                Graphics gr = Graphics.FromImage(bmap);
                Brush cBrush = new Pen(Color.FromArgb(150,Color.White )).Brush;
                Rectangle rect1 = new Rectangle(0, 0, sourceImage.Width, cropForm.y_Param);
                Rectangle rect2 = new Rectangle(0, cropForm.y_Param, cropForm.x_Param, cropForm.Height_Param);
                Rectangle rect3 = new Rectangle
                (0, (cropForm.y_Param + cropForm.Height_Param), sourceImage.Width, sourceImage.Height);
                Rectangle rect4 = new Rectangle((cropForm.x_Param + cropForm.Width_Param),
            cropForm.y_Param, (sourceImage.Width - cropForm.x_Param - cropForm.Width_Param), cropForm.Height_Param);
                gr.FillRectangle(cBrush, rect1);
                gr.FillRectangle(cBrush, rect2);
                gr.FillRectangle(cBrush, rect3);
                gr.FillRectangle(cBrush, rect4);
                _bitmapPrevCropArea = (Bitmap)bmap.Clone();
                pictureBox1.Image = _bitmapPrevCropArea;
            }
        }



        private void metroButton22_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                frmResize resize = new frmResize();
                resize.ShowDialog();
                if (resize.y != 0 && resize.x != 0)
                {
                    Bitmap temp = (Bitmap)sourceImage;
                    Bitmap bmap = new Bitmap(resize.y, resize.x, temp.PixelFormat);

                    double nWidthFactor = (double)temp.Width / (double)resize.y;
                    double nHeightFactor = (double)temp.Height / (double)resize.x;

                    double fx, fy, nx, ny;
                    int cx, cy, fr_x, fr_y;
                    Color color1 = new Color();
                    Color color2 = new Color();
                    Color color3 = new Color();
                    Color color4 = new Color();
                    byte nRed, nGreen, nBlue;

                    byte bp1, bp2;

                    for (int x = 0; x < bmap.Width; ++x)
                    {
                        for (int y = 0; y < bmap.Height; ++y)
                        {

                            fr_x = (int)Math.Floor(x * nWidthFactor);
                            fr_y = (int)Math.Floor(y * nHeightFactor);
                            cx = fr_x + 1;
                            if (cx >= temp.Width) cx = fr_x;
                            cy = fr_y + 1;
                            if (cy >= temp.Height) cy = fr_y;
                            fx = x * nWidthFactor - fr_x;
                            fy = y * nHeightFactor - fr_y;
                            nx = 1.0 - fx;
                            ny = 1.0 - fy;

                            color1 = temp.GetPixel(fr_x, fr_y);
                            color2 = temp.GetPixel(cx, fr_y);
                            color3 = temp.GetPixel(fr_x, cy);
                            color4 = temp.GetPixel(cx, cy);

                            // Blue
                            bp1 = (byte)(nx * color1.B + fx * color2.B);

                            bp2 = (byte)(nx * color3.B + fx * color4.B);

                            nBlue = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                            // Green
                            bp1 = (byte)(nx * color1.G + fx * color2.G);

                            bp2 = (byte)(nx * color3.G + fx * color4.G);

                            nGreen = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                            // Red
                            bp1 = (byte)(nx * color1.R + fx * color2.R);

                            bp2 = (byte)(nx * color3.R + fx * color4.R);

                            nRed = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                            bmap.SetPixel(x, y, System.Drawing.Color.FromArgb
                    (255, nRed, nGreen, nBlue));
                        }
                    }
                    temp = (Bitmap)bmap.Clone();
                    pictureBox1.Image = temp;

                }
            }
        }

        private void metroButton28_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                frmGamma gamma = new frmGamma();
                gamma.ShowDialog();
                Bitmap temp = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)temp.Clone();
                Color c;
                byte[] redGamma = CreateGammaArray(gamma.r);
                byte[] greenGamma = CreateGammaArray(gamma.g);
                byte[] blueGamma = CreateGammaArray(gamma.b);
                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        bmap.SetPixel(i, j, Color.FromArgb(redGamma[c.R],
                           greenGamma[c.G], blueGamma[c.B]));
                    }
                }
                temp = (Bitmap)bmap.Clone();
                pictureBox1.Image = temp;
            }
        }
        private byte[] CreateGammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; ++i)
            {
                gammaArray[i] = (byte)Math.Min(255,
        (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }
            return gammaArray;
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                _currentImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
                sourceImage = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                //GetImageDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                _index = 0;
                _filePathNames = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                try
                {
                    _currentImagePath = _filePathNames[_index];
                    pictureBox1.ImageLocation = _filePathNames[_index];
                }
                catch (Exception)
                {
                    MessageBox.Show(this,
                       "There Was Error Processing your file.\nFile is not a valid image file",
                       "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do You want to quit", "Really Quit?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }
            Close();
        }

        private void faceDetectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetectFaces();
        }

        private void resetAllEffectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = sourceImage;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Image Files|*.jpg";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog.FileName);
            }
        }

        private void openFileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                _currentImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
                sourceImage = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                //GetImageDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to be saved");

            }
            else
            {
                saveFileDialog.Filter = "Image Files|*.jpg";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void metroButton25_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Load Image First");

            }
            else
            {
                ApplyFilter(Grayscale.CommonAlgorithms.BT709);
            }
        }

        private void MainButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFolderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                _index = 0;
                _filePathNames = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                try
                {
                    _currentImagePath = _filePathNames[_index];
                    pictureBox1.ImageLocation = _filePathNames[_index];
                }
                catch (Exception)
                {
                    MessageBox.Show(this,
                       "There Was Error Processing your file.\nFile is not a valid image file",
                       "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton17_Click_1(object sender, EventArgs e)
        {
            String imagepath = "";

            //            public void InsertText(string text, int xPosition,
            //    int yPosition, string fontName, float fontSize,
            //string fontStyle, string colorName1, string colorName2)
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                     imagepath  = openFileDialog.FileName;
                 //   pictureBox1.ImageLocation = openFileDialog.FileName;

                  //  sourceImage = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                  //  pictureBox1.Image = sourceImage;
                    //GetImageDetails();
                }
                catch (Exception)
                {
                    MessageBox.Show(this,
                        "There Was Error Processing your file.\nFile is not a valid image file",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //frmInsertText ins = new frmInsertText();
                //ins.ShowDialog();
                Bitmap temp = (Bitmap)sourceImage;
                Bitmap bmap = (Bitmap)temp.Clone();
                

                Graphics gr = Graphics.FromImage(bmap);
                if (!string.IsNullOrEmpty(imagepath ))
                {
                    Rectangle rect = new Rectangle(300  , 200  ,
                300, 200 );
                    gr.DrawImage(Bitmap.FromFile(imagepath ), rect);
                }
                temp = (Bitmap)bmap.Clone();
                pictureBox1.Image = temp;
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void keyPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String imgpath="";
            imgpath = "C:\\Users\\user\\Desktop\\About.png";
            pictureBox1.ImageLocation = imgpath;
            Bitmap cimage;

                cimage  = (Bitmap)Bitmap.FromFile(imgpath );
                pictureBox1.Image = cimage;


        }
    }


    /*
    private void pictureBox2_Click(object sender, EventArgs e)
    {
        if(pictureBox2.Image == null)
        {
            return;
        }
        else
        {
            GetImageDetails();
        }
    }
     * */
}
