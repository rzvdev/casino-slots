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
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        private void AboutControl_Load(object sender, EventArgs e)
        {
            connected_server_label.Text = $"{ConnectionInfo.GetServerAddress()}\n{ConnectionInfo.GetDatabaseName()}";
        }
    }
}
