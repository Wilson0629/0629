using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "test2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "153";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "22222";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "660";
        }
    }
}
