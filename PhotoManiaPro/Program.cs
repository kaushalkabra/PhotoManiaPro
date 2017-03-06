using System;
using System.Windows.Forms;

namespace PhotoManiaPro
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.username == Properties.Settings.Default.username)
            {
                if (login.password == Properties.Settings.Default.password)
                {
                    Application.Run(new MainWindowForm());
                }
            }
            else
            {
                MessageBox.Show("Invalid username/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}