using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOChucVu
    {

        private List<DTO.DTOChucVu> TachDTO(SqlDataReader reader)
        {
            List<DTO.DTOChucVu> danhsach = new List<DTO.DTOChucVu>();
            //DataTable dt;

            while (reader.Read())
            {
                DTO.DTOChucVu chucvu = new DTO.DTOChucVu();
                chucvu.Machucvu = (int)reader["macv"];
                chucvu.Tenchucvu = (string)reader["tencv"];
                danhsach.Add(chucvu);
            }

            return danhsach;
        }



        public DTO.DTOChucVu LayChucVuQuaTen(string tenChucVu)
        {
            List<DTO.DTOChucVu> ds =
                TachDTO(
                    new DAOSql()
                        .Query("Select * from chucvu where TenCV = @ten")
                        .BindParam("@ten", tenChucVu)
                        .ExecuteReader());

            return ds.Count == 0 ? null : ds[0];
        }

        public DTO.DTOChucVu LayChucVuQuaID(int ma)
        {
            List<DTO.DTOChucVu> ds =
                TachDTO(
                    new DAOSql()
                        .Query("Select * from chucvu where macv = @ma")
                        .BindParam("@ma", ma)
                        .ExecuteReader());

            return ds.Count == 0 ? null : ds[0];
        }


        public List<DTO.DTOChucVu> Lay()
        {
            return TachDTO(
                    new DAOSql()
                        .Query("Select * from chucvu")
                        .ExecuteReader());
        }

    }
}
