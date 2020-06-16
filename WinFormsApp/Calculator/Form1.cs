using System;
using System.Runtime;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    { 
        public Calculator()
        {
            InitializeComponent();
        }
        private void bClear_Click(object sender, EventArgs e)
        {
           textBox1.Text = "";
        }
        private void bNum1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void bNum2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void bNum3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        private void bNum4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        private void bNum5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        private void bNum6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        private void bNum7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        private void bNum8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        private void bNum9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void bNum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
    }
}
