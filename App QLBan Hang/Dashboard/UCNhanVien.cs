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
        }


        private void llb_danhsach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_DanhSach());
        }

        private void llb_themnhanvien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        public void xemThongTin(DTO.DTONhanVien nhanvien)
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_Xem(nhanvien));
        }

        private void uC_MenuTop1_YuhClick(object sender, EventArgs e)
        {

        }
    }
}
