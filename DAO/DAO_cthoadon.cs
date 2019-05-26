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
    class DAO_cthoadon:DAOSql
    {
        public DataTable layCThoadon()
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CTHoaDon,", YuhGetDBConnection());
                DataTable dtcthd = new DataTable();
                da.Fill(dtcthd);
                return dtcthd;

            }
        public bool themCThoadon()
            {
                try
                {
                    YuhGetDBConnection();

                    SqlCommand cmd = new SqlCommand("Themcthd", YuhGetDBConnection());
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
            public bool suaCThoadon()
            {
                try
                {
                    YuhGetDBConnection();

                    SqlCommand cmd = new SqlCommand("Suacthd", YuhGetDBConnection());
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
            public bool xoaCThoadon()
            {
                try
                {
                    YuhGetDBConnection();

                    SqlCommand cmd = new SqlCommand(" ", YuhGetDBConnection());
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
