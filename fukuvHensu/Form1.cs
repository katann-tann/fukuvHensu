using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("岩立一樹");
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -5;
            label1.Text = "↑";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 5;
            vy = 0;
            label1.Text = "→";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = -5;
            vy = 0;
            label1.Text = "←";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 5;
            label1.Text = "↓";
        }
    }
}
