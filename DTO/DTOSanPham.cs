using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSanPham
    {
        private int ma;
        private int gia;
        private int sanpham;
        private DTOLoaiSanPham loai;

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

        public int Sanpham
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

        public DTOLoaiSanPham Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }
    }
}
