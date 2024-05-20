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
    public partial class OptionPasswordForm : Form
    {
        public OptionPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == "")
            {
                MessageBox.Show("비밀번호를 먼저 입력해주세요.");
                return;
            }

            else if(tb_password.Text == "0000") {
                OptionForm subFrom = new OptionForm();
                subFrom.ShowDialog();

                this.Close();
            }
            
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
                return;
            }
        }

        private void OptionPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
