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
        private string ten;
        private bool giotinh;                   //0:Nam, 1:Nu
        private string sdt;
        private string diachi;
        private DateTime ngaysinh;
        private int diem;

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
                Tengioitinh = giotinh ? "Nữ" : "Nam";
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

        public int Diem
        {
            get
            {
                return diem;
            }

            set
            {
                diem = value;
            }
        }

        public string Tengioitinh
        {
            get
            {
                return tengioitinh;
            }

            set
            {
                tengioitinh = value;
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
    }
}
