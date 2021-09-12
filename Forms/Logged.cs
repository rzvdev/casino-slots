using System;
using System.Windows.Forms;
using SizzlingHot.UserControls;

namespace SizzlingHot
{
    public partial class Logged : Form
    {
        public Logged()
        {
            InitializeComponent();
        }
        private void Logged_Load(object sender, EventArgs e)
        {
            user_label2.Text = $"{Account.User}";
            Side_panel.Height = games_button.Height;
            gamesControl1.BringToFront();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Side_panel.Height = setting_button.Height;
            Side_panel.Top = setting_button.Top;
            settingsControl1.BringToFront();
        }

        private void Games_Button_Click(object sender, EventArgs e)
        {
            Side_panel.Height = games_button.Height;
            Side_panel.Top = games_button.Top;
            gamesControl1.BringToFront();
        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            Side_panel.Height = about_button.Height;
            Side_panel.Top = about_button.Top;
            aboutControl1.BringToFront();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Account.Logout();
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

        private void gamesControl1_Load(object sender, EventArgs e)
        {

        }

        private void settingsControl1_Load(object sender, EventArgs e)
        {

        }

        private void Logged_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
