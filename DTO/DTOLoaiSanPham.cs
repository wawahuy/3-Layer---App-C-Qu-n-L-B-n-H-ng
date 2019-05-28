using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOLoaiSanPham
    {
        private int ma;
        private string ten;
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
    }
}
