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
                string query = string.Format("insert into  NhaCungCap values( )");
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
        public bool suancc()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update  NhaCungCap set ()");
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
        public bool xoancc(int mancc)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from  NhaCungCap where  ", mancc);
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
