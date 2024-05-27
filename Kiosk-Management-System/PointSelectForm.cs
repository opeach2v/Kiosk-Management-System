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
    public partial class PointSelectForm : Form
    {
        string telnum;
        int points;
        private int price;

        public int Price // 이전 창으로 포인트 차감 후 남은 결제액 전달
        {
            get { return price; }
            set { price = value; }
        }

        public PointSelectForm(string telnum, int point, int price)
        {
            InitializeComponent();
            this.telnum = telnum;
            points = point;
            this.price = price;
        }
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void tb_usePoint_TextChanged(object sender, EventArgs e)
        {
            //잘못 누름. 사용할 곳 있으면 사용해도 됨.
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            string usePoint = tb_usePoint.Text;
            if(usePoint == "")
            {
                MessageBox.Show("사용할 포인트를 입력하세요.");
            }

            if(tb_usePoint.Text.Any(c => ! char.IsDigit(c)))
            {
                MessageBox.Show("숫자만 입력해주세요.");
                return;
            }
            else if(points < 1000)
            {
                MessageBox.Show("포인트가 1000점 이상일 경우 사용 가능합니다.");
                return;
            }
            else
            {
                // 입력된 텍스트보다 데이터베이스에서 불러온 텍스트보다 클 경우
                if (string.Compare(tb_usePoint.Text, tb_point.Text) > 0)
                {
                    MessageBox.Show("보유한 포인트를 초과하였습니다.");
                    return;
                }
                else
                {
                    price -= Int32.Parse(tb_usePoint.Text);
                    points -= Int32.Parse(tb_usePoint.Text);
                    MessageBox.Show("포인트 사용이 완료되었습니다. 남은 포인트: " + points + "남은 결제금액: " + price);

                    cmd.CommandText = "UPDATE customer SET point =" +  points + "WHERE telnum =" + telnum +"";
                    cmd.ExecuteNonQuery();

                    this.Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포인트 사용을 취소합니다.");
            this.Close();
        }

        private void PointSelectForm_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            tb_point.Text = points.ToString();
        }

        private void tb_point_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
