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
    public partial class UCNhaCungCap : UserControl
    {
        
        public UCNhaCungCap()
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
            transitionPage.openGUI(new Dashboard.NhaCungCap.UC_NCC_DanhSach());
        }

        public void themKhachHang()
        {
            transitionPage.openGUI(new Dashboard.NhaCungCap.UC_NCC_Them());
        }

        public void xemThongTin(DTO.DTONhaCungCap ncc)
        {
            uC_MenuTop.click(2);
            transitionPage.openGUI(new Dashboard.NhaCungCap.UC_NCC_Xem(ncc));
        }

        public void suaThongTin(DTO.DTOKhachHang khachhang)
        {
            uC_MenuTop.click(3);
            transitionPage.openGUI(new Dashboard.KhachHang.UC_KH_Sua(khachhang));
        }

        private void uC_MenuTop1_YuhClick(object sender, EventArgs e)
        {
            Yuh.UC_MenuTop.UC_MenuTopChild item = (Yuh.UC_MenuTop.UC_MenuTopChild)sender;

            switch(item.Text)
            {   
                case "Danh sách":
                    xemDanhSach();
                    break;

                case "Thêm nhà cung cấp":
                    themKhachHang();
                    break;
            }



        }

        private void uC_MenuTop_Load(object sender, EventArgs e)
        {

        }
    }
}
