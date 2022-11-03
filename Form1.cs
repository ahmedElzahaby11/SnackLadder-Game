using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snack_ladderGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int t;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            t = rnd.Next(1, 7);
            textBox1.Text = t.ToString();
        }

        int counter = 0;
        bool flag;
        int x;
        int y;
        private void button2_Click(object sender, EventArgs e)
        {
            if (y == 39 && x + (t * 47) > 495)
            {
                MessageBox.Show("you can't play now");
                if(counter % 2 !=0)
                {
                    x = pictureBox3.Location.X;
                    y = pictureBox3.Location.Y;
                    counter++;
                }
                else
                {
                    x = pictureBox2.Location.X;
                    y = pictureBox2.Location.Y;
                    counter++;
                }
            }
            else
            {
                flag = false;
                counter++;
                if (counter < 3)
                {
                    y = 408;
                    if (t == 1)
                    {
                        x = 495;
                    }
                    if (t == 2)
                    {
                        x = 448;
                    }
                    if (t == 3)
                    {
                        x = 401;
                    }
                    if (t == 4)
                    {
                        x = 354;
                    }
                    if (t == 5)
                    {
                        x = 307;
                    }
                    if (t == 6)
                    {
                        x = 260;
                    }
                }
                else
                {
                    if (t == 1)
                    {
                        if (y % 2 == 0)
                        {
                            x -= 47;
                        }

                        else
                        {
                            x += 47;
                        }
                    }
                    if (t == 2)
                    {
                        if (y % 2 == 0)
                        {
                            x -= 94;
                        }
                        else
                        {
                            x += 94;
                        }
                    }
                    if (t == 3)
                    {
                        if (y % 2 == 0)
                        {
                            x -= 141;
                        }
                        else
                        {
                            x += 141;
                        }
                    }
                    if (t == 4)
                    {
                        if (y % 2 == 0)
                        {
                            x -= 188;
                        }
                        else
                        {
                            x += 188;
                        }
                    }
                    if (t == 5)
                    {
                        if (y % 2 == 0)
                        {
                            x -= 235;
                        }
                        else
                        {
                            x += 235;
                        }
                    }
                    if (t == 6)
                    {
                        if (y % 2 == 0)
                        {
                            x -= 282;
                        }
                        else
                        {
                            x += 282;
                        }
                    }
                    if (x < 72)
                    {
                        y -= 41;
                        int z = 72 - x;
                        x += 2 * z;
                        x -= 47;
                    }
                    if (x > 495)
                    {
                        y -= 41;
                        int z = x - 495;
                        x -= 2 * z;
                        x += 47;
                    }
                }
                if (x == 448 && y == 408)
                {
                    x = 495;
                    y = 285;
                }
                if (x == 213 && y == 408)
                {
                    x = 354;
                    y = 367;
                }
                if (x == 72 && y == 408)
                {
                    x = 166;
                    y = 285;
                }
                if (x == 401 && y == 326)
                {
                    x = 213;
                    y = 80;
                }
                if (x == 72 && y == 326)
                {
                    x = 119;
                    y = 244;
                }
                if (x == 495 && y == 203)
                {
                    x = 354;
                    y = 162;
                }
                if (x == 72 && y == 121)
                {
                    x = 72;
                    y = 39;
                }
                if (x == 495 && y == 121)
                {
                    x = 495;
                    y = 39;
                }
                if (x == 213 && y == 367)
                {
                    x = 354;
                    y = 408;
                }
                if (x == 354 && y == 203)
                {
                    x = 354;
                    y = 285;
                }
                if (x == 213 && y == 162)
                {
                    x = 72;
                    y = 203;
                }
                if (x == 119 && y == 162)
                {
                    x = 119;
                    y = 367;
                }
                if (x == 354 && y == 80)
                {
                    x = 213;
                    y = 326;
                }
                if (x == 401 && y == 39)
                {
                    x = 401;
                    y = 121;
                }
                if (x == 307 && y == 39)
                {
                    x = 307;
                    y = 121;
                }
                if (x == 166 && y == 39)
                {
                    x = 119;
                    y = 121;
                }
                if (x == 495 && y == 39)
                {
                    flag = true;
                    counter = 0;
                    MessageBox.Show("you Won");

                }
                if (counter % 2 != 0)
                {
                    pictureBox2.Location = new Point(x, y);
                    x = pictureBox3.Location.X;
                    y = pictureBox3.Location.Y;
                    if (flag)
                    {
                        pictureBox2.Location = new Point(707, 38);
                        pictureBox3.Location = new Point(635, 38);
                    }

                }
                else
                {
                    pictureBox3.Location = new Point(x, y);
                    x = pictureBox2.Location.X;
                    y = pictureBox2.Location.Y;

                    if (flag)
                    {
                        pictureBox2.Location = new Point(707, 38);
                        pictureBox3.Location = new Point(635, 38);
                    }
                }
            }
          
        }

    }
}

