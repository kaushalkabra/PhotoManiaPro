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
    public partial class frmResize : MetroForm
    {
        public int x { get; set; }
        public int y { get; set; }

        public frmResize()
        {
            InitializeComponent();
        }

        private void frmResize_Load(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(metroTextBox1.Text);
            y = Convert.ToInt32(metroTextBox2.Text);
            this.Close();
        }
    }
}
