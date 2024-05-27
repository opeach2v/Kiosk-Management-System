namespace Kiosk_Management_System
{
    partial class PointSelectForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_point = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_use = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_usePoint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(137, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "포인트 사용/조회";
            // 
            // tb_point
            // 
            this.tb_point.BackColor = System.Drawing.Color.Silver;
            this.tb_point.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_point.Location = new System.Drawing.Point(286, 128);
            this.tb_point.Name = "tb_point";
            this.tb_point.ReadOnly = true;
            this.tb_point.Size = new System.Drawing.Size(178, 32);
            this.tb_point.TabIndex = 6;
            this.tb_point.TextChanged += new System.EventHandler(this.tb_point_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(106, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "보유 포인트";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(307, 259);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 38);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_use
            // 
            this.btn_use.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_use.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_use.Location = new System.Drawing.Point(142, 259);
            this.btn_use.Name = "btn_use";
            this.btn_use.Size = new System.Drawing.Size(118, 38);
            this.btn_use.TabIndex = 8;
            this.btn_use.Text = "사용";
            this.btn_use.UseVisualStyleBackColor = false;
            this.btn_use.Click += new System.EventHandler(this.btn_use_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(106, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "사용할 포인트";
            // 
            // tb_usePoint
            // 
            this.tb_usePoint.BackColor = System.Drawing.Color.White;
            this.tb_usePoint.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_usePoint.Location = new System.Drawing.Point(286, 191);
            this.tb_usePoint.Name = "tb_usePoint";
            this.tb_usePoint.Size = new System.Drawing.Size(178, 32);
            this.tb_usePoint.TabIndex = 9;
            this.tb_usePoint.TextChanged += new System.EventHandler(this.tb_usePoint_TextChanged);
            // 
            // PointSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_usePoint);
            this.Controls.Add(this.btn_use);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_point);
            this.Controls.Add(this.label2);
            this.Name = "PointSelectForm";
            this.Text = "PointSelectForm";
            this.Load += new System.EventHandler(this.PointSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_use;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_usePoint;
    }
}