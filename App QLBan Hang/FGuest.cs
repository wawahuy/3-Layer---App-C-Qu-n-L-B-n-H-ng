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
    public partial class FGuest : FTemplate
    {
        private UCGuest.GTLogin     ucLogin;
        private UCGuest.GTConfig    ucConfig;
        private UserControl         ucCurrent;
        private BUS.BUSSql          busSql;

        public FGuest()
        {
            InitializeComponent();

            //Init Usercontrol
            ucLogin = new UCGuest.GTLogin();
            ucConfig = new UCGuest.GTConfig();

            //Register callback when click items
            uc_menu.YuhItems[0].YuhSelect += new EventHandler(openLogin);
            uc_menu.YuhItems[1].YuhSelect += new EventHandler(openConfigSql);
            uc_menu.YuhItems[2].YuhSelect += new EventHandler(openSupport);
            uc_menu.ReferActionClicked();

            //Load SqlDeltail
            busSql = new BUS.BUSSql();
            busSql.LoadDeltailSqlGlobal();

            //Save last guest
            m_guestLast = this;
        }

        private void openSupport(object sender, EventArgs e)
        {
            openGUI(null);
        }

        private void openConfigSql(object sender, EventArgs e)
        {
            openGUI(ucConfig);
        }

        public void openLogin(Object obj, EventArgs args)
        {
            openGUI(ucLogin);
        }


        private void openGUI(UserControl uc)
        {
            if (ucCurrent != null)
            {
                panel_main.Controls.Remove(ucCurrent);
            }

            ucCurrent = uc;
            
            if (ucCurrent == null) return;
            uc.Visible = false;
            transistionPage.Show(uc);

            ucCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            ucCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            ucCurrent.Location = new System.Drawing.Point(0, 0);
            ucCurrent.Name = "ContentMain";
            ucCurrent.Size = new System.Drawing.Size(631, 502);
            ucCurrent.TabIndex = 0;
            panel_main.Controls.Add(ucCurrent);
        }


        private static FGuest m_guestLast;
        public static void showWaiting(bool isShow)
        {
            if(!isShow)
                m_guestLast.transistion.Hide(m_guestLast.ucWaiting);
            else
                m_guestLast.transistion.Show(m_guestLast.ucWaiting);
        }

        private void Uc_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
