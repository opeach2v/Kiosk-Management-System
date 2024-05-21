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
    public partial class InsertDrinkForm : Form
    {
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public InsertDrinkForm()
        {
            InitializeComponent();
        }

        private void InsertDrinkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CafeDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string data1, data2, data3, data4, sql;

            data1 = cb_category.Text;
            data2 = tb_name.Text;
            data3 = tb_count.Text;
            data4 = tb_price.Text;

            if(cb_category.Text == "커피")
            {
                sql = "INSERT INTO coffeeMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "논커피")
            {
                sql = "INSERT INTO noncoffeeMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "에이드/차")
            {
                sql = "INSERT INTO adeMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "스무디")
            {
                sql = "INSERT INTO smooMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "디저트")
            {
                sql = "INSERT INTO desertMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(data1 + " 카테고리의 " + data2 + "가 추가되었습니다.");
            return;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
