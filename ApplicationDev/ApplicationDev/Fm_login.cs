using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Day16_ApplicationDev
{
    public partial class Fm_login : Form
    {
        private SqlConnection Connect = null;
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
        public int failcount = 0;
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source = 61.105.9.203; " +
                "Initial Catalog = AppDev;" +
                "User ID=kfqs;Password=1234";
            Connect = new SqlConnection(strCon);

            Connect.Open();//데이터베이스에 접속한다.
            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터베이스 연결 실패. ");
                return;

            }


            String sLogid = string.Empty;
            string sPerPw = string.Empty;

            sLogid = txtid.Text;
            sPerPw = txtpw.Text;



            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_KBS WHERE " +
               "USERID = '" + sLogid + "'", Connect);
            //데이터를 담을 그릇
            DataTable DtTemp = new DataTable();
            //어댑터 실행 후 그릇의 데이터 담기
            adapter.Fill(DtTemp);

            // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
            

                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("사용자 정보가 없습니다.");
                failcount = failcount + 1;
                if (failcount == 3)
                {
                    MessageBox.Show("3회 실패!");
                    this.Close();
                }



            }

                else if (DtTemp.Rows[0]["PW"].ToString() != sPerPw)//row는 이름을 때릴 수 있다네?
                {

                    MessageBox.Show("ID 또는 비밀번호가 일치하지 않습니다.");

                failcount = failcount + 1;
                if (failcount == 3)
                {
                    MessageBox.Show("3회 실패!");
                    this.Close();
                }


            }
                
           
               

               else if ((DtTemp.Rows[0]["PW"].ToString() == sPerPw))
                {
                    MessageBox.Show("환영합니다!");
                    this.Close();

                }



          









        }
    }
}
