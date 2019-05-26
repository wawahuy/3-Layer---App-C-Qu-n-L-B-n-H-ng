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
    class DAO_kcsp:DAOSql
    {
        public DataTable laykcsp()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KichCoSP,", YuhGetDBConnection());
            DataTable dtkcsp = new DataTable();
            da.Fill(dtkcsp);
            return dtkcsp;

        }
        public bool themkcsp()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("ThemKichCoSP", YuhGetDBConnection());
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
        public bool suakcsp()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("SuaKichCoSP", YuhGetDBConnection());
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
        public bool xoakcsp( )
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
