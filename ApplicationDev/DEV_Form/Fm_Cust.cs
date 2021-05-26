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
using ApplicationDev;

namespace DEV_Form
{
    

    public partial class Fm_Cust : Form
    {

        private SqlConnection connect = null; //접속 정보 객체 명명 
        string strCon = "Data Source = 61.105.9.203; " +
                "Initial Catalog = AppDev;" +
                "User ID=kfqs1;Password=1234";
        public Fm_Cust()
        {
            InitializeComponent();
        }

        private void Fm_Cust_Load(object sender, EventArgs e)
        {
            try
            {
                // 콤보박스 품목 상세 데이터 조회 및 추가
                // 접속 정보 커넥선 에 등록 및 객체 선언
                //빈 그릇을 만들어줍시다
                connect = new SqlConnection(strCon);
                connect.Open();
                dtpSD.Text = string.Format("{0:2020-01-01}", DateTime.Now);
                if (connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                //SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ITEMDETAIL FROM TB_TESTITEM_KBS ", connect);
                //DataTable dtTemp = new DataTable();
                //adapter.Fill(dtTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DGV.DataSource = null;
                connect = new SqlConnection(strCon);
                connect.Open();

                if (connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;

                }

                //조회를 위한 파라미터 설정

                string sCC = txtCustCode.Text;
                string sCN = txtCustName.Text;
                string sSD = dtpSD.Text.ToString() ; //date-time picker
                string sED = dtpED.Text.ToString() ;
                string sBT = null;
                string sCT = null;
                string uF = null;
                //나머진 읽고 알아듣는게..

                if (rbSY.Checked == true) sBT = "상용차 부품";
                if (rbC.Checked == true) sBT = "자동차부품";
                if (rbCut.Checked == true) sBT = "절삭가공";
                if (rbPump.Checked == true) sBT = "펌프 압축기";
                
                if (chkCust.Checked == true) sCT = "C";//이름으로만 검색

                //SQL 제어구문 
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CUSTCODE,  " +
                                                            "       CASE WHEN CUSTTYPE = 'C' THEN '고객사'" +
                                                            "            WHEN CUSTTYPE = 'V' THEN '협력사'" +
                                                            "            END AS CUSTTYPE,                 " +
                                                            "       CUSTNAME,  " +
                                                            "       BIZCLASS, " +
                                                            "       BIZTYPE,   " +
                                                            "       CASE WHEN USEFLAG = 'Y' THEN '사용'" +
                                                            "            WHEN USEFLAG = 'N' THEN '미사용'" +
                                                            "            END AS USEFLAG,                " +

                                                            "       FIRSTDATE,  " +
                                                            "       MAKEDATE,  " +
                                                            "       MAKER,     " +
                                                            "       EDITDATE,  " +
                                                            "       EDITOR     " +
                                                            "  FROM TB_CUST_KBS WITH(NOLOCK)  " +
                                                            " WHERE CUSTCODE LIKE '%" + sCC + "%' " +

                                                            "   AND CUSTNAME LIKE '%" + sCN + "%' " +
                                                            "   AND BIZTYPE  LIKE '%" + sBT + "%'"  +
                                                            "   AND FIRSTDATE BETWEEN'" + sSD + "'AND'" + sED + "'"

                                                            , connect);
                //해당 sql문을 connect 스트링에 적혀있는 주소로 쿼리해줄 객체 생성
                //시스템에서 열리는 화면 한개를 한 본이라고 부른다.

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp); //앞에서 해보았듯이, 빈 그릇을 챙겨와서...
                //adapter 객체가 해당 데이터테이블을 채우도록 해준다.

                if (dtTemp.Rows.Count == 0)
                {
                    DGV.DataSource = null;

                    return; //아래 else 안해도 되도록...
                }

                //없으면 이 이벤트 종-료
                DGV.DataSource = dtTemp; // 데이터 그리드 뷰에 (아까 채운) 데이터 테이블 등록

                // 그리드뷰의 헤더 명칭 선언
                DGV.Columns["CUSTCODE"].HeaderText = "거래처 코드";
                DGV.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                DGV.Columns["CUSTNAME"].HeaderText = "거래처 이름";
                DGV.Columns["BIZCLASS"].HeaderText = "업태";
                DGV.Columns["BIZTYPE"].HeaderText = "종목";
                DGV.Columns["USEFLAG"].HeaderText = "사용여부";

                DGV.Columns["FIRSTDATE"].HeaderText = "거래일자";
                DGV.Columns["MAKEDATE"].HeaderText = "등록일시";
                DGV.Columns["MAKER"].HeaderText = "등록자";
                DGV.Columns["EDITDATE"].HeaderText = "수정일시";
                DGV.Columns["EDITOR"].HeaderText = "수정자";

                // 그리드 뷰의 폭 지정
                DGV.Columns[0].Width = 100;
                DGV.Columns[1].Width = 200;
                DGV.Columns[2].Width = 200;
                DGV.Columns[3].Width = 200;
                DGV.Columns[4].Width = 200;
                DGV.Columns[5].Width = 100;
                DGV.Columns[6].Width = 200;
                DGV.Columns[7].Width = 100;
                DGV.Columns[8].Width = 100;
                DGV.Columns[9].Width = 100;

                // 컬럼의 수정 여부를 지정 한다


                DGV.Columns["CUSTCODE"].ReadOnly = true;
                DGV.Columns["CUSTTYPE"].ReadOnly = true;









            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connect.Close();

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // 데이터 그리드 뷰 에 신규 행 추가
            DataRow dr = ((DataTable)DGV.DataSource).NewRow();
            ((DataTable)DGV.DataSource).Rows.Add(dr);
            DGV.Columns["CUSTCODE"].ReadOnly = false;
            DGV.Columns["CUSTTYPE"].ReadOnly = false;



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.DGV.Rows.Count == 0) return;//예의 vc
            if (MessageBox.Show("선택된 데이터를 삭제?", "데이터삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            connect = new SqlConnection(strCon);
            connect.Open();
            //연-결

            // 트랜잭션 관리를 위한 권한 위임 
            tran = connect.BeginTransaction("TranStart"); //여기 들어간건 트랜잭션명입니다요
            cmd.Transaction = tran;
            cmd.Connection = connect;


            try
            {
                string Custcode = DGV.CurrentRow.Cells["CUSTCODE"].Value.ToString(); //현재 선택된 열을 custcode가 나타냅니다.
                cmd.CommandText = "DELETE TB_CUST_KBS WHERE CUSTCODE = '" + Custcode + "'"; //해당하는 열을 날리시오...따옴표를 안에 넣고 싶을때 이리 처리하는 디-테일

                cmd.ExecuteNonQuery();
                //연결에 대한 Transact - SQL 문을 실행하고 영향을 받는 행의 수를 반환합니다.
                // 성공 시 DB Commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제 하였습니다.");
                btnSearch_Click(null, null); // 데이터 재조회
                //다시 해당 버튼(조회)을 눌렀을때처럼..!
            }
            catch
            {
                tran.Rollback();
                MessageBox.Show("데이터 삭제에 실패 하였습니다.");
                //잘못 되었으면 롤-백
            }
            finally
            {
                connect.Close();
                //끝에는 DB와의 연결을 끊어주어야...! 이런 것들 놓치지 않는 것이 좋을듯.

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            if (MessageBox.Show("등록 ㄱㄱ?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return; //VCVC
            string sCC = DGV.CurrentRow.Cells["CUSTCODE"].Value.ToString();
            
            
            string sCT = DGV.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
            if(sCT == "고객사")
            {
                sCT = 'C'.ToString(); 
            }
            else if(sCT == "협력사")
            {
                sCT = 'V'.ToString();

            }
            else
            {
                sCT = 'C'.ToString();
            }
            
            string sCN = DGV.CurrentRow.Cells["CUSTNAME"].Value.ToString();
            string sBC = DGV.CurrentRow.Cells["BIZCLASS"].Value.ToString();
            string sBT = DGV.CurrentRow.Cells["BIZTYPE"].Value.ToString();
            
            
            string uF = DGV.CurrentRow.Cells["USEFLAG"].Value.ToString();
            if (uF == "사용")
            {
                uF = 'Y'.ToString();
            }
            else if (uF == "미사용")
            {
                uF = 'N'.ToString();

            }
            else
            {
                uF = 'Y'.ToString();
            }

            string sFD = DGV.CurrentRow.Cells["FIRSTDATE"].Value.ToString();
            
            if (sCC == "" )
            {
                MessageBox.Show("거래처 코드 및 거래처 타입, 거래일자가 입력되지 않았습니다.");
                return;
                
            }
            else if (sCT == "")
            {
                MessageBox.Show("거래처 코드 및 거래처 타입, 거래일자가 입력되지 않았습니다.");
                return;
            }
            else if (sFD == "")
            {
                MessageBox.Show("거래처 코드 및 거래처 타입, 거래일자가 입력되지 않았습니다.");
                return;
            }



            SqlCommand cmd = new();
            SqlTransaction transaction;
            connect = new SqlConnection(strCon);
            connect.Open();

            //데이터 조회 후 해당 데이터가 있는지 확인 후 UPDATE / INSERT 분기
            //string Ssql = " SELECT ITEMCODE FROM TB_TESTITEM_KBS WHERE ITEMCODE = '" + sIC + "'";
            //SqlDataAdapter adapter = new SqlDataAdapter(Ssql, connect);
            //DataTable dttemp = new DataTable();
            //adapter.Fill(dttemp);
            transaction = connect.BeginTransaction("TESTTRAN");
            cmd.Transaction = transaction;
            cmd.Connection = connect;
            cmd.CommandText = "UPDATE TB_CUST_KBS  //업데이트할때는 기본 키를 지켜야..                                 " +
                                      "    SET CUSTCODE = '" + sCC + "',                " +
                                      "        CUSTTYPE = '" + sCT + "',              " +
                                      "        CUSTNAME = '" + sCN + "',            " +
                                      "        USEFLAG = '" + uF + "',                 " +
                                      "        FIRSTDATE = '" + sFD + "',                " +
                                      "        EDITOR = '" + Common.LogInID + "', " +
                                      //"        
                                      "        EDITDATE = GETDATE()                     " +
                                      "  WHERE CUSTCODE = '" + sCC + "'" +
                                      " IF (@@ROWCOUNT =0) " + //SQL의 ROWCOUNT함수를 알아두자.
                                      "INSERT INTO TB_CUST_KBS(CUSTCODE,CUSTTYPE, CUSTNAME,BIZCLASS,BIZTYPE,USEFLAG,FIRSTDATE,MAKEDATE,MAKER) " +
                                      "VALUES('"+sCC+"','"+sCT+"','"+sCN+"','"+sBC+"','"+sBT+"','"+uF+"','"+sFD+"',"+"GETDATE(),"+"''"+")";


            cmd.ExecuteNonQuery(); //CRUD 실행함수
            //성공 시 DB COMMIT
            transaction.Commit();
            MessageBox.Show("성공입니다");
            connect.Close();







        }
    }
}
