using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.KhachHang
{
    public partial class UC_KH_Xem : UserControl
    {
        DTO.DTOKhachHang khachhang;

        public UC_KH_Xem()
        {
            InitializeComponent();
        }

        public UC_KH_Xem(DTO.DTOKhachHang kh)
        {
            InitializeComponent();
            khachhang = kh;

            lb_cmnd.Text = kh.Cmnd;
            lb_diachi.Text = kh.Diachi;
            lb_gioitinh.Text = kh.Tengioitinh;
            lb_hoten.Text = kh.Ten;
            lb_diem.Text = kh.Diem.ToString();
            lb_ngaysinh.Text = kh.Ngaysinh.ToString();
            lb_sdt.Text = kh.Sdt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            UCKhachHang kh = new UCKhachHang();
            kh.suaThongTin(khachhang);
            FDashboard.openUserControl(kh);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if(new BUS.BUSKhachHang().xoa(khachhang))
            {
               MessageBox.Show("Xóa khách hàng thành công!");
               FDashboard.openUserControl(new UCNhanVien());
            } else
            {
                MessageBox.Show("Xóa khách hàng thất bại!");
            }
        }

        private void btn_xem_ds_hoa_don_Click(object sender, EventArgs e)
        {
        }


    }
}
