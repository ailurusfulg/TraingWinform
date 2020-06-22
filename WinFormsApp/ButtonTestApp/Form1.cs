using System;
using System.Windows.Forms;

namespace ButtonTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Flat_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void System_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.System.ToString();
        }

        private void Standard_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Standard.ToString();
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Popup.ToString();
        }

        private void LblButtonStyle_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = "결과표시";
        }
    }
}
