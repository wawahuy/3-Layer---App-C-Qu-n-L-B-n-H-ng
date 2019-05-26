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
                 
                SqlCommand cmd = new SqlCommand("ThemCTPhieuNhap", YuhGetDBConnection());
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
        public bool suactphieunhap()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("SuaCTPhieuNhap", YuhGetDBConnection());
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
        public bool xoactphieunhap(int mapn)
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
