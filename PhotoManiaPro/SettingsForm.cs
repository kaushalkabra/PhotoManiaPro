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

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnIntervalSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.slideShowTimer = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
        }

        private void ToggleSettingsLocked_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnThemeSet_Click(object sender, EventArgs e)
        {
        }
    }
}

