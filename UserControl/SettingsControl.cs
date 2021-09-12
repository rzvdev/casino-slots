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
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                Resolution.WIDTH = 600;
                Resolution.HEIGHT = 400;
            }
            if(listBox1.SelectedIndex == 1)
            {
                Resolution.IsFullscreen = true;
            }
        }
    }
}
