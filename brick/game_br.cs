using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brick
{
    public partial class game_br : Form
    {
       // int[,] mass = new int[30, 24];
        int speed_ball_left = 4;
        int speed_ball_up=3;
        public game_br()
        {
            InitializeComponent();
        }

        private void game_br_Load(object sender, EventArgs e)
        {
            new_game();
        }

        private void new_game()
        {
            Cursor.Hide();
            for(int i=0;i<20;++i)
            {
                for(int i2=0;i2<30;++i2)
                {
                    PictureBox a = new PictureBox();
                    a.SizeMode =PictureBoxSizeMode.StretchImage;
                    a.Height = 30;
                    a.Width = 30;
                    a.Left = 30 * i2;
                    a.Top = 30 * i;
                    a.Image = Image.FromFile(@"br_img.jpg");
                    panel1.Controls.Add(a);
                    //mass[i2, i] = 1;

                }
            }
                }
        //тик
        private void timer1_Tick(object sender, EventArgs e)
        {
            ball_.Left += speed_ball_left;
            ball_.Top += speed_ball_up;
            if (Cursor.Position.X - 75 > panel1.Left && Cursor.Position.X + 75 < panel1.Right)
                polosa_.Left = Cursor.Position.X - 75;
            if (Cursor.Position.X - 75 < panel1.Left)
                polosa_.Left = 0;
            if (Cursor.Position.X + 75 > panel1.Right)
                polosa_.Left = panel1.Right-150;
          
            if (ball_.Bottom>=polosa_.Top&&((ball_.Left<=polosa_.Right&&ball_.Left>=polosa_.Left)|| (ball_.Right <= polosa_.Right && ball_.Right >= polosa_.Left)))//
            {
                speed_ball_up = -Math.Abs(speed_ball_up);
                if(Math.Abs( speed_ball_left)<5)
                if (ball_.Left < polosa_.Left + 40|| ball_.Right > polosa_.Right - 40)
                    speed_ball_left=speed_ball_left > 0 ? speed_ball_left + 1 : speed_ball_left - 1;
                if (Math.Abs(speed_ball_left) > 0)
                    if (ball_.Left > polosa_.Left + 40 && ball_.Left < polosa_.Right - 40)
                    speed_ball_left = speed_ball_left > 0 ? speed_ball_left - 1 : speed_ball_left + 1;
                if(Math.Abs(speed_ball_up)+ Math.Abs(speed_ball_left)!=7)
                {
                    if(speed_ball_up>0)
                    {
                        speed_ball_up = 7 - Math.Abs(speed_ball_left);
                    }
                    else
                    {
                        speed_ball_up = -(7 - Math.Abs(speed_ball_left));
                    }
                }
            }
            if(ball_.Left<=panel1.Left)
            {
                speed_ball_left = -speed_ball_left;
            }
            if(ball_.Right >= panel1.Right)
            {
                speed_ball_left = -speed_ball_left;
            }
            if (ball_.Top <= panel1.Top)
            {
                speed_ball_up = -speed_ball_up;
            }
            if(ball_.Bottom>= panel1.Bottom)
                {
                timer1.Enabled = false;
                Cursor.Show();

            }
            if(panel1.Controls.Count==2)
            {
                timer1.Enabled = false;
                Cursor.Show();
                MessageBox.Show("u win");
                this.Close();
            }
            else
            foreach (var i in panel1.Controls)
            {
                
                if (i is PictureBox)
                {
                    if (ball_.Top < ((PictureBox)i).Bottom&& ball_.Top > ((PictureBox)i).Top)
                        if (((ball_.Left <= ((PictureBox)i).Right && ball_.Left >= ((PictureBox)i).Left) || (ball_.Right <= ((PictureBox)i).Right && ball_.Right >= ((PictureBox)i).Left)))
                        {
                            speed_ball_up =- speed_ball_up;
                            ((PictureBox)i).Dispose();
                        }

                }
                   

            }

        }
       /* private void get_element_by_name(ref object s,string nn)
        {
            foreach(var i in panel1.Controls)
            {
                if()

            }
        }*/

        private void game_br_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                polosa_.Left -= 10;

            }
            if(e.KeyCode == Keys.Right)
            {

                polosa_.Left += 10;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Show();
                this.Close();
                
            }


        }
    }
}
