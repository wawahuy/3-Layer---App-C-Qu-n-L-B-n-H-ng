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
                string query = string.Format("insert into MauSP values( )");
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
        public bool suamausp()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update MauSP set ()");
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
        public bool xoamausp(int mamau)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from MauSP where  ", mamau);
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
