namespace brick
{
    partial class game_br
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.polosa_ = new System.Windows.Forms.PictureBox();
            this.ball_ = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polosa_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.polosa_);
            this.panel1.Controls.Add(this.ball_);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 720);
            this.panel1.TabIndex = 0;
            // 
            // polosa_
            // 
            this.polosa_.Image = global::brick.Properties.Resources.niz;
            this.polosa_.Location = new System.Drawing.Point(444, 688);
            this.polosa_.Name = "polosa_";
            this.polosa_.Size = new System.Drawing.Size(150, 20);
            this.polosa_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.polosa_.TabIndex = 1;
            this.polosa_.TabStop = false;
            // 
            // ball_
            // 
            this.ball_.Image = global::brick.Properties.Resources.mach19;
            this.ball_.Location = new System.Drawing.Point(313, 599);
            this.ball_.Name = "ball_";
            this.ball_.Size = new System.Drawing.Size(20, 20);
            this.ball_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball_.TabIndex = 0;
            this.ball_.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // game_br
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.panel1);
            this.Name = "game_br";
            this.Text = "game_br";
            this.Load += new System.EventHandler(this.game_br_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_br_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polosa_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox polosa_;
        private System.Windows.Forms.PictureBox ball_;
        private System.Windows.Forms.Timer timer1;
    }
}