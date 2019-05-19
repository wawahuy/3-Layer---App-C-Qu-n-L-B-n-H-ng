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
            clickXemDanhSach();
        }

        public void clickXemDanhSach()
        {
            uC_MenuTop.click(0);
        }

        public void xemDanhSach()
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_DanhSach());
        }

        public void themNhanVien()
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_Them());
        }

        public void xemThongTin(DTO.DTONhanVien nhanvien)
        {
            uC_MenuTop.click(2);
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_Xem(nhanvien));
        }

        private void uC_MenuTop1_YuhClick(object sender, EventArgs e)
        {
            Yuh.UC_MenuTop.UC_MenuTopChild item = (Yuh.UC_MenuTop.UC_MenuTopChild)sender;

            switch(item.Text)
            {   
                case "Danh sách":
                    xemDanhSach();
                    break;

                case "Thêm nhân viên":
                    themNhanVien();
                    break;
            }



        }
    }
}
