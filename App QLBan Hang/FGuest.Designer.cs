namespace App_QLBan_Hang
{
    partial class FGuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem menuItem1 = new App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem();
            App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem menuItem2 = new App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem();
            App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem menuItem3 = new App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGuest));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.uc_menu = new App_QLBan_Hang.YuhUserControl.UC_MenuOne();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.ucWaiting = new App_QLBan_Hang.UC_Waiting();
            this.transistion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionPage = new App_QLBan_Hang.Yuh.TransitionPage(this.components);
            this.panel_menu.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.panel_menu.Controls.Add(this.uc_menu);
            this.panel_menu.Controls.Add(this.panel3);
            this.transistion.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(1, 34);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(158, 510);
            this.panel_menu.TabIndex = 1;
            // 
            // uc_menu
            // 
            this.uc_menu.BackColor = System.Drawing.Color.Transparent;
            this.transistion.SetDecoration(this.uc_menu, BunifuAnimatorNS.DecorationType.None);
            this.uc_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_menu.Location = new System.Drawing.Point(0, 144);
            this.uc_menu.Name = "uc_menu";
            this.uc_menu.Size = new System.Drawing.Size(158, 366);
            this.uc_menu.TabIndex = 1;
            this.uc_menu.YuhAlignText = System.Drawing.ContentAlignment.MiddleLeft;
            this.uc_menu.YuhBackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.uc_menu.YuhBackColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.uc_menu.YuhBackColorIdel = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.uc_menu.YuhFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            menuItem1.Icon = global::App_QLBan_Hang.Properties.Resources.icons8_password_32;
            menuItem1.IconMarginLeft = 10;
            menuItem1.IconMarginRight = 0;
            menuItem1.IconVisible = true;
            menuItem1.IconZoom = 50D;
            menuItem1.Name = "uc_menu_login";
            menuItem1.Text = "Đăng nhập";
            menuItem2.Icon = global::App_QLBan_Hang.Properties.Resources.icons8_services_32;
            menuItem2.IconMarginLeft = 0;
            menuItem2.IconMarginRight = 0;
            menuItem2.IconVisible = true;
            menuItem2.IconZoom = 50D;
            menuItem2.Name = "uc_menu_config";
            menuItem2.Text = "Cấu hình CSDL";
            menuItem3.Icon = global::App_QLBan_Hang.Properties.Resources.icons8_help_32;
            menuItem3.IconMarginLeft = 0;
            menuItem3.IconMarginRight = 0;
            menuItem3.IconVisible = true;
            menuItem3.IconZoom = 50D;
            menuItem3.Name = "uc_menu_help";
            menuItem3.Text = "Trợ giúp";
            this.uc_menu.YuhItems = new App_QLBan_Hang.YuhUserControl.UC_MenuOne.MenuItem[] {
        menuItem1,
        menuItem2,
        menuItem3};
            this.uc_menu.YuhSelectedItem = 0;
            this.uc_menu.YuhTextColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.uc_menu.YuhTextColorIdel = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.panel3.BackgroundImage = global::App_QLBan_Hang.Properties.Resources.icons8_playstore_100;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.transistion.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 144);
            this.panel3.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_main.Controls.Add(this.ucWaiting);
            this.transistion.SetDecoration(this.panel_main, BunifuAnimatorNS.DecorationType.None);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(159, 34);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(629, 510);
            this.panel_main.TabIndex = 2;
            // 
            // ucWaiting
            // 
            this.ucWaiting.BackColor = System.Drawing.Color.White;
            this.transistion.SetDecoration(this.ucWaiting, BunifuAnimatorNS.DecorationType.None);
            this.ucWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWaiting.Location = new System.Drawing.Point(0, 0);
            this.ucWaiting.Name = "ucWaiting";
            this.ucWaiting.ProcessColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.ucWaiting.Size = new System.Drawing.Size(629, 510);
            this.ucWaiting.TabIndex = 0;
            this.ucWaiting.TextDeltail = "Xin chờ...";
            this.ucWaiting.Visible = false;
            // 
            // transistion
            // 
            this.transistion.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transistion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transistion.DefaultAnimation = animation1;
            this.transistion.MaxAnimationTime = 400;
            this.transistion.TimeStep = 0.01F;
            // 
            // transitionPage
            // 
            this.transitionPage.Yuh_Anim_type = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transitionPage.Yuh_interval = 10;
            this.transitionPage.Yuh_Panel_main = this.panel_main;
            this.transitionPage.Yuh_timemax = 1000;
            // 
            // FGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 545);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu);
            this.transistion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "FGuest";
            this.Text = "Quản lý bán hàng";
            this.YuhControlParent = this.panel_menu;
            this.YuhIcon = global::App_QLBan_Hang.Properties.Resources.icons8_small_business_161;
            this.YuhIconVisible = true;
            this.YuhMaximizedVisible = false;
            this.YuhMinimizedVisible = true;
            this.YuhText = "Quản lý bán hàng";
            this.Controls.SetChildIndex(this.panel_menu, 0);
            this.Controls.SetChildIndex(this.panel_main, 0);
            this.panel_menu.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel3;
        private YuhUserControl.UC_MenuOne uc_menu;
        private UC_Waiting ucWaiting;
        private BunifuAnimatorNS.BunifuTransition transistion;
        private Yuh.TransitionPage transitionPage;
    }
}