using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SizzlingHot
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        // if the connection is lost or open during running, 
        // the status changes
        private void CheckConnection()
        {
            DbConnection dbConnection = DbConnection.GetInstance();

            while (true)
            {
                if (dbConnection.TryConnection())
                {
                    this.connected_label.Image = Properties.Resources.online;
                    //connected_label.Image = Image.FromFile(@"D:\Project\casino\casino\Resources\online.png");
                }
                else
                {
                    this.connected_label.Image = global::SizzlingHot.Properties.Resources.offline;
                    //connected_label.Image = Image.FromFile(@"D:\Project\casino\casino\Resources\offline.png");

                    if (Account.LoggedIn)
                    {
                        MsgBox.Show(Owner, "Connection lost!", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                Thread.Sleep(AppConst._CONNECTION_REFRESH_TIME);
            }
        }

        // when loading the main
        // start checking connection thread
        private void Main_Load(object sender, EventArgs e)
        {
            Thread checkConnectionThread = new Thread(new ThreadStart(CheckConnection));
            checkConnectionThread.Start();
        }

        //When we press the click button,
        //the method tries to connect to the database, 
        //if it can not connect to the database, 
        //we will not be able to log in.
        //if you can connect to the database and the account entered exists, 
        //we will display messagebox and we will be redirected to logged form
        private void login_button_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = DbConnection.GetInstance();

            if (dbConnection.CanConnect)
            {
                if (user_textbox.Text.Length > AppConst._USER_PASSWORD_MIN_LENGTH && password_textbox.Text.Length > AppConst._USER_PASSWORD_MIN_LENGTH)
                {
                    if (dbConnection.ConnectDB(user_textbox.Text, password_textbox.Text))
                    {
                        MsgBox.Show(AppConst._INFO_LOGGED_IN);
                        Logged logged = new Logged();
                        info_label.Text = "";
                        this.Hide();
                        logged.ShowDialog();
                    }
                    else
                    {
                        info_label.Text = AppConst._INFO_ACCOUNT_DONT_EXIST;
                    }
                }
                else
                {
                    info_label.Text = AppConst._INFO_EMPTY_FIELDS;
                }
            }
            else
            {
                info_label.Text = AppConst._INFO_NOT_CONNECTED;
            }
        }

        //when we press the tab button 
        //we will clear the textbox to the password
        private void keypressed_tab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                password_textbox.Text = "";
                info_label.Text = "";
            }
        }

        //when we press the enter button 
        //on the password textbox we will 
        //operate the login method
        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login_button_Click(sender, e);
            }
        }


        // if user press close windows
        // try close app
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void sqlConnectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                DbConnection dbConnection = DbConnection.GetInstance();
            if (sqlConnectionCheckBox.Checked)
            {
                dbConnection.IsSqlConnection = true;
            } else
            {
                dbConnection.IsSqlConnection = false; 
            }
        }
    }
}
