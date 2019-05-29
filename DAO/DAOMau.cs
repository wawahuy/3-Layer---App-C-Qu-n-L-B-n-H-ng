using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOMau
    {

        private List<DTO.DTOMau> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOMau> danhsach = new List<DTO.DTOMau>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOMau mau = new DTO.DTOMau();
                mau.Ma = (int)reader["mamau"];
                mau.Ten = (string)reader["tenmau"];
                danhsach.Add(mau);
            }

            return danhsach;
        }


        public bool Them(DTO.DTOMau mau)
        {
            return new DAO.DAOSql()
                        .Procedure("ThemMau")
                        .BindParam("@ten", mau.Ten)
                        .ExecuteNonQuery() > 0;
        }

        public bool Xoa(DTO.DTOMau mau)
        {
            return new DAO.DAOSql()
                        .Procedure("XoaMau")
                        .BindParam("@ma", mau.Ma)
                        .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTOMau mau)
        {
            return new DAO.DAOSql()
                        .Procedure("SuaMau")
                        .BindParam("@ma", mau.Ma)
                        .BindParam("@ten", mau.Ten)
                        .ExecuteNonQuery() > 0;
        }


        public List<DTO.DTOMau> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from mausp where xoa=0")
                        .ExecuteReader());
        }


        public List<DTO.DTOMau> layQuaTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from mausp where tenmau = @ten and xoa=0")
                        .BindParam("@ten", ten)
                        .ExecuteReader());
        }

        public List<DTO.DTOMau> layQuaMaKRB(int ma)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from mausp where mamau = @ma")
                        .BindParam("@ma", ma)
                        .ExecuteReader());
        }


        public List<DTO.DTOMau> timKiemTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from mausp where tenmau like @ten and xoa=0")
                        .BindParam("@ten", "%"+ten+"%")
                        .ExecuteReader());
        }

    }
}
