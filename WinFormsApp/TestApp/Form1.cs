using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            // openFileDialog1.InitialDirectory = "@C:W";
            // openFileDialog1.Filter = "모든파일(*.*)|*.*";
            openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();

            foreach (var item in openFileDialog1.FileName)
            {
                textBox1.Text += item;
                // textBox1.Text += Environment.NewLine;
                textBox1.Text += "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
            }
        }
    }
}
