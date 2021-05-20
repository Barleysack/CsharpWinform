using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day16_ApplicationDev
{
    public partial class FM_password : Form
    {
        public FM_password()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pwreg_Click(object sender, EventArgs e)
        {
            //비밀번호를 변경
            // 1. id 존재여부 확인
            // 2. 이전 비밀번호 일치 확인
            // 3. 바뀔 비밀번호로 등록
            // 4. 변경여부 메시지 처리

        }
    }
}
