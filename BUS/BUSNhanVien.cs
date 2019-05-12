using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSNhanVien
    {

        public DTO.DTONhanVien DangNhap(string taikhoan, string matkhau, ref string thongbao)
        {
            if(taikhoan == "")
            {
                thongbao = "Vui lòng nhập tài khoản!";
                return null;
            }

            if (matkhau == "")
            {
                thongbao = "Vui lòng nhập tài mật khẩu!";
                return null;
            }

            DTO.DTONhanVien nv = new DAO.DAONhanVien().LayVoiTK(taikhoan, matkhau);
            if(nv == null)
            {
                thongbao = "Sai tài khoản hoặc mật khẩu!";
            }

            return nv;
        }

    }
}
