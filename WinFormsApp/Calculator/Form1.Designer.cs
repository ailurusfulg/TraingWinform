namespace Calculator
{
    partial class Calculator
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
            this.bNum1 = new System.Windows.Forms.Button();
            this.bNum3 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bNum5 = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bNum2 = new System.Windows.Forms.Button();
            this.bNum4 = new System.Windows.Forms.Button();
            this.bNum6 = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.bPlu = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bNum = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bSign = new System.Windows.Forms.Button();
            this.bNum8 = new System.Windows.Forms.Button();
            this.bNum9 = new System.Windows.Forms.Button();
            this.bNum7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bNum1
            // 
            this.bNum1.Location = new System.Drawing.Point(11, 365);
            this.bNum1.Name = "bNum1";
            this.bNum1.Size = new System.Drawing.Size(80, 80);
            this.bNum1.TabIndex = 0;
            this.bNum1.Text = "1";
            this.bNum1.UseVisualStyleBackColor = true;
            this.bNum1.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum3
            // 
            this.bNum3.Location = new System.Drawing.Point(183, 365);
            this.bNum3.Name = "bNum3";
            this.bNum3.Size = new System.Drawing.Size(80, 80);
            this.bNum3.TabIndex = 0;
            this.bNum3.Text = "3";
            this.bNum3.UseVisualStyleBackColor = true;
            this.bNum3.Click += new System.EventHandler(this.bNum3_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(11, 107);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(164, 80);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bNum5
            // 
            this.bNum5.Location = new System.Drawing.Point(97, 279);
            this.bNum5.Name = "bNum5";
            this.bNum5.Size = new System.Drawing.Size(80, 80);
            this.bNum5.TabIndex = 0;
            this.bNum5.Text = "5";
            this.bNum5.UseVisualStyleBackColor = true;
            this.bNum5.Click += new System.EventHandler(this.bNum5_Click);
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(183, 107);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(80, 80);
            this.bMul.TabIndex = 0;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(269, 107);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(80, 80);
            this.bDiv.TabIndex = 0;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            // 
            // bNum2
            // 
            this.bNum2.Location = new System.Drawing.Point(97, 365);
            this.bNum2.Name = "bNum2";
            this.bNum2.Size = new System.Drawing.Size(80, 80);
            this.bNum2.TabIndex = 0;
            this.bNum2.Text = "2";
            this.bNum2.UseVisualStyleBackColor = true;
            this.bNum2.Click += new System.EventHandler(this.bNum2_Click);
            // 
            // bNum4
            // 
            this.bNum4.Location = new System.Drawing.Point(11, 279);
            this.bNum4.Name = "bNum4";
            this.bNum4.Size = new System.Drawing.Size(80, 80);
            this.bNum4.TabIndex = 0;
            this.bNum4.Text = "4";
            this.bNum4.UseVisualStyleBackColor = true;
            this.bNum4.Click += new System.EventHandler(this.bNum4_Click);
            // 
            // bNum6
            // 
            this.bNum6.Location = new System.Drawing.Point(183, 279);
            this.bNum6.Name = "bNum6";
            this.bNum6.Size = new System.Drawing.Size(80, 80);
            this.bNum6.TabIndex = 0;
            this.bNum6.Text = "6";
            this.bNum6.UseVisualStyleBackColor = true;
            this.bNum6.Click += new System.EventHandler(this.bNum6_Click);
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(269, 365);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(80, 166);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            // 
            // bPlu
            // 
            this.bPlu.Location = new System.Drawing.Point(269, 279);
            this.bPlu.Name = "bPlu";
            this.bPlu.Size = new System.Drawing.Size(80, 80);
            this.bPlu.TabIndex = 0;
            this.bPlu.Text = "+";
            this.bPlu.UseVisualStyleBackColor = true;
            // 
            // bMin
            // 
            this.bMin.Location = new System.Drawing.Point(269, 193);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(80, 80);
            this.bMin.TabIndex = 0;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = true;
            // 
            // bNum
            // 
            this.bNum.Location = new System.Drawing.Point(97, 451);
            this.bNum.Name = "bNum";
            this.bNum.Size = new System.Drawing.Size(80, 80);
            this.bNum.TabIndex = 0;
            this.bNum.Text = "0";
            this.bNum.UseVisualStyleBackColor = true;
            this.bNum.Click += new System.EventHandler(this.bNum_Click);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(183, 451);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(80, 80);
            this.bDot.TabIndex = 0;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            // 
            // bSign
            // 
            this.bSign.Location = new System.Drawing.Point(12, 451);
            this.bSign.Name = "bSign";
            this.bSign.Size = new System.Drawing.Size(80, 80);
            this.bSign.TabIndex = 0;
            this.bSign.Text = "+/-";
            this.bSign.UseVisualStyleBackColor = true;
            this.bSign.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum8
            // 
            this.bNum8.Location = new System.Drawing.Point(95, 193);
            this.bNum8.Name = "bNum8";
            this.bNum8.Size = new System.Drawing.Size(80, 80);
            this.bNum8.TabIndex = 0;
            this.bNum8.Text = "8";
            this.bNum8.UseVisualStyleBackColor = true;
            this.bNum8.Click += new System.EventHandler(this.bNum8_Click);
            // 
            // bNum9
            // 
            this.bNum9.Location = new System.Drawing.Point(181, 193);
            this.bNum9.Name = "bNum9";
            this.bNum9.Size = new System.Drawing.Size(80, 80);
            this.bNum9.TabIndex = 0;
            this.bNum9.Text = "9";
            this.bNum9.UseVisualStyleBackColor = true;
            this.bNum9.Click += new System.EventHandler(this.bNum9_Click);
            // 
            // bNum7
            // 
            this.bNum7.Location = new System.Drawing.Point(11, 193);
            this.bNum7.Name = "bNum7";
            this.bNum7.Size = new System.Drawing.Size(80, 80);
            this.bNum7.TabIndex = 0;
            this.bNum7.Text = "7";
            this.bNum7.UseVisualStyleBackColor = true;
            this.bNum7.Click += new System.EventHandler(this.bNum7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(11, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 47);
            this.textBox1.TabIndex = 1;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 543);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bNum6);
            this.Controls.Add(this.bPlu);
            this.Controls.Add(this.bNum9);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bNum7);
            this.Controls.Add(this.bNum8);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bNum);
            this.Controls.Add(this.bNum2);
            this.Controls.Add(this.bNum5);
            this.Controls.Add(this.bNum4);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bNum3);
            this.Controls.Add(this.bSign);
            this.Controls.Add(this.bNum1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNum1;
        private System.Windows.Forms.Button bNum3;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bNum5;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bNum2;
        private System.Windows.Forms.Button bNum4;
        private System.Windows.Forms.Button bNum6;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bPlu;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bNum;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bSign;
        private System.Windows.Forms.Button bNum8;
        private System.Windows.Forms.Button bNum9;
        private System.Windows.Forms.Button bNum7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

