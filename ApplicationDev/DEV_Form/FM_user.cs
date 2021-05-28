using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_Form
{
    public partial class FM_user : BaseMDIChildForm
    {
        public FM_user()
        {
            InitializeComponent();


        }
        public override void Inquire()
        {
            base.Inquire();
            //DB HELPER 선언 
            DBHelper helper = new(false); //선언함으로서 connection.open
            try
            {
                string sUserId = txtUID.Text;
                string sUserName = txtUname.Text;
                DataTable dttemp = new();
                dttemp = helper.FillTable("SP_USER_KBS_S1",
                    CommandType.StoredProcedure,
                    helper.CreateParameter("USERID", sUserId),
                    helper.CreateParameter("USERNAME", sUserName));
                if (dttemp.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("조회할 데이터 없음");
                }
                else
                {
                    dataGridView1.DataSource = dttemp;
                    //그리드 뷰에 데이터 삽입. 

                }

                    //dataGridView1.CurrentRow.Cells["USERID"].ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show("error : " + EX);
               
            }
            finally
            {
                helper.Close();
            }
        }

        public override void DoNew()
        {
            base.DoNew();
            DataRow dr = ((DataTable)dataGridView1.DataSource).NewRow();
            ((DataTable)dataGridView1.DataSource).Rows.Add(dr);

        }
        public override void Delete()
        {
            base.Delete();
            if (dataGridView1.Rows.Count == 0) return;
            int iSI = dataGridView1.CurrentCell.RowIndex-1;
            DataTable dttemp = (DataTable)dataGridView1.DataSource;
            dttemp.Rows[iSI].Delete();

        }
    }
}
