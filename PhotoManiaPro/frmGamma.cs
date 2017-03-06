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
    public partial class frmGamma : MetroForm
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public frmGamma()
        {
            InitializeComponent();
        }

        private void frmGamma_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt16(metroTextBox1.Text);
            g = Convert.ToInt16(metroTextBox2.Text);
            b = Convert.ToInt16(metroTextBox3.Text);
            this.Close();


        }
    }
}
