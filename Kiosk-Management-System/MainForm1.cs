using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Kiosk_Management_System
{
    public partial class MainForm1 : Form
    {
        int limit = 0;

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

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public MainForm1()
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            InitializeComponent();

            // btnENG의 클릭 이벤트 핸들러를 설정
            this.btnENG.Click += new System.EventHandler(this.btnENG_Click);

            // btnKR의 클릭 이벤트 핸들러를 설정
            this.btnKR.Click += new System.EventHandler(this.btnKR_Click);

            tb_num.Text = count_total.ToString();
            tb_amount.Text = price_total.ToString();

            // UI의 총 수량 및 가격 레이블을 갱신하는 코드를 여기에 작성합니다.
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
            if (list_purchase.SelectedItems.Count == 0) // 선택된 항목이 없을 경우
            {
                MessageBox.Show("취소할 메뉴를 선택해주세요.");
                return;
            }



            for (int i = list_purchase.SelectedItems.Count - 1; i >= 0; i--)
            {
                var selectedItem = list_purchase.SelectedItems[i];
                // 선택된 항목을 리스트에서 제거
                string item = selectedItem.ToString(); // item에 저장
                string itemName = item.Split('x')[0].Trim(); // 메뉴 이름 추출
                int itemCount = int.Parse(item.Split('x')[1].Trim()); // 메뉴 개수 추출
                int itemPrice = GetPriceByName(itemName); // 메뉴 가격 가져오기

                // 총 수량과 총 가격 업데이트
                count_total -= itemCount;
                price_total -= itemPrice * itemCount;

                // 해당 메뉴의 수량을 감소시킴
                switch (itemName)
                {
                    case "에스프레소":
                        es_count -= itemCount; // 수량만큼 감소
                        break;
                    case "아메리카노":
                        ame_count -= itemCount;
                        break;
                    case "카페라떼":
                        latte_count -= itemCount;
                        break;
                    case "카푸치노":
                        capu_count -= itemCount;
                        break;
                    case "카라멜 마끼아또":
                        macci_count -= itemCount;
                        break;
                    case "바닐라 라떼":
                        vanila_count -= itemCount;
                        break;
                    case "카페 모카":
                        moca_count -= itemCount;
                        break;
                    case "아이스크림 라떼":
                        icecream_count -= itemCount;
                        break;
                }

                list_purchase.Items.Remove(selectedItem);

            }

            // 수량과 총액을 새로고침
            totalRefresh();
           
        }

        // 메뉴 이름에 해당하는 가격을 가져오는 메서드
        private int GetPriceByName(string name)
        {
            switch (name)
            {
                case "에스프레소":
                    return 1300;
                case "아메리카노":
                    return 1800;
                case "카페라떼":
                    return 2800;
                case "카푸치노":
                    return 3000;
                case "카라멜 마끼아또":
                    return 2800;
                case "바닐라 라떼":
                    return 2800;
                case "카페 모카":
                    return 2800;
                case "아이스크림 라떼":
                    return 2800;
                default:
                    return 0;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count == 0)
            {
                MessageBox.Show("구매내역이 비어있습니다.");
                return;
            }

            else    // 리스트에 1개라도 있으면
            {
                list_purchase.Items.Clear();  
                count_total = 0;
                price_total = 0;
                totalRefresh();
                countReset();
                priceReset();
                isFirstClick = true;
                totalRefresh();
            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다.");
                return;
            }
            
            else
            {
                string menuName = es_N.Text;
                int number = count_total;

                PaymentForm subFrom = new PaymentForm(menuName, number);
                subFrom.ShowDialog();
            }
        }

        // 모든 메뉴들 공통 함수
        private void AddMenuItem(string name, string priceText, int price)
        {
            bool itemExists = false;
            foreach (var item in list_purchase.Items)
            {
                string itemName = item.ToString().Split('x')[0].Trim(); // 항목의 이름 추출
                if (itemName == name) // 이미 있는 항목인 경우
                {
                    int index = list_purchase.Items.IndexOf(item);
                    string existingItem = list_purchase.Items[index].ToString();
                    int count = int.Parse(existingItem.Split('x')[1].Trim()); // 기존 수량 가져오기
                    count++;
                    list_purchase.Items[index] = name + " x " + count;
                    price_total += price;
                    IncreaseItemCount(name); // 해당 메뉴의 수량 증가
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists) // 새로운 항목인 경우
            {
                list_purchase.Items.Add(name + " x 1");

                // 새로운 항목이 추가되면 해당 메뉴의 개수와 총 가격을 업데이트
                IncreaseItemCount(name); // 해당 메뉴의 수량 증가
                price_total += price;
            }

            count_total++; // 항목이 추가될 때마다 총 개수 증가

            totalRefresh();

            // 주문된 커피의 개수와 총 가격을 텍스트 상자에 업데이트
            tb_num.Text = count_total.ToString(); // 모든 메뉴의 총 개수를 표시
            tb_amount.Text = price_total.ToString();
        }

        private void IncreaseItemCount(string itemName) // 카운트 증가
        {
            switch (itemName)
            {
                case "에스프레소":
                    es_count++;
                    break;
                case "아메리카노":
                    ame_count++;
                    break;
                case "카페라떼":
                    latte_count++;
                    break;
                case "카푸치노":
                    capu_count++;
                    break;
                case "카라멜 마끼아또":
                    macci_count++;
                    break;
                case "바닐라 라떼":
                    vanila_count++;
                    break;
                case "카페 모카":
                    moca_count++;
                    break;
                case "아이스크림 라떼":
                    icecream_count++;
                    break;
            }
        }

        private void overflow(string name) // DB에 저장된 개수 초과 시 호출
        {
            foreach (var item in list_purchase.Items)
            {
                string itemname = item.ToString().Split('x')[0].Trim(); // 항목의 이름 추출
                if (itemname == name)
                {
                    int index = list_purchase.Items.IndexOf(item);
                    string existingItem = list_purchase.Items[index].ToString();
                    int count = int.Parse(existingItem.Split('x')[1].Trim()); // 기존 수량 가져오기
                    count--;
                    list_purchase.Items[index] = name + " x " + count;
                    break;
                }
            }
        }

        // 커피 메뉴
        private void coffee_es_Click(object sender, EventArgs e) // 버튼 클릭 이벤트
        {
            AddMenuItem(es_N.Text, es_P.Text, 1300); // AddMenuItem 호출 매개변수는 각 메뉴 이름, 가격
            
            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" +es_N.Text+"'";
            reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                limit = reader.GetInt32(0); // DB에 저장된 메뉴의 개수 읽어옴
            }

            if(limit < es_count)
            {
                es_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." +es_count);
                count_total--; 
                tb_num.Text = count_total.ToString();
                price_total = price_total - 1300;
                tb_amount.Text = price_total.ToString();
                overflow(es_N.Text); // overflow 호출
            }
            reader.Close();
            
        }
        private void coffee_ame_Click(object sender, EventArgs e)
        {
            AddMenuItem(ame_N.Text, ame_P.Text, 1800);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + ame_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < ame_count)
            {
                ame_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + ame_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 1800;
                tb_amount.Text = price_total.ToString();
                overflow(ame_N.Text);
            }
            reader.Close();


        }

        private void coffee_latte_Click(object sender, EventArgs e)
        {
            AddMenuItem(latte_N.Text, latte_P.Text, 2800);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + latte_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < latte_count)
            {
                latte_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + latte_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 2800;
                tb_amount.Text = price_total.ToString();
                overflow(latte_N.Text);
            }
            reader.Close();
        }

        private void coffee_Capu_Click(object sender, EventArgs e)
        {
            AddMenuItem(Capu_N.Text, Capu_P.Text, 3000);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + Capu_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < capu_count)
            {
                capu_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + capu_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 3000;
                tb_amount.Text = price_total.ToString();
                overflow(Capu_N.Text);
            }
            reader.Close();
        }

        private void coffee_macci_Click(object sender, EventArgs e)
        {
            AddMenuItem(macci_N.Text, macci_P.Text, 3200);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + macci_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < macci_count)
            {
                macci_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + macci_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 3200;
                tb_amount.Text = price_total.ToString();
                overflow(macci_N.Text);
            }
            reader.Close();
        }

        private void coffee_vanila_Click(object sender, EventArgs e)
        {
            AddMenuItem(vanila_N.Text, vanila_P.Text, 3400);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + vanila_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < vanila_count)
            {
                vanila_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + vanila_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 3400;
                tb_amount.Text = price_total.ToString();
                overflow(vanila_N.Text);
            }
            reader.Close();
        }

        private void coffee_moca_Click(object sender, EventArgs e)
        {
            AddMenuItem(moca_N.Text, moca_P.Text, 3600);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + moca_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < moca_count)
            {
                moca_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + moca_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 3600;
                tb_amount.Text = price_total.ToString();
                overflow(moca_N.Text);
            }
            reader.Close();
        }

        private void coffee_icecream_Click(object sender, EventArgs e)
        {
            AddMenuItem(icecream_N.Text, icecream_P.Text, 3800);

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + icecream_N.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                limit = reader.GetInt32(0);
            }

            if (limit < icecream_count)
            {
                icecream_count = limit;
                MessageBox.Show("정해진 수량을 초과했습니다." + icecream_count);
                count_total--;
                tb_num.Text = count_total.ToString();
                price_total = price_total - 3800;
                tb_amount.Text = price_total.ToString();
                overflow(icecream_N.Text);
            }
            reader.Close();
        }

        // 논커피 메뉴
        private void non_choco_Click(object sender, EventArgs e)
        {
            AddMenuItem(choco_N.Text, choco_P.Text, 3000);
        }

        private void non_green_Click(object sender, EventArgs e)
        {
            AddMenuItem(green_N.Text, green_P.Text, 3200);
        }

        // 에이드 메뉴
        private void ade_lemon_Click(object sender, EventArgs e)
        {
            AddMenuItem(lemon_N.Text, lemon_P.Text, 3500);
        }

        private void ade_berry_Click(object sender, EventArgs e)
        {
            AddMenuItem(berry_N.Text, berry_P.Text, 3500);
        }

        // 스무디 메뉴
        private void smoo_choco_Click_1(object sender, EventArgs e)
        {
            AddMenuItem(smoo_choco_N.Text, smoo_choco_P.Text, 4400);
        }

        // 디저트 메뉴
        private void dessert_crof_Click(object sender, EventArgs e)
        {
            AddMenuItem(crof_N.Text, crof_P.Text, 2000);
        }

        private void dessert_roll_Click(object sender, EventArgs e)
        {
            AddMenuItem(roll_N.Text, roll_P.Text, 4400);
        }


        private void tb_num_TextChanged(object sender, EventArgs e)
        {
            //사용xxxxxxxx
        }

        private void tb_amount_TextChanged(object sender, EventArgs e)
        {
            // 사용 xxxxx
        }

        private void btnKR_Click(object sender, EventArgs e)
        {
            es_N.Text = "에스프레소";
            ame_N.Text = "아메리카노";
            latte_N.Text = "카페 라떼";
            Capu_N.Text = "카푸치노";
            macci_N.Text = "카라멜 마끼아또";
            vanila_N.Text = "바닐라 라뗴";
            moca_N.Text = "카페 모카";
            icecream_N.Text = "아이스크림 라뗴";
            choco_N.Text = "초코라뗴";
            green_N.Text = "녹차라뗴";
            lemon_N.Text = "레몬에이드";
            berry_N.Text = "딸기에이드";
            smoo_choco_N.Text = "초코스무디";
            crof_N.Text = "크로플";
            roll_N.Text = "생크림롤";
            order.Text = "구매목록";
            btn_partcancel.Text = "선택 취소";
            btn_cancel.Text = "전체 취소";
            btn_sell.Text = "결제하기";
            total.Text = "수량";
            price.Text = "총액";
        }

        private void btnENG_Click(object sender, EventArgs e)
        {
            es_N.Text = "Espresso";
            ame_N.Text = "Americano";
            latte_N.Text = "Cafe Latte";
            Capu_N.Text = "Cappuccino";
            macci_N.Text = "Caramel Macchiato";
            vanila_N.Text = "Vanilla Latte";
            moca_N.Text = "Cafe Mocha";
            icecream_N.Text = "Ice Cream Latte";
            choco_N.Text = "Chocolate Latte";
            green_N.Text = "Green Tea Latte";
            lemon_N.Text = "Lemonade";
            berry_N.Text = "Strawberry ade";
            smoo_choco_N.Text = "Chocolate Smoothie";
            crof_N.Text = "Croffle";
            roll_N.Text = "Cream Roll";
            order.Text = "Order";
            btn_partcancel.Text = "partcancel";
            btn_cancel.Text = "Cancel";
            btn_sell.Text = "Pay";
            total.Text = "Total";
            price.Text = "Price";
        }
    }
}
