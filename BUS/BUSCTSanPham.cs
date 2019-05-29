using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSCTSanPham
    {

        public List<DTO.DTOChiTietSanPham> lay(DTO.DTOSanPham sanpham)
        {
            return new DAO.DAOCTSanPham().lay(sanpham);
        }


        public bool xoa(DTO.DTOChiTietSanPham sanpham)
        {
            return new DAO.DAOCTSanPham().Xoa(sanpham);
        }

        public bool sua(DTO.DTOChiTietSanPham sanpham)
        {
            return new DAO.DAOCTSanPham().Sua(sanpham);
        }

    }
}
