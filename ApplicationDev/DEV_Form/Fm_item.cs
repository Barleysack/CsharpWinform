using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DEV_Form
{
    public partial class Fm_item : Form
    {
        public Fm_item()
        {
            InitializeComponent();
        }

        private SqlConnection connect = null; //접속 정보 객체 명명 
        string strCon = "Data Source = 61.105.9.203; " +
                "Initial Catalog = AppDev;" +
                "User ID=kfqs1;Password=1234";
        

        private void Fm_item_Load(object sender, EventArgs e)//이미 메모리에 올라가있는 클래스가 호출될때 실행
        {
            

            //콤보 박스 품목 상세 데이터 조회 및 추가

            try
            {
                // 콤보박스 품목 상세 데이터 조회 및 추가
                // 접속 정보 커넥선 에 등록 및 객체 선언
                 //빈 그릇을 만들어줍시다
                connect = new SqlConnection(strCon);
                connect.Open();
                dtpStart.Text = string.Format("{0:2020-01-01}", DateTime.Now);
                if (connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ITEMDETAIL FROM TB_TESTITEM_KBS ", connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                cmbItemDetail.DataSource = dtTemp;
                cmbItemDetail.DisplayMember = "ITEMDETAIL"; // 눈으로 보여줄 항목
                cmbItemDetail.ValueMember = "ITEMDETAIL"; // 실제 데이터를 처리할 코드 항목 
                cmbItemDetail.Text = "";
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

                dgvGrid.DataSource = null;
                connect = new SqlConnection(strCon);
                connect.Open();

                if(connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;

                }

                //조회를 위한 파라미터 설정

                string sIC = txtItemCode.Text;
                string sIN = txtItemName.Text;
                string sSD = dtpStart.Text; //date-time picker
                string sED = dtpEnd.Text;
                string sID = cmbItemDetail.Text;
                string sEF = null; //나머진 읽고 알아듣는게..

                if (rbProd.Checked == true) sEF = "N";//단종여부
                if (rbEnd.Checked == true) sEF = "Y";
                if (chkNameOnly.Checked == true) sIC = "";//이름으로만 검색

                //SQL 제어구문 
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT ITEMCODE,  "                          +
                                                            "       ITEMNAME,  "                          +
                                                            "       ITEMDETAIL,  "                        +
                                                            "       ITEMDETAIL2, "                        +
                                                            "       CASE WHEN ENDFLAG = 'Y' THEN '단종'"  +
                                                            "            WHEN ENDFLAG = 'N' THEN '생산'"  +
                                                            "            END AS ENDFLAG,                " +
                                                            //해당 결과값을 나타낼 행의 이름은 ENDFLAG로 하겠다.
                                                            "       PRODDATE,  "                          +
                                                            "       MAKEDATE,  "                          +
                                                            "       MAKER,     "                          +
                                                            "       EDITDATE,  "                          +
                                                            "       EDITOR     "                          +
                                                            "  FROM TB_TESTITEM_KBS WITH(NOLOCK)  "        +
                                                            " WHERE ITEMCODE LIKE '%" + sIC + "%' "       +
                                                            "   AND ITEMNAME LIKE '%" + sIN + "%' "       +
                                                            "   AND ITEMDETAIL LIKE '%" + sID + "%' "     +
                                                            "   AND ENDFLAG  = '" + sEF + "'"             +
                                                            "   AND PRODDATE BETWEEN'" +sSD +"'AND'"+ sED + "'"

                                                            , connect);
                //해당 sql문을 connect 스트링에 적혀있는 주소로 쿼리해줄 객체 생성

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp); //앞에서 해보았듯이, 빈 그릇을 챙겨와서...
                //adapter 객체가 해당 데이터테이블을 채우도록 해준다.

                if (dtTemp.Rows.Count == 0)
                {
                    dgvGrid.DataSource = null;

                    return; //아래 else 안해도 되도록...
                }
                    
                    //없으면 이 이벤트 종-료
                dgvGrid.DataSource = dtTemp; // 데이터 그리드 뷰에 (아까 채운) 데이터 테이블 등록

                // 그리드뷰의 헤더 명칭 선언
                dgvGrid.Columns["ITEMCODE"].HeaderText = "품목 코드";
                dgvGrid.Columns["ITEMNAME"].HeaderText = "품목 명";
                dgvGrid.Columns["ITEMDETAIL"].HeaderText = "품목 상세";
                dgvGrid.Columns["ITEMDETAIL2"].HeaderText = "품목 상세2";
                dgvGrid.Columns["ENDFLAG"].HeaderText = "단종 여부";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록 일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                // 그리드 뷰의 폭 지정
                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 200;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;

                // 컬럼의 수정 여부를 지정 한다
                dgvGrid.Columns["ITEMCODE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;











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
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
            dgvGrid.Columns["ITEMCODE"].ReadOnly = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //선택된 행 삭제.
            //역시 VC는 넣네
            if (this.dgvGrid.Rows.Count == 0) return;//예의 vc
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
                string Itemcode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString(); //현재 선택된 열을 itemcode가 나타냅니다.
                cmd.CommandText = "DELETE TB_TESTITEM_KBS"+/*여긴 당연히 내 데이터베이스를 써야..*/
                    "WHERE ITEMCODE = '" + Itemcode + "'"; //해당하는 열을 날리시오...따옴표를 안에 넣고 싶을때 이리 처리하는 디-테일

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
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("등록 ㄱㄱ?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return; //VCVC
            string sIC = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
            string sIN = dgvGrid.CurrentRow.Cells["ITEMNAME"].Value.ToString();
            string sID = dgvGrid.CurrentRow.Cells["ITEMDETAIL"].Value.ToString();
            string sID2 = dgvGrid.CurrentRow.Cells["ITEMDETAIL2"].Value.ToString();
            string sPD = dgvGrid.CurrentRow.Cells["PRODDATE"].Value.ToString();
            string sEF = dgvGrid.CurrentRow.Cells["ENDFLAG"].Value.ToString();

            SqlCommand cmd =new();
            SqlTransaction transaction;
            connect = new SqlConnection(strCon);
            connect.Open();

            // 데이터 조회 후 해당 데이터가 있는지 확인 후 UPDATE/INSERT 분기 
            string Ssql = " SELECT ITEMCODE FROM TB_TESTITEM_KBS WHERE ITEMCODE = '"+sIC+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(Ssql, connect);
            DataTable dttemp = new DataTable();
            adapter.Fill(dttemp);
            transaction = connect.BeginTransaction("TESTTRAN");
            cmd.Transaction = transaction;
            cmd.Connection = connect;
            //데이터가 있는 경우 UPDATE, 없는 경우 INSERT 
            if(dttemp.Rows.Count == 0)
            {
                //데이터가 없으니 INSERT 해라.

                cmd.CommandText = "INSERT INTO TB_TESTITEM_KBS (ITEMCODE,ITEMNAME,ITEMDETAIL,ITEMDETAIL2,ENDFLAG,PRODDATE,MAKEDATE,MAKER)" +
                                  "VALUES ('" + sIC + "','" + sIN + "','" + sID + "','" + sID2 + "','" + sEF + "','" + sPD + "',GETDATE(),'" + "" + "')";
                //SQL에서 인식되는 문자열을 위한 작은 따옴표들..!

            }
            else
            {
                //데이터가 있으니 UPDATE 해라. 

                cmd.CommandText = "UPDATE TB_TESTITEM_KBS                                  " +
                                  "    SET ITEMNAME = '" + sIC + "',             " +
                                  "        ITEMDETAIL = '" + sID + "',             " +
                                  "        ITEMDETAIL2 = '" + sID2+ "',            " +
                                  "        ENDFLAG = '" + sEF + "',              " +
                                  "        PRODDATE = '" + sPD + "',             " +
                                  "        EDITOR = '',  " +
                                  //"        EDITOR = '"    + Commoncs.LoginUserID + "',  " +
                                  "        EDITDATE = GETDATE()     " +
                                  "  WHERE ITEMCODE = '" + sIC + "'";
            }
            cmd.ExecuteNonQuery(); //CRUD 실행함수
            //성공 시 DB COMMIT
            transaction.Commit();
            MessageBox.Show("성공입니다");
            connect.Close();

        }
    }
}
