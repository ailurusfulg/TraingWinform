using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            treeView1.ExpandAll();      // 모든 노드를 펼침
            treeView1.CollapseAll();    // 모든 노드를 접음
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 2, 2));
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("노드 추가할 이름을 넣고, 추가할 폴더를 선택하세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(new TreeNode(textBox1.Text, 1, 0));
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
