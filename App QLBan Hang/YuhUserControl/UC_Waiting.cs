using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang
{
    public partial class UC_Waiting : UserControl
    {

        public UC_Waiting(string deltail)
        {
            InitializeComponent();
            lb_deltail.Text = deltail;
        }

        public UC_Waiting()
        {
            InitializeComponent();
        }

        public string TextDeltail
        {
            get { return lb_deltail.Text; }
            set { lb_deltail.Text = value; }
        }

        public Color ProcessColor
        {
            get { return cWaiting.ProgressColor; }
            set { cWaiting.ProgressColor = value; }
        }
    }
}
