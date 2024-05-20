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
            this.list_purchase = new System.Windows.Forms.ListView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.btn_partcancel = new System.Windows.Forms.Button();
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
            this.non_choco = new System.Windows.Forms.Button();
            this.non_green = new System.Windows.Forms.Button();
            this.tab_ade = new System.Windows.Forms.TabPage();
            this.ade_berry = new System.Windows.Forms.Button();
            this.ade_lemon = new System.Windows.Forms.Button();
            this.tab_smoo = new System.Windows.Forms.TabPage();
            this.smoo_choco = new System.Windows.Forms.Button();
            this.tab_desert = new System.Windows.Forms.TabPage();
            this.desert_roll = new System.Windows.Forms.Button();
            this.desert_crof = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_option = new System.Windows.Forms.Button();
            this.bttab.SuspendLayout();
            this.tab_coffee.SuspendLayout();
            this.tab_noncoffee.SuspendLayout();
            this.tab_ade.SuspendLayout();
            this.tab_smoo.SuspendLayout();
            this.tab_desert.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_purchase
            // 
            this.list_purchase.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_purchase.HideSelection = false;
            this.list_purchase.Location = new System.Drawing.Point(16, 700);
            this.list_purchase.Name = "list_purchase";
            this.list_purchase.Size = new System.Drawing.Size(432, 191);
            this.list_purchase.TabIndex = 10;
            this.list_purchase.UseCompatibleStateImageBehavior = false;
            this.list_purchase.View = System.Windows.Forms.View.List;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(454, 751);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 46);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "전체 취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_sell.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sell.Location = new System.Drawing.Point(454, 802);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(115, 89);
            this.btn_sell.TabIndex = 11;
            this.btn_sell.Text = "결제하기";
            this.btn_sell.UseVisualStyleBackColor = false;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.BackColor = System.Drawing.Color.PeachPuff;
            this.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_amount.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_amount.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_amount.Location = new System.Drawing.Point(355, 906);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.ReadOnly = true;
            this.tb_amount.Size = new System.Drawing.Size(149, 23);
            this.tb_amount.TabIndex = 13;
            this.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_amount.TextChanged += new System.EventHandler(this.tb_amount_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox7.Location = new System.Drawing.Point(262, 904);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(10, 25);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "|";
            // 
            // tb_num
            // 
            this.tb_num.BackColor = System.Drawing.Color.PeachPuff;
            this.tb_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_num.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_num.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_num.Location = new System.Drawing.Point(100, 905);
            this.tb_num.Name = "tb_num";
            this.tb_num.ReadOnly = true;
            this.tb_num.Size = new System.Drawing.Size(149, 23);
            this.tb_num.TabIndex = 13;
            this.tb_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_num.TextChanged += new System.EventHandler(this.tb_num_TextChanged);
            // 
            // btn_partcancel
            // 
            this.btn_partcancel.BackColor = System.Drawing.Color.MistyRose;
            this.btn_partcancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_partcancel.Location = new System.Drawing.Point(454, 700);
            this.btn_partcancel.Name = "btn_partcancel";
            this.btn_partcancel.Size = new System.Drawing.Size(115, 46);
            this.btn_partcancel.TabIndex = 16;
            this.btn_partcancel.Text = "선택 취소";
            this.btn_partcancel.UseVisualStyleBackColor = false;
            this.btn_partcancel.Click += new System.EventHandler(this.btn_partcancel_Click);
            // 
            // bttab
            // 
            this.bttab.Controls.Add(this.tab_coffee);
            this.bttab.Controls.Add(this.tab_noncoffee);
            this.bttab.Controls.Add(this.tab_ade);
            this.bttab.Controls.Add(this.tab_smoo);
            this.bttab.Controls.Add(this.tab_desert);
            this.bttab.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bttab.ItemSize = new System.Drawing.Size(110, 40);
            this.bttab.Location = new System.Drawing.Point(12, 70);
            this.bttab.Name = "bttab";
            this.bttab.SelectedIndex = 0;
            this.bttab.Size = new System.Drawing.Size(570, 588);
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
            this.tab_coffee.Location = new System.Drawing.Point(4, 44);
            this.tab_coffee.Name = "tab_coffee";
            this.tab_coffee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_coffee.Size = new System.Drawing.Size(562, 540);
            this.tab_coffee.TabIndex = 0;
            this.tab_coffee.Text = "커피";
            // 
            // coffee_icecream
            // 
            this.coffee_icecream.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_icecream.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_icecream.Location = new System.Drawing.Point(196, 360);
            this.coffee_icecream.Name = "coffee_icecream";
            this.coffee_icecream.Size = new System.Drawing.Size(170, 170);
            this.coffee_icecream.TabIndex = 23;
            this.coffee_icecream.Text = "아이스크림라떼\r\n5000원";
            this.coffee_icecream.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_icecream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_icecream.UseVisualStyleBackColor = true;
            this.coffee_icecream.Click += new System.EventHandler(this.coffee_icecream_Click);
            // 
            // coffee_moca
            // 
            this.coffee_moca.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_moca.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_moca.Location = new System.Drawing.Point(16, 360);
            this.coffee_moca.Name = "coffee_moca";
            this.coffee_moca.Size = new System.Drawing.Size(170, 170);
            this.coffee_moca.TabIndex = 24;
            this.coffee_moca.Text = "카페모카\r\n4200원";
            this.coffee_moca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_moca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_moca.UseVisualStyleBackColor = true;
            this.coffee_moca.Click += new System.EventHandler(this.coffee_moca_Click);
            // 
            // coffee_vanila
            // 
            this.coffee_vanila.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_vanila.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_vanila.Location = new System.Drawing.Point(378, 184);
            this.coffee_vanila.Name = "coffee_vanila";
            this.coffee_vanila.Size = new System.Drawing.Size(170, 170);
            this.coffee_vanila.TabIndex = 20;
            this.coffee_vanila.Text = "바닐라라떼\r\n4000원";
            this.coffee_vanila.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_vanila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_vanila.UseVisualStyleBackColor = true;
            this.coffee_vanila.Click += new System.EventHandler(this.coffee_vanila_Click);
            // 
            // coffee_macci
            // 
            this.coffee_macci.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_macci.Image = global::Kiosk_Management_System.Properties.Resources.카라멜마끼아또;
            this.coffee_macci.Location = new System.Drawing.Point(196, 184);
            this.coffee_macci.Name = "coffee_macci";
            this.coffee_macci.Size = new System.Drawing.Size(170, 170);
            this.coffee_macci.TabIndex = 21;
            this.coffee_macci.Text = "카라멜마끼아또\r\n4000원";
            this.coffee_macci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_macci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_macci.UseVisualStyleBackColor = true;
            this.coffee_macci.Click += new System.EventHandler(this.coffee_macci_Click);
            // 
            // coffee_capu
            // 
            this.coffee_capu.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_capu.Image = global::Kiosk_Management_System.Properties.Resources.카푸치노;
            this.coffee_capu.Location = new System.Drawing.Point(16, 184);
            this.coffee_capu.Name = "coffee_capu";
            this.coffee_capu.Size = new System.Drawing.Size(170, 170);
            this.coffee_capu.TabIndex = 22;
            this.coffee_capu.Text = "카푸치노\r\n3000원";
            this.coffee_capu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_capu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_capu.UseVisualStyleBackColor = true;
            this.coffee_capu.Click += new System.EventHandler(this.coffee_capu_Click);
            // 
            // coffee_latte
            // 
            this.coffee_latte.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_latte.Image = global::Kiosk_Management_System.Properties.Resources.카페라떼;
            this.coffee_latte.Location = new System.Drawing.Point(378, 8);
            this.coffee_latte.Name = "coffee_latte";
            this.coffee_latte.Size = new System.Drawing.Size(170, 170);
            this.coffee_latte.TabIndex = 17;
            this.coffee_latte.Text = "카페라떼\r\n2800원";
            this.coffee_latte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_latte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_latte.UseVisualStyleBackColor = true;
            this.coffee_latte.Click += new System.EventHandler(this.coffee_latte_Click);
            // 
            // coffee_ame
            // 
            this.coffee_ame.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_ame.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.coffee_ame.Location = new System.Drawing.Point(196, 8);
            this.coffee_ame.Name = "coffee_ame";
            this.coffee_ame.Size = new System.Drawing.Size(170, 170);
            this.coffee_ame.TabIndex = 18;
            this.coffee_ame.Text = "아메리카노\r\n1800원";
            this.coffee_ame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_ame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_ame.UseVisualStyleBackColor = true;
            this.coffee_ame.Click += new System.EventHandler(this.coffee_ame_Click);
            // 
            // coffee_es
            // 
            this.coffee_es.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffee_es.Image = global::Kiosk_Management_System.Properties.Resources.에스프레소;
            this.coffee_es.Location = new System.Drawing.Point(16, 8);
            this.coffee_es.Name = "coffee_es";
            this.coffee_es.Size = new System.Drawing.Size(170, 170);
            this.coffee_es.TabIndex = 19;
            this.coffee_es.Text = "에스프레소\r\n1300원";
            this.coffee_es.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffee_es.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coffee_es.UseVisualStyleBackColor = true;
            this.coffee_es.Click += new System.EventHandler(this.coffee_es_Click);
            // 
            // tab_noncoffee
            // 
            this.tab_noncoffee.Controls.Add(this.non_choco);
            this.tab_noncoffee.Controls.Add(this.non_green);
            this.tab_noncoffee.Location = new System.Drawing.Point(4, 44);
            this.tab_noncoffee.Name = "tab_noncoffee";
            this.tab_noncoffee.Padding = new System.Windows.Forms.Padding(3);
            this.tab_noncoffee.Size = new System.Drawing.Size(562, 540);
            this.tab_noncoffee.TabIndex = 4;
            this.tab_noncoffee.Text = "논커피";
            this.tab_noncoffee.UseVisualStyleBackColor = true;
            // 
            // non_choco
            // 
            this.non_choco.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.non_choco.Image = global::Kiosk_Management_System.Properties.Resources.초코라떼;
            this.non_choco.Location = new System.Drawing.Point(16, 8);
            this.non_choco.Name = "non_choco";
            this.non_choco.Size = new System.Drawing.Size(170, 170);
            this.non_choco.TabIndex = 2;
            this.non_choco.Text = "초코라떼\r\n3000원";
            this.non_choco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.non_choco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.non_choco.UseVisualStyleBackColor = true;
            this.non_choco.Click += new System.EventHandler(this.non_choco_Click);
            // 
            // non_green
            // 
            this.non_green.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.non_green.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.non_green.Location = new System.Drawing.Point(196, 8);
            this.non_green.Name = "non_green";
            this.non_green.Size = new System.Drawing.Size(170, 170);
            this.non_green.TabIndex = 1;
            this.non_green.Text = "녹차라떼\r\n3200원";
            this.non_green.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.non_green.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.non_green.UseVisualStyleBackColor = true;
            this.non_green.Click += new System.EventHandler(this.non_green_Click);
            // 
            // tab_ade
            // 
            this.tab_ade.Controls.Add(this.ade_berry);
            this.tab_ade.Controls.Add(this.ade_lemon);
            this.tab_ade.Location = new System.Drawing.Point(4, 44);
            this.tab_ade.Name = "tab_ade";
            this.tab_ade.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ade.Size = new System.Drawing.Size(562, 540);
            this.tab_ade.TabIndex = 1;
            this.tab_ade.Text = "에이드/차";
            this.tab_ade.UseVisualStyleBackColor = true;
            // 
            // ade_berry
            // 
            this.ade_berry.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ade_berry.Image = global::Kiosk_Management_System.Properties.Resources.딸기에이드;
            this.ade_berry.Location = new System.Drawing.Point(196, 8);
            this.ade_berry.Name = "ade_berry";
            this.ade_berry.Size = new System.Drawing.Size(170, 170);
            this.ade_berry.TabIndex = 0;
            this.ade_berry.Text = "딸기에이드\r\n3500원";
            this.ade_berry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ade_berry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ade_berry.UseVisualStyleBackColor = true;
            this.ade_berry.Click += new System.EventHandler(this.ade_berry_Click);
            // 
            // ade_lemon
            // 
            this.ade_lemon.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ade_lemon.Image = global::Kiosk_Management_System.Properties.Resources.레몬에이드;
            this.ade_lemon.Location = new System.Drawing.Point(16, 8);
            this.ade_lemon.Name = "ade_lemon";
            this.ade_lemon.Size = new System.Drawing.Size(170, 170);
            this.ade_lemon.TabIndex = 0;
            this.ade_lemon.Text = "레몬에이드\r\n3500원";
            this.ade_lemon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ade_lemon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ade_lemon.UseVisualStyleBackColor = true;
            this.ade_lemon.Click += new System.EventHandler(this.ade_lemon_Click);
            // 
            // tab_smoo
            // 
            this.tab_smoo.Controls.Add(this.smoo_choco);
            this.tab_smoo.Location = new System.Drawing.Point(4, 44);
            this.tab_smoo.Name = "tab_smoo";
            this.tab_smoo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_smoo.Size = new System.Drawing.Size(562, 540);
            this.tab_smoo.TabIndex = 2;
            this.tab_smoo.Text = "스무디";
            this.tab_smoo.UseVisualStyleBackColor = true;
            // 
            // smoo_choco
            // 
            this.smoo_choco.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.smoo_choco.Image = global::Kiosk_Management_System.Properties.Resources.초코스무디;
            this.smoo_choco.Location = new System.Drawing.Point(16, 8);
            this.smoo_choco.Name = "smoo_choco";
            this.smoo_choco.Size = new System.Drawing.Size(170, 170);
            this.smoo_choco.TabIndex = 0;
            this.smoo_choco.Text = "초코스무디\r\n4400원";
            this.smoo_choco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.smoo_choco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.smoo_choco.UseVisualStyleBackColor = true;
            this.smoo_choco.Click += new System.EventHandler(this.smoo_choco_Click);
            // 
            // tab_desert
            // 
            this.tab_desert.BackColor = System.Drawing.Color.White;
            this.tab_desert.Controls.Add(this.desert_roll);
            this.tab_desert.Controls.Add(this.desert_crof);
            this.tab_desert.Location = new System.Drawing.Point(4, 44);
            this.tab_desert.Name = "tab_desert";
            this.tab_desert.Padding = new System.Windows.Forms.Padding(3);
            this.tab_desert.Size = new System.Drawing.Size(562, 540);
            this.tab_desert.TabIndex = 3;
            this.tab_desert.Text = "디저트";
            // 
            // desert_roll
            // 
            this.desert_roll.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.desert_roll.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.desert_roll.Location = new System.Drawing.Point(196, 8);
            this.desert_roll.Name = "desert_roll";
            this.desert_roll.Size = new System.Drawing.Size(170, 170);
            this.desert_roll.TabIndex = 0;
            this.desert_roll.Text = "생크림롤빵\r\n3400원";
            this.desert_roll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.desert_roll.UseVisualStyleBackColor = true;
            this.desert_roll.Click += new System.EventHandler(this.desert_roll_Click);
            // 
            // desert_crof
            // 
            this.desert_crof.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.desert_crof.Image = global::Kiosk_Management_System.Properties.Resources.기본2;
            this.desert_crof.Location = new System.Drawing.Point(16, 8);
            this.desert_crof.Name = "desert_crof";
            this.desert_crof.Size = new System.Drawing.Size(170, 170);
            this.desert_crof.TabIndex = 0;
            this.desert_crof.Text = "크로플\r\n2000원";
            this.desert_crof.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.desert_crof.UseVisualStyleBackColor = true;
            this.desert_crof.Click += new System.EventHandler(this.desert_crof_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "2 CAFE 경남대점";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "구매내역";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(32, 906);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "수량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(297, 907);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "총액";
            // 
            // btn_option
            // 
            this.btn_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_option.Image = global::Kiosk_Management_System.Properties.Resources.설정1;
            this.btn_option.Location = new System.Drawing.Point(519, 14);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(35, 35);
            this.btn_option.TabIndex = 6;
            this.btn_option.UseVisualStyleBackColor = true;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(594, 944);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttab);
            this.Controls.Add(this.btn_partcancel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.list_purchase);
            this.Controls.Add(this.btn_option);
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2CAFE-Kiosk";
            this.bttab.ResumeLayout(false);
            this.tab_coffee.ResumeLayout(false);
            this.tab_noncoffee.ResumeLayout(false);
            this.tab_ade.ResumeLayout(false);
            this.tab_smoo.ResumeLayout(false);
            this.tab_desert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.ListView list_purchase;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sell;
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
        private System.Windows.Forms.Button non_green;
        private System.Windows.Forms.Button ade_lemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button non_choco;
        private System.Windows.Forms.Button ade_berry;
        private System.Windows.Forms.Button smoo_choco;
        private System.Windows.Forms.Button desert_crof;
        private System.Windows.Forms.Button desert_roll;
    }
}

