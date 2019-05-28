using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard.SizeMau
{
    public partial class UC_Mau : UserControl
    {
        DTO.DTOMau mauChon;
        Shared.SDelegate.CALLBACK1 callback;

        public UC_Mau()
        {
            InitializeComponent();

            btn_huy.Visible = false;
            btn_sua.Visible = false;
            btn_xoa.Visible = false;
        }

        public void setWindowSelectItem(Shared.SDelegate.CALLBACK1 callback)
        {
            this.callback = callback;
        }


        private void load()
        {
            BUS.BUSMau busMau = new BUS.BUSMau();

            if(txb_search.text == "")
                datagrid.DataSource = busMau.lay();
            else
                datagrid.DataSource = busMau.search(txb_search.text);
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid.SelectedRows.Count == 0) return;
            mauChon = (DTO.DTOMau)datagrid.SelectedRows[0].DataBoundItem;

            txb_tenmau.Text = mauChon.Ten;
            btn_huy.Visible = true;
            btn_sua.Visible = true;
            btn_xoa.Visible = true;
            btn_them.Visible = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO.DTOMau mau = new DTO.DTOMau();
            mau.Ten = txb_tenmau.Text;

            if (new BUS.BUSMau().them(mau))
            {
                MessageBox.Show("Thêm thành công!");
            } else
            {
                MessageBox.Show("Màu đã tồn tại!");
            }

            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(new BUS.BUSMau().xoa(mauChon))
            {
                MessageBox.Show("Xóa thành công!");
            } else
            {
                MessageBox.Show("Xóa không thành công!");
            }
            btn_huy_Click(null, null);
            load();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            mauChon.Ten = txb_tenmau.Text;
            if (new BUS.BUSMau().sua(mauChon))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
            load();
        }


        private void btn_huy_Click(object sender, EventArgs e)
        {
            btn_huy.Visible = false;
            btn_sua.Visible = false;
            btn_xoa.Visible = false;
            btn_them.Visible = true;
            mauChon = null;
            txb_search.text = "";
        }

        private void txb_search_OnTextChange(object sender, EventArgs e)
        {
            load();
        }

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid.SelectedRows.Count == 0 || callback == null) return;
            mauChon = (DTO.DTOMau)datagrid.SelectedRows[0].DataBoundItem;
            callback((object)mauChon);
        }

        private void UC_Mau_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch { }
        }
    }
}
