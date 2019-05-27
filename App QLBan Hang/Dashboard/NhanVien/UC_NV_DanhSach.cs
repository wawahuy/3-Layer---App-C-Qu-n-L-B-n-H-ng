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
            //LoadDL();
            dd_loaitimkiem.selectedIndex = 0;
        }

        private void btn_xem_ds_hoa_don_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang code!");
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            UCNhanVien nv = new UCNhanVien();
            nv.xemThongTin((DTO.DTONhanVien)datagrid.SelectedRows[0].DataBoundItem);
            FDashboard.openUserControl(nv);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            UCNhanVien nv = new UCNhanVien();
            nv.suaThongTin((DTO.DTONhanVien)datagrid.SelectedRows[0].DataBoundItem);
            FDashboard.openUserControl(nv);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Kiểm tra loại tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dd_loaitimkiem_onItemSelected(object sender, EventArgs e)
        {
            dd_search.Visible = false;
            txb_search.Visible = false;

            switch (dd_loaitimkiem.selectedValue)
            {
                case "Tấc cả":
                    LoadDL();
                    break;

                case "Tìm theo Tài Khoản":
                case "Tìm theo Tên":
                case "Tìm theo CMND":
                case "Tìm theo SĐT":
                    txb_search.Visible = true;
                    break;

                case "Tìm theo Chức Vụ":
                case "Tìm theo Giới tính":
                    dd_search.Visible = true;
                    break;
            }

            switch (dd_loaitimkiem.selectedValue)
            {
                case "Tìm theo Giới tính":
                    dd_search.Items = new string[] { "Nam", "Nữ" };
                    break;

                case "Tìm theo Chức Vụ":
                    BUS.BUSChucVu chucvu = new BUS.BUSChucVu();
                    List<string> cvs = Shared.SFunction.GetArrByPrototype<DTO.DTOChucVu, string>(chucvu.layHetChucVu(), "Tenchucvu");
                    dd_search.Items = cvs.ToArray();
                    break;
            }
        }

        private void dd_search_onItemSelected(object sender, EventArgs e)
        {
            BUS.BUSNhanVien busNV = new BUS.BUSNhanVien();
            List<DTO.DTONhanVien> lNV = new List<DTO.DTONhanVien>();

            switch (dd_loaitimkiem.selectedValue)
            {
                case "Tìm theo Chức Vụ":
                    lNV = busNV.TimTheoChucVu(dd_search.selectedValue);
                    break;

                case "Tìm theo Giới tính":
                    lNV = busNV.TimTheoGioiTinh(dd_search.selectedValue == "Nữ");
                    break;
            }

            datagrid.DataSource = lNV;
        }

        private void txb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            BUS.BUSNhanVien busNV = new BUS.BUSNhanVien();
            List<DTO.DTONhanVien> lNV = new List<DTO.DTONhanVien>();
            string value = txb_search.Text + e.KeyChar;

            switch (dd_loaitimkiem.selectedValue)
            {
                case "Tìm theo Tài Khoản":
                    lNV = busNV.TimTheoTaiKhoan(value);
                    break;

                case "Tìm theo Tên":
                    lNV = busNV.TimTheoTen(value);
                    break;

                case "Tìm theo CMND":
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                    lNV = busNV.TimTheoCMND(value);
                    break;

                case "Tìm theo SĐT":
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                    lNV = busNV.TimTheoSDT(value);
                    break;
            }

            datagrid.DataSource = lNV;
            if (!e.Handled) return;
        }
    }
}
