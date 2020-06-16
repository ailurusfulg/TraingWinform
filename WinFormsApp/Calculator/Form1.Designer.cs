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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bNum1
            // 
            this.bNum1.Location = new System.Drawing.Point(11, 304);
            this.bNum1.Name = "bNum1";
            this.bNum1.Size = new System.Drawing.Size(80, 80);
            this.bNum1.TabIndex = 0;
            this.bNum1.Text = "1";
            this.bNum1.UseVisualStyleBackColor = true;
            this.bNum1.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum3
            // 
            this.bNum3.Location = new System.Drawing.Point(183, 304);
            this.bNum3.Name = "bNum3";
            this.bNum3.Size = new System.Drawing.Size(80, 80);
            this.bNum3.TabIndex = 0;
            this.bNum3.Text = "3";
            this.bNum3.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(11, 132);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(80, 80);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bNum5
            // 
            this.bNum5.Location = new System.Drawing.Point(97, 218);
            this.bNum5.Name = "bNum5";
            this.bNum5.Size = new System.Drawing.Size(80, 80);
            this.bNum5.TabIndex = 0;
            this.bNum5.Text = "5";
            this.bNum5.UseVisualStyleBackColor = true;
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(183, 132);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(80, 80);
            this.bMul.TabIndex = 0;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(97, 132);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(80, 80);
            this.bDiv.TabIndex = 0;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            // 
            // bNum2
            // 
            this.bNum2.Location = new System.Drawing.Point(97, 304);
            this.bNum2.Name = "bNum2";
            this.bNum2.Size = new System.Drawing.Size(80, 80);
            this.bNum2.TabIndex = 0;
            this.bNum2.Text = "2";
            this.bNum2.UseVisualStyleBackColor = true;
            // 
            // bNum4
            // 
            this.bNum4.Location = new System.Drawing.Point(11, 218);
            this.bNum4.Name = "bNum4";
            this.bNum4.Size = new System.Drawing.Size(80, 80);
            this.bNum4.TabIndex = 0;
            this.bNum4.Text = "4";
            this.bNum4.UseVisualStyleBackColor = true;
            // 
            // bNum6
            // 
            this.bNum6.Location = new System.Drawing.Point(183, 218);
            this.bNum6.Name = "bNum6";
            this.bNum6.Size = new System.Drawing.Size(80, 80);
            this.bNum6.TabIndex = 0;
            this.bNum6.Text = "6";
            this.bNum6.UseVisualStyleBackColor = true;
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(269, 304);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(80, 166);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            // 
            // bPlu
            // 
            this.bPlu.Location = new System.Drawing.Point(269, 218);
            this.bPlu.Name = "bPlu";
            this.bPlu.Size = new System.Drawing.Size(80, 80);
            this.bPlu.TabIndex = 0;
            this.bPlu.Text = "+";
            this.bPlu.UseVisualStyleBackColor = true;
            // 
            // bMin
            // 
            this.bMin.Location = new System.Drawing.Point(269, 132);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(80, 80);
            this.bMin.TabIndex = 0;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = true;
            // 
            // bNum
            // 
            this.bNum.Location = new System.Drawing.Point(97, 390);
            this.bNum.Name = "bNum";
            this.bNum.Size = new System.Drawing.Size(80, 80);
            this.bNum.TabIndex = 0;
            this.bNum.Text = "0";
            this.bNum.UseVisualStyleBackColor = true;
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(183, 390);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(80, 80);
            this.bDot.TabIndex = 0;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            // 
            // bSign
            // 
            this.bSign.Location = new System.Drawing.Point(12, 390);
            this.bSign.Name = "bSign";
            this.bSign.Size = new System.Drawing.Size(80, 80);
            this.bSign.TabIndex = 0;
            this.bSign.Text = "+/-";
            this.bSign.UseVisualStyleBackColor = true;
            this.bSign.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("굴림", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNum6);
            this.Controls.Add(this.bPlu);
            this.Controls.Add(this.bMin);
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
        private System.Windows.Forms.Label label1;
    }
}

