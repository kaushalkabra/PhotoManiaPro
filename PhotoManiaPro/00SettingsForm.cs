using System;
using MetroFramework.Forms;

namespace PhotoManiaPro
{
    public partial class SettingsForm : MetroForm
    {
        private void LoadTheme()
        {
            Style = Properties.Settings.Default.AppStyle;


        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ToggleSettingsLocked.Checked = true;
        }
    }
}
