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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public static decimal num;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            num = numericUpDown1.Value;
            f2.Show();

        }

       
    }
}
