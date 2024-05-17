namespace Kiosk_Management_System
{
    partial class MainForm1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.list_purchase = new System.Windows.Forms.ListView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.btn_partcancel = new System.Windows.Forms.Button();
            this.btn_option = new System.Windows.Forms.Button();
            this.bttab = new System.Windows.Forms.TabControl();
            this.tab_coffee = new System.Windows.Forms.TabPage();
            this.tab_ade = new System.Windows.Forms.TabPage();
            this.tab_smoo = new System.Windows.Forms.TabPage();
            this.tab_desert = new System.Windows.Forms.TabPage();
            this.tab_noncoffee = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.bttab.SuspendLayout();
            this.tab_coffee.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(36, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(265, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "2 CAFE 경남대점";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(36, 808);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "구매 내역";
            // 
            // list_purchase
            // 
            this.list_purchase.HideSelection = false;
            this.list_purchase.Location = new System.Drawing.Point(36, 838);
            this.list_purchase.Name = "list_purchase";
            this.list_purchase.Size = new System.Drawing.Size(471, 191);
            this.list_purchase.TabIndex = 10;
            this.list_purchase.UseCompatibleStateImageBehavior = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(513, 889);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 46);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "전체 취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_sell.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sell.Location = new System.Drawing.Point(513, 940);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(120, 89);
            this.btn_sell.TabIndex = 11;
            this.btn_sell.Text = "결제하기";
            this.btn_sell.UseVisualStyleBackColor = false;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(45, 1047);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(61, 25);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "수량";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(352, 1047);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(77, 25);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "총 금액";
            // 
            // tb_amount
            // 
            this.tb_amount.BackColor = System.Drawing.Color.PeachPuff;
            this.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_amount.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_amount.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_amount.Location = new System.Drawing.Point(441, 1047);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(155, 25);
            this.tb_amount.TabIndex = 13;
            this.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox7.Location = new System.Drawing.Point(303, 1047);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(20, 25);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "|";
            // 
            // tb_num
            // 
            this.tb_num.BackColor = System.Drawing.Color.PeachPuff;
            this.tb_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_num.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_num.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_num.Location = new System.Drawing.Point(121, 1047);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(155, 25);
            this.tb_num.TabIndex = 13;
            this.tb_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_partcancel
            // 
            this.btn_partcancel.BackColor = System.Drawing.Color.MistyRose;
            this.btn_partcancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_partcancel.Location = new System.Drawing.Point(513, 838);
            this.btn_partcancel.Name = "btn_partcancel";
            this.btn_partcancel.Size = new System.Drawing.Size(120, 46);
            this.btn_partcancel.TabIndex = 16;
            this.btn_partcancel.Text = "선택 취소";
            this.btn_partcancel.UseVisualStyleBackColor = false;
            this.btn_partcancel.Click += new System.EventHandler(this.btn_partcancel_Click);
            // 
            // btn_option
            // 
            this.btn_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_option.Image = global::Kiosk_Management_System.Properties.Resources.설정;
            this.btn_option.Location = new System.Drawing.Point(589, 18);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(40, 40);
            this.btn_option.TabIndex = 6;
            this.btn_option.UseVisualStyleBackColor = true;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            // 
            // bttab
            // 
            this.bttab.Controls.Add(this.tab_coffee);
            this.bttab.Controls.Add(this.tab_noncoffee);
            this.bttab.Controls.Add(this.tab_ade);
            this.bttab.Controls.Add(this.tab_smoo);
            this.bttab.Controls.Add(this.tab_desert);
            this.bttab.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bttab.ItemSize = new System.Drawing.Size(142, 50);
            this.bttab.Location = new System.Drawing.Point(27, 80);
            this.bttab.Name = "bttab";
            this.bttab.SelectedIndex = 0;
            this.bttab.Size = new System.Drawing.Size(617, 709);
            this.bttab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.bttab.TabIndex = 18;
            this.bttab.TabStop = false;
            // 
            // tab_coffee
            // 
            this.tab_coffee.AutoScroll = true;
            this.tab_coffee.BackColor = System.Drawing.Color.White;
            this.tab_coffee.Controls.Add(this.button1);
            this.tab_coffee.Controls.Add(this.button2);
            this.tab_coffee.Controls.Add(this.button3);
            this.tab_coffee.Controls.Add(this.button4);
            this.tab_coffee.Controls.Add(this.button5);
            this.tab_coffee.Controls.Add(this.button6);
            this.tab_coffee.Controls.Add(this.button7);
            this.tab_coffee.Controls.Add(this.button8);
            this.tab_coffee.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_coffee.Location = new System.Drawing.Point(4, 54);
            this.tab_coffee.Name = "tab_coffee";
            this.tab_coffee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_coffee.Size = new System.Drawing.Size(609, 651);
            this.tab_coffee.TabIndex = 0;
            this.tab_coffee.Text = "커피";
            // 
            // tab_ade
            // 
            this.tab_ade.Location = new System.Drawing.Point(4, 54);
            this.tab_ade.Name = "tab_ade";
            this.tab_ade.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ade.Size = new System.Drawing.Size(609, 651);
            this.tab_ade.TabIndex = 1;
            this.tab_ade.Text = "에이드/차";
            this.tab_ade.UseVisualStyleBackColor = true;
            // 
            // tab_smoo
            // 
            this.tab_smoo.Location = new System.Drawing.Point(4, 54);
            this.tab_smoo.Name = "tab_smoo";
            this.tab_smoo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_smoo.Size = new System.Drawing.Size(609, 651);
            this.tab_smoo.TabIndex = 2;
            this.tab_smoo.Text = "스무디";
            this.tab_smoo.UseVisualStyleBackColor = true;
            // 
            // tab_desert
            // 
            this.tab_desert.Location = new System.Drawing.Point(4, 54);
            this.tab_desert.Name = "tab_desert";
            this.tab_desert.Padding = new System.Windows.Forms.Padding(3);
            this.tab_desert.Size = new System.Drawing.Size(609, 651);
            this.tab_desert.TabIndex = 3;
            this.tab_desert.Text = "디저트";
            this.tab_desert.UseVisualStyleBackColor = true;
            // 
            // tab_noncoffee
            // 
            this.tab_noncoffee.Location = new System.Drawing.Point(4, 54);
            this.tab_noncoffee.Name = "tab_noncoffee";
            this.tab_noncoffee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_noncoffee.Size = new System.Drawing.Size(609, 651);
            this.tab_noncoffee.TabIndex = 4;
            this.tab_noncoffee.Text = "논커피";
            this.tab_noncoffee.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.button1.Location = new System.Drawing.Point(211, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 207);
            this.button1.TabIndex = 23;
            this.button1.Text = "아이스크림라떼\r\n5000원";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.button2.Location = new System.Drawing.Point(16, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 207);
            this.button2.TabIndex = 24;
            this.button2.Text = "카페모카\r\n4200원";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.button3.Location = new System.Drawing.Point(406, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 207);
            this.button3.TabIndex = 20;
            this.button3.Text = "바닐라라떼\r\n4000원";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Image = global::Kiosk_Management_System.Properties.Resources.카라멜마끼아또;
            this.button4.Location = new System.Drawing.Point(211, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 207);
            this.button4.TabIndex = 21;
            this.button4.Text = "카라멜마끼아또\r\n4000원";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = global::Kiosk_Management_System.Properties.Resources.카푸치노;
            this.button5.Location = new System.Drawing.Point(16, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 207);
            this.button5.TabIndex = 22;
            this.button5.Text = "카푸치노\r\n3000원";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Image = global::Kiosk_Management_System.Properties.Resources.카페라떼;
            this.button6.Location = new System.Drawing.Point(406, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 207);
            this.button6.TabIndex = 17;
            this.button6.Text = "카페라떼\r\n2800원";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.button7.Location = new System.Drawing.Point(211, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(189, 207);
            this.button7.TabIndex = 18;
            this.button7.Text = "아메리카노\r\n1800원";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Image = global::Kiosk_Management_System.Properties.Resources.에스프레소;
            this.button8.Location = new System.Drawing.Point(16, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 207);
            this.button8.TabIndex = 19;
            this.button8.Text = "에스프레소\r\n1300원";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(667, 1100);
            this.Controls.Add(this.bttab);
            this.Controls.Add(this.btn_partcancel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.list_purchase);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_option);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm1";
            this.Text = "2CAFE-Kiosk";
            this.bttab.ResumeLayout(false);
            this.tab_coffee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView list_purchase;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Button btn_partcancel;
        private System.Windows.Forms.TabControl bttab;
        private System.Windows.Forms.TabPage tab_coffee;
        private System.Windows.Forms.TabPage tab_ade;
        private System.Windows.Forms.TabPage tab_smoo;
        private System.Windows.Forms.TabPage tab_desert;
        private System.Windows.Forms.TabPage tab_noncoffee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

