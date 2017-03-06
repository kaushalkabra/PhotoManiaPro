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
using PhotoManiaPro.Properties;
namespace PhotoManiaPro
{
    public partial class FrmCrop : MetroForm
    {
        // public MyDataObj DataObj { get; set; } //obj shared by both forms

        public int x_Param { get; set; }
        public int y_Param { get; set; }
        public int Height_Param { get; set; }
        public int Width_Param { get; set; }

        public FrmCrop()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // int x, y, h, w;
            x_Param = System.Convert.ToInt32(textBox2.Text);
            y_Param = System.Convert.ToInt32(textBox4.Text);
            Height_Param = System.Convert.ToInt32(textBox1.Text);
            Width_Param = System.Convert.ToInt32(textBox3.Text);
            this.Close();
        }
    }
}
