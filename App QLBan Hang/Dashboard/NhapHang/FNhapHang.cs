using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.NhapHang
{
    public partial class FNhapHang : FTemplate
    {
        DTO.DTONhaCungCap ncc;
        DTO.DTOMau mau;
        DTO.DTOKichCo kichco;
        DTO.DTOSanPham sanpham;

        DTO.DTOPhieuNhap phieunhap;

        public FNhapHang()
        {
            InitializeComponent();
            lamMoiCTSP();
            phieunhap = new DTO.DTOPhieuNhap();
        }

        private void LoadDL()
        {
            datagrid.DataSource = new List<DTO.DTOChiTietPhieuNhap>();
            datagrid.DataSource = phieunhap.Chitietnhap;
        }

        private void btn_ncc_Click(object sender, EventArgs e)
        {
            Form f = new FNhaCungCap();
            f.ShowDialog();
            ncc = FNhaCungCap.Ncc ?? ncc;
            if (ncc != null)
            {
                btn_ncc.Text = ncc.Ten;
            }
        }

        private void btn_mau_Click(object sender, EventArgs e)
        {
            SizeMau.FMau f = new SizeMau.FMau(mau);
            f.ShowDialog();
            btn_mau.Text =((mau.Ten == null || mau.Ten == "") ? "  (Click để chọn)" :  mau.Ten);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            Form f = new SanPham.FChonSanPham(sanpham);
            f.ShowDialog();
            btn_sanpham.Text = ((sanpham.Ten == null || sanpham.Ten == "") ? "  (Click để chọn)" :  sanpham.Ten);
        }

        private void btn_kichthuoc_Click(object sender, EventArgs e)
        {
            SizeMau.FSize f = new SizeMau.FSize(kichco);
            f.ShowDialog();
            btn_kichthuoc.Text =  ((kichco.Ten == null || kichco.Ten == "") ? "  (Click để chọn)" :kichco.Ten);
        }

        private void txb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_themct_Click(object sender, EventArgs e)
        {
            if(sanpham == null)
            {
                MessageBox.Show("Cần chọn sản phẩm!");
                return;
            }

            if (mau == null)
            {
                MessageBox.Show("Cần chọn màu!");
                return;
            }

            if (kichco == null)
            {
                MessageBox.Show("Cần chọn kích cỡ!");
                return;
            }

            if (txb_gia.Text == "")
            {
                MessageBox.Show("Cần nhập giá!");
                return;
            }

            if (txb_soluong.Text == "")
            {
                MessageBox.Show("Cần nhập số lượng!");
                return;
            }

            bool hasUpdate = false;
            foreach(DTO.DTOChiTietPhieuNhap cts in phieunhap.Chitietnhap)
            {
                if(cts.Sanpham.Sanpham.Ma == sanpham.Ma &&
                    cts.Sanpham.Mau.Ma == mau.Ma &&
                    cts.Sanpham.Kichco.Ma == kichco.Ma)
                {
                    cts.Soluong += int.Parse(txb_soluong.Text);
                    hasUpdate = true;
                }
            }


            if (!hasUpdate)
            {
                DTO.DTOChiTietPhieuNhap ct = new DTO.DTOChiTietPhieuNhap();
                ct.Sanpham = new DTO.DTOChiTietSanPham();
                ct.Sanpham.Sanpham = sanpham;
                ct.Sanpham.Mau = mau;
                ct.Sanpham.Kichco = kichco;
                ct.Soluong = int.Parse(txb_soluong.Text);
                ct.Gia = int.Parse(txb_gia.Text);
                phieunhap.Chitietnhap.Add(ct);
            }

            lamMoiCTSP();

            LoadDL();

        }

        private void lamMoiCTSP()
        {
            mau = new DTO.DTOMau();
            kichco = new DTO.DTOKichCo();
            sanpham = new DTO.DTOSanPham();
        }
    }
}
