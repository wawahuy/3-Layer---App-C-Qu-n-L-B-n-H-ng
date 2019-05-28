using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAONhaCungCap
    {

        public bool Them(DTO.DTONhaCungCap ncc)
        {
            return new DAOSql()
                .Procedure("ThemNCC")
                .BindParam("@ten", ncc.Ten)
                .BindParam("@diachi", ncc.Diachi)
                .BindParam("@sdt", ncc.Sdt)
                .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTONhaCungCap ncc)
        {
            return new DAOSql()
               .Procedure("SuaNCC")
               .BindParam("@ma", ncc.Ma)
               .BindParam("@ten", ncc.Ten)
               .BindParam("@diachi", ncc.Diachi)
               .BindParam("@sdt", ncc.Sdt)
               .ExecuteNonQuery() > 0;
        }


        public bool Xoa(DTO.DTONhaCungCap ncc)
        {
            return new DAOSql()
                        .Procedure("XoaNCC")
                        .BindParam("@ma", ncc.Ma)
                        .ExecuteNonQuery() > 0;
        }


        private List<DTO.DTONhaCungCap> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTONhaCungCap> danhsach = new List<DTO.DTONhaCungCap>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTONhaCungCap ncc = new DTO.DTONhaCungCap();
                ncc.Ma = (int)reader["mancc"];
                ncc.Ten = (string)reader["tenncc"];
                ncc.Diachi = (string)reader["diachi"];
                ncc.Sdt = (string)reader["sdt"];
                danhsach.Add(ncc);
            }

            return danhsach;
        }


        //public List<DTO.DTOKhachHang> layKhachHangQuaCMND(string cmnd)
        //{
        //    return TachDTO(
        //            new DAOSql()
        //                .Query("Select * from khachhang where cmnd = @cmnd and xoa = 0")
        //                .BindParam("@cmnd", cmnd)
        //                .ExecuteReader());
        //}


        public List<DTO.DTONhaCungCap> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from nhacungcap where xoa = 0")
                        .ExecuteReader());
        }

        public List<DTO.DTONhaCungCap> TimKH_Ten(string tenncc)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from nhacungcap where tenncc like @ten and xoa = 0")
                        .BindParam("@ten", "%" + tenncc + "%")
                        .ExecuteReader());
        }

        public List<DTO.DTONhaCungCap> TimKH_SDT(string sdt)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from nhacungcap where SDT like @sdt and xoa = 0")
                        .BindParam("@sdt", sdt + '%')
                        .ExecuteReader());
        }

        public List<DTO.DTONhaCungCap> TimKH_DiaChi(string diachi)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from nhacungcap where diachi like @diachi and xoa = 0")
                        .BindParam("@diachi", diachi + '%')
                        .ExecuteReader());
        }

        public List<DTO.DTONhaCungCap> layNCCQuaTen(string tenncc)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from nhacungcap where tenncc = @ten and xoa = 0")
                        .BindParam("@ten", tenncc)
                        .ExecuteReader());
        }

    }
}
