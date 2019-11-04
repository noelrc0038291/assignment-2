using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double rt, r1, r2;
            try
            {
                rt = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                rt = 0.0;
            }
            try
            {
                rt = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                rt = 0.0;
            }

            try
            {
                r1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r1 = 0.0;
            }
            try
            {
                r1 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r1 = 0.0;
            }

            try
            {
                r2 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r2 = 0.0;
            }
            try
            {
                r2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r2 = 0.0;
            }

            double rr = 1.0 / (1.0 / r1 + 1.0 / r2);
            label1.Text = "rt = " + rr + " N";

          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double rt, r1, r2;
            try
            {
                rt = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                rt = 0.0;
            }
            try
            {
                rt = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                rt = 0.0;
            }

            try
            {
                r1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r1 = 0.0;
            }
            try
            {
                r1 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r1 = 0.0;
            }

            try
            {
                r2 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r2 = 0.0;
            }
            try
            {
                r2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r2 = 0.0;
            }

            double rr = r1 + r2;
            label2.Text = "rt = " + rr + " N";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
