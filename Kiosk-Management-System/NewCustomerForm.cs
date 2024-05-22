using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Management_System
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void btn_insert_Click(object sender, EventArgs e)
        {
            // 텍스트박스가 비었을 때
            if (tb_telnum.Text == "")
            {
                MessageBox.Show("전화번호를 먼저 입력하세요.");
                return;
            }
            // '-'를 제외한 문자가 포함되어있으면
            else if (tb_telnum.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("숫자만 입력해주세요.");
                return;
            }

            else
            {
                // 데이터베이스에 고객 정보 등록 코드 작성
                connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
                conn = new SqlConnection(connStr);
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;

                string data1, data2, sql;   // data1은 전번, data2는 포인트(기본적으로 0지급)

                data1 = tb_telnum.Text;
                data2 = 0.ToString();    // 처음엔 포인트 0으로 시작

                sql = "INSERT INTO customer VALUES('" + data1 + "','" + data2 + "')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("정상적으로 등록되었습니다.");
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("회원 등록을 취소합니다.");
            this.Close();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            tb_telnum.Mask = "";
        }
    }
}
