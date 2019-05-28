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

        public FCTSanPham()
        {
            InitializeComponent();
            mau = new DTO.DTOMau();
            kichco = new DTO.DTOKichCo();
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

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
        }
    }
}
