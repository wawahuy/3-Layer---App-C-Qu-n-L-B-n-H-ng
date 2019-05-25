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
    class DAO_quyenht:DAOSql
    {
        public DataTable layquyenht()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from QuyenHeThong,", YuhGetDBConnection());
            DataTable dtKH = new DataTable();
            da.Fill(dtKH);
            return dtKH;

        }
        public bool themquyenht()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("insert into  ");
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
        public bool suaquyenht()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update  ");
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
        public bool xoaquyenht(int maquyen)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from  ", maquyen);
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
