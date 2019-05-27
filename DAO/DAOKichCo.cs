using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoKichCo
    {

        private List<DTO.DTOKichCo> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOKichCo> danhsach = new List<DTO.DTOKichCo>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOKichCo kichco = new DTO.DTOKichCo();
                kichco.Ma = (int)reader["makc"];
                kichco.Ten = (string)reader["tenkc"];
                danhsach.Add(kichco);
            }

            return danhsach;
        }


        public bool Them(DTO.DTOKichCo kichco)
        {
            return new DAO.DAOSql()
                        .Procedure("ThemKichCo")
                        .BindParam("@ten", kichco.Ten)
                        .ExecuteNonQuery() > 0;
        }

        public bool Xoa(DTO.DTOKichCo kichco)
        {
            return new DAO.DAOSql()
                        .Procedure("XoaKichCo")
                        .BindParam("@ma", kichco.Ma)
                        .ExecuteNonQuery() > 0;
        }


        public bool Sua(DTO.DTOKichCo kichco)
        {
            return new DAO.DAOSql()
                        .Procedure("SuaMau")
                        .BindParam("@ma", kichco.Ma)
                        .BindParam("@ten", kichco.Ten)
                        .ExecuteNonQuery() > 0;
        }


        public List<DTO.DTOKichCo> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from kichcosp where xoa=0")
                        .ExecuteReader());
        }


        public List<DTO.DTOKichCo> layQuaTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from kichcosp where tenkc = @ten and xoa=0")
                        .BindParam("@ten", ten)
                        .ExecuteReader());
        }


        public List<DTO.DTOKichCo> timKiemTen(string ten)
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from kichcosp where tenkc like @ten and xoa=0")
                        .BindParam("@ten", "%"+ten+"%")
                        .ExecuteReader());
        }

    }
}
