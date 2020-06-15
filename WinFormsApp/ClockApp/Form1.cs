using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form 로드 시 발생"); // 초기화 할 것들은 폼 로드에 기입
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form 클로즈 시 발생");
        }

        private void Form1_Activated(object sender, EventArgs e) // 폼 클로징은 닫기 버튼 눌렀을 때, 폼 클로즈드는 아예 꺼지고 나서
        {
            MessageBox.Show("Form 활성화 시 발생");
        }

        private void ㄴ(object sender, EventArgs e)
        {

        }
    }
}
