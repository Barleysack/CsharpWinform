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

namespace ApplicationDev
{
    public partial class Fm_main : Form
    {
        public Fm_main()
        {
            InitializeComponent();
            this.M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_SYSTEM_DropDownItemClicked);
            this.stbExit.Click += new System.EventHandler(this.stbExit_Click);
            this.stbClose.Click += new System.EventHandler(this.stbClose_Click);

            this.stbSearch.Click += new System.EventHandler(this.stbSearch_Click);
            
            this.stbInsert.Click += new System.EventHandler(this.stbInsert_Click);
            this.stbDel.Click += new System.EventHandler(this.stbDel_Click);
            this.stbSave.Click += new System.EventHandler(this.stbSave_Click);

            //Fm_login login = new();
            //login.ShowDialog(); 



            //tsusername.Text= login.Tag.ToString();
            ////태그값은 스르르 사라집니다 로그인이 끝나면-
            //if (tsusername.Text == "FAIL")
            //{
            //    //습관처럼 쓰십쇼...
            //    System.Environment.Exit(0);



            //   }
        }

        private void stbClose_Click(object sender, EventArgs e)
        {
            //tab 화면이 열린게 있어야..벨리데이션...!
            // 열려있는 화면이 있는지 확인
            if (mytabcontrol1.TabPages.Count == 0) return;
            //선택된 탭 페이지를 닫는다.
            mytabcontrol1.SelectedTab.Dispose();
            
        }

        private void stbExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void stbSearch_Click(object sender, EventArgs e) //조회
        {
            ChildCommand("SEARCH");
        }
        private void stbInsert_Click(object sender, EventArgs e) //추가
        {
            ChildCommand("NEW");
        }
        private void stbDel_Click(object sender, EventArgs e) //삭제
        {
            ChildCommand("DELETE");
        }
        private void stbSave_Click(object sender, EventArgs e) //저장
        {
            ChildCommand("SAVE");
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

            //show_form.MdiParent = this;
            //show_form.Show();
            
            //해당되는 폼이 이미 오픈되어 있는지 확인 후 활성화 또는 리턴.
            for (int i = 0; i < mytabcontrol1.TabPages.Count; i++)
            {
                if (mytabcontrol1.TabPages[i].Name == e.ClickedItem.Name.ToString())
                {

                    mytabcontrol1.SelectedTab = mytabcontrol1.TabPages[i];                    
                    return;


                }

                
            }
            mytabcontrol1.AddForm(show_form);

        }

        private void Toolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void ChildCommand(String Command)
        {
            if (this.mytabcontrol1.TabPages.Count == 0)  return;
            var Child = mytabcontrol1.SelectedTab.Controls[0] as DEV_Form.ChildInterface; //interface를 가진지 확인.
            switch (Command)
            {
                case "NEW":Child.DoNew(); break;
                case "SAVE":Child.Save(); break;
                case "SEARCH": Child.Inquire(); break;
                case "DELETE": Child.Delete(); break;
            }


        }
    
    }

    public partial class MDIForm : TabPage
    { }
    public partial class mytabcontrol : TabControl
    {
        public void AddForm(Form NewForm) //form 형식의 인자를 받겠다
                                      //형식에 대한...! 인자값에 대한 정확한 규칙을 정의하는 것...! 오버로딩으로 본다.
        {
            if (NewForm == null) return; //인자로 받은 폼이 없을 경우 실행 중지 , 이는 Validation.
            NewForm.TopLevel = false;    //인자로 받은 폼이 최상위 개체가 아님을 선언 
            MDIForm page = new MDIForm();
            page.Controls.Clear();       //페이지를 초기화
            page.Controls.Add(NewForm);  //페이지에 폼 추가
            page.Text = NewForm.Text;    //폼에서 지정한 이름을 탭 페이지 이름으로 가져오겠다. 
            page.Name = NewForm.Name;    //폼에서 설정한 이름으로 탭 페이지 설정 Text,name을 둘다 가져온다.

            base.TabPages.Add(page);     //base 는 부모 컨트롤을 가르킨다. 파생된 클래스 안에서 부모 컨트롤의 함수를 호출하기 위해..!
                                         //탭 컨트롤에 페이지를 추가한다. 
            NewForm.Show();              //인자로 받은 폼을 보여준다.
            base.SelectedTab = page;     //TabControl에서 가져오는 selected tab 

        }
    }
}
