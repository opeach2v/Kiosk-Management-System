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
    public partial class PaymentForm : Form
    {
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;

        string menuName2;
        int number2;
        int number3;
        public PaymentForm(string menuName, int number)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = '" + menuName2 + "'";
            number3 = cmd.ExecuteNonQuery();

            InitializeComponent();
            menuName2 = menuName;
            number2 = number;
            number3 -= number2;

            cmd.CommandText = "UPDATE coffeeMenu SET num = " + number3 + "";
            cmd.ExecuteNonQuery();
        }

        // 나머지 결제 버튼은 작동x
        private void btn_point_Click(object sender, EventArgs e)
        {
            PointForm subFrom = new PointForm();
            subFrom.ShowDialog();
            this.Close();   //사용자가 폼을 닫을 때까지 이전 폼에 접근하지 못함.
        }
    }
}
