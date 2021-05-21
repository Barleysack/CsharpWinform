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

namespace ApplicationDev
{
    public partial class Fm_main : Form
    {
        public Fm_main()
        {
            InitializeComponent();
            Fm_login login = new();
            login.ShowDialog();
            this.stbExit.Click += new System.EventHandler(this.stbExit_Click);
            this.M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_SYSTEM_DropDownItemClicked);
            tsusername.Text = login.Tag.ToString();
            //태그값은 스르르 사라집니다 로그인이 끝나면-
            if (tsusername.Text == "FAIL")
            {
                //습관처럼 쓰십쇼...
                System.Environment.Exit(0);
               
                

            }
        }
        
        private void stbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsdatenow.Text = DateTime.Now.ToString();
        }

        private void M_SYSTEM_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //단순히 호출하는 경우
            //MDI_TEST form = new();
            //form.MdiParent = this;
            //form.Show();
            //프로그램 호출.

            Assembly assemb = Assembly.LoadFrom(Application.StartupPath + @"\" + "DEV_Form.DLL");
            //DLL파일의 위치 .
            Type typeform = assemb.GetType("DEV_Form." + e.ClickedItem.Name.ToString(), true);
            //당신이 선택한 아이템의 이름을 가져와라, DEV_fORM.선택한이름의 폼~를 통으로 가져오라는 느낌.*/
            Form show_form = (Form)Activator.CreateInstance(typeform);
            //TYPEFORM에서 가져온 이름과 같은 폼을 DEV_FORM.DLL에서 호출(인스턴스 생성)하라.

            show_form.MdiParent = this;
            show_form.Show();

        }

    }
}
