using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Management_System
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            OptionPasswordForm subFrom = new OptionPasswordForm();
            subFrom.ShowDialog();
        }

        private void btn_partcancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            if()    // 리스트가 비어있으면
            {
                MessageBox.Show("결제할 메뉴가 없습니다.");
                return;
            }

            PaymentForm subFrom = new PaymentForm();
            subFrom.ShowDialog();
        }
    }
}
