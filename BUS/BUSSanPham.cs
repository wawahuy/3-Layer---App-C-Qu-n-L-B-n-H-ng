using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSSanPham
    {

        public bool tonTaiTen(string ten)
        {
            return new DAO.DAOSanPham().layQuaTen(ten).Count > 0;
        }

        public bool them(DTO.DTOSanPham sp)
        {
            return new DAO.DAOSanPham().Them(sp);
        }

        public bool xoa(DTO.DTOSanPham sp)
        {
            return new DAO.DAOSanPham().Xoa(sp);
        }

        public bool sua(DTO.DTOSanPham sp)
        {
            return new DAO.DAOSanPham().Sua(sp);
        }

        public List<DTO.DTOSanPham> layDanhSach()
        {
            return new DAO.DAOSanPham().lay();
        }

    }
}
