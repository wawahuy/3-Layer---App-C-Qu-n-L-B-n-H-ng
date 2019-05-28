using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.NhaCungCap
{
    public partial class UC_NCC_Xem : UserControl
    {
        DTO.DTONhaCungCap ncc;

        public UC_NCC_Xem()
        {
            InitializeComponent();
        }

        public UC_NCC_Xem(DTO.DTONhaCungCap kh)
        {
            InitializeComponent();
            ncc = kh;

            lb_diachi.Text = kh.Diachi;
            lb_hoten.Text = kh.Ten;
            lb_sdt.Text = kh.Sdt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            UCNhaCungCap ucncc = new UCNhaCungCap();
            //kh.suaThongTin(khachhang);
            FDashboard.openUserControl(ucncc);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa NCC này không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if(new BUS.BUSNhaCungCap().xoa(ncc))
            {
               MessageBox.Show("Xóa NCC thành công!");
               FDashboard.openUserControl(new UCNhaCungCap());
            } else
            {
                MessageBox.Show("Xóa NCC thất bại!");
            }
        }

        private void btn_xem_ds_hoa_don_Click(object sender, EventArgs e)
        {
        }


    }
}
