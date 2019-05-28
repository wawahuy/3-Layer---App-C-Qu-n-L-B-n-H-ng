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
    public partial class FThemSanPham : FTemplate
    {
        DTO.DTOLoaiSanPham lsp;

        public FThemSanPham()
        {
            InitializeComponent();
            lsp = new DTO.DTOLoaiSanPham();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
            FLoaiSanPham f = new FLoaiSanPham();
            f.setLSP(lsp);
            f.ShowDialog();
            btn_loai.Text = "  " + (lsp.Ten == "" ? "(Click để chọn)" : lsp.Ten);
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
            else
            {
                
            }

            return comp;
        }


    }
}
