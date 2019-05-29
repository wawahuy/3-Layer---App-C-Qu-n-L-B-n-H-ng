using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.SanPham
{
    public partial class UC_SP_DanhSach : UserControl
    {
        DTO.DTOLoaiSanPham lsp;
        DTO.DTOSanPham sanphamchon;
        Shared.SDelegate.CALLBACK1 callback;
        bool hasCallback;

        public UC_SP_DanhSach()
        {
            InitializeComponent();
            lsp = new DTO.DTOLoaiSanPham();
        }

        public void setCallBackSelect(Shared.SDelegate.CALLBACK1 callback)
        {
            this.callback = callback;
            hasCallback = true;
        }


        private void LoadDS()
        {
            try
            {
                datagrid.DataSource = new BUS.BUSSanPham().layDanhSach();
            } catch { }
        }


        /// <summary>
        /// Phần THêm , Sửa , Xóa
        /// </summary>
        /// 
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if(new BUS.BUSSanPham().xoa(sanphamchon))
            {
                MessageBox.Show("Xóa thành công!");
                LoadDS();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            sanphamchon.Gia = long.Parse(txb_gia.Text);
            sanphamchon.Loai = lsp;
            sanphamchon.Ten = txb_ten.Text;


            if (new BUS.BUSSanPham().sua(sanphamchon))
            {
                MessageBox.Show("Sửa thành công!");
                LoadDS();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO.DTOSanPham sp = new DTO.DTOSanPham();
            sp.Loai = lsp == null ? sp.Loai : lsp;
            sp.Gia = long.Parse(txb_gia.Text);
            sp.Ten = txb_ten.Text;

            if(new BUS.BUSSanPham().them(sp))
            {
                MessageBox.Show("Thêm thành công!");
                xoaNoiDungForm();
            } else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            btn_huy.Visible = false;
            btn_sua.Visible = false;
            btn_xoa.Visible = false;
            btn_them.Visible = true;
            txb_ten.Text = "";
            txb_gia.Text = "";
        }



        private void xoaNoiDungForm()
        {
            txb_gia.Text = txb_ten.Text = "";
            lsp = new DTO.DTOLoaiSanPham();
            btn_loai.Text = "  (Click để chọn)";
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
            FLoaiSanPham f = new FLoaiSanPham();
            f.setLSP(lsp);
            f.ShowDialog();
            btn_loai.Text = "  " + (lsp.Ten == null || lsp.Ten == "" ? "(Click để chọn)" : lsp.Ten);
        }

        private void txb_gia_OnValueChanged(object sender, EventArgs e)
        {
            testTextBox();
        }


        private bool testTextBox()
        {
            bool comp = true;

            lb_gia.Text = "";
            if (txb_gia.Text == "")
            {
                comp = false;
            }
            else
            {
                lb_gia.Text = String.Format("Ý của bạn là: {0:0,0} vnđ", decimal.Parse(txb_gia.Text));
            }


            lb_tensp.Text = "";
            if (txb_ten.Text == "")
            {
                comp = false;
            }
            else if (new BUS.BUSSanPham().tonTaiTen(txb_ten.Text) && sanphamchon.Ten != txb_ten.Text)
            {
                comp = false;
                lb_tensp.Text = "Tên này đã được sử dụng!";
            }

            return comp && lsp.Ten != null;
        }

        private void txb_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UC_SP_DanhSach_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_huy.Visible = true;
            btn_sua.Visible = true;
            btn_xoa.Visible = true;
            btn_them.Visible = false;

            sanphamchon = (DTO.DTOSanPham)datagrid.SelectedRows[0].DataBoundItem;
            lsp = sanphamchon.Loai;
            txb_ten.Text = sanphamchon.Ten;
            btn_loai.Text = "  " + (sanphamchon.Loai.Ten == null || sanphamchon.Loai.Ten == "" ? "(Click để chọn)" : sanphamchon.Loai.Ten);
            txb_gia.Text = ((long)sanphamchon.Gia).ToString();
        }

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sanphamchon = (DTO.DTOSanPham)datagrid.SelectedRows[0].DataBoundItem;

            if(hasCallback)
            {
                callback((object)sanphamchon);
                return;
            }

            new FCTSanPham(sanphamchon).ShowDialog();
            LoadDS();
        }

    }
}
