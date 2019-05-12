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
        private string donvi;

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

        public string Donvi
        {
            get
            {
                return donvi;
            }

            set
            {
                donvi = value;
            }
        }
    }
}
