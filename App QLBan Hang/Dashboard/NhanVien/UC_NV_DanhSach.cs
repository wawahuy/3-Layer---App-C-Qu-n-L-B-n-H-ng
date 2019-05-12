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
        public UC_NV_DanhSach()
        {
            InitializeComponent();
            datagrid.DataSource = new DAO.DAONhanVien().Lay();
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = datagrid.SelectedRows;
            btn_xoa.Visible = rows.Count >= 1;
            btn_sua.Visible = rows.Count == 1;
        }
    }
}
