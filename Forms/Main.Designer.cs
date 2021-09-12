
namespace SizzlingHot
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.user_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.serverStatus_label = new System.Windows.Forms.Label();
            this.connected_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.sqlConnectionCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(75, 46);
            this.user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(59, 18);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "User:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(32, 89);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(97, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password:";
            // 
            // user_textbox
            // 
            this.user_textbox.Location = new System.Drawing.Point(141, 44);
            this.user_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_textbox.MaxLength = 20;
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(167, 22);
            this.user_textbox.TabIndex = 2;
            this.user_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keypressed_tab);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(141, 87);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_textbox.MaxLength = 20;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(167, 22);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textbox_KeyPress);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(173, 139);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 28);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // serverStatus_label
            // 
            this.serverStatus_label.AutoSize = true;
            this.serverStatus_label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatus_label.Location = new System.Drawing.Point(304, 10);
            this.serverStatus_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverStatus_label.Name = "serverStatus_label";
            this.serverStatus_label.Size = new System.Drawing.Size(61, 17);
            this.serverStatus_label.TabIndex = 5;
            this.serverStatus_label.Text = "Status:";
            // 
            // connected_label
            // 
            this.connected_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connected_label.Location = new System.Drawing.Point(376, 10);
            this.connected_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connected_label.Name = "connected_label";
            this.connected_label.Size = new System.Drawing.Size(18, 16);
            this.connected_label.TabIndex = 6;
            // 
            // info_label
            // 
            this.info_label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.Color.Red;
            this.info_label.Location = new System.Drawing.Point(36, 116);
            this.info_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(355, 18);
            this.info_label.TabIndex = 7;
            this.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sqlConnectionCheckBox
            // 
            this.sqlConnectionCheckBox.AutoSize = true;
            this.sqlConnectionCheckBox.Location = new System.Drawing.Point(13, 5);
            this.sqlConnectionCheckBox.Name = "sqlConnectionCheckBox";
            this.sqlConnectionCheckBox.Size = new System.Drawing.Size(125, 20);
            this.sqlConnectionCheckBox.TabIndex = 8;
            this.sqlConnectionCheckBox.Text = "SQL Connection";
            this.sqlConnectionCheckBox.UseVisualStyleBackColor = true;
            this.sqlConnectionCheckBox.CheckedChanged += new System.EventHandler(this.sqlConnectionCheckBox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 186);
            this.Controls.Add(this.sqlConnectionCheckBox);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.connected_label);
            this.Controls.Add(this.serverStatus_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.user_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CASINO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label serverStatus_label;
        private System.Windows.Forms.Label connected_label;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.CheckBox sqlConnectionCheckBox;
    }
}

