using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk_Management_System
{
    public partial class MainForm1 : Form
    {
        private bool isFirstClick = true;
        // 메뉴 전체 카운트
        int count_total = 0;
        int price_total = 0;

        // 메뉴 선택 수량 카운트
        int es_count = 0;
        int ame_count = 0;
        int latte_count = 0;
        int capu_count = 0;
        int macci_count = 0;
        int vanila_count = 0;
        int moca_count = 0;
        int icecream_count = 0;
        int nonchoco_count = 0;
        int nongreen_count = 0;
        int adelemon_count = 0;
        int adeberry_count = 0;
        int smoochoco_count = 0;
        int crof_count = 0;
        int roll_count = 0;

        // 메뉴 선택한 만큼의 금액 카운트
        int es_price = 0;
        int ame_price = 0;
        int latte_price = 0;
        int capu_price = 0;
        int macci_price = 0;
        int vanila_price = 0;
        int moca_price = 0;
        int icecream_price = 0;
        int nonchoco_price = 0;
        int nongreen_price = 0;
        int adelemon_price = 0;
        int adeberry_price = 0;
        int smoochoco_price = 0;
        int crof_price = 0;
        int roll_price = 0;

        public MainForm1()
        {
            InitializeComponent();
            tb_num.Text = count_total.ToString();
            tb_amount.Text = price_total.ToString();
        }

        private void totalRefresh() // 수량, 총액 새로고침
        {
            tb_num.Text = count_total.ToString();
            tb_amount.Text = price_total.ToString();
        }

        private void countReset()
        {
            es_count = 0;
            ame_count = 0;
            latte_count = 0;
            capu_count = 0;
            macci_count = 0;
            vanila_count = 0;
            moca_count = 0;
            icecream_count = 0;
            nonchoco_count = 0;
            nongreen_count = 0;
            adelemon_count = 0;
            adeberry_count = 0;
            smoochoco_count = 0;
            crof_count = 0;
            roll_count = 0;
        } // 리스트뷰에 등록되는 모든 음료 총량 초기화

        private void priceReset() // 리스트뷰에 등록되는 모든 음료 총금액 초기화
        {
            es_price = 0;
            ame_price = 0;
            latte_price = 0;
            capu_price = 0;
            macci_price = 0;
            vanila_price = 0;
            moca_price = 0;
            icecream_price = 0;
            nonchoco_price = 0;
            nongreen_price = 0;
            adelemon_price = 0;
            adeberry_price = 0;
            smoochoco_price = 0;
            crof_price = 0;
            roll_price = 0;
    }

        private void btn_option_Click(object sender, EventArgs e)
        {
            OptionPasswordForm subFrom = new OptionPasswordForm();
            subFrom.ShowDialog();
        }

        private void btn_partcancel_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count == 0)    // 리스트가 비어있을 경우. 뭔가 이게 아닌 것 같은 느낌 ㅠㅠ
            {
                MessageBox.Show("구매내역이 비어있습니다.");
                return;
            }
            else
            {
                // 선택한 메뉴만 삭제할 수 있도록 (데이터베이스 삭제 x)
                // 여러개 선택할 수 있으면 베스트 (갯수도)
                // 따로 메시지 박스는 안 나오게
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count == 0)    // 리스트가 비어있을 경우. 뭔가 이게 아닌 것 같은 느낌 ㅠㅠ
            {
                MessageBox.Show("구매내역이 비어있습니다.");
                return;
            }

            else    // 리스트에 1개라도 있으면
            {
                list_purchase.Items.Clear();    // 리스트뷰의 모든 항목 지움(데이터베이스 삭제x)
                // 따로 메시지 박스는 안 나오게
                count_total = 0;
                price_total = 0;
                totalRefresh();
                countReset();
                priceReset();
                isFirstClick = true;
                return;
            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count == 0)    // 리스트가 비어있을 경우. 뭔가 이게 아닌 것 같은 느낌 ㅠㅠ
            {
                MessageBox.Show("결제할 메뉴가 없습니다.");
                return;
            }
            
            else
            {
                PaymentForm subFrom = new PaymentForm();
                subFrom.ShowDialog();
            }
        }

        private void coffee_es_Click(object sender, EventArgs e)
        {
            /* if (isFirstClick)
            {
                ListViewItem es = new ListViewItem(new string[] { "에스프레소   ", es_count.ToString(), es_price.ToString() });
                list_purchase.Items.Add(es);

                isFirstClick = false;
            }
            es_count++;
            count_total++;
            es_price += 1300;
            price_total += 1300;
            totalRefresh(); */
        }

        private void coffee_ame_Click(object sender, EventArgs e)
        {
           
        }

        private void coffee_latte_Click(object sender, EventArgs e)
        {
            
        }

        private void coffee_capu_Click(object sender, EventArgs e)
        {

        }

        private void coffee_macci_Click(object sender, EventArgs e)
        {

        }

        private void coffee_vanila_Click(object sender, EventArgs e)
        {

        }

        private void coffee_moca_Click(object sender, EventArgs e)
        {

        }

        private void coffee_icecream_Click(object sender, EventArgs e)
        {

        }

        private void non_choco_Click(object sender, EventArgs e)
        {

        }

        private void non_green_Click(object sender, EventArgs e)
        {

        }

        private void ade_lemon_Click(object sender, EventArgs e)
        {

        }

        private void ade_berry_Click(object sender, EventArgs e)
        {

        }

        private void smoo_choco_Click(object sender, EventArgs e)
        {

        }

        private void desert_crof_Click(object sender, EventArgs e)
        {

        }

        private void desert_roll_Click(object sender, EventArgs e)
        {

        }

        private void tb_num_TextChanged(object sender, EventArgs e)
        {
            //사용xxxxxxxx
        }

        private void tb_amount_TextChanged(object sender, EventArgs e)
        {
            // 사용 xxxxx
        }
    }
}
