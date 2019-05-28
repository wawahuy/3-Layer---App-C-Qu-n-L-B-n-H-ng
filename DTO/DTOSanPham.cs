using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSanPham
    {
        private string ten;
        private int ma;
        private long gia;
        private DTOLoaiSanPham loai;
        private int tongsl;
        private bool xoa;

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

        public long Gia
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

        public int Tongsl
        {
            get
            {
                return tongsl;
            }

            set
            {
                tongsl = value;
            }
        }

        public bool Xoa
        {
            get
            {
                return xoa;
            }

            set
            {
                xoa = value;
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

        public string TenLoai
        {
            get
            {
                return loai.Ten;
            }

        }
    }
}
