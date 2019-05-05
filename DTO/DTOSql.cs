using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSql
    {
        private string server = Final.SERVER;
        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private string db = Final.DB;
        public string DB
        {
            get { return db; }
            set { db = value; }
        }

        private bool authWin = Final.AUTHWIN;
        public bool AuthWin
        {
            get
            {
                return authWin;
            }

            set
            {
                authWin = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        private string user = Final.USER;
        private string pass = Final.PASS;
    }
}
