using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSLoai
    {

        public List<DTO.DTOLoaiSanPham> lay()
        {
            return new DAO.DAOLoai().Lay();
        }

        public bool them(DTO.DTOLoaiSanPham mau)
        {
            DAO.DAOLoai dao = new DAO.DAOLoai();

            if(dao.layQuaTen(mau.Ten).Count > 0)
            {
                return false;
            }

            return dao.Them(mau);
        }


        public bool xoa(DTO.DTOLoaiSanPham mau)
        {
            return new DAO.DAOLoai().Xoa(mau);
        }


        public bool sua(DTO.DTOLoaiSanPham mau)
        {
            return new DAO.DAOLoai().Sua(mau);
        }


        public List<DTO.DTOLoaiSanPham> search(string se)
        {
            return new DAO.DAOLoai().timKiemTen(se);
        }

    }
}
