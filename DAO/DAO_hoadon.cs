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
    class DAO_hoadon:DAOSql
    {
        public DataTable layhoadon()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon,", YuhGetDBConnection());
            DataTable dthd = new DataTable();
            da.Fill(dthd);
            return dthd;

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
                string query = string.Format("update HoaDon set ()");
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
        public bool xoaSanPham(int mahd)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from Hoadon where MaSP= {0}", mahd);
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
