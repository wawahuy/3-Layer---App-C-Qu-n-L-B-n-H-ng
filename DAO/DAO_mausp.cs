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
    class DAO_mausp:DAOSql
    {
        public DataTable laymausp()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from MauSP,", YuhGetDBConnection());
            DataTable dtmausp = new DataTable();
            da.Fill(dtmausp);
            return dtmausp;

        }
        public bool themmausp()
        {
            try
            {
                YuhGetDBConnection();
                SqlCommand cmd = new SqlCommand("ThemMauSP", YuhGetDBConnection());
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
        public bool suamausp()
        {
            try
            {
                YuhGetDBConnection();
                SqlCommand cmd = new SqlCommand("SuaMauSP", YuhGetDBConnection());
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
        public bool xoamausp( )
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
