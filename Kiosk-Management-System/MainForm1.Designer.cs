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
            this.coffee_icecream = new System.Windows.Forms.Button();
            this.coffee_moca = new System.Windows.Forms.Button();
            this.coffee_vanila = new System.Windows.Forms.Button();
            this.coffee_macci = new System.Windows.Forms.Button();
            this.coffee_capu = new System.Windows.Forms.Button();
            this.coffee_latte = new System.Windows.Forms.Button();
            this.coffee_ame = new System.Windows.Forms.Button();
            this.coffee_es = new System.Windows.Forms.Button();
            this.tab_noncoffee = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tab_ade = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.tab_smoo = new System.Windows.Forms.TabPage();
            this.tab_desert = new System.Windows.Forms.TabPage();
            this.bttab.SuspendLayout();
            this.tab_coffee.SuspendLayout();
            this.tab_noncoffee.SuspendLayout();
            this.tab_ade.SuspendLayout();
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
            this.tab_coffee.Controls.Add(this.coffee_icecream);
            this.tab_coffee.Controls.Add(this.coffee_moca);
            this.tab_coffee.Controls.Add(this.coffee_vanila);
            this.tab_coffee.Controls.Add(this.coffee_macci);
            this.tab_coffee.Controls.Add(this.coffee_capu);
            this.tab_coffee.Controls.Add(this.coffee_latte);
            this.tab_coffee.Controls.Add(this.coffee_ame);
            this.tab_coffee.Controls.Add(this.coffee_es);
            this.tab_coffee.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_coffee.Location = new System.Drawing.Point(4, 54);
            this.tab_coffee.Name = "tab_coffee";
            this.tab_coffee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_coffee.Size = new System.Drawing.Size(609, 651);
            this.tab_coffee.TabIndex = 0;
            this.tab_coffee.Text = "커피";
            // 
            // coffee_icecream
            // 
            this.coffee_icecream.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_icecream.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_icecream.Location = new System.Drawing.Point(211, 435);
            this.coffee_icecream.Name = "coffee_icecream";
            this.coffee_icecream.Size = new System.Drawing.Size(189, 207);
            this.coffee_icecream.TabIndex = 23;
            this.coffee_icecream.Text = "아이스크림라떼\r\n5000원";
            this.coffee_icecream.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_icecream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_icecream.UseVisualStyleBackColor = true;
            // 
            // coffee_moca
            // 
            this.coffee_moca.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_moca.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_moca.Location = new System.Drawing.Point(16, 435);
            this.coffee_moca.Name = "coffee_moca";
            this.coffee_moca.Size = new System.Drawing.Size(189, 207);
            this.coffee_moca.TabIndex = 24;
            this.coffee_moca.Text = "카페모카\r\n4200원";
            this.coffee_moca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_moca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_moca.UseVisualStyleBackColor = true;
            // 
            // coffee_vanila
            // 
            this.coffee_vanila.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_vanila.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_vanila.Location = new System.Drawing.Point(406, 222);
            this.coffee_vanila.Name = "coffee_vanila";
            this.coffee_vanila.Size = new System.Drawing.Size(189, 207);
            this.coffee_vanila.TabIndex = 20;
            this.coffee_vanila.Text = "바닐라라떼\r\n4000원";
            this.coffee_vanila.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_vanila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_vanila.UseVisualStyleBackColor = true;
            // 
            // coffee_macci
            // 
            this.coffee_macci.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_macci.Image = global::Kiosk_Management_System.Properties.Resources.카라멜마끼아또;
            this.coffee_macci.Location = new System.Drawing.Point(211, 222);
            this.coffee_macci.Name = "coffee_macci";
            this.coffee_macci.Size = new System.Drawing.Size(189, 207);
            this.coffee_macci.TabIndex = 21;
            this.coffee_macci.Text = "카라멜마끼아또\r\n4000원";
            this.coffee_macci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_macci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_macci.UseVisualStyleBackColor = true;
            // 
            // coffee_capu
            // 
            this.coffee_capu.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_capu.Image = global::Kiosk_Management_System.Properties.Resources.카푸치노;
            this.coffee_capu.Location = new System.Drawing.Point(16, 222);
            this.coffee_capu.Name = "coffee_capu";
            this.coffee_capu.Size = new System.Drawing.Size(189, 207);
            this.coffee_capu.TabIndex = 22;
            this.coffee_capu.Text = "카푸치노\r\n3000원";
            this.coffee_capu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_capu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_capu.UseVisualStyleBackColor = true;
            // 
            // coffee_latte
            // 
            this.coffee_latte.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_latte.Image = global::Kiosk_Management_System.Properties.Resources.카페라떼;
            this.coffee_latte.Location = new System.Drawing.Point(406, 9);
            this.coffee_latte.Name = "coffee_latte";
            this.coffee_latte.Size = new System.Drawing.Size(189, 207);
            this.coffee_latte.TabIndex = 17;
            this.coffee_latte.Text = "카페라떼\r\n2800원";
            this.coffee_latte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_latte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_latte.UseVisualStyleBackColor = true;
            // 
            // coffee_ame
            // 
            this.coffee_ame.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_ame.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_ame.Location = new System.Drawing.Point(211, 9);
            this.coffee_ame.Name = "coffee_ame";
            this.coffee_ame.Size = new System.Drawing.Size(189, 207);
            this.coffee_ame.TabIndex = 18;
            this.coffee_ame.Text = "아메리카노\r\n1800원";
            this.coffee_ame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_ame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_ame.UseVisualStyleBackColor = true;
            // 
            // coffee_es
            // 
            this.coffee_es.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_es.Image = global::Kiosk_Management_System.Properties.Resources.에스프레소;
            this.coffee_es.Location = new System.Drawing.Point(16, 9);
            this.coffee_es.Name = "coffee_es";
            this.coffee_es.Size = new System.Drawing.Size(189, 207);
            this.coffee_es.TabIndex = 19;
            this.coffee_es.Text = "에스프레소\r\n1300원";
            this.coffee_es.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_es.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_es.UseVisualStyleBackColor = true;
            // 
            // tab_noncoffee
            // 
            this.tab_noncoffee.Controls.Add(this.button10);
            this.tab_noncoffee.Controls.Add(this.button9);
            this.tab_noncoffee.Location = new System.Drawing.Point(4, 54);
            this.tab_noncoffee.Name = "tab_noncoffee";
            this.tab_noncoffee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_noncoffee.Size = new System.Drawing.Size(609, 651);
            this.tab_noncoffee.TabIndex = 4;
            this.tab_noncoffee.Text = "논커피";
            this.tab_noncoffee.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.button10.Location = new System.Drawing.Point(211, 9);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(189, 207);
            this.button10.TabIndex = 1;
            this.button10.Text = "녹차라떼\r\n3200원";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Image = global::Kiosk_Management_System.Properties.Resources.초코라떼;
            this.button9.Location = new System.Drawing.Point(16, 9);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(189, 207);
            this.button9.TabIndex = 0;
            this.button9.Text = "초코라떼\r\n3000원";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // tab_ade
            // 
            this.tab_ade.Controls.Add(this.button11);
            this.tab_ade.Location = new System.Drawing.Point(4, 54);
            this.tab_ade.Name = "tab_ade";
            this.tab_ade.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ade.Size = new System.Drawing.Size(609, 651);
            this.tab_ade.TabIndex = 1;
            this.tab_ade.Text = "에이드/차";
            this.tab_ade.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(14, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(152, 150);
            this.button11.TabIndex = 0;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
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
            this.tab_noncoffee.ResumeLayout(false);
            this.tab_ade.ResumeLayout(false);
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
        private System.Windows.Forms.Button coffee_icecream;
        private System.Windows.Forms.Button coffee_moca;
        private System.Windows.Forms.Button coffee_vanila;
        private System.Windows.Forms.Button coffee_macci;
        private System.Windows.Forms.Button coffee_capu;
        private System.Windows.Forms.Button coffee_latte;
        private System.Windows.Forms.Button coffee_ame;
        private System.Windows.Forms.Button coffee_es;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

