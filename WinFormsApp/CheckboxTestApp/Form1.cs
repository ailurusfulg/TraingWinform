using System;
using System.Windows.Forms;

namespace CheckboxTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private string strTemp = "";

        //private void UpdateLabel(string s, bool b)
        //{
        //    if (b == true)
        //    {
        //        strTemp += " " + s + " ";
        //        label2.Text = strTemp;
        //    }
        //    else
        //    {
        //        strTemp = label2.Text;
        //        int i = strTemp.IndexOf(s.Substring(0, 1));
        //        int j = i + s.Length;
        //        label2.Text = strTemp.Remove(i, j - i);
        //    }
        //}

        private void UpdateLabel()
        {
            string strchk1 = "", strchk2 = "", strchk3 = "", strchk4 = "";
            if (checkBox1.Checked) strchk1 = checkBox1.Text;
            else strchk1 = "";
            if (checkBox2.Checked) strchk2 = checkBox2.Text;
            else strchk2 = "";
            if (checkBox3.Checked) strchk3 = checkBox3.Text;
            else strchk3 = "";
            if (checkBox4.Checked) strchk4 = checkBox4.Text;
            else strchk4 = "";

            label2.Text = strchk1 + " " + strchk2 + " " + strchk3 + " " + strchk4 + " ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "좋아하는 과일 : ";
        }
    }
}
