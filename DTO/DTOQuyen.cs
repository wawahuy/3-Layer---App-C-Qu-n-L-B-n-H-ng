using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOQuyen
    {
        private string ten;
        private int ma;

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
    }
}
