﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietPhieuNhap
    {
        private int ma;
        private DTOSanPham sanpham;
        private DTOMau mau;
        private DTOKichCo kichco;
        private int soluong;

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

        public DTOSanPham Sanpham
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

        public DTOMau Mau
        {
            get
            {
                return mau;
            }

            set
            {
                mau = value;
            }
        }

        public DTOKichCo Kichco
        {
            get
            {
                return kichco;
            }

            set
            {
                kichco = value;
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
    }
}
