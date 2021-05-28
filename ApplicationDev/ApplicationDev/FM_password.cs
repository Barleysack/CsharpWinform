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



namespace ApplicationDev
{
    public partial class FM_password : Form
    {   
        private SqlConnection Connect = null; //데이터베이스 접속 정보 관리
        private SqlTransaction Tran;          //데이터베이스 관리 권한
        private SqlCommand cmd = new();       //데이터베이스 명령 전달


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
            string strCon = "Data Source = 222.235.141.8; " +
                "Initial Catalog = AppDev;" +
                "User ID=kfqs;Password=1234";
            Connect = new SqlConnection(strCon);

            Connect.Open();//데이터베이스에 접속한다.
            if(Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터베이스 연결 실패. ");
                return;

            }
            // 1. id 존재여부 확인
            String sLogid = string.Empty;
            string sPerPw = string.Empty;
            string sNewPw = string.Empty;
            sLogid = txtID.Text;
            sPerPw = txtPrevpw.Text;
            sNewPw = txtNewpw.Text;


            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_KBS WHERE " +
                "USERID = '"+sLogid+"'", Connect);
            //데이터를 담을 그릇
            DataTable DtTemp = new DataTable();
           //어댑터 실행 후 그릇의 데이터 담기
            adapter.Fill(DtTemp);

            // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
            if (DtTemp.Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사용자입니다.");
                return;

            }



            // 2. 이전 비밀번호 일치 확인
            else if (DtTemp.Rows[0]["PW"].ToString() != sPerPw)//row는 이름을 때릴 수 있다네?
            {
                MessageBox.Show("이전 비밀번호가 일치하지 않습니다. ");
                return;

            }


            // 3. 바뀔 비밀번호로 등록
            else
            {


                if (MessageBox.Show("해당 비밀번호로 변경하시겠습니까?", "비밀번호변경",
                    MessageBoxButtons.YesNo) == DialogResult.No) //NO 누르면 RETURN으로 나가버릴테야 이 코드블럭을;;
                {
                    return;
                }
                Tran = Connect.BeginTransaction("트랜잭션 시작");//트랜잭션 선언
                cmd.Transaction = Tran;//트랜잭션 사용 여부 커맨드에 등록
                cmd.Connection = Connect;// 커맨드에 접속 정보 입력
                cmd.CommandText = "UPDATE TB_USER_KBS SET PW = '" + sNewPw + "'WHERE USERID= '"+sLogid+"'";

                cmd.ExecuteNonQuery();//C,R, U,D 실행함수 실행 (CREATE,READ,UPDATE,DELETE)
                Tran.Commit();//변경 내용 승인 
                // 4. 변경여부 메시지 처리
                
                MessageBox.Show("정상적으로 변경하였습니다.");
                this.Close();

            }
            


        }
    }
}
