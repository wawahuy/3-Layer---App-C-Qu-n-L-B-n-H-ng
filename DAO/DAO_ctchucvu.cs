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
    class DAO_ctchucvu:DAOSql
    {
        public DataTable loadctchucvu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTQuyenChucVu,", YuhGetDBConnection());
            DataTable dtctchucvu = new DataTable();
            da.Fill(dtctchucvu);
            return dtctchucvu;

        }
        public bool themctchucvu()
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
        public bool suactchucvu()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update  set ()");
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
        public bool xoactchucvu(int macv)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from CTQuyenChucVu where ", macv);
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
