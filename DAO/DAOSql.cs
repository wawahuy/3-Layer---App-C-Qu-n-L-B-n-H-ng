using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.IO;
using System.Xml;

namespace DAO
{
    public class DAOSql
    {

        /// <summary>
        /// Thông tin SQL
        /// </summary>
        private static DTO.DTOSql YuhsqlDeltail = new DTO.DTOSql();
        public  static DTO.DTOSql YuhSqlDeltail
        {
            get { return YuhsqlDeltail; }
        }


        /// <summary>
        /// Các phương thức tỉnh kết nối chung
        /// </summary>
        public static string YuhGetStrDBConnection(DTO.DTOSql sqld)
        {
            if (sqld.AuthWin)
                return YuhGetStrDBConnection(sqld.Server, sqld.DB);
            else
                return YuhGetStrDBConnection(sqld.Server, sqld.DB, sqld.User, sqld.Pass);
        }

        public static string YuhGetStrDBConnection(string srv, string db)
        {
            return "Data Source = tcp:" + srv + "; Initial Catalog = " + db + "; Integrated Security = True";
        }

        public static string YuhGetStrDBConnection(string srv, string db, string user, string pass)
        {
            return String.Format("Data Source = tcp:{0}; Initial Catalog = {1}; Integrated Security = False; User ID = {2}; Password = {3}",
                    srv,
                    db,
                    user,
                    pass);
        }

        public static SqlConnection YuhGetDBConnection()
        {
            return YuhGetServerConnection(YuhGetStrDBConnection(YuhsqlDeltail));
        }

        public static SqlConnection YuhGetDBConnection(string strconnect)
        {
            try
            {
                SqlConnection sql = new SqlConnection(strconnect);
                sql.Open();
                return sql;
            }
            catch
            {
                return null;
            }
        }

        public static SqlConnection YuhGetServerConnection(string server)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Data Source=" + server+"; Integrated Security = True");
                sql.Open();
                return sql;
            }
            catch
            {
                return null;
            }
        }

        public static List<string>  YuhGetListLocalDB()
        {
            List<string> l = new List<string>();
            using (SqlConnection serverConnect = YuhGetServerConnection("localhost"))
            {
                DataTable databases = serverConnect.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    l.Add(database.Field<String>("database_name"));
                }
                serverConnect.Close();
            }
            return l;
        }

        public static Object GetClassPropertyDBValue<T>(string pro, T obj)
        {
            if (obj == null) return DBNull.Value;
            return typeof(T).GetProperty(pro).GetValue(obj);
        }

        /// <summary>
        /// Class SQL
        /// </summary>
        private DTOSql m_sqlDelt;
        public  DTOSql SqlDelt
        {
            get
            {
                return m_sqlDelt;
            }

            set
            {
                m_sqlDelt = value;
            }
        }

        public DAOSql(DTO.DTOSql sqlDeltail)
        {
            m_sqlDelt = sqlDeltail;
        }

        public DAOSql()
        {
            m_sqlDelt = YuhSqlDeltail;
        }

        public bool IsActive()
        {
            using(SqlConnection sql = GetConnection())
            {
                if (sql == null)
                    return false;
                else
                    return true;
            }
        }

        public SqlConnection GetConnection()
        {
            return YuhGetDBConnection(YuhGetStrDBConnection(m_sqlDelt));
        }

        public bool SaveDeltailFileXML()
        {
            return SaveDeltailFileXML(Final.PATH_FILE_CONFIG_SQL);
        }

        public bool SaveDeltailFileXML(string path)
        {
            if (File.Exists(path)) File.Delete(path);

            using (FileStream fs = File.Create(path))
            {
            }

            XmlTextWriter textWriter = new XmlTextWriter(path, null);
            textWriter.WriteStartDocument();

            textWriter.WriteStartElement("SqlConfig");

            textWriter.WriteStartElement("Server", "");
            textWriter.WriteString(m_sqlDelt.Server);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Db", "");
            textWriter.WriteString(m_sqlDelt.DB);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("WindowsAuth", "");
            textWriter.WriteString(m_sqlDelt.AuthWin.ToString());
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("User", "");
            textWriter.WriteString(m_sqlDelt.User);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Pass", "");
            textWriter.WriteString(m_sqlDelt.Pass);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();

            return true;
        }

        public bool ReadDeltailFileXML()
        {
            return ReadDeltailFileXML(Final.PATH_FILE_CONFIG_SQL);
        }

        public bool ReadDeltailFileXML(string path)
        {
            if (File.Exists(path))
                try
                {
                    using (XmlTextReader textReader = new XmlTextReader(path))
                    {
                        while (textReader.Read())
                        {
                            if (textReader.IsStartElement())
                            {
                                switch (textReader.Name)
                                {
                                    case "Server":
                                        m_sqlDelt.Server = textReader.ReadString();
                                        break;
                                    case "Db":
                                        m_sqlDelt.DB = textReader.ReadString();
                                        break;
                                    case "WindowsAuth":
                                        m_sqlDelt.AuthWin = textReader.ReadString() == "True" ? true : false;
                                        break;
                                    case "User":
                                        m_sqlDelt.User = textReader.ReadString();
                                        break;
                                    case "Pass":
                                        m_sqlDelt.Pass = textReader.ReadString();
                                        break;
                                }
                            }
                        }
                    }
                    return true;
                }
                catch
                {
                }
           return false;
        }

        public void SetDeltailGlobal()
        {
            YuhsqlDeltail = m_sqlDelt;
        }

        public static bool ContainsColumn(IDataReader dataReader, string columnName)
        {
            /// See: http://stackoverflow.com/questions/373230/check-for-column-name-in-a-sqldatareader-object/7248381#7248381
            try
            {
                return dataReader.GetOrdinal(columnName) >= 0;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// Query
        /// </summary>
        private SqlConnection m_connection;
        private SqlCommand    m_command;

        public DAOSql Query(string query)
        {
            m_connection = GetConnection();
            m_command = new SqlCommand(query, m_connection);
            return this;
        }

        public DAOSql Procedure(string query)
        {
            m_connection = GetConnection();
            m_command = new SqlCommand();
            m_command.CommandType = CommandType.StoredProcedure;
            m_command.CommandText = query;
            m_command.Connection = m_connection;
            return this;
        }

        public DAOSql BindRageParams(SqlParameter[] parms)
        {
            m_command.Parameters.AddRange(parms);
            return this;
        }

        public DAOSql BindParam(string name, Object value, SqlDbType type)
        {
            SqlParameter param = new SqlParameter(name, value);
            param.SqlDbType = type;
            m_command.Parameters.Add(param);
            return this;
        }

        public DAOSql BindParam(string name, Object value)
        {
            m_command.Parameters.AddWithValue(name, value);
            return this;
        }

        public SqlDataReader ExecuteReader()
        {
            SqlDataReader data = m_command.ExecuteReader();
            //m_connection.Close();
            return data;
        }

        public int ExecuteNonQuery()
        {
            int data = m_command.ExecuteNonQuery();
            m_connection.Close();
            return data;
        }

        public Object ExecuteScalar()
        {
            object data = m_command.ExecuteScalar();
            //m_connection.Close();
            return data;
        }
    }
}
