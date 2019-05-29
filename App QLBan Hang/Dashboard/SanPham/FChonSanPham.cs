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
    public partial class FChonSanPham : FTemplate
    {
        public FChonSanPham(DTO.DTOSanPham sanpham)
        {
            InitializeComponent();
            uC_SP_DanhSach1.setCallBackSelect((object sp) =>
            {
                DTO.DTOSanPham s = (DTO.DTOSanPham)sp;
                sanpham.Ma = s.Ma;
                sanpham.Loai = s.Loai;
                sanpham.Gia = s.Gia;
                sanpham.Ten = s.Ten;
                sanpham.Tongsl = s.Tongsl;
                this.Close();
            });
        }
    }
}
