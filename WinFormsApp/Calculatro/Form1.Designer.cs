namespace Calculatro
{
    partial class Calcurator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bMark = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bNum1 = new System.Windows.Forms.Button();
            this.bNum2 = new System.Windows.Forms.Button();
            this.bNum3 = new System.Windows.Forms.Button();
            this.bNum4 = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bNum5 = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.bNum6 = new System.Windows.Forms.Button();
            this.bNum8 = new System.Windows.Forms.Button();
            this.bNum7 = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bNum9 = new System.Windows.Forms.Button();
            this.bPower = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕코딩", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 67);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bMark
            // 
            this.bMark.Location = new System.Drawing.Point(23, 399);
            this.bMark.Name = "bMark";
            this.bMark.Size = new System.Drawing.Size(61, 52);
            this.bMark.TabIndex = 1;
            this.bMark.Text = "+/-";
            this.bMark.UseVisualStyleBackColor = true;
            // 
            // bNum0
            // 
            this.button0.Location = new System.Drawing.Point(108, 399);
            this.button0.Name = "bNum0";
            this.button0.Size = new System.Drawing.Size(61, 52);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(193, 399);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(61, 52);
            this.bDot.TabIndex = 1;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            // 
            // bNum1
            // 
            this.bNum1.Location = new System.Drawing.Point(23, 333);
            this.bNum1.Name = "bNum1";
            this.bNum1.Size = new System.Drawing.Size(61, 52);
            this.bNum1.TabIndex = 1;
            this.bNum1.Text = "1";
            this.bNum1.UseVisualStyleBackColor = true;
            this.bNum1.Click += new System.EventHandler(this.button4_Click);
            // 
            // bNum2
            // 
            this.bNum2.Location = new System.Drawing.Point(108, 333);
            this.bNum2.Name = "bNum2";
            this.bNum2.Size = new System.Drawing.Size(61, 52);
            this.bNum2.TabIndex = 1;
            this.bNum2.Text = "2";
            this.bNum2.UseVisualStyleBackColor = true;
            // 
            // bNum3
            // 
            this.bNum3.Location = new System.Drawing.Point(193, 333);
            this.bNum3.Name = "bNum3";
            this.bNum3.Size = new System.Drawing.Size(61, 52);
            this.bNum3.TabIndex = 1;
            this.bNum3.Text = "3";
            this.bNum3.UseVisualStyleBackColor = true;
            // 
            // bNum4
            // 
            this.bNum4.Location = new System.Drawing.Point(23, 265);
            this.bNum4.Name = "bNum4";
            this.bNum4.Size = new System.Drawing.Size(61, 52);
            this.bNum4.TabIndex = 1;
            this.bNum4.Text = "4";
            this.bNum4.UseVisualStyleBackColor = true;
            this.bNum4.Click += new System.EventHandler(this.button7_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(278, 265);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(61, 52);
            this.bPlus.TabIndex = 1;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.button8_Click);
            // 
            // bNum5
            // 
            this.bNum5.Location = new System.Drawing.Point(108, 265);
            this.bNum5.Name = "bNum5";
            this.bNum5.Size = new System.Drawing.Size(61, 52);
            this.bNum5.TabIndex = 1;
            this.bNum5.Text = "5";
            this.bNum5.UseVisualStyleBackColor = true;
            this.bNum5.Click += new System.EventHandler(this.button9_Click);
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(278, 333);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(61, 118);
            this.bEnter.TabIndex = 1;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            // 
            // bNum6
            // 
            this.bNum6.Location = new System.Drawing.Point(193, 265);
            this.bNum6.Name = "bNum6";
            this.bNum6.Size = new System.Drawing.Size(61, 52);
            this.bNum6.TabIndex = 1;
            this.bNum6.Text = "6";
            this.bNum6.UseVisualStyleBackColor = true;
            this.bNum6.Click += new System.EventHandler(this.button11_Click);
            // 
            // bNum8
            // 
            this.bNum8.Location = new System.Drawing.Point(108, 195);
            this.bNum8.Name = "bNum8";
            this.bNum8.Size = new System.Drawing.Size(61, 52);
            this.bNum8.TabIndex = 1;
            this.bNum8.Text = "8";
            this.bNum8.UseVisualStyleBackColor = true;
            this.bNum8.Click += new System.EventHandler(this.button9_Click);
            // 
            // bNum7
            // 
            this.bNum7.Location = new System.Drawing.Point(23, 195);
            this.bNum7.Name = "bNum7";
            this.bNum7.Size = new System.Drawing.Size(61, 52);
            this.bNum7.TabIndex = 1;
            this.bNum7.Text = "7";
            this.bNum7.UseVisualStyleBackColor = true;
            this.bNum7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(278, 195);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(61, 52);
            this.bMinus.TabIndex = 1;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.button8_Click);
            // 
            // bNum9
            // 
            this.bNum9.Location = new System.Drawing.Point(193, 195);
            this.bNum9.Name = "bNum9";
            this.bNum9.Size = new System.Drawing.Size(61, 52);
            this.bNum9.TabIndex = 1;
            this.bNum9.Text = "9";
            this.bNum9.UseVisualStyleBackColor = true;
            this.bNum9.Click += new System.EventHandler(this.button11_Click);
            // 
            // bPower
            // 
            this.bPower.Location = new System.Drawing.Point(23, 123);
            this.bPower.Name = "bPower";
            this.bPower.Size = new System.Drawing.Size(61, 52);
            this.bPower.TabIndex = 1;
            this.bPower.Text = "On/Off";
            this.bPower.UseVisualStyleBackColor = true;
            this.bPower.Click += new System.EventHandler(this.button7_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(108, 123);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(61, 52);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button9_Click);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(193, 123);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(61, 52);
            this.bDiv.TabIndex = 1;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.button11_Click);
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(278, 123);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(61, 52);
            this.bMul.TabIndex = 1;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.button8_Click);
            // 
            // Calcurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 477);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bNum9);
            this.Controls.Add(this.bNum6);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bPower);
            this.Controls.Add(this.bNum7);
            this.Controls.Add(this.bNum3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.bNum8);
            this.Controls.Add(this.bNum4);
            this.Controls.Add(this.bNum5);
            this.Controls.Add(this.bNum2);
            this.Controls.Add(this.bNum1);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.bMark);
            this.Controls.Add(this.textBox1);
            this.Name = "Calcurator";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bMark;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bNum1;
        private System.Windows.Forms.Button bNum2;
        private System.Windows.Forms.Button bNum3;
        private System.Windows.Forms.Button bNum4;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bNum5;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bNum6;
        private System.Windows.Forms.Button bNum8;
        private System.Windows.Forms.Button bNum7;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bNum9;
        private System.Windows.Forms.Button bPower;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMul;
    }
}

