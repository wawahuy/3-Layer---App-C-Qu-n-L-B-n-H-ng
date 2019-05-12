using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            //Application.Run(new FGuest());
            Application.Run(new FDashboard());
=======
            FormGuest = new FGuest();
            Application.Run(FormGuest);

            ///Application.Run(new FDashboard());
>>>>>>> Stashed changes

        }
    }
}
