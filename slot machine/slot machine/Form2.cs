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
        const int speed = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = Properties.Resources._851592_279586392215626_1440866487_n.Width;
            pictureBox1.Height = Properties.Resources._851592_279586392215626_1440866487_n.Height;

            pictureBox2.Width = Properties.Resources._851592_279586392215626_1440866487_n.Width;
            pictureBox2.Height = Properties.Resources._851592_279586392215626_1440866487_n.Height;

            button1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
            button2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+ Properties.Resources._851592_279586392215626_1440866487_n.Height);
            pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - Properties.Resources._851592_279586392215626_1440866487_n.Height);

            pictureBox1.Image = Properties.Resources._851592_279586392215626_1440866487_n;
            pictureBox2.Image = Properties.Resources._851592_279586392215626_1440866487_n;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + speed);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + speed);

           // if (pictureBox1.Location.Y - )
        }
    }
}
