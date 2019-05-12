using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhieuNhap
    {
        private int ma;
        private int tongtien;
        private int thue;
        private DateTime ngaylap;
        private bool trangthai;
        private DTOChiTietPhieuNhap[] chitietnhap;
        private DTONhaCungCap nhacungcap;
        private DTONhanVien nhanvien;

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

        public int Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        public int Thue
        {
            get
            {
                return thue;
            }

            set
            {
                thue = value;
            }
        }

        public DateTime Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public bool Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }

        public DTOChiTietPhieuNhap[] Chitietnhap
        {
            get
            {
                return chitietnhap;
            }

            set
            {
                chitietnhap = value;
            }
        }

        public DTONhaCungCap Nhacungcap
        {
            get
            {
                return nhacungcap;
            }

            set
            {
                nhacungcap = value;
            }
        }

        public DTONhanVien Nhanvien
        {
            get
            {
                return nhanvien;
            }

            set
            {
                nhanvien = value;
            }
        }
    }
}
