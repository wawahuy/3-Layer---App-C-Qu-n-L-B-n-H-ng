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
                string query = string.Format("insert into KhachHang values(@tenkh, @diachi, @gioitinh, @cmnd, @ngaysinh, @diem)");
                SqlCommand cmd = new SqlCommand(query, YuhGetDBConnection());
                

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
                string query = string.Format("update KhachHang set (@tenkh, @diachi, @gioitinh, @cmnd, @ngaysinh, @diem)");
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
        public bool xoaKhachHang(int makh)
        {
            try
            {
                YuhGetDBConnection();
                string query = string.Format("delete from KhachHang where MaKH= {0}",makh );
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
