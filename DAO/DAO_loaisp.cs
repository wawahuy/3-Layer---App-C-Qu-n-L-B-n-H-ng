using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class DAO_loaisp:DAOSql
    {
        public DataTable layloaisp()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from LoaiSanPham,", YuhGetDBConnection());
            DataTable dtlsp = new DataTable();
            da.Fill(dtlsp);
            return dtlsp;

        }
        public bool themlsp()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("insert into LoaiSanPham values( )");
                SqlCommand cmd = new SqlCommand(query, YuhGetDBConnection());


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                YuhGetDBConnection().Close();
            }
            return false;
        }
        public bool sualsp()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update  LoaiSanPham set ()");
                SqlCommand cmd = new SqlCommand(query, YuhGetDBConnection());


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                YuhGetDBConnection().Close();
            }
            return false;
        }
        public bool xoalsp(int malsp)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from  LoaiSanPham where  ", malsp);
                SqlCommand cmd = new SqlCommand(query, YuhGetDBConnection());


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                YuhGetDBConnection().Close();
            }
            return false;
        }
    }
}
