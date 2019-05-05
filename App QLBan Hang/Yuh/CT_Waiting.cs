using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang
{
    public partial class CT_Waiting : Bunifu.Framework.UI.BunifuCircleProgressbar
    {
        public CT_Waiting()
        {
            InitializeComponent();
            timerProcess.Start();
        }


        private int dir = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Value == 90)
            {
                dir = -1;
                animationIterval = 4;
            }
            else if (this.Value == 10)
            {
                dir = 1;
                animationIterval = 2;
            }
            Value += dir;
        }
    }
}
