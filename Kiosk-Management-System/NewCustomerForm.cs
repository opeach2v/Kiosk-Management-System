using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Management_System
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            // 텍스트박스가 비었을 때
            if (tb_telnum.Text == "")
            {
                MessageBox.Show("전화번호를 먼저 입력하세요.");
                return;
            }

            // '-'의 문자가 포함되었을 경우
            // MessageBox.Show("숫자와 '-'만 입력해주세요."); return;

            else
            {
                // 데이터베이스에 고객 정보 등록 코드 작성
                MessageBox.Show("정상적으로 등록되었습니다.");
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("회원 등록을 취소합니다.");
            return;
        }
    }
}
