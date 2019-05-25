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
                string query = string.Format("insert into KichCoSP values( )");
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
        public bool suakcsp()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update KichCoSP set ()");
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
        public bool xoakcsp(int makc)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from KichCoSP where  ", makc);
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
