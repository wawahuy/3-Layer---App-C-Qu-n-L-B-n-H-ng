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
    class DAO_loaisp:DAOSql
    {
        public DataTable layloaisp()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from LoaiSanPham,", YuhGetDBConnection());
            DataTable dtlsp = new DataTable();
            da.Fill(dtlsp);
            return dtlsp;

        }
        public bool themlsp()
        {
            try
            {
                YuhGetDBConnection();
                
                SqlCommand cmd = new SqlCommand("ThemLoaisp", YuhGetDBConnection());
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
        public bool sualsp()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("SuaLoaisp", YuhGetDBConnection());
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
        public bool xoalsp( )
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
