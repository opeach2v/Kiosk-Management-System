namespace Kiosk_Management_System
{
    partial class OptionPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_password.Location = new System.Drawing.Point(78, 130);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(224, 30);
            this.tb_password.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_login.Location = new System.Drawing.Point(141, 174);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 34);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "키오스크 관리 시스템\r\n비밀번호 입력";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(70, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tip! 초기 비밀번호는 0000입니다";
            // 
            // OptionPasswordForm
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(378, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Name = "OptionPasswordForm";
            this.Text = "키오스크 관리 시스템 로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionPasswordForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}