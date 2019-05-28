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
    public partial class UC_NCC_DanhSach : UserControl
    {
        public static UC_NCC_DanhSach CurrentShow;

        public UC_NCC_DanhSach()
        {
            InitializeComponent();
            CurrentShow = this;
            LoadDL();
        }

        public void LoadDL()
        {
            datagrid.DataSource = new BUS.BUSNhaCungCap().layHeNhaCungCap();
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = datagrid.SelectedRows;

            if(MessageBox.Show("Bạn có muốn xóa "+rows.Count+" NCC này không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Xóa thành công " + new BUS.BUSNhaCungCap().xoa(rows) + "/" + rows.Count + " (Nhà cung cấp)!");
            LoadDL();
        }


        private void datagrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = datagrid.SelectedRows;
            btn_xoa.Visible = rows.Count >= 1;
            btn_sua.Visible = btn_xem.Visible = rows.Count == 1;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            //LoadDL();
            dd_loaitimkiem.selectedIndex = 0;
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            UCNhaCungCap kh = new UCNhaCungCap();
            kh.xemThongTin((DTO.DTONhaCungCap)datagrid.SelectedRows[0].DataBoundItem);
            FDashboard.openUserControl(kh);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            UCNhaCungCap kh = new UCNhaCungCap();
            kh.suaThongTin((DTO.DTONhaCungCap)datagrid.SelectedRows[0].DataBoundItem);
            FDashboard.openUserControl(kh);
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
            txb_search.Visible = false;

            switch (dd_loaitimkiem.selectedValue)
            {
                case "Tấc cả":
                    LoadDL();
                    break;

                case "Tìm theo Tên":
                case "Tìm theo Địa Chỉ":
                case "Tìm theo SĐT":
                    txb_search.Visible = true;
                    break;

            }
        }


        private void txb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            BUS.BUSNhaCungCap busNCC = new BUS.BUSNhaCungCap();
            List<DTO.DTONhaCungCap> lNCC = new List<DTO.DTONhaCungCap>();
            string value = txb_search.Text + e.KeyChar;

            switch (dd_loaitimkiem.selectedValue)
            {
                case "Tìm theo Tên":
                    lNCC = busNCC.TimTheoTen(value);
                    break;

                case "Tìm theo SĐT":
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                    lNCC = busNCC.TimTheoSDT(value);
                    break;

                case "Tìm theo Địa Chỉ":
                    lNCC = busNCC.TimTheoDiaChi(value);
                    break;
            }

            datagrid.DataSource = lNCC;
        }
    }
}
