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
    public partial class Form1 : Form
    {
        const int picSpeed = 1;
        int picY;//240
        int pic2Y;
        bool a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            pictureBox1.Image = Properties.Resources._851592_279586392215626_1440866487_n;
            pictureBox2.Image = Properties.Resources._851592_279586392215626_1440866487_n;

            pictureBox1.Width = Properties.Resources._851592_279586392215626_1440866487_n.Width;
            pictureBox1.Height = Properties.Resources._851592_279586392215626_1440866487_n.Height;
            pictureBox2.Width = Properties.Resources._851592_279586392215626_1440866487_n.Width;
            pictureBox2.Height = Properties.Resources._851592_279586392215626_1440866487_n.Height;

            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox1.Location.Y - Properties.Resources._851592_279586392215626_1440866487_n.Height);
            picY = 288;//pictureBox1.Location.Y;
            Console.WriteLine(picY);
            pic2Y = pictureBox2.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Height > 0 && a==false)
            {
                pictureBox1.Height -= picSpeed;
                pictureBox1.Location = new Point(pictureBox1.Location.X, picY += picSpeed);
                Console.WriteLine("a");
            }
            else
            {
                a = true;
                Console.Write("b");
                pictureBox1.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - Properties.Resources._851592_279586392215626_1440866487_n.Height);
                pictureBox1.Height = Properties.Resources._851592_279586392215626_1440866487_n.Height;
            }
          

            // pictureBox2.Height += picSpeed;
            pictureBox2.Location = new Point(pictureBox2.Location.X, pic2Y += picSpeed);
            if ((pictureBox2.Location.Y + pictureBox2.Height) > pictureBox1.Location.Y)
            {
                pictureBox2.Height -= picSpeed;
              //  Console.WriteLine(pictureBox2.Height);
                  if (pictureBox2.Height <= 0)
                {
                    picY = 288;
                    Console.WriteLine("C");
                   a = false;
                    Console.WriteLine(pictureBox1.Location.Y & pictureBox2.Location.Y);
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox1.Location.Y + Properties.Resources._851592_279586392215626_1440866487_n.Height);
                    pictureBox2.Height = Properties.Resources._851592_279586392215626_1440866487_n.Height;
                }
            }
           
        }
    }
}
