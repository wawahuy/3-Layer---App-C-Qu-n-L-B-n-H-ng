using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
            llb_danhsach_LinkClicked(null, null);
        }

        private void llb_danhsach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_DanhSach());
        }
    }
}
