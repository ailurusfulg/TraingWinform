using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // MessageBox.Show($"Hell World! {now}");
            TxtCurrentDate.Text = now.ToString();
        }

        private void g_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCurrentDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
