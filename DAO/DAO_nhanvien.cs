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
    class DAO_nhanvien : DAOSql 
    {
        public DataTable layNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien,", YuhGetDBConnection());
            DataTable dtNV = new DataTable();
            da.Fill(dtNV);
            return dtNV;

        }
        public bool themKhachHang()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("insert into NhanVien values( )");
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
        public bool suaKhachHang()
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("update NhanVien set ()");
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
        public bool xoaKhachHang(int manv)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from NhanVien where MaNV= {0}", manv);
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
