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
        int point;

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public PointForm()
        {
            InitializeComponent();

        
        }

        private void PointForm_Load(object sender, EventArgs e)
        {
            tb_telnum.Mask = "";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            // 텍스트박스가 비었을 때
            if (tb_telnum.Text == "")
            {
                MessageBox.Show("전화번호를 먼저 입력하세요.");
                return;
            }

            //입력한 번호가 데이터베이스에 존재하지 않을 때 회원등록폼으로 이동하고 this.Close();
            cmd.CommandText = "SELECT CASE WHEN telnum = '" + tb_telnum.Text + "' THEN 1 ELSE 0 END AS checkNum FROM customer where telnum = '" + tb_telnum.Text + "'";
            cmd.ExecuteNonQuery();

            int result;
            string data1;
            try
            {   // 받는 값이 있으면 1 반환 , 없으면 에러 
                // 1일 때만 정상 작동 에러라면 catch로 이동
                cmd.CommandText = "SELECT point FROM customer WHERE telnum = '" + tb_telnum.Text + "'";
                result = (int)cmd.ExecuteScalar();
                
                int point = Convert.ToInt32(result);
                data1 = point.ToString();
                MessageBox.Show("정상적으로 조회되었습니다.");
                PointSelectForm subForm = new PointSelectForm(data1);
                subForm.ShowDialog();
                this.Close();
            }
            catch (NullReferenceException)
            {
                result = 0;
                MessageBox.Show("등록된 정보가 없습니다. 회원등록 창으로 이동합니다.");
                NewCustomerForm subForm = new NewCustomerForm();
                subForm.ShowDialog();
                this.Close();
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}