using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Accord.Vision.Detection;
using MetroFramework.Forms;
using Accord.Vision.Detection.Cascades;

namespace PhotoManiaPro
{
    public partial class MainWindowForm : MetroForm
    {
        private string[] _filePathNames;
        private int _index;
        private string _currentImagePath;
        readonly private HaarObjectDetector _detector;
        private Rectangle[] _faceObjects;
        private FileInfo _fileInfo;
        private bool _isSlideShowOn;
        private FileSize _size;


        private void LoadTheme()
        {
            // Main Form
            Style = Properties.Settings.Default.AppStyle;

            // Textboxes
            TxtHorizontalResolution.Style = Properties.Settings.Default.AppStyle;
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
            metroLabel12.Style = Properties.Settings.Default.AppStyle;
        }

        public MainWindowForm()
        {
            InitializeComponent();
            LoadTheme();
            var cascade = new FaceHaarCascade();
            _detector = new HaarObjectDetector(cascade, 30);
            _detector.SearchMode = ObjectDetectorSearchMode.Average;
            _detector.ScalingFactor = 1.5f;
            _detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller;
            _detector.UseParallelProcessing = true;
            _detector.Suppression = 3;
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
                pictureBox.ImageLocation = openFileDialog.FileName;
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
            // File Chooser Dialog Setup
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|" +
                                    "BMP Files (*.bmp)|*.bmp|" +
                                    "JPG Files (*.jpg)|*.jpg|" +
                                    "PNG Files (*.png)|*.png|" +
                                    "ALL Files (*.*)|*.*";
            openFileDialog.FileName = "Select A Valid Picture File";
            openFileDialog.Title = "Photo Mania Pro Picture Selector";
            openFileDialog.InitialDirectory = "C:";

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
                    pictureBox.ImageLocation = _filePathNames[_index];
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
                pictureBox.ImageLocation = _filePathNames[_index];
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
                pictureBox.ImageLocation = _filePathNames[_index];
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
            PreviousPicture();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void DetectFaces()
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show(this, "Open Image file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var bit = new Bitmap(pictureBox.Image);
            _faceObjects = _detector.ProcessFrame(bit);
            MessageBox.Show(this,
                "Face[s] detectes -> " + _faceObjects.Length,
                "Face Detection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            var graphics = Graphics.FromImage(pictureBox.Image);
            foreach (var face in _faceObjects)
            {
                graphics.DrawRectangle(Pens.Red, face);
            }
            graphics.Dispose();
            pictureBox.Invalidate();
        }

        private void faceDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetectFaces();
        }

        private void GetImageDetails()
        {
            TxtImageName.Text = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);
            TxtImageType.Text = Path.GetExtension(pictureBox.ImageLocation);
            _fileInfo = new FileInfo(pictureBox.ImageLocation);

            _size = FileSizeSuffixRetriever.GetSuffix(_fileInfo.Length);
            TxtImageSize.Text = _size.Size + " " + _size.Suffix;

            TxtImageWidth.Text = pictureBox.Image.Size.Width.ToString();
            TxtImageHeight.Text = pictureBox.Image.Size.Height.ToString();
            TxtVerticalResolution.Text = pictureBox.Image.VerticalResolution.ToString();
            TxtHorizontalResolution.Text = pictureBox.Image.HorizontalResolution.ToString();
            TxtPixelFormat.Text = pictureBox.Image.PixelFormat.ToString();
            TxtRawFormat.Text = pictureBox.Image.RawFormat.ToString();
            TxtPalletteFlags.Text = pictureBox.Image.Palette.Flags.ToString();
            _fileInfo = null;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox.Image == null)
            {
                return;
            }
            else
            {
                System.GC.Collect();
                GetImageDetails();
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
            if (pictureBox.Image == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show(this, "Are you sure to delete this picture?\nImage once deleted cannot be recovered",
                    "Delete? Read Carefully",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(pictureBox.ImageLocation);
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}