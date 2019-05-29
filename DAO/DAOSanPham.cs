using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOSanPham
    {

        private List<DTO.DTOSanPham> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOSanPham> danhsach = new List<DTO.DTOSanPham>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOSanPham sp = new DTO.DTOSanPham();
                sp.Ma = (int)reader["masp"];
                sp.Ten = (string)reader["tensp"];
                if(DAOSql.ContainsColumn(reader, "tongsl"))
                    sp.Tongsl = reader["tongsl"] is DBNull ? 0 : (int)reader["tongsl"];
                sp.Loai = new DAO.DAOLoai().layQuaMaKoKiemTra((int)reader["malsp"])[0];
                sp.Gia = (long)((decimal)reader["gia"]);
                danhsach.Add(sp);
            }

            return danhsach;
        }


        public bool Them(DTO.DTOSanPham sp)
        {
            return new DAOSql()
                        .Procedure("ThemSanPham")
                        .BindParam("@ten", sp.Ten)
                        .BindParam("@loai", sp.Loai.Ma)
                        .BindParam("@gia", sp.Gia, System.Data.SqlDbType.Decimal)
                        .ExecuteNonQuery() > 0;
        }

        public bool Xoa(DTO.DTOSanPham sp)
        {
            return new DAOSql()
                        .Procedure("XoaSanPham")
                        .BindParam("@ma", sp.Ma)
                        .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTOSanPham sp)
        {
            return new DAOSql()
                        .Procedure("SuaSanPham")
                        .BindParam("@ma", sp.Ma)
                        .BindParam("@ten", sp.Ten)
                        .BindParam("@loai", sp.Loai.Ma)
                        .BindParam("@gia", (decimal)sp.Gia, System.Data.SqlDbType.Decimal)
                        .ExecuteNonQuery() > 0;
        }


        public List<DTO.DTOSanPham> layQuaTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from sanpham where tensp = @ten and xoa=0")
                        .BindParam("@ten", ten)
                        .ExecuteReader());
        }


        public List<DTO.DTOSanPham> layQuaMaKRB(int ma){
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from sanpham where masp = @ma")
                        .BindParam("@ma", ma)
                        .ExecuteReader());
        }

        public List<DTO.DTOSanPham> lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from layDanhSachSanPham()")
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
