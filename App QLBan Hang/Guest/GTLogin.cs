using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.UCGuest
{
    public partial class GTLogin : UserControl
    {
        public GTLogin()
        {
            InitializeComponent();
        }


        private void btn_login_Click_1(object sender, EventArgs e)
        {
        }

        private void txb_password_OnValueChanged(object sender, EventArgs e)
        {
            this.txb_password.isPassword = true;
        }
    }
}
