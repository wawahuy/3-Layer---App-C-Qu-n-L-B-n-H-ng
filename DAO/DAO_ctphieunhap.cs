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
    class DAO_ctphieunhap:DAOSql
    {
        public DataTable layctphieunhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTPhieuNhap,", YuhGetDBConnection());
            DataTable dtctpn = new DataTable();
            da.Fill(dtctpn);
            return dtctpn;

        }
        public bool themctphieunhap()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("insert into CTPhieuNhap values( )");
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
        public bool suactphieunhap()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update CTPhieuNhap set ()");
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
        public bool xoactphieunhap(int mapn)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from CTPhieuNhap where  ", mapn);
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
