using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizzlingHot.UserControls
{
    public partial class GamesPage : UserControl
    {
        public GamesPage()
        {
            InitializeComponent();
        }

        private void play_shinningcrown_button_Click(object sender, EventArgs e)
        {
            Form form = Logged.ActiveForm;
            form.Hide();
            ShiningCrown game = new ShiningCrown();
            game.ShowDialog();
            form.Close();
            Console.WriteLine("TEST");
        }
    }
}
