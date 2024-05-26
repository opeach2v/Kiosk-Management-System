using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Management_System
{
    public partial class PointForm : Form
    {
        int point;
        int price;

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public PointForm(int price)
        {
            InitializeComponent();
            this.price = price;
        
        }

        private void PointForm_Load(object sender, EventArgs e)
        {
            tb_telnum.Mask = "";

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=CafeDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            // 텍스트박스가 비었을 때
            if (string.IsNullOrEmpty(tb_telnum.Text))
            {
                MessageBox.Show("전화번호를 먼저 입력하세요.");
                return;
            }

            // 입력한 번호가 데이터베이스에 존재하는지 확인
            cmd.CommandText = "SELECT COUNT(*) FROM customer WHERE telnum = @telnum";
            cmd.Parameters.AddWithValue("@telnum", tb_telnum.Text);

            int count = (int)cmd.ExecuteScalar();

            if (count == 0)
            {
                // 입력한 번호가 데이터베이스에 존재하지 않을 때 회원등록폼으로 이동
                MessageBox.Show("등록된 정보가 없습니다. 회원등록 창으로 이동합니다.");
                NewCustomerForm subForm = new NewCustomerForm();
                subForm.ShowDialog();
                this.Close();
            }
            else
            {
                // 입력한 번호가 데이터베이스에 존재할 때 포인트 조회
                cmd.CommandText = "SELECT point FROM customer WHERE telnum = @telnum";
                int point = (int)cmd.ExecuteScalar();

                MessageBox.Show("정상적으로 조회되었습니다.");
                PointSelectForm subForm = new PointSelectForm(point, price);
                subForm.ShowDialog();
                this.Close();
            }

            conn.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}