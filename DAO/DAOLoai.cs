using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOLoai
    {

        private List<DTO.DTOLoaiSanPham> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOLoaiSanPham> danhsach = new List<DTO.DTOLoaiSanPham>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOLoaiSanPham mau = new DTO.DTOLoaiSanPham();
                mau.Ma = (int)reader["malsp"];
                mau.Ten = (string)reader["tenlsp"];
                danhsach.Add(mau);
            }

            return danhsach;
        }


        public bool Them(DTO.DTOLoaiSanPham mau)
        {
            return new DAO.DAOSql()
                        .Procedure("ThemLoai")
                        .BindParam("@ten", mau.Ten)
                        .ExecuteNonQuery() > 0;
        }

        public bool Xoa(DTO.DTOLoaiSanPham mau)
        {
            return new DAO.DAOSql()
                        .Procedure("XoaLoai")
                        .BindParam("@ma", mau.Ma)
                        .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTOLoaiSanPham mau)
        {
            return new DAO.DAOSql()
                        .Procedure("SuaLoai")
                        .BindParam("@ma", mau.Ma)
                        .BindParam("@ten", mau.Ten)
                        .ExecuteNonQuery() > 0;
        }


        public List<DTO.DTOLoaiSanPham> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from loaisanpham where xoa=0")
                        .ExecuteReader());
        }


        public List<DTO.DTOLoaiSanPham> layQuaTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from loaisanpham where tenlsp = @ten and xoa=0")
                        .BindParam("@ten", ten)
                        .ExecuteReader());
        }


        public List<DTO.DTOLoaiSanPham> timKiemTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from loaisanpham where tenlsp like @ten and xoa=0")
                        .BindParam("@ten", "%"+ten+"%")
                        .ExecuteReader());
        }

    }
}
