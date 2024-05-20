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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
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
