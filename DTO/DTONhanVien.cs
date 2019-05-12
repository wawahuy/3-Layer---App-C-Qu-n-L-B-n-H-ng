using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhanVien
    {
        private int ma;
        private string ten;
        private string taikhoan;
        private string matkhau;
        private string cmnd;
        private bool giotinh;                   //0:Nam, 1:Nu
        private int luong;
        private string diachi;
        private string sdt;
        private DateTime ngaysinh;
        private DateTime gianhap;
        private DTOChucVu chucvu;

        private string tenchucvu;
        private string tengioitinh;

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

        public string Taikhoan
        {
            get
            {
                return taikhoan;
            }

            set
            {
                taikhoan = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public bool Giotinh
        {
            get
            {
                return giotinh;
            }

            set
            {
                giotinh = value;
                tengioitinh = giotinh ? "Nam" : "Nữ";
            }
        }

        public int Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public DateTime Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
            }
        }

        public DTOChucVu Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
                tenchucvu = chucvu == null ? "" : chucvu.Tenchucvu;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public string Tenchucvu
        {
            get
            {
                return tenchucvu;
            }

            
        }

        public string Tengioitinh
        {
            get
            {
                return tengioitinh;
            }

            
        }
    }
}
