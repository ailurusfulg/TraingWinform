using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = $"ID : { textBox1.Text} \r\nPASSWORD : { textBox2.Text}";

            if ((textBox1.Text.ToUpper() == "ADMIN") && (textBox2.Text.ToUpper() == "P@SSW0RD!"))
            {
                MessageBox.Show("관리자 로그인!!");
            }
        }
    }
}
