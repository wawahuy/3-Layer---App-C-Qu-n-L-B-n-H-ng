using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    class DAO_khachhang:DAOSql
    {

        public DataTable layKhachhang()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang,", YuhGetDBConnection());
            DataTable dtKH = new DataTable();
            da.Fill(dtKH);
            return dtKH;

        }
        public bool themKhachHang()
        {
            try
            {
                YuhGetDBConnection();
                
                SqlCommand cmd = new SqlCommand("ThemKhachHang", YuhGetDBConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception )
            {

            }
            finally
            {
                YuhGetDBConnection().Close();
            }
            return false;
        }
        public bool suaKhachHang()
        {
            try
            {
                YuhGetDBConnection();
                
                SqlCommand cmd = new SqlCommand("SuaKhachHang", YuhGetDBConnection());
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
        public bool xoaKhachHang( )
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
