using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang
{
    static class Program
    {
        static DTO.DTONhanVien loginCurrent;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Init 
            BUS.BUSSql busSql = new BUS.BUSSql();
            busSql.LoadDeltailSqlGlobal();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormGuest = new FGuest();
            Application.Run(FormGuest);

            Application.Run(new FDashboard());

        }


        public static Form FormGuest;
    }
}
