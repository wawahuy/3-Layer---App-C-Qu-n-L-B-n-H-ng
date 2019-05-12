using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.NhanVien
{
    public partial class UC_NV_Xem : UserControl
    {
        DTO.DTONhanVien nhanvien;

        public UC_NV_Xem()
        {
            InitializeComponent();
        }

        public UC_NV_Xem(DTO.DTONhanVien nv)
        {
            InitializeComponent();
            nhanvien = nv;

            lb_chucvu.Text = nv.Tenchucvu;
            lb_cmnd.Text = nv.Cmnd;
            lb_diachi.Text = nv.Diachi;
            lb_gianhap.Text = nv.Gianhap.ToString();
            lb_gioitinh.Text = nv.Tengioitinh;
            lb_hoten.Text = nv.Ten;
            lb_luong.Text = nv.Luong.ToString();
            lb_ngaysinh.Text = nv.Ngaysinh.ToString();
            lb_sdt.Text = nv.Sdt;
            lb_taikhoan.Text = nv.Taikhoan;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xem_ds_hoa_don_Click(object sender, EventArgs e)
        {

        }
    }
}
