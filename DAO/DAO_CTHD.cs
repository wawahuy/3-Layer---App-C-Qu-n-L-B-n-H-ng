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
    class DAO_CTHD:DAOSql
    {
        public bool themcthd()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("");
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
        public bool suacthd()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update CTHD set ()");
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
        public bool xoacthd(int macthd)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from Hoadon where ", macthd);
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
