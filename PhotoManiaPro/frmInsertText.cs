using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PhotoManiaPro
{
    public partial class frmInsertText : MetroForm
    {
        public String text { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public int h  { get; set; }
        public int  w  { get; set; }
        public string fontStyle { get; set; }
        public string colorName1 { get; set; }
        public string colorName2 { get; set; }

        public frmInsertText()
        {
            InitializeComponent();
        }

        private void frmInsertText_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1Submit_Click(object sender, EventArgs e)
        {
            string text;
            int  xPosition, yPosition,h,w;
            string fontName;

            double  fontSize;
            string fontStyle, colorName1, colorName2;
           // text = metroTextBox1.Text;
            xPosition = Convert.ToInt32(metroTextBox2.Text);
            yPosition = Convert.ToInt32(metroTextBox3.Text);
            h = Convert.ToInt32(metroTextBox1.Text);
            w = Convert.ToInt32(metroTextBox4.Text);

            //fontSize = Convert.ToDouble(metroTextBox5.Text);
            //fontName = metroTextBox4.Text;
            //fontStyle = metroTextBox6.Text;
            //colorName1 = metroTextBox7.Text;
            //colorName2 = metroTextBox8.Text;
            this.Close();

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}