namespace Kiosk_Management_System
{
    partial class UpdateDrinkForm
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(146, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = "음료 변경";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(264, 342);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 44);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(96, 342);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 44);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "변경";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "커피",
            "논커피",
            "에이드/차",
            "스무디",
            "디저트"});
            this.cb_category.Location = new System.Drawing.Point(182, 122);
            this.cb_category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(213, 30);
            this.cb_category.TabIndex = 14;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(182, 178);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(213, 30);
            this.tb_name.TabIndex = 11;
            // 
            // tb_count
            // 
            this.tb_count.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_count.Location = new System.Drawing.Point(182, 233);
            this.tb_count.Margin = new System.Windows.Forms.Padding(2);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(213, 30);
            this.tb_count.TabIndex = 12;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(182, 288);
            this.tb_price.Margin = new System.Windows.Forms.Padding(2);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(213, 30);
            this.tb_price.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "갯수";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(82, 125);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 25);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "종류";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(82, 290);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 25);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "가격";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(82, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 25);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "이름";
            // 
            // UpdateDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateDrinkForm";
            this.Text = "수량 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
    }
}