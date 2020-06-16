namespace ButtonTestApp
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
            this.bFlat = new System.Windows.Forms.Button();
            this.bPopup = new System.Windows.Forms.Button();
            this.bStandard = new System.Windows.Forms.Button();
            this.bSystem = new System.Windows.Forms.Button();
            this.LblButtonStyle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bFlat
            // 
            this.bFlat.AutoSize = true;
            this.bFlat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bFlat.Cursor = System.Windows.Forms.Cursors.Default;
            this.bFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFlat.Font = new System.Drawing.Font("나눔고딕코딩", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bFlat.Location = new System.Drawing.Point(58, 60);
            this.bFlat.Name = "bFlat";
            this.bFlat.Size = new System.Drawing.Size(195, 103);
            this.bFlat.TabIndex = 0;
            this.bFlat.Text = "Flat";
            this.bFlat.UseVisualStyleBackColor = false;
            this.bFlat.Click += new System.EventHandler(this.Flat_Click);
            // 
            // bPopup
            // 
            this.bPopup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPopup.Font = new System.Drawing.Font("나눔고딕코딩", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bPopup.Location = new System.Drawing.Point(368, 60);
            this.bPopup.Name = "bPopup";
            this.bPopup.Size = new System.Drawing.Size(195, 103);
            this.bPopup.TabIndex = 1;
            this.bPopup.Text = "Popup";
            this.bPopup.UseVisualStyleBackColor = false;
            this.bPopup.Click += new System.EventHandler(this.Popup_Click);
            // 
            // bStandard
            // 
            this.bStandard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bStandard.Font = new System.Drawing.Font("나눔고딕코딩", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bStandard.Location = new System.Drawing.Point(58, 223);
            this.bStandard.Name = "bStandard";
            this.bStandard.Size = new System.Drawing.Size(195, 103);
            this.bStandard.TabIndex = 2;
            this.bStandard.Text = "Standard";
            this.bStandard.UseVisualStyleBackColor = false;
            this.bStandard.Click += new System.EventHandler(this.Standard_Click);
            // 
            // bSystem
            // 
            this.bSystem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSystem.Font = new System.Drawing.Font("나눔고딕코딩", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bSystem.Location = new System.Drawing.Point(368, 223);
            this.bSystem.Name = "bSystem";
            this.bSystem.Size = new System.Drawing.Size(195, 103);
            this.bSystem.TabIndex = 3;
            this.bSystem.Text = "System";
            this.bSystem.UseVisualStyleBackColor = false;
            this.bSystem.Click += new System.EventHandler(this.System_Click);
            // 
            // LblButtonStyle
            // 
            this.LblButtonStyle.AutoSize = true;
            this.LblButtonStyle.Location = new System.Drawing.Point(33, 376);
            this.LblButtonStyle.Name = "LblButtonStyle";
            this.LblButtonStyle.Size = new System.Drawing.Size(45, 15);
            this.LblButtonStyle.TabIndex = 1;
            this.LblButtonStyle.Text = "label1";
            this.LblButtonStyle.Click += new System.EventHandler(this.LblButtonStyle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblButtonStyle);
            this.Controls.Add(this.bSystem);
            this.Controls.Add(this.bStandard);
            this.Controls.Add(this.bPopup);
            this.Controls.Add(this.bFlat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LblButtonStyle_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFlat;
        private System.Windows.Forms.Button bPopup;
        private System.Windows.Forms.Button bStandard;
        private System.Windows.Forms.Button bSystem;
        private System.Windows.Forms.Label LblButtonStyle;
    }
}

