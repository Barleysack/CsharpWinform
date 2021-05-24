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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEV_Form;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
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

            connect = new SqlConnection(strCon); //접속정보 커넥션에 객체 등록 및 객체 선언.
            connect.Open();

            if (connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터베이스 연결에 실패하였습니다");
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ITEMDETAIL FROM " +
                "TB_TESTITEM_KBS GROUP BY ITEMDETAIL", connect);
            //distinct로도 가능하다. Group by 대신.
            DataTable dttemp = new DataTable();
            adapter.Fill(dttemp);

            cmbItemDetail.DataSource = dttemp;
            cmbItemDetail.DisplayMember = "ITEMDESC";
            cmbItemDetail.ValueMember = "ITEMDESC";
            cmbItemDetail.Text = "";



        }
    }
}
