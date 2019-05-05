using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSSql
    {
        private DAO.DAOSql sql;

        public BUSSql()
        {
            sql = new DAO.DAOSql();
        }

        public void LoadDeltailSqlGlobal()
        {
            sql.ReadDeltailFileXML();
            sql.SetDeltailGlobal();
        }

        public List<String> GetListDatabaseNameLocal()
        {
            return DAO.DAOSql.YuhGetListLocalDB();
        }

        public DTO.DTOSql GetSqlDeltail()
        {
            return DAO.DAOSql.YuhSqlDeltail;
        }

        public void Config(DTO.DTOSql deltail, Shared.SInvokeEvent callback)
        {
            new Shared.SSequence()
                .Then(() =>
                {
                    DAO.DAOSql sql = new DAO.DAOSql(deltail);
                    callback.Wait(null);
                    if (sql.IsActive())
                    {
                        callback.Success(null);
                        sql.SetDeltailGlobal();
                        sql.SaveDeltailFileXML();
                    }
                    else
                        callback.Error(null);
                })
                .Start();
        }

    }
}
