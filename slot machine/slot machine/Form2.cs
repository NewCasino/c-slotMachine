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
        int[] speed = { 30, 30, 30 };
        int up;
        int down;
        Random rnd = new Random();
        List<int> loc = new List<int>();
        int thisLow = 0;
        int thisLow2 = 0;
        int checkLow;
        int checklow2;
        int isLow;
        int divideNum = 2;
        int divideNum2 = 2;
        int isLow2;
        int setRealLoc;
        int setRealLoc2;
        int box2Y;
        int box2Y2;
        int box2Y3;
        bool firstColumn;
        bool secondColumn;
        bool thirdColumn;
        int checkLow3;
        int isLow3;
        int thisLow3;
        int setRealLoc3;
        int divideNum3;
        bool turnBack;
        int target;
        int target2;
        int target3;
        bool fruit;
        bool isWin;
        Form3 f3 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label13.Text = Form3.num.ToString();
            pictureboxLoc();
            pictureboxWidtHeight();
            buttonLocation();
            pictureboxLocation();
            pictureboxImage();
            pictureboxRandom();
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", loc[0], loc[1], loc[2], loc[3], loc[4], loc[5]);
            Console.WriteLine("box4:{0},box3:{1}", pictureBox4.Location.Y, pictureBox3.Location.Y);
        }

        private void pictureboxLoc()
        {
            loc.Add(pictureBox1.Location.Y); //banana 200
            loc.Add(pictureBox1.Location.Y + (1 * 120)); //big win 320
            loc.Add(pictureBox1.Location.Y + (2 * 120)); //red 440
            loc.Add(pictureBox1.Location.Y + (3 * 120));//bar 560
            loc.Add(pictureBox1.Location.Y + (4 * 120));//watermelon 680
            loc.Add(pictureBox1.Location.Y + (5 * 120));//7 800
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
            fruit = false;
            foreach (Label a in panel2.Controls)
            {
                a.BackColor = DefaultBackColor;
            }
            reset();
           // i = rnd.Next(-20, 20);
            pictureboxStart();
            target = loc[rnd.Next(0, loc.Count )];
            target2 = loc[rnd.Next(0, loc.Count )];
            target3 = loc[rnd.Next(0, loc.Count )];
            Console.WriteLine("{0} {1} {2}",target,target2,target3);
            timer4.Enabled = true;
            button3.Enabled = false;
            label13.Text = (Convert.ToInt32(label13.Text) - Convert.ToInt32(label11.Text)).ToString();
        }

        private void reset()
        {
            i = 0;
            firstColumn = false;
            secondColumn = false;
            thirdColumn = false;
            speed[0] = 30;
            speed[1] = 30;
            speed[2] = 30;
         
            turnBack = false;
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
                if (firstColumn == false)
                {
                    
                    timer5.Enabled = true;
                }
                if (i >= 160)
                {
                    if (secondColumn == false)
                    {
                        timer7.Enabled = true;
                    }
                   if (i>=200)
                    {
                        if (thirdColumn == false)
                        {
                            timer9.Enabled = true;
                            timer4.Enabled = false;
                        }
                    }
                }
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

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y == target )
            {
                // firstColumn = true;
                 timer5.Enabled = false;
                speed[0] = 0;
                
            }

        }
        
      

        private void timer7_Tick(object sender, EventArgs e)
        {

            if (pictureBox4.Location.Y == target2)
            {
                // firstColumn = true;
                timer7.Enabled = false;
                speed[1] = 0;
            }
           
        }

      
       
        private void timer9_Tick(object sender, EventArgs e)
        {
            if (pictureBox6.Location.Y == target3)
            {
                // firstColumn = true;
                timer9.Enabled = false;
                speed[2] = 0;
                button3.Enabled = true;
                result();
                if (isWin == false)
                {
                    if (label13.Text == "0")
                    {
                        MessageBox.Show("game over");
                        f3.Show();
                        this.Close();
                    }
                }
            }
           
        }

        private void result()
        {
            if (target==320 && target2 == 320 && target3 == 320) //big win
            {
                isWin = true;
                label15.Text = label1.Text;
                label1.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) +Convert.ToInt32( label1.Text)).ToString();
            }
            if (target == 560 && target2 == 560 && target3 == 560) //bar
            {
                isWin = true;
                label15.Text = label2.Text;
                label2.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) +Convert.ToInt32( label2.Text)).ToString();
            }
            if (target == 800 && target2 == 800&& target3 == 800) //7
            {
                isWin = true;
                label15.Text = label3.Text;
                label3.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) +Convert.ToInt32( label3.Text)).ToString();
            }
            if ((target == 680 || target == 200)&&(target2==440||target2==800)&&(target3==560||target3==320))
            {
                isWin = true;
                label15.Text = label4.Text;
                label4.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) + Convert.ToInt32( label4.Text)).ToString();
            }
            if (target == 440 && target2 == 440 && target3 == 440) //red
            {
                isWin = true;
                label15.Text = label5.Text;
                fruit = true;
                label5.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) +Convert.ToInt32( label5.Text)).ToString();
            }
            if (target == 200 && target2 == 200 && target3 == 200) //banana
            {
                isWin = true;
                label15.Text = label6.Text;
                fruit = true;
                label6.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) +Convert.ToInt32( label6.Text)).ToString();
            }
            if (target == 680 && target2 == 680 && target3 == 680) //watermelon
            {
                isWin = true;
                label15.Text = label7.Text;
                fruit = true;
                label7.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) +Convert.ToInt32( label7.Text)).ToString();
            }
            if ((target == 200||target==440||target==680)&& (target2 == 200 || target2 == 440 || target2 == 680) && (target3 == 200 || target3 == 440 || target3 == 680) && fruit == false ) //3 fruit
            {
                isWin = true;
                label15.Text = label8.Text;
                label8.BackColor = Color.Yellow;
                label13.Text = (Convert.ToInt32(label13.Text) + Convert.ToInt32(label8.Text)).ToString();

            }
           

        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label11.Text) < 10 && Convert.ToInt32(label11.Text)<Convert.ToInt32(label13.Text))
            {
                label11.Text = (Convert.ToInt32(label11.Text) + 1).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label11.Text) > 1)
            {
                label11.Text = (Convert.ToInt32(label11.Text) - 1).ToString();
            }
        }

        private void label11_TextChanged(object sender, EventArgs e)
        {
            label1.Text = (200 * Convert.ToInt32( label11.Text)).ToString();
            label2.Text = (50 * Convert.ToInt32(label11.Text)).ToString();
            label3.Text = (20 * Convert.ToInt32(label11.Text)).ToString();
            label4.Text = (16 * Convert.ToInt32(label11.Text)).ToString();
            label5.Text = (15 * Convert.ToInt32(label11.Text)).ToString();
            label6.Text = (14 * Convert.ToInt32(label11.Text)).ToString();
            label7.Text = (12 * Convert.ToInt32(label11.Text)).ToString();
            label8.Text = (7 * Convert.ToInt32(label11.Text)).ToString();
            label9.Text = (4 * Convert.ToInt32(label11.Text)).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}//box1 : 560,320
 //box2:200