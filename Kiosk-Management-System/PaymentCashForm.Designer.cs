namespace Kiosk_Management_System
{
    partial class PaymentCashForm
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_change = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_receiveAmount = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Silver;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(300, 296);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 38);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_ok.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(125, 296);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(99, 38);
            this.btn_ok.TabIndex = 23;
            this.btn_ok.Text = "결제";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_change
            // 
            this.tb_change.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_change.Location = new System.Drawing.Point(201, 232);
            this.tb_change.Margin = new System.Windows.Forms.Padding(2);
            this.tb_change.Name = "tb_change";
            this.tb_change.Size = new System.Drawing.Size(224, 30);
            this.tb_change.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(68, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "거스름돈";
            // 
            // tb_receiveAmount
            // 
            this.tb_receiveAmount.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_receiveAmount.Location = new System.Drawing.Point(201, 174);
            this.tb_receiveAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_receiveAmount.Name = "tb_receiveAmount";
            this.tb_receiveAmount.Size = new System.Drawing.Size(224, 30);
            this.tb_receiveAmount.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(66, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "받은 금액";
            // 
            // tb_amount
            // 
            this.tb_amount.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_amount.Location = new System.Drawing.Point(201, 115);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(224, 30);
            this.tb_amount.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(66, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "결제 금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(166, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "현금 결제";
            // 
            // PaymentCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 374);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_receiveAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaymentCashForm";
            this.Text = "현금 결제";
            this.Load += new System.EventHandler(this.PaymentCashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.MaskedTextBox tb_change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_receiveAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tb_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}