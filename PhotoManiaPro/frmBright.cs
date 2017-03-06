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
    public partial class frmBright : MetroForm
    {
        public int brightness { get; set; }
        public frmBright()
        {
            InitializeComponent();
        }

        private void frmBright_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            brightness = Convert.ToInt16(metroTextBox1 .Text );
            this.Close();
        }
    }
}
