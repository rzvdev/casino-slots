
namespace SizzlingHot
{
    partial class Logged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logged));
            this.user_label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Side_panel = new System.Windows.Forms.Panel();
            this.about_button = new System.Windows.Forms.Button();
            this.setting_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.games_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aboutControl1 = new SizzlingHot.UserControls.AboutControl();
            this.settingsControl1 = new SizzlingHot.UserControls.SettingsControl();
            this.gamesControl1 = new SizzlingHot.UserControls.GamesControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_label2
            // 
            this.user_label2.AutoSize = true;
            this.user_label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label2.ForeColor = System.Drawing.Color.Red;
            this.user_label2.Location = new System.Drawing.Point(440, 14);
            this.user_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label2.Name = "user_label2";
            this.user_label2.Size = new System.Drawing.Size(0, 25);
            this.user_label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Side_panel);
            this.panel1.Controls.Add(this.about_button);
            this.panel1.Controls.Add(this.setting_button);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.games_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 692);
            this.panel1.TabIndex = 4;
            // 
            // Side_panel
            // 
            this.Side_panel.BackColor = System.Drawing.Color.DarkRed;
            this.Side_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side_panel.Location = new System.Drawing.Point(0, 122);
            this.Side_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Side_panel.Name = "Side_panel";
            this.Side_panel.Size = new System.Drawing.Size(18, 111);
            this.Side_panel.TabIndex = 6;
            // 
            // about_button
            // 
            this.about_button.FlatAppearance.BorderSize = 0;
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_button.ForeColor = System.Drawing.Color.Snow;
            this.about_button.Image = global::SizzlingHot.Properties.Resources.about;
            this.about_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_button.Location = new System.Drawing.Point(18, 365);
            this.about_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(309, 112);
            this.about_button.TabIndex = 2;
            this.about_button.Text = "        ABOUT";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // setting_button
            // 
            this.setting_button.FlatAppearance.BorderSize = 0;
            this.setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_button.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_button.ForeColor = System.Drawing.Color.Snow;
            this.setting_button.Image = global::SizzlingHot.Properties.Resources.settings1;
            this.setting_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_button.Location = new System.Drawing.Point(18, 243);
            this.setting_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(309, 112);
            this.setting_button.TabIndex = 2;
            this.setting_button.Text = " SETTINGS";
            this.setting_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = global::SizzlingHot.Properties.Resources.logout;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 112);
            this.button3.TabIndex = 2;
            this.button3.Text = "      LOGOUT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // games_button
            // 
            this.games_button.FlatAppearance.BorderSize = 0;
            this.games_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.games_button.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.games_button.ForeColor = System.Drawing.Color.Snow;
            this.games_button.Image = global::SizzlingHot.Properties.Resources.games;
            this.games_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.games_button.Location = new System.Drawing.Point(18, 122);
            this.games_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.games_button.Name = "games_button";
            this.games_button.Size = new System.Drawing.Size(309, 112);
            this.games_button.TabIndex = 2;
            this.games_button.Text = "      GAMES";
            this.games_button.UseVisualStyleBackColor = true;
            this.games_button.Click += new System.EventHandler(this.Games_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.user_label);
            this.panel2.Controls.Add(this.user_label2);
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 45);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SizzlingHot.Properties.Resources.user3;
            this.label1.Location = new System.Drawing.Point(324, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 0;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(366, 14);
            this.user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(67, 25);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "User:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.aboutControl1);
            this.panel3.Controls.Add(this.settingsControl1);
            this.panel3.Controls.Add(this.gamesControl1);
            this.panel3.Location = new System.Drawing.Point(326, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 649);
            this.panel3.TabIndex = 5;
            // 
            // aboutControl1
            // 
            this.aboutControl1.Location = new System.Drawing.Point(0, 0);
            this.aboutControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(874, 649);
            this.aboutControl1.TabIndex = 2;
            // 
            // settingsControl1
            // 
            this.settingsControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(874, 649);
            this.settingsControl1.TabIndex = 1;
            this.settingsControl1.Load += new System.EventHandler(this.settingsControl1_Load);
            // 
            // gamesControl1
            // 
            this.gamesControl1.BackColor = System.Drawing.Color.White;
            this.gamesControl1.Location = new System.Drawing.Point(0, 0);
            this.gamesControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gamesControl1.Name = "gamesControl1";
            this.gamesControl1.Size = new System.Drawing.Size(874, 649);
            this.gamesControl1.TabIndex = 0;
            // 
            // Logged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CASINO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logged_FormClosing);
            this.Load += new System.EventHandler(this.Logged_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label user_label2;
        private System.Windows.Forms.Button games_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Side_panel;
        private System.Windows.Forms.Panel panel3;
        private UserControls.GamesControl gamesControl1;
        private UserControls.SettingsControl settingsControl1;
        private UserControls.AboutControl aboutControl1;
    }
}