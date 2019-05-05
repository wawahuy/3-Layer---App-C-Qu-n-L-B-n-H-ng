using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Final
    {
        //Config
        public const string SERVER  = "localhost";
        public const string DB      = "QLCUAHANG";
        public const bool   AUTHWIN = true;
        public const string PASS    = "";
        public const string USER    = "";

        //File
        public static string PATH_FILE_CONFIG_SQL = Environment.CurrentDirectory + @"\ConfigSQL.xml";


        //Alert
        public const string ERROR_CONNECT_SQL = "Không thể kết nối đến CSDL!";
    }
}
