using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAONhanVien
    {

        public bool Them(DTO.DTONhanVien nhanvien)
        {
            //ThemNhanVien (@ten, @taikhoan, @matkhau, @diachi, @gioitinh, @cmnd, @sdt, @ngaysinh, @luong, @chucvu)
            return new DAOSql()
                .Procedure("ThemNhanVien")
                .BindParam("@ten", nhanvien.Ten)
                .BindParam("@taikhoan", nhanvien.Taikhoan)
                .BindParam("@matkhau", nhanvien.Matkhau)
                .BindParam("@diachi", nhanvien.Diachi)
                .BindParam("@gioitinh", nhanvien.Giotinh, System.Data.SqlDbType.Bit)
                .BindParam("@cmnd", nhanvien.Cmnd)
                .BindParam("@sdt", nhanvien.Sdt)
                .BindParam("@ngaysinh", nhanvien.Ngaysinh, System.Data.SqlDbType.Date)
                .BindParam("@luong", nhanvien.Luong)
                .BindParam("@chucvu", nhanvien.Chucvu.Machucvu)
                .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTONhanVien nhanvien)
        {
            //SuaNhanVien (@ma, @ten, @taikhoan, @matkhau, @diachi, @gioitinh, @cmnd, @sdt, @ngaysinh, @luong, @chucvu)
            return new DAOSql()
               .Procedure("SuaNhanVien")
               .BindParam("@ma", nhanvien.Ma)
               .BindParam("@ten", nhanvien.Ten)
               .BindParam("@taikhoan", nhanvien.Taikhoan)
               .BindParam("@matkhau", nhanvien.Matkhau)
               .BindParam("@diachi", nhanvien.Diachi)
               .BindParam("@gioitinh", nhanvien.Giotinh, System.Data.SqlDbType.Bit)
               .BindParam("@cmnd", nhanvien.Cmnd)
               .BindParam("@sdt", nhanvien.Sdt)
               .BindParam("@ngaysinh", nhanvien.Ngaysinh, System.Data.SqlDbType.Date)
               .BindParam("@luong", nhanvien.Luong)
               .BindParam("@chucvu", DAOSql.GetClassPropertyDBValue("Machucvu", nhanvien.Chucvu))
               .ExecuteNonQuery() > 0;
        }


        public bool Xoa(DTO.DTONhanVien nhanvien)
        {
            return new DAOSql()
                        .Procedure("XoaNhanVien")
                        .BindParam("@ma", nhanvien.Ma)
                        .ExecuteNonQuery() > 0;
        }


        private List<DTO.DTONhanVien> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTONhanVien> danhsach = new List<DTO.DTONhanVien>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTONhanVien nhanvien = new DTO.DTONhanVien();
                nhanvien.Ma = (int)reader["manv"];
                nhanvien.Ten = (string)reader["tennv"];
                nhanvien.Taikhoan = (string)reader["taikhoan"];
                nhanvien.Matkhau = (string)reader["matkhau"];
                nhanvien.Diachi = (string)reader["diachi"];
                nhanvien.Giotinh = (bool)reader["gioitinh"];
                nhanvien.Cmnd = (string)reader["cmnd"];
                nhanvien.Ngaysinh = (DateTime)reader["ngaysinh"];
                nhanvien.Luong = (int)reader["luong"];
                nhanvien.Gianhap = (DateTime)reader["gianhap"];
                nhanvien.Sdt = (string)reader["sdt"];
                int macv = (int)(reader["macv"] ?? 0);
                nhanvien.Chucvu = (new DAO.DAOChucVu()).LayChucVuQuaID(macv);

                danhsach.Add(nhanvien);
            }

            return danhsach;
        }


        public List<DTO.DTONhanVien> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from nhanvien where xoa = 0")
                        .ExecuteReader());
        }


        public DTO.DTONhanVien LayVoiTK(string taikhoan, string matkhau)
        {
            List<DTO.DTONhanVien> ds =
                TachDTO(
                    new DAOSql()
                        .Query("Select * from nhanvien where taikhoan = @u and matkhau = @p and xoa=0")
                        .BindParam("@u", taikhoan)
                        .BindParam("@p", matkhau)
                        .ExecuteReader());
            return ds.Count == 0 ? null : ds[0];
        }


        public DTO.DTONhanVien LayVoiMa(int ma)
        {
            List<DTO.DTONhanVien> ds =
                TachDTO(
                    new DAOSql()
                        .Query("Select * from nhanvien where manv = @ma")
                        .BindParam("@ma", ma)
                        .ExecuteReader());
            return ds.Count == 0 ? null : ds[0];
        }

    }
}
