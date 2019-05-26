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
    class DAO_phieunhap:DAOSql
    {
        public DataTable layphieunhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PhieuNhap,", YuhGetDBConnection());
            DataTable dtpn = new DataTable();
            da.Fill(dtpn);
            return dtpn;

        }
        public bool themphieunhap()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("ThemPhieuNhap", YuhGetDBConnection());
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
        public bool suaKphieunhap()
        {
            try
            {
                YuhGetDBConnection();
 
                SqlCommand cmd = new SqlCommand("SuaPhieuNhap", YuhGetDBConnection());
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
        public bool xoaphieunhap(int mapn)
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
