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
    public partial class PointSelectForm : Form
    {
        public PointSelectForm()
        {
            InitializeComponent();
        }

        private void tb_usePoint_TextChanged(object sender, EventArgs e)
        {
            //잘못 누름. 사용할 곳 있으면 사용해도 됨.
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            if(tb_usePoint.Text == "")
            {
                MessageBox.Show("사용할 포인트를 입력하세요.");
            }

            // 문자가 포함되었을 경우
            // MessageBox.Show("숫자만 입력해주세요."); return;

            // 숫자만 사용됨.
            // 보유 포인트보다 입력한 포인트가 더 많을 경우
            // MessageBox.Show("보유 포인트를 초과하였습니다."); return;
            // 그 외는 MessageBox.Show("포인트 사용이 완료되었습니다."); 하고 종료
            // (키오스크 특징상 메인화면으로 돌아갈 수 있으면 베스트)
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포인트 사용을 취소합니다.");
            return;
        }
    }
}
