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
            this.Flat = new System.Windows.Forms.Button();
            this.Popup = new System.Windows.Forms.Button();
            this.Standard = new System.Windows.Forms.Button();
            this.System = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flat
            // 
            this.Flat.BackColor = System.Drawing.Color.Crimson;
            this.Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Flat.Font = new System.Drawing.Font("나눔고딕코딩", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Flat.ForeColor = System.Drawing.Color.Cornsilk;
            this.Flat.Location = new System.Drawing.Point(152, 126);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(135, 76);
            this.Flat.TabIndex = 0;
            this.Flat.Text = "Flat";
            this.Flat.UseVisualStyleBackColor = false;
            // 
            // Popup
            // 
            this.Popup.BackColor = System.Drawing.Color.Crimson;
            this.Popup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Popup.Font = new System.Drawing.Font("나눔고딕코딩", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Popup.ForeColor = System.Drawing.Color.Cornsilk;
            this.Popup.Location = new System.Drawing.Point(405, 126);
            this.Popup.Name = "Popup";
            this.Popup.Size = new System.Drawing.Size(135, 76);
            this.Popup.TabIndex = 0;
            this.Popup.Text = "Popup";
            this.Popup.UseVisualStyleBackColor = false;
            // 
            // Standard
            // 
            this.Standard.BackColor = System.Drawing.Color.Crimson;
            this.Standard.Font = new System.Drawing.Font("나눔고딕코딩", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Standard.ForeColor = System.Drawing.Color.Cornsilk;
            this.Standard.Location = new System.Drawing.Point(152, 248);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(135, 76);
            this.Standard.TabIndex = 0;
            this.Standard.Text = "Standard";
            this.Standard.UseVisualStyleBackColor = false;
            // 
            // System
            // 
            this.System.BackColor = System.Drawing.Color.Crimson;
            this.System.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.System.Font = new System.Drawing.Font("나눔고딕코딩", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.System.ForeColor = System.Drawing.Color.Cornsilk;
            this.System.Location = new System.Drawing.Point(405, 248);
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(135, 76);
            this.System.TabIndex = 0;
            this.System.Text = "System";
            this.System.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.System);
            this.Controls.Add(this.Popup);
            this.Controls.Add(this.Standard);
            this.Controls.Add(this.Flat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Flat;
        private System.Windows.Forms.Button Popup;
        private System.Windows.Forms.Button Standard;
        private System.Windows.Forms.Button System;
    }
}

