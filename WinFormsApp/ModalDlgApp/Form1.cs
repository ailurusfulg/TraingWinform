using System;
using System.Windows.Forms;

namespace ModalDlgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            // form.showDialog(); // 모달
            // form.Show();       // 모달리스

            MessageBox.Show("텍스트입니다", "제목", MessageBoxButtons.YesNoCancel);
        }
    }
}
