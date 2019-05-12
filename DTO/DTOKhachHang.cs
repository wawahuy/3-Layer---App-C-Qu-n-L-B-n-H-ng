using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOKhachHang
    {
        private int ma;
        private string cmnd;
        private bool giotinh;                   //0:Nam, 1:Nu
        private string luong;
        private string sdt;
        private string diachi;
        private DateTime ngaysinh;

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
            }
        }

        public string Luong
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
    }
}
