﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("베토벤", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("모차르트", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("차이코프스키", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("클래식", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드7", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드8", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드9", 2, 2);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("팝", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("노드10", 2, 2);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("노드11", 2, 2);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("노드12", 2, 2);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("K-pop", 1, 0, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "노드4";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "베토벤";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "노드5";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "모차르트";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "노드6";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "차이코프스키";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "클래식";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "노드7";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "노드7";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "노드8";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "노드8";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "노드9";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "노드9";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "팝";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "노드10";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "노드10";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "노드11";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "노드11";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "노드12";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "노드12";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Node2";
            treeNode12.SelectedImageIndex = 0;
            treeNode12.Text = "K-pop";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(563, 289);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(201, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "노드추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(304, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "노드제거";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_open.png");
            this.imageList1.Images.SetKeyName(1, "folder_close.png");
            this.imageList1.Images.SetKeyName(2, "dvd.png");
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(563, 25);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

