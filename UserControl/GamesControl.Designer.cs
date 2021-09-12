
namespace SizzlingHot.UserControls
{
    partial class GamesControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gamesPage5 = new SizzlingHot.UserControls.GamesPage();
            this.sizzlingHotControl1 = new SizzlingHot.UserControls.SizzlingHotControl();
            this.bookOfRaControl1 = new SizzlingHot.UserControls.BookOfRaControl();
            this.superHot40Control1 = new SizzlingHot.UserControls.SuperHot40Control();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.gamesPage5);
            this.flowLayoutPanel1.Controls.Add(this.sizzlingHotControl1);
            this.flowLayoutPanel1.Controls.Add(this.bookOfRaControl1);
            this.flowLayoutPanel1.Controls.Add(this.superHot40Control1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 422);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gamesPage5
            // 
            this.gamesPage5.AutoSize = true;
            this.gamesPage5.BackColor = System.Drawing.Color.White;
            this.gamesPage5.ForeColor = System.Drawing.Color.White;
            this.gamesPage5.Location = new System.Drawing.Point(3, 3);
            this.gamesPage5.Name = "gamesPage5";
            this.gamesPage5.Size = new System.Drawing.Size(542, 139);
            this.gamesPage5.TabIndex = 4;
            // 
            // sizzlingHotControl1
            // 
            this.sizzlingHotControl1.Location = new System.Drawing.Point(3, 148);
            this.sizzlingHotControl1.Name = "sizzlingHotControl1";
            this.sizzlingHotControl1.Size = new System.Drawing.Size(542, 139);
            this.sizzlingHotControl1.TabIndex = 5;
            // 
            // bookOfRaControl1
            // 
            this.bookOfRaControl1.Location = new System.Drawing.Point(3, 293);
            this.bookOfRaControl1.Name = "bookOfRaControl1";
            this.bookOfRaControl1.Size = new System.Drawing.Size(542, 139);
            this.bookOfRaControl1.TabIndex = 6;
            // 
            // superHot40Control1
            // 
            this.superHot40Control1.Location = new System.Drawing.Point(3, 438);
            this.superHot40Control1.Name = "superHot40Control1";
            this.superHot40Control1.Size = new System.Drawing.Size(542, 139);
            this.superHot40Control1.TabIndex = 7;
            // 
            // GamesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GamesControl";
            this.Size = new System.Drawing.Size(583, 422);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GamesPage gamesPage5;
        private SizzlingHotControl sizzlingHotControl1;
        private BookOfRaControl bookOfRaControl1;
        private SuperHot40Control superHot40Control1;
    }
}
