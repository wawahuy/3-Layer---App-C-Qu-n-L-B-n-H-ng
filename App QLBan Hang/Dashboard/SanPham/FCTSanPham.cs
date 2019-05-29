using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.SanPham
{
    public partial class FCTSanPham : FTemplate
    {
        DTO.DTOMau mau;
        DTO.DTOKichCo kichco;
        DTO.DTOSanPham sanpham;
        DTO.DTOChiTietSanPham ctsanpham;

        public FCTSanPham(DTO.DTOSanPham sanpham)
        {
            InitializeComponent();
            mau = new DTO.DTOMau();
            kichco = new DTO.DTOKichCo();
            this.sanpham = sanpham;
            LoadDS();
        }

        private void LoadDS() {
            datagrid.DataSource = new BUS.BUSCTSanPham().lay(sanpham);
        }


        private void btn_mau_Click(object sender, EventArgs e)
        {
            SizeMau.FMau f = new SizeMau.FMau(mau);
            f.ShowDialog();
            btn_mau.Text = " Màu: " + ((mau.Ten == null || mau.Ten == "") ? "" : mau.Ten);
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            SizeMau.FSize f = new SizeMau.FSize(kichco);
            f.ShowDialog();
            btn_size.Text = " Size: " + ((kichco.Ten == null || kichco.Ten == "") ? "" : kichco.Ten);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(txb_soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }

            ctsanpham.Mau = mau;
            ctsanpham.Kichco = kichco;
            ctsanpham.Soluong = int.Parse(txb_soluong.Text);

            if (new BUS.BUSCTSanPham().sua(ctsanpham))
            {
                MessageBox.Show("Sửa thành công!");
                LoadDS();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
            LoadDS();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi tiết này không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (new BUS.BUSCTSanPham().xoa(ctsanpham))
            {
                MessageBox.Show("Xóa thành công!");
                LoadDS();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadDS();
        }

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_mau.Enabled = btn_size.Enabled = btn_sua.Enabled = btn_xoa.Enabled = txb_soluong.Enabled = true;
            ctsanpham = (DTO.DTOChiTietSanPham)datagrid.SelectedRows[0].DataBoundItem;
            kichco = ctsanpham.Kichco;
            mau = ctsanpham.Mau;
            btn_mau.Text = " Màu: " + ((mau.Ten == null || mau.Ten == "") ? "" : mau.Ten);
            btn_size.Text = " Size: " + ((kichco.Ten == null || kichco.Ten == "") ? "" : kichco.Ten);
            txb_soluong.Text = ctsanpham.Soluong.ToString();
        }

        private void txb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
