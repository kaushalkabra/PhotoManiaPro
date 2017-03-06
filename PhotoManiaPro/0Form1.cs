using System;
using System.IO;

namespace PhotoManiaPro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string[] _fileNames;
        private int _index = 0;
        private bool _isSlideShowOn = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Text = "SlideShow On";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Image Files (*.jpeg)|*.jpeg|BMP Image Files (*.bmp)|*.bmp";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Multiselect = true;
            _index = 0;
            folderBrowserDialog.ShowDialog();
            _fileNames = Directory.GetFiles(folderBrowserDialog.SelectedPath);
            pictureBox1.ImageLocation = _fileNames[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_index == 0)
            {
                _index = _fileNames.Length - 1;
            }
            {
                _index--;
                pictureBox1.ImageLocation = _fileNames[_index];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_isSlideShowOn == false)
            {
                timer1.Start();
                _isSlideShowOn = true;
                button3.Text = "Slideshow Off";
            }
            else
            {
                _isSlideShowOn = false;
                timer1.Stop();
                button3.Text = "SlideShow On";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void NextPicture()
        {
            if (_index == _fileNames.Length - 1)
            {
                _index = 0;
            }
            {
                _index++;
                pictureBox1.ImageLocation = _fileNames[_index];
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
