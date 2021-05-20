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
    public partial class Fm_login : Form
    {
        public Fm_login()
        {
            InitializeComponent();
        }

        private void Btn_pwchange_Click(object sender, EventArgs e)
        {
            // 비밀번호 변경 화면 팝업 호출. 
            this.Visible = false;
            FM_password fmPW = new(); //객체 선언하며 메모리에 올려주는 것-
            fmPW.ShowDialog(); //show와 차이는 이걸 불러오면 앞의 폼을 사용할 수 없다는 것. 
            this.Visible = true;

            
        }
    }
}
