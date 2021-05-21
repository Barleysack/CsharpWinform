using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
