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
        const int speed = 20;
        int up;
        int down;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureboxWidtHeight();
            buttonLocation();
            pictureboxLocation();
            pictureboxImage();
        }
        
        private void pictureboxImage()
        {
            pictureBox1.Image = Properties.Resources.reel_strip;
            pictureBox2.Image = Properties.Resources.reel_strip;
            pictureBox3.Image = Properties.Resources.reel_strip;
            pictureBox4.Image = Properties.Resources.reel_strip;
        }

        private void pictureboxLocation()
        {
            pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - Properties.Resources.reel_strip.Height);
            pictureBox3.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - Properties.Resources.reel_strip.Height);
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + speed);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + speed);
            if (pictureBox1.Location.Y >= down)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
            if (pictureBox2.Location.Y >= down)
            {
                pictureBox2.Location = new Point(pictureBox1.Location.X, button1.Location.Y - Properties.Resources.reel_strip.Height);
            }
        }
    }
}
