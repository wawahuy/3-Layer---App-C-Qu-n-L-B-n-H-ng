using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietPhieuNhap
    {
        private int ma;
        private DTOChiTietSanPham sanpham;
        private int soluong;
        private int gia;

        public string HT_TenSP
        {
            get { return sanpham.Sanpham.Ten; }
        }

        public string HT_Mau
        {
            get { return sanpham.TenMau; }
        }

        public string HT_KichCo
        {
            get { return sanpham.TenKichCo; }
        }

        public int Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public DTOChiTietSanPham Sanpham
        {
            get
            {
                return sanpham;
            }

            set
            {
                sanpham = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public int Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }
    }
}
