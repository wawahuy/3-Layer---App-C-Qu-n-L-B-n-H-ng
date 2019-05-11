using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang
{
    public partial class FDashboard : FTemplate
    {
        public FDashboard()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            int MIN_PANEL_MENU = 45;
            int MAX_PANEL_MENU = 282;
            int width = panel99.Width == MIN_PANEL_MENU ? MAX_PANEL_MENU : MIN_PANEL_MENU;

            panel99.Visible = false;
            panel99.Width = width;
            bunifuTransition.Show(panel99);

            foreach (Control ct in panel_menu.Controls)
            {
                if (ct is Bunifu.Framework.UI.BunifuFlatButton) {
                    Bunifu.Framework.UI.BunifuFlatButton ob = ((Bunifu.Framework.UI.BunifuFlatButton)ct);
                }
            }
        }

        private void Btn_hoadon_Click(object sender, EventArgs e)
        {

        }
    }
}
