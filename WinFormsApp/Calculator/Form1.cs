using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        
        int x = 0;
        

        public Calculator()
        {
            InitializeComponent();
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            int x = 0;
        }

        private void bNum1_Click(object sender, EventArgs e)
        {
            label1.Text = $"1";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = x.ToString();
        }
    }
}
