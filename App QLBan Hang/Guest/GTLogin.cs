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


        
        private void txb_password_OnValueChanged(object sender, EventArgs e)
        {
            this.txb_password.isPassword = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string thongbao = "";
            BUS.BUSNhanVien bnv = new BUS.BUSNhanVien();
            DTO.DTONhanVien nv = bnv.DangNhap(txb_username.Text, txb_password.Text, ref thongbao);
            if ( nv != null) 
            {
                Program.loginCurrent = nv;
                Program.FormGuest.Hide();
                new FDashboard().ShowDialog();
                Program.FormGuest.Show();
                txb_password.Text = "";
            }
            else
            {
                lb_thongbao.Visible = true;
                Shared.SFunction.SetTimeOut(
                    () => Invoke((Action)(() => lb_thongbao.Visible = false))
                , 2000);
                lb_thongbao.Text = thongbao;
            }

            Program.loginCurrent = null;

            
        }
    }
}
