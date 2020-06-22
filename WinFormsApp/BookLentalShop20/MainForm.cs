using BookRentalShop20;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BookLentalShop20
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }
        private void MnuItemDivMng_Click(object sender, EventArgs e)
        {
            DivForm form = new DivForm();
            InitChildForm(form, "구분코드 관리");

        }
        private void MnuItemUserMng_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            InitChildForm(form, "사용자 관리");

        }
        private void 회원관리MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm();
            InitChildForm(form, "회원 관리");
        }
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LblUserID.Text = Commons.LOGINUSERID;
        }

        private void 책관리BToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        //{
        //    try
        //    {
        //        if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
        //                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            e.Cancel = false;
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
    }
}
