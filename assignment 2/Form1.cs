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

            double r1, r2;

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
                r1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r1 = 0.0;
            }

            try
            {
                r2 = double.Parse(textBox2.Text);
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

            double ra = 1.0 / (1.0 / r1 + 1.0 / r2);
            label1.Text = "rt = " + ra + " N";


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double r3, r4;
            try
            {
                r3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r3 = 0.0;
            }
            try
            {
                r3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r3 = 0.0;
            }

            try
            {
                r4 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r4 = 0.0;
            }
            try
            {
                r4 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r4 = 0.0;
            }

            double rb = r3 + r4;
            label2.Text = "rt = " + rb + " N";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double r5, r6, r7;
            try
            {
                r5 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r5 = 0.0;
            }
            try
            {
                r5 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r5 = 0.0;
            }

            try
            {
                r6 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r6 = 0.0;
            }
            try
            {
                r6 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r6 = 0.0;
            }

            try
            {
                r7 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r7 = 0.0;
            }
            try
            {
                r7 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r7 = 0.0;
            }

                double rc = 1.0 / (1.0 / r5 + 1.0 / r6 + 1.0 / r7);
                label3.Text = "rt = " + rc + " N";
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double r8, r9, r10;
            try
            {
                r8 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r8 = 0.0;
            }
            try
            {
                r8 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r8 = 0.0;
            }

            try
            {
                r9 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r9 = 0.0;
            }
            try
            {
                r9 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r9 = 0.0;
            }
            try
            {
                r10 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                r10 = 0.0;
            }
            try
            {
                r10 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                r10 = 0.0;
            }

            double rd = r8 + r9 + r10;
            label4.Text = "rt = " + rd + " N";
        }
    }
}