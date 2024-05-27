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

        //PointForm에서 받아온 price(포인트 차감 후 남은 결제액)로 결제금액 변경
        public void SetPrice(int newPrice)
        {
            price = newPrice;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            PointForm subForm = new PointForm(price);
            subForm.ShowDialog();
            SetPrice(subForm.Price);  // PointSelectForm에서 포인트 차감 후 남은 결제액을 가져옴
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            PaymentCashForm subFrom = new PaymentCashForm(menuName, number, price);
            subFrom.ShowDialog();
        }
    }
}
