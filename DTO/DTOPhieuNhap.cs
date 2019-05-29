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
        private DateTime ngaylap;
        private bool trangthai;
        private List<DTOChiTietPhieuNhap> chitietnhap;
        private DTONhaCungCap nhacungcap;
        private DTONhanVien nhanvien;

        public DTOPhieuNhap()
        {
            Chitietnhap = new List<DTOChiTietPhieuNhap>();
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

        public List<DTOChiTietPhieuNhap> Chitietnhap
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
    }
}
