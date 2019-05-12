using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChucVu
    {
        private int machucvu;
        private string tenchucvu;
        private DTOQuyen[] quyen;

        public int Machucvu
        {
            get
            {
                return machucvu;
            }

            set
            {
                machucvu = value;
            }
        }

        public string Tenchucvu
        {
            get
            {
                return tenchucvu;
            }

            set
            {
                tenchucvu = value;
            }
        }

        public DTOQuyen[] Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }
    }
}
