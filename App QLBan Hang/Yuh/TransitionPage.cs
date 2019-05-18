using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;

namespace App_QLBan_Hang.Yuh
{
    public partial class TransitionPage : Component
    {
        public TransitionPage()
        {
            InitializeComponent();
        }

        public TransitionPage(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private Panel panel_main;
        private BunifuAnimatorNS.AnimationType anim_type;
        private int yuh_interval;
        private int yuh_timemax;
        private UserControl ucCurrent;

        public Panel Yuh_Panel_main
        {
            get
            {
                return panel_main;
            }

            set
            {
                panel_main = value;
            }
        }

        public AnimationType Yuh_Anim_type
        {
            get
            {
                anim_type = bunifuTransition.AnimationType;
                return anim_type;
            }

            set
            {
                anim_type = value;
                this.bunifuTransition.AnimationType = value;
            }
        }

        public int Yuh_interval
        {
            get
            {
                yuh_interval = bunifuTransition.Interval;
                return yuh_interval;
            }

            set
            {
                bunifuTransition.Interval = yuh_interval = value;
            }
        }

        public int Yuh_timemax
        {
            get
            {
                yuh_timemax = bunifuTransition.MaxAnimationTime;
                return yuh_timemax;
            }

            set
            {
                bunifuTransition.MaxAnimationTime = yuh_timemax = value;
            }
        }

        public void openGUI(UserControl uc)
        {
            if (ucCurrent != null)
            {
                panel_main.Controls.Remove(ucCurrent);
            }

            ucCurrent = uc;

            if (ucCurrent == null) return;
            uc.Visible = false;
            bunifuTransition.Show(uc);

            ucCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            ucCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            ucCurrent.Location = new System.Drawing.Point(0, 0);
            ucCurrent.Name = "ContentMain";
            //ucCurrent.Size = new System.Drawing.Size(631, 502);
            ucCurrent.TabIndex = 0;
            panel_main.Controls.Add(ucCurrent);
        }


        public void openGUINoAnimation(UserControl uc)
        {
            if (ucCurrent != null)
            {
                panel_main.Controls.Remove(ucCurrent);
            }

            ucCurrent = uc;

            if (ucCurrent == null) return;
            uc.Visible = true;

            ucCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            ucCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            ucCurrent.Location = new System.Drawing.Point(0, 0);
            ucCurrent.Name = "ContentMain";
            //ucCurrent.Size = new System.Drawing.Size(631, 502);
            ucCurrent.TabIndex = 0;
            panel_main.Controls.Add(ucCurrent);
        }
    }
}
