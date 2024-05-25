namespace Kiosk_Management_System
{
    partial class PaymentForm
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
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_cash = new System.Windows.Forms.Button();
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_credit
            // 
            this.btn_credit.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_credit.ForeColor = System.Drawing.Color.White;
            this.btn_credit.Location = new System.Drawing.Point(214, 111);
            this.btn_credit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(136, 67);
            this.btn_credit.TabIndex = 0;
            this.btn_credit.Text = "신용카드";
            this.btn_credit.UseVisualStyleBackColor = false;
            // 
            // btn_cash
            // 
            this.btn_cash.BackColor = System.Drawing.Color.Green;
            this.btn_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cash.ForeColor = System.Drawing.Color.White;
            this.btn_cash.Location = new System.Drawing.Point(48, 111);
            this.btn_cash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(136, 67);
            this.btn_cash.TabIndex = 0;
            this.btn_cash.Text = "현금";
            this.btn_cash.UseVisualStyleBackColor = false;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // btn_easy
            // 
            this.btn_easy.BackColor = System.Drawing.Color.Gold;
            this.btn_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_easy.Location = new System.Drawing.Point(48, 201);
            this.btn_easy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(136, 67);
            this.btn_easy.TabIndex = 0;
            this.btn_easy.Text = "간편결제";
            this.btn_easy.UseVisualStyleBackColor = false;
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.Tomato;
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_point.ForeColor = System.Drawing.Color.White;
            this.btn_point.Location = new System.Drawing.Point(214, 201);
            this.btn_point.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(136, 67);
            this.btn_point.TabIndex = 0;
            this.btn_point.Text = "포인트 사용";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(98, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "결제 방식 선택";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.btn_cash);
            this.Controls.Add(this.btn_credit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaymentForm";
            this.Text = "결제 방식 선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Label label2;
    }
}