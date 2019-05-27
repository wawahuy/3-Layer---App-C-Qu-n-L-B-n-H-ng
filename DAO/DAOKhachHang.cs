using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOKhachHang
    {

        public bool Them(DTO.DTOKhachHang kh)
        {
            return new DAOSql()
                .Procedure("ThemKhachHang")
                .BindParam("@ten", kh.Ten)
                .BindParam("@diachi", kh.Diachi)
                .BindParam("@gioitinh", kh.Giotinh, System.Data.SqlDbType.Bit)
                .BindParam("@cmnd", kh.Cmnd)
                .BindParam("@sdt", kh.Sdt)
                .BindParam("@ngaysinh", kh.Ngaysinh, System.Data.SqlDbType.Date)
                .BindParam("@Diem", kh.Diem)
                .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTOKhachHang kh)
        {
            return new DAOSql()
               .Procedure("SuaKhachHang")
               .BindParam("@ma", kh.Ma)
               .BindParam("@ten", kh.Ten)
               .BindParam("@diachi", kh.Diachi)
               .BindParam("@gioitinh", kh.Giotinh, System.Data.SqlDbType.Bit)
               .BindParam("@cmnd", kh.Cmnd)
               .BindParam("@sdt", kh.Sdt)
               .BindParam("@ngaysinh", kh.Ngaysinh, System.Data.SqlDbType.Date)
               .BindParam("@Diem", kh.Diem)
               .ExecuteNonQuery() > 0;
        }


        public bool Xoa(DTO.DTOKhachHang khachhang)
        {
            return new DAOSql()
                        .Procedure("XoaKhachHang")
                        .BindParam("@ma", khachhang.Ma)
                        .ExecuteNonQuery() > 0;
        }


        private List<DTO.DTOKhachHang> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOKhachHang> danhsach = new List<DTO.DTOKhachHang>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOKhachHang nhanvien = new DTO.DTOKhachHang();
                nhanvien.Ma = (int)reader["makh"];
                nhanvien.Ten = (string)reader["tenkh"];
                nhanvien.Diachi = (string)reader["diachi"];
                nhanvien.Giotinh = (bool)reader["gioitinh"];
                nhanvien.Cmnd = (string)reader["cmnd"];
                nhanvien.Ngaysinh = (DateTime)reader["ngaysinh"];
                nhanvien.Diem = (int)reader["diem"];
                nhanvien.Sdt = (string)reader["sdt"];

                danhsach.Add(nhanvien);
            }

            return danhsach;
        }


        public List<DTO.DTOKhachHang> layKhachHangQuaCMND(string cmnd)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from khachhang where cmnd = @cmnd and xoa = 0")
                        .BindParam("@cmnd", cmnd)
                        .ExecuteReader());
        }


        public List<DTO.DTOKhachHang> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from khachhang where xoa = 0")
                        .ExecuteReader());
        }



        //public DTO.DTONhanVien LayVoiMa(int ma)
        //{
        //    List<DTO.DTONhanVien> ds =
        //        TachDTO(
        //            new DAOSql()
        //                .Query("Select * from nhanvien where manv = @ma")
        //                .BindParam("@ma", ma)
        //                .ExecuteReader());
        //    return ds.Count == 0 ? null : ds[0];
        //}




        public List<DTO.DTOKhachHang> TimKH_GioiTinh(bool gioitinh)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from khachhang where gioitinh = @gioitinh and xoa = 0")
                        .BindParam("@gioitinh", gioitinh)
                        .ExecuteReader());
        }


        public List<DTO.DTOKhachHang> TimKH_Ten(string tennv)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from khachhang where tenkh like @ten and xoa = 0")
                        .BindParam("@ten", "%" + tennv + "%")
                        .ExecuteReader());
        }

        public List<DTO.DTOKhachHang> TimKH_SDT(string sdt)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from khachhang where SDT like @sdt and xoa = 0")
                        .BindParam("@sdt", sdt + '%')
                        .ExecuteReader());
        }

        public List<DTO.DTOKhachHang> TimKH_CMND(string cmnd)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from khachhang where CMND like @cmnd and xoa = 0")
                        .BindParam("@cmnd", cmnd + '%')
                        .ExecuteReader());
        }

    }
}
