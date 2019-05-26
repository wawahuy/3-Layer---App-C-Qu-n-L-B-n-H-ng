using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    class DAO_quyenht:DAOSql
    {
        public DataTable layquyenht()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from QuyenHeThong,", YuhGetDBConnection());
            DataTable dtqht = new DataTable();
            da.Fill(dtqht);
            return dtqht;

        }
        public bool themquyenht()
        {
            try
            {
                YuhGetDBConnection();
                SqlCommand cmd = new SqlCommand("Themquyenht", YuhGetDBConnection());
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
        public bool suaquyenht()
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand("Suaquyenht", YuhGetDBConnection());
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
        public bool xoaquyenht( )
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand( "", YuhGetDBConnection());
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
