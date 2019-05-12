using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHoaDon
    {
        private int ma;
        private int tongtien;
        private int thue;
        private DateTime ngaylap;
        private DTOChiTietHoaDon[] chitiethoadon;
        private DTOKhachHang khachhang;
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

        public DTOChiTietHoaDon[] Chitiethoadon
        {
            get
            {
                return chitiethoadon;
            }

            set
            {
                chitiethoadon = value;
            }
        }

        public DTOKhachHang Khachhang
        {
            get
            {
                return khachhang;
            }

            set
            {
                khachhang = value;
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
