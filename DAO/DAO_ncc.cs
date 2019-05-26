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
    class DAO_ncc:DAOSql
    {
        public DataTable layNcc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap ,", YuhGetDBConnection());
            DataTable dtncc = new DataTable();
            da.Fill(dtncc);
            return dtncc;

        }
        public bool themncc()
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand("ThemNCC", YuhGetDBConnection());
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
        public bool suancc()
        {
            try
            {
                YuhGetDBConnection();
  
                SqlCommand cmd = new SqlCommand("SuaNCC", YuhGetDBConnection());
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
        public bool xoancc( )
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand("", YuhGetDBConnection());
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
