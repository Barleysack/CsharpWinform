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
    public partial class BaseMDIChildForm : Form,ChildInterface
    {
        public BaseMDIChildForm()
        {
            InitializeComponent();
        }

        public virtual void Inquire()
        {
            
        }

        public virtual void DoNew()
        {

        }

        public virtual void Delete()
        {

        }

        public virtual void Save()
        {

        }
    }
}
