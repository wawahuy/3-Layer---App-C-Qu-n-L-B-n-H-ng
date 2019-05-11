using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhanVien
    {
        public int ma;
        public string taikhoan;
        public string cmnd;
        public bool gioting;                   //0:Nam, 1:Nu
        public string luong;
        public DTOChucVu chucvu;
    }
}
