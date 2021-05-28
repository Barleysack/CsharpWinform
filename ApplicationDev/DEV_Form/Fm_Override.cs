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
    public partial class Fm_Override : BaseMDIChildForm
    {
        public Fm_Override()
        {
            InitializeComponent();
        }

        public override void Save()
        {
            base.Save();
        }
        public override void Inquire()
        {
            base.Inquire();
        }
        public override void Delete()
        {
            base.Delete();
        }
        public override void DoNew()
        {
            base.DoNew();
        }
    }
}
