using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Management_System
{
    public partial class OptionForm : Form
    {
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database=CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_drinkSelect_Click(object sender, EventArgs e)
        {
            list_option.View = View.Details;
            list_option.GridLines = true;
            int listWidth = list_option.Width;
            list_option.Columns.Add("카테고리", (int)(listWidth * 0.3));
            list_option.Columns.Add("이름", (int)(listWidth * 0.3));
            list_option.Columns.Add("갯수", (int)(listWidth * 0.2));
            list_option.Columns.Add("가격", (int)(listWidth * 0.2));

            string data1, data2, data3, data4;
            // 커피
            cmd.CommandText = "SELECT * FROM coffeeMenu";
            SqlDataReader reader1 = cmd.ExecuteReader();

            list_option.Items.Clear();
            ListViewItem item1;
            while(reader1.Read())
            {
                data1 = reader1.GetString(0);
                data2 = reader1.GetString(1);
                data3 = reader1.GetInt32(2).ToString();
                data4 = reader1.GetInt32(3).ToString();

                item1 = new ListViewItem(data1);
                item1.SubItems.Add(data2);
                item1.SubItems.Add(data3);
                item1.SubItems.Add(data4);

                list_option.Items.Add(item1);
            }
            reader1.Close();

            // 논커피
            cmd.CommandText = "SELECT * FROM noncoffeeMenu";
            SqlDataReader reader2 = cmd.ExecuteReader();

            list_option.Items.Clear();
            ListViewItem item2;
            while (reader2.Read())
            {
                data1 = reader2.GetString(0);
                data2 = reader2.GetString(1);
                data3 = reader2.GetInt32(2).ToString();
                data4 = reader2.GetInt32(3).ToString();

                item2 = new ListViewItem(data1);
                item2.SubItems.Add(data2);
                item2.SubItems.Add(data3);
                item2.SubItems.Add(data4);

                list_option.Items.Add(item2);
            }
            reader2.Close();

            // 에이드/차
            cmd.CommandText = "SELECT * FROM adeMenu";
            SqlDataReader reader3 = cmd.ExecuteReader();

            list_option.Items.Clear();
            ListViewItem item3;
            while (reader3.Read())
            {
                data1 = reader3.GetString(0);
                data2 = reader3.GetString(1);
                data3 = reader3.GetInt32(2).ToString();
                data4 = reader3.GetInt32(3).ToString();

                item3 = new ListViewItem(data1);
                item3.SubItems.Add(data2);
                item3.SubItems.Add(data3);
                item3.SubItems.Add(data4);

                list_option.Items.Add(item3);
            }
            reader3.Close();

            // 스무디
            cmd.CommandText = "SELECT * FROM smooMenu";
            SqlDataReader reader4 = cmd.ExecuteReader();

            list_option.Items.Clear();
            ListViewItem item4;
            while (reader4.Read())
            {
                data1 = reader4.GetString(0);
                data2 = reader4.GetString(1);
                data3 = reader4.GetInt32(2).ToString();
                data4 = reader4.GetInt32(3).ToString();

                item4 = new ListViewItem(data1);
                item4.SubItems.Add(data2);
                item4.SubItems.Add(data3);
                item4.SubItems.Add(data4);

                list_option.Items.Add(item4);
            }
            reader4.Close();

            // 디저트
            cmd.CommandText = "SELECT * FROM desertMenu";
            SqlDataReader reader5 = cmd.ExecuteReader();

            list_option.Items.Clear();
            ListViewItem item5;
            while (reader5.Read())
            {
                data1 = reader5.GetString(0);
                data2 = reader5.GetString(1);
                data3 = reader5.GetInt32(2).ToString();
                data4 = reader5.GetInt32(3).ToString();

                item5 = new ListViewItem(data1);
                item5.SubItems.Add(data2);
                item5.SubItems.Add(data3);
                item5.SubItems.Add(data4);

                list_option.Items.Add(item5);
            }
            reader5.Close();
        }

        private void btn_drinkInsert_Click(object sender, EventArgs e)
        {
            InsertDrinkForm subFrom = new InsertDrinkForm();
            subFrom.ShowDialog();
            this.Close();
        }

        private void btn_drinkDelete_Click(object sender, EventArgs e)
        {
            // 메뉴 이름을 선택해서 음료삭제 버튼 누르면 삭제 되도록 작성
            // 메뉴 이름만 선택되도록 하면 베스트
            // 리스트 뷰에서만이 아니라 데이터베이스 자체를 삭제해야함
        }

        private void btn_cusSelect_Click(object sender, EventArgs e)
        {
            list_option.View = View.Details;
            list_option.GridLines = true;
            int listWidth = list_option.Width;
            list_option.Columns.Add("전화번호", (int)(listWidth * 0.4));
            list_option.Columns.Add("포인트", (int)(listWidth * 0.3));
            list_option.Columns.Add("순서", (int)(listWidth * 0.2));

            string data1, data2, data3;

            cmd.CommandText = "SELECT * FROM customer";
            SqlDataReader reader = cmd.ExecuteReader();

            list_option.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                data1 = reader.GetInt32(0).ToString();
                data2 = reader.GetInt32(1).ToString();
                data3 = reader.GetInt32(2).ToString();

                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);

                list_option.Items.Add(item);
            }
            reader.Close();
        }

        private void btn_cusDelete_Click(object sender, EventArgs e)
        {
            // 고객을 선택해서 회원삭제 버튼 누르면 삭제 되도록 작성
            // 고객의 뭘 선택하는진 작성하는 사람 맘대로 해도 될 듯
            // 리스트 뷰에서만이 아니라 데이터베이스 자체를 삭제해야함
        }

        private void OptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}