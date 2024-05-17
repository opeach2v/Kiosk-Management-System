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
            this.btn_coffee = new System.Windows.Forms.Button();
            this.btn_ade = new System.Windows.Forms.Button();
            this.btn_smoo = new System.Windows.Forms.Button();
            this.btn_desert = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coffee_moca = new System.Windows.Forms.Button();
            this.coffee_vanila = new System.Windows.Forms.Button();
            this.btn_before = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.list_purchase = new System.Windows.Forms.ListView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.btn_option = new System.Windows.Forms.Button();
            this.coffee_icecream = new System.Windows.Forms.Button();
            this.coffee_macci = new System.Windows.Forms.Button();
            this.coffee_capu = new System.Windows.Forms.Button();
            this.coffee_clatte = new System.Windows.Forms.Button();
            this.coffee_ame = new System.Windows.Forms.Button();
            this.coffee_es = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // btn_coffee
            // 
            this.btn_coffee.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_coffee.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_coffee.Location = new System.Drawing.Point(99, 74);
            this.btn_coffee.Name = "btn_coffee";
            this.btn_coffee.Size = new System.Drawing.Size(118, 51);
            this.btn_coffee.TabIndex = 1;
            this.btn_coffee.Text = "커피";
            this.btn_coffee.UseVisualStyleBackColor = false;
            // 
            // btn_ade
            // 
            this.btn_ade.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ade.Location = new System.Drawing.Point(216, 74);
            this.btn_ade.Name = "btn_ade";
            this.btn_ade.Size = new System.Drawing.Size(118, 51);
            this.btn_ade.TabIndex = 1;
            this.btn_ade.Text = "에이드/차";
            this.btn_ade.UseVisualStyleBackColor = true;
            // 
            // btn_smoo
            // 
            this.btn_smoo.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_smoo.Location = new System.Drawing.Point(333, 74);
            this.btn_smoo.Name = "btn_smoo";
            this.btn_smoo.Size = new System.Drawing.Size(118, 51);
            this.btn_smoo.TabIndex = 1;
            this.btn_smoo.Text = "스무디";
            this.btn_smoo.UseVisualStyleBackColor = true;
            // 
            // btn_desert
            // 
            this.btn_desert.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_desert.Location = new System.Drawing.Point(450, 74);
            this.btn_desert.Name = "btn_desert";
            this.btn_desert.Size = new System.Drawing.Size(118, 51);
            this.btn_desert.TabIndex = 1;
            this.btn_desert.Text = "디저트";
            this.btn_desert.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_left.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_left.ForeColor = System.Drawing.Color.Gray;
            this.btn_left.Location = new System.Drawing.Point(39, 80);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(54, 38);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_right.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_right.ForeColor = System.Drawing.Color.Gray;
            this.btn_right.Location = new System.Drawing.Point(574, 80);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(54, 38);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.coffee_icecream);
            this.groupBox1.Controls.Add(this.coffee_moca);
            this.groupBox1.Controls.Add(this.coffee_vanila);
            this.groupBox1.Controls.Add(this.coffee_macci);
            this.groupBox1.Controls.Add(this.coffee_capu);
            this.groupBox1.Controls.Add(this.coffee_clatte);
            this.groupBox1.Controls.Add(this.coffee_ame);
            this.groupBox1.Controls.Add(this.coffee_es);
            this.groupBox1.Location = new System.Drawing.Point(36, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 676);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // coffee_moca
            // 
            this.coffee_moca.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_moca.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_moca.Location = new System.Drawing.Point(9, 430);
            this.coffee_moca.Name = "coffee_moca";
            this.coffee_moca.Size = new System.Drawing.Size(189, 207);
            this.coffee_moca.TabIndex = 6;
            this.coffee_moca.Text = "카페모카\r\n4200원";
            this.coffee_moca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_moca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_moca.UseVisualStyleBackColor = true;
            // 
            // coffee_vanila
            // 
            this.coffee_vanila.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_vanila.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_vanila.Location = new System.Drawing.Point(399, 217);
            this.coffee_vanila.Name = "coffee_vanila";
            this.coffee_vanila.Size = new System.Drawing.Size(189, 207);
            this.coffee_vanila.TabIndex = 1;
            this.coffee_vanila.Text = "바닐라라떼\r\n4000원";
            this.coffee_vanila.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_vanila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_vanila.UseVisualStyleBackColor = true;
            // 
            // btn_before
            // 
            this.btn_before.BackColor = System.Drawing.Color.SeaShell;
            this.btn_before.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_before.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_before.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_before.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_before.ForeColor = System.Drawing.Color.DimGray;
            this.btn_before.Location = new System.Drawing.Point(36, 767);
            this.btn_before.Name = "btn_before";
            this.btn_before.Size = new System.Drawing.Size(70, 33);
            this.btn_before.TabIndex = 7;
            this.btn_before.Text = "이전";
            this.btn_before.UseVisualStyleBackColor = false;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.SeaShell;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_next.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_next.ForeColor = System.Drawing.Color.DimGray;
            this.btn_next.Location = new System.Drawing.Point(563, 767);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(70, 33);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = "다음";
            this.btn_next.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(36, 811);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "구매 내역";
            // 
            // list_purchase
            // 
            this.list_purchase.HideSelection = false;
            this.list_purchase.Location = new System.Drawing.Point(36, 841);
            this.list_purchase.Name = "list_purchase";
            this.list_purchase.Size = new System.Drawing.Size(471, 191);
            this.list_purchase.TabIndex = 10;
            this.list_purchase.UseCompatibleStateImageBehavior = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(513, 846);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 89);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "전체 취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_sell
            // 
            this.btn_sell.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_sell.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sell.Location = new System.Drawing.Point(513, 939);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(120, 89);
            this.btn_sell.TabIndex = 11;
            this.btn_sell.Text = "결제하기";
            this.btn_sell.UseVisualStyleBackColor = false;
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
            this.tb_amount.Location = new System.Drawing.Point(435, 1047);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(155, 25);
            this.tb_amount.TabIndex = 13;
            this.tb_amount.Text = "0";
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
            this.tb_num.Text = "0";
            this.tb_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // 
            // coffee_icecream
            // 
            this.coffee_icecream.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_icecream.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_icecream.Location = new System.Drawing.Point(204, 430);
            this.coffee_icecream.Name = "coffee_icecream";
            this.coffee_icecream.Size = new System.Drawing.Size(189, 207);
            this.coffee_icecream.TabIndex = 5;
            this.coffee_icecream.Text = "아이스크림라떼\r\n5000원";
            this.coffee_icecream.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_icecream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_icecream.UseVisualStyleBackColor = true;
            // 
            // coffee_macci
            // 
            this.coffee_macci.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_macci.Image = global::Kiosk_Management_System.Properties.Resources.카라멜마끼아또;
            this.coffee_macci.Location = new System.Drawing.Point(204, 217);
            this.coffee_macci.Name = "coffee_macci";
            this.coffee_macci.Size = new System.Drawing.Size(189, 207);
            this.coffee_macci.TabIndex = 2;
            this.coffee_macci.Text = "카라멜마끼아또\r\n4000원";
            this.coffee_macci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_macci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_macci.UseVisualStyleBackColor = true;
            // 
            // coffee_capu
            // 
            this.coffee_capu.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_capu.Image = global::Kiosk_Management_System.Properties.Resources.카푸치노;
            this.coffee_capu.Location = new System.Drawing.Point(9, 217);
            this.coffee_capu.Name = "coffee_capu";
            this.coffee_capu.Size = new System.Drawing.Size(189, 207);
            this.coffee_capu.TabIndex = 3;
            this.coffee_capu.Text = "카푸치노\r\n3000원";
            this.coffee_capu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_capu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_capu.UseVisualStyleBackColor = true;
            // 
            // coffee_clatte
            // 
            this.coffee_clatte.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_clatte.Image = global::Kiosk_Management_System.Properties.Resources.카페라떼;
            this.coffee_clatte.Location = new System.Drawing.Point(399, 4);
            this.coffee_clatte.Name = "coffee_clatte";
            this.coffee_clatte.Size = new System.Drawing.Size(189, 207);
            this.coffee_clatte.TabIndex = 0;
            this.coffee_clatte.Text = "카페라떼\r\n2800원";
            this.coffee_clatte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_clatte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_clatte.UseVisualStyleBackColor = true;
            // 
            // coffee_ame
            // 
            this.coffee_ame.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_ame.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_ame.Location = new System.Drawing.Point(204, 4);
            this.coffee_ame.Name = "coffee_ame";
            this.coffee_ame.Size = new System.Drawing.Size(189, 207);
            this.coffee_ame.TabIndex = 0;
            this.coffee_ame.Text = "아메리카노\r\n1800원";
            this.coffee_ame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_ame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_ame.UseVisualStyleBackColor = true;
            // 
            // coffee_es
            // 
            this.coffee_es.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_es.Image = global::Kiosk_Management_System.Properties.Resources.에스프레소;
            this.coffee_es.Location = new System.Drawing.Point(9, 4);
            this.coffee_es.Name = "coffee_es";
            this.coffee_es.Size = new System.Drawing.Size(189, 207);
            this.coffee_es.TabIndex = 0;
            this.coffee_es.Text = "에스프레소\r\n1300원";
            this.coffee_es.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_es.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_es.UseVisualStyleBackColor = true;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(667, 1100);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.list_purchase);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_before);
            this.Controls.Add(this.btn_option);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_desert);
            this.Controls.Add(this.btn_smoo);
            this.Controls.Add(this.btn_ade);
            this.Controls.Add(this.btn_coffee);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm1";
            this.Text = "2CAFE-Kiosk";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_coffee;
        private System.Windows.Forms.Button btn_ade;
        private System.Windows.Forms.Button btn_smoo;
        private System.Windows.Forms.Button btn_desert;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button coffee_icecream;
        private System.Windows.Forms.Button coffee_moca;
        private System.Windows.Forms.Button coffee_vanila;
        private System.Windows.Forms.Button coffee_macci;
        private System.Windows.Forms.Button coffee_capu;
        private System.Windows.Forms.Button coffee_clatte;
        private System.Windows.Forms.Button coffee_ame;
        private System.Windows.Forms.Button coffee_es;
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.Button btn_before;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView list_purchase;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tb_num;
    }
}

