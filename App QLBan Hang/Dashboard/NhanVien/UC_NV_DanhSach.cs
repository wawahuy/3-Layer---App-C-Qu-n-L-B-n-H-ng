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
    public partial class UC_NV_DanhSach : UserControl
    {
        public static UC_NV_DanhSach CurrentShow;

        public UC_NV_DanhSach()
        {
            InitializeComponent();
            CurrentShow = this;
            LoadDL();
        }

        public void LoadDL()
        {
            datagrid.DataSource = new BUS.BUSNhanVien().layHetNhanVien();
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = datagrid.SelectedRows;

            if(MessageBox.Show("Bạn có muốn xóa "+rows.Count+" nhân viên không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Xóa thành công " + new BUS.BUSNhanVien().xoaNhanVien(rows) + "/" + rows.Count + " (Nhân Viên)!");
            LoadDL();
        }


        private void datagrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = datagrid.SelectedRows;
            btn_xoa.Visible = rows.Count >= 1;
            btn_xem_ds_hoa_don.Visible = btn_sua.Visible = btn_xem.Visible = rows.Count == 1;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void btn_xem_ds_hoa_don_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang code!");
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            UCNhanVien.CurrentShow.xemThongTin((DTO.DTONhanVien)datagrid.SelectedRows[0].DataBoundItem);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
        }
    }
}
