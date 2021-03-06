﻿using System;
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
            if (MessageBox.Show("진짜 닫을래?", "경고",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false; // 취소를 안시켜서 종료
            }
            else
            {
                e.Cancel = true; // 취소시키니까 종료 안됨
            }
        }


    }
}
