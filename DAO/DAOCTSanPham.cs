using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOCTSanPham
    {

        private List<DTO.DTOChiTietSanPham> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOChiTietSanPham> danhsach = new List<DTO.DTOChiTietSanPham>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOChiTietSanPham sp = new DTO.DTOChiTietSanPham();
                sp.Ma = (int)reader["mactsp"];
                sp.Sanpham = new DAO.DAOSanPham().layQuaMaKRB((int)reader["masp"])[0];
                sp.Kichco = new DAO.DaoKichCo().layQuaMaKRB((int)reader["makc"])[0];
                sp.Mau = new DAO.DAOMau().layQuaMaKRB((int)reader["mamau"])[0];
                sp.Soluong = (int)reader["soluong"];
                danhsach.Add(sp);
            }

            return danhsach;
        }


        //public bool Them(DTO.DTOSanPham sp)
        //{
        //    return new DAOSql()
        //                .Procedure("ThemSanPham")
        //                .BindParam("@ten", sp.Ten)
        //                .BindParam("@loai", sp.Loai.Ma)
        //                .BindParam("@gia", sp.Gia, System.Data.SqlDbType.Decimal)
        //                .ExecuteNonQuery() > 0;
        //}

        public bool Xoa(DTO.DTOChiTietSanPham ctsp)
        {
            return new DAOSql()
                        .Procedure("XoaCTSanPham")
                        .BindParam("@ma", ctsp.Ma)
                        .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTOChiTietSanPham ctsp)
        {
            return new DAOSql()
                        .Procedure("SuaCTSanPham")
                        .BindParam("@ma", ctsp.Ma)
                        .BindParam("@masp", ctsp.Sanpham.Ma)
                        .BindParam("@mamau", ctsp.Mau.Ma)
                        .BindParam("@makc", ctsp.Kichco.Ma)
                        .BindParam("@soluong", ctsp.Soluong)
                        .ExecuteNonQuery() > 0;
        }


        //public List<DTO.DTOSanPham> layQuaTen(string ten)
        //{
        //    return TachDTO(
        //            new DAOSql()
        //                .Query("Select * from sanpham where tensp = @ten and xoa=0")
        //                .BindParam("@ten", ten)
        //                .ExecuteReader());
        //}


        public List<DTO.DTOChiTietSanPham> lay(DTO.DTOSanPham sanpham)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from ctsanpham where xoa = 0 and masp=@ma")
                        .BindParam("@ma", sanpham.Ma)
                        .ExecuteReader());
        }


        //public List<DTO.DTOLoaiSanPham> timKiemTen(string ten)
        //{
        //    return TachDTO(
        //            new DAOSql()
        //                .Query("Select * from loaisanpham where tenlsp like @ten and xoa=0")
        //                .BindParam("@ten", "%"+ten+"%")
        //                .ExecuteReader());
        //}

    }
}
