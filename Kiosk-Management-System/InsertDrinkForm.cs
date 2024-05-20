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
            conn.Close();
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

            sql = "INSERT INTO cb_category VALUES('"+data1+"','"+data2+"',"+data3+","+data4+")";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            MessageBox.Show(data1 + " 카테고리의 " + data2 + "가 추가되었습니다. 창이 닫힙니다.");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
