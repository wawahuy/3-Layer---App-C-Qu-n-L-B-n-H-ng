using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    class DAO_sanpham:DAOSql
    {
        public DataTable laySanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham,", YuhGetDBConnection());
            DataTable dtsp = new DataTable();
            da.Fill(dtsp);
            return dtsp;

        }
        public bool themSanPham()
        {
            try
            {
                YuhGetDBConnection();
             
                SqlCommand cmd = new SqlCommand("Themsanpham", YuhGetDBConnection());
                cmd.CommandType = CommandType.StoredProcedure;

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
        public bool suaSanPham()
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand("Suasanpham", YuhGetDBConnection());
                cmd.CommandType = CommandType.StoredProcedure;

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
        public bool xoaSanPham( )
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand("Xoasanpham", YuhGetDBConnection());
                cmd.CommandType = CommandType.StoredProcedure;

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
