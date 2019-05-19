using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    class DAO_sanpham:DAOSql
    {
        public DataTable laySanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham,", YuhGetDBConnection());
            DataTable dtsp = new DataTable();
            da.Fill(dtsp);
            return dtsp;

        }
        public bool themSanPham()
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
        public bool suaSanPham()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update SanPham set ()");
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
        public bool xoaSanPham(int masp)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from SanPham where MaSP= {0}", masp);
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
