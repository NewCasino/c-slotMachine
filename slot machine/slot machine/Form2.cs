using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_machine
{
    public partial class Form2 : Form
    {
        //const int speed = 20;
        int[] speed = { 20, 20, 20 };
        int up;
        int down;
        Random rnd = new Random();
        List<int> loc = new List<int>();
        int thisLow = 0;
        int checkLow;
        int isLow;
        int setRealLoc;
        int box2Y;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            pictureboxLoc();
            pictureboxWidtHeight();
            buttonLocation();
            pictureboxLocation();
            pictureboxImage();
            pictureboxRandom();
            Console.WriteLine("{0},{1},{2},{3},{4},{5},({6},{7},{8},{9},{10}", loc[0], loc[1], loc[2], loc[3], loc[4], loc[5], loc[6], loc[7], loc[8], loc[9], loc[10]);
            Console.WriteLine("box4:{0},box3:{1}", pictureBox4.Location.Y, pictureBox3.Location.Y);
        }

        private void pictureboxLoc()
        {
            loc.Add(pictureBox1.Location.Y);
            loc.Add(pictureBox1.Location.Y + (1 * 120));
            loc.Add(pictureBox1.Location.Y + (2 * 120));
            loc.Add(pictureBox1.Location.Y + (3 * 120));
            loc.Add(pictureBox1.Location.Y + (4 * 120));
            loc.Add(pictureBox1.Location.Y + (5 * 120));
            loc.Add(pictureBox1.Location.Y - (1 * 120));
            loc.Add(pictureBox1.Location.Y - (2 * 120));
            loc.Add(pictureBox1.Location.Y - (3 * 120));
            loc.Add(pictureBox1.Location.Y - (4 * 120));
            loc.Add(pictureBox1.Location.Y - (5 * 120));
        }

        private void pictureboxRandom()
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, up + (rnd.Next(0, 6) * 120));
            pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - Properties.Resources.reel_strip.Height);

            pictureBox4.Location = new Point(pictureBox4.Location.X, up + (rnd.Next(0, 6) * 120));
            pictureBox3.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - Properties.Resources.reel_strip.Height);

            pictureBox6.Location = new Point(pictureBox6.Location.X, up + (rnd.Next(0, 6) * 120));
            pictureBox5.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - Properties.Resources.reel_strip.Height);


        }

        private void pictureboxStart()
        {
            //pictureboxRandom();
            //Console.WriteLine(rndNum);
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void pictureboxImage()
        {
            pictureBox1.Image = Properties.Resources.reel_strip;
            pictureBox2.Image = Properties.Resources.reel_strip;
            pictureBox3.Image = Properties.Resources.reel_strip;
            pictureBox4.Image = Properties.Resources.reel_strip;
            pictureBox5.Image = Properties.Resources.reel_strip;
            pictureBox6.Image = Properties.Resources.reel_strip;
        }

        private void pictureboxLocation()
        {
            pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - Properties.Resources.reel_strip.Height);
            pictureBox3.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - Properties.Resources.reel_strip.Height);
            pictureBox5.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - Properties.Resources.reel_strip.Height);
        }

        private void buttonLocation()
        {
            button1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            button2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + Properties.Resources.reel_strip.Height);
            up = button1.Location.Y;
            down = button2.Location.Y;
        }

        private void pictureboxWidtHeight()
        {
            pictureBox1.Width = Properties.Resources.reel_strip.Width;
            pictureBox1.Height = Properties.Resources.reel_strip.Height;

            pictureBox2.Width = Properties.Resources.reel_strip.Width;
            pictureBox2.Height = Properties.Resources.reel_strip.Height;

            pictureBox3.Width = Properties.Resources.reel_strip.Width;
            pictureBox3.Height = Properties.Resources.reel_strip.Height;

            pictureBox4.Width = Properties.Resources.reel_strip.Width;
            pictureBox4.Height = Properties.Resources.reel_strip.Height;

            pictureBox5.Width = Properties.Resources.reel_strip.Width;
            pictureBox5.Height = Properties.Resources.reel_strip.Height;

            pictureBox6.Width = Properties.Resources.reel_strip.Width;
            pictureBox6.Height = Properties.Resources.reel_strip.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + speed[0]);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + speed[0]);
            if (pictureBox1.Location.Y >= down)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
            if (pictureBox2.Location.Y >= down)
            {
                pictureBox2.Location = new Point(pictureBox1.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + speed[1]);
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + speed[1]);
            if (pictureBox4.Location.Y >= down)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
            if (pictureBox3.Location.Y >= down)
            {
                pictureBox3.Location = new Point(pictureBox4.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + speed[2]);
            pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + speed[2]);
            if (pictureBox6.Location.Y >= down)
            {
                pictureBox6.Location = new Point(pictureBox6.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
            if (pictureBox5.Location.Y >= down)
            {
                pictureBox5.Location = new Point(pictureBox6.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
        }
        int i;
        private void button3_Click(object sender, EventArgs e)
        {
            i = rnd.Next(-20, 20);
            pictureboxStart();
            timer4.Enabled = true;
            //pictureboxStop();
        }

        private void pictureboxStop()
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i >= 120)
            {
               // timer4.Enabled = false;
                timer5.Enabled = true;
                if (i >= 140)
                {
                    timer7.Enabled = true;
                }
            }
           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (speed[0] > 0)
            {
                speed[0] -= 2;
            }
            else
            {
                timer5.Enabled = false;
                checkLow = pictureBox1.Location.Y;//278   78,42,162
                if (checkLow < 0)
                isLow = Math.Abs( checkLow);

                foreach (int a in loc)
                {
                    checkLow = Math.Abs(a - pictureBox1.Location.Y);
                    if (checkLow < isLow)
                    {
                        isLow = checkLow;
                        thisLow = a;
                    }
                }
                setRealLoc = thisLow;
                 box2Y =0;
                //   Console.WriteLine()
                 timer6.Enabled = true;
               // pushToAns();
            }
        }

        private void pushToAns()
        {
            if (pictureBox1.Location.Y > thisLow)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-isLow);//--
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y -isLow);
                Console.WriteLine("box1Y{0},boy2Y{1}", pictureBox1.Location.Y, pictureBox2.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + isLow);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + isLow);
                Console.WriteLine("box1Y{0},boy2Y{1}", pictureBox1.Location.Y, pictureBox2.Location.Y);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > thisLow)
            {
                if (isLow > box2Y)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);//--
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 2);
                }
            }
            else if (pictureBox1.Location.Y < thisLow)
            {
                if (isLow > box2Y)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 2);
                }
            }
            else if (pictureBox1.Location.Y == thisLow)
            {
                timer6.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, 80);
            pictureBox2.Visible = false;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (speed[1] > 0)
            {
                speed[1] -= 2;
            }
            else
            {
                timer7.Enabled = false;
                checkLow = pictureBox4.Location.Y;
                isLow = Math.Abs(checkLow);

                foreach (int a in loc)
                {
                    checkLow = Math.Abs(a - pictureBox4.Location.Y);
                    if (checkLow < isLow)
                    {
                        isLow = checkLow;
                        thisLow = a;
                    }
                }
                setRealLoc = thisLow;
                box2Y = 0;
                timer8.Enabled = true;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Location.Y > thisLow)
            {
                if (isLow > box2Y)
                {
                    pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 2);//--
                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 2);
                }
            }
            else if (pictureBox4.Location.Y < thisLow)
            {
                if (isLow > box2Y)
                {
                    pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 2);
                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 2);
                }
            }
            else if (pictureBox4.Location.Y == thisLow)
            {
                timer8.Enabled = false;
            }
        }
    }
}//box1 : 560,320
 //box2:200