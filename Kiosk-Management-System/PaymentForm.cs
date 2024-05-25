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
        string menuName;
        int number;
        int price;

        public PaymentForm(string menuName, int number, int price)
        {
            InitializeComponent();
            this.menuName = menuName;
            this.number = number;
            this.price = price;
        }

        // 나머지 결제 버튼은 작동x
        private void btn_point_Click(object sender, EventArgs e)
        {
            PointForm subFrom = new PointForm(price);
            subFrom.ShowDialog();
            this.Close();   //사용자가 폼을 닫을 때까지 이전 폼에 접근하지 못함.
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            PaymentCashForm subFrom = new PaymentCashForm(menuName, number, price);
            subFrom.ShowDialog();
        }
    }
}
