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
    class DAO_chucvu:DAOSql
    {
        public bool themchucvu()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("ThemChucVu", YuhGetDBConnection());
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
        public bool suachucvu()
        {
            try
            {
                YuhGetDBConnection();
                 
                SqlCommand cmd = new SqlCommand("SuaChucVu", YuhGetDBConnection());
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
        public bool xoachucvu(int macv)
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
