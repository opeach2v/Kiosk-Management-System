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
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // 텍스트박스가 비었을 때
            if(tb_telnum.Text == "")
            {
                MessageBox.Show("전화번호를 먼저 입력하세요.");
                return;
            }
            
            // 문자가 포함되었을 경우
            // MessageBox.Show("숫자만 입력해주세요."); return;

            // 숫자만 입력된 경우
                // 입력한 번호가 데이터베이스에 존재하지 않을 때 회원등록폼으로 이동하고 this.Close();
                    // this.Close();로 하는 이유: 등록폼에서 정상적으로 등록된 뒤 다시 조회하는 과정을 거쳐야 함.
                // 입력한 번호가 데이터베이스에 존재할 때 밑에 코드 실행
            MessageBox.Show("정상적으로 조회되었습니다.");
            // 포인트 조회 폼으로 이동
            PointSelectForm subFrom = new PointSelectForm();
            subFrom.ShowDialog();
            return;
        }
    }
}