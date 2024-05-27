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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Kiosk_Management_System
{
    public partial class PaymentCashForm : Form
    {
        string menuName;
        int count;
        int price;

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public PaymentCashForm(string menuName, int number, int price)
        {
            InitializeComponent();
            this.menuName = menuName;
            count = number;
            this.price = price;
        }

        private void PaymentCashForm_Load(object sender, EventArgs e)
        {
            tb_amount.Text = price.ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // 거스름돈 계산
            string receiveAmount = tb_receiveAmount.Text;
            int change = Int32.Parse(receiveAmount) - price;
            tb_change.Text = change.ToString();

            connStr = "Server=localhost\\SQLEXPRESS;Database=CafeDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            // 결제 후 수량 차감
            cmd.CommandText = "SELECT num FROM coffeeMenu WHERE name = @menuName";
            cmd.Parameters.AddWithValue("@menuName", menuName);
            int num = (int)cmd.ExecuteScalar();
            num = num - count;

            cmd.CommandText = "UPDATE coffeeMenu SET num = @num WHERE name = @menuName";
            cmd.Parameters.AddWithValue("@num", num);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO sales VALUES(@menuName, @count, @price, '현금')";
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();

            PointInsertForm subFrom = new PointInsertForm(price);
            subFrom.ShowDialog();
        }
    }
}
