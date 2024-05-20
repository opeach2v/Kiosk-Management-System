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
    public partial class PointForm : Form
    {
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        public PointForm()
        {
            InitializeComponent();
        }

        private void PointForm_Load(object sender, EventArgs e)
        {
            tb_telnum.Mask = "000-0000-0000";

            connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // 텍스트박스가 비었을 때
            if(tb_telnum.Text == "")
            {
                MessageBox.Show("전화번호를 먼저 입력하세요.");
                return;
            }
            
            // 입력한 번호가 데이터베이스에 존재하지 않을 때 회원등록폼으로 이동하고 this.Close();
            // this.Close();로 하는 이유: 등록폼에서 정상적으로 등록된 뒤 다시 조회하는 과정을 거쳐야 함.
             // 입력한 번호가 데이터베이스에 존재할 때 밑에 코드 실행
            else
            {
                string db_telnum;

                cmd.CommandText = "SELECT * FROM customer";
                SqlDataReader reader = cmd.ExecuteReader();

                
            }
            MessageBox.Show("정상적으로 조회되었습니다.");
            // 포인트 조회 폼으로 이동
            PointSelectForm subFrom = new PointSelectForm();
            subFrom.ShowDialog();
            return;
        }

        /* 입력된 텍스트에 문자가 포함되어 있는지 검사하는 코드
        private bool ContainsNonNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c)) { return true; }
            }
            return false;
        }*/
    }
}