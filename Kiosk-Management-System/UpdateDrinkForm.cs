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
    public partial class UpdateDrinkForm : Form
    {
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public UpdateDrinkForm()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
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

            if (cb_category.Text == "커피")
            {
                cmd.CommandText = "DELETE FROM coffeeMenu WHERE name = '" + data2 + "'";
                cmd.ExecuteNonQuery();

                sql = "INSERT INTO coffeeMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "논커피")
            {
                cmd.CommandText = "DELETE FROM noncoffeMenu WHERE neme =" + data2 + "";
                cmd.ExecuteNonQuery();

                sql = "INSERT INTO noncoffeeMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "에이드/차")
            {
                cmd.CommandText = "DELETE FROM adeMenu WHERE neme =" + data2 + "";
                cmd.ExecuteNonQuery();

                sql = "INSERT INTO adeMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "스무디")
            {
                cmd.CommandText = "DELETE FROM smooMenu WHERE neme =" + data2 + "";
                cmd.ExecuteNonQuery();

                sql = "INSERT INTO smooMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            if (cb_category.Text == "디저트")
            {
                cmd.CommandText = "DELETE FROM desertMenu WHERE neme =" + data2 + "";
                cmd.ExecuteNonQuery();

                sql = "INSERT INTO desertMenu VALUES('" + data1 + "','" + data2 + "'," + data3 + "," + data4 + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(data1 + " 카테고리의 " + data2 + "가(이) 변경되었습니다.");
            return;
        }
    }
}
