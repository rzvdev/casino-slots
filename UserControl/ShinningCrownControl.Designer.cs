
namespace SizzlingHot.UserControls
{
    partial class GamesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.play_shinningcrown_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.play_shinningcrown_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 136);
            this.panel1.TabIndex = 3;
            // 
            // play_shinningcrown_button
            // 
            this.play_shinningcrown_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_shinningcrown_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.play_shinningcrown_button.FlatAppearance.BorderSize = 0;
            this.play_shinningcrown_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.play_shinningcrown_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.play_shinningcrown_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_shinningcrown_button.Image = global::SizzlingHot.Properties.Resources.Capture;
            this.play_shinningcrown_button.Location = new System.Drawing.Point(317, 85);
            this.play_shinningcrown_button.Name = "play_shinningcrown_button";
            this.play_shinningcrown_button.Size = new System.Drawing.Size(117, 48);
            this.play_shinningcrown_button.TabIndex = 2;
            this.play_shinningcrown_button.UseVisualStyleBackColor = true;
            this.play_shinningcrown_button.Click += new System.EventHandler(this.play_shinningcrown_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(202, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SizzlingHot.Properties.Resources.shining_crown;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // GamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GamesPage";
            this.Size = new System.Drawing.Size(542, 139);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button play_shinningcrown_button;
        private System.Windows.Forms.Label label1;
    }
}
