namespace App_QLBan_Hang.Dashboard
{
    partial class UCNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild uC_MenuTopChild1 = new App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild();
            App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild uC_MenuTopChild2 = new App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild();
            App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild uC_MenuTopChild3 = new App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild();
            App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild uC_MenuTopChild4 = new App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild();
            this.transitionPage = new App_QLBan_Hang.Yuh.TransitionPage(this.components);
            this.uC_MenuTop1 = new App_QLBan_Hang.Yuh.UC_MenuTop();
            this.panel_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // transitionPage
            // 
            this.transitionPage.Yuh_Anim_type = BunifuAnimatorNS.AnimationType.Particles;
            this.transitionPage.Yuh_interval = 1;
            this.transitionPage.Yuh_Panel_main = null;
            this.transitionPage.Yuh_timemax = 1000;
            // 
            // uC_MenuTop1
            // 
            this.uC_MenuTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MenuTop1.Location = new System.Drawing.Point(0, 0);
            this.uC_MenuTop1.Name = "uC_MenuTop1";
            this.uC_MenuTop1.Size = new System.Drawing.Size(916, 76);
            this.uC_MenuTop1.TabIndex = 0;
            this.uC_MenuTop1.Yuhfont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            uC_MenuTopChild1.Coloridel = System.Drawing.Color.Black;
            uC_MenuTopChild1.Colorselected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            uC_MenuTopChild1.Enable = true;
            uC_MenuTopChild1.Text = "Danh sách";
            uC_MenuTopChild2.Coloridel = System.Drawing.Color.Black;
            uC_MenuTopChild2.Colorselected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            uC_MenuTopChild2.Enable = true;
            uC_MenuTopChild2.Text = "Thêm nhân viên";
            uC_MenuTopChild3.Coloridel = System.Drawing.Color.WhiteSmoke;
            uC_MenuTopChild3.Colorselected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            uC_MenuTopChild3.Enable = false;
            uC_MenuTopChild3.Text = "Xem nhân viên";
            uC_MenuTopChild4.Coloridel = System.Drawing.Color.WhiteSmoke;
            uC_MenuTopChild4.Colorselected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            uC_MenuTopChild4.Enable = false;
            uC_MenuTopChild4.Text = "Sửa nhân viên";
            this.uC_MenuTop1.Yuhitems = new App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild[] {
        uC_MenuTopChild1,
        uC_MenuTopChild2,
        uC_MenuTopChild3,
        uC_MenuTopChild4};
            this.uC_MenuTop1.YuhClick += new System.EventHandler(this.uC_MenuTop1_YuhClick);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 76);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(916, 589);
            this.panel_main.TabIndex = 1;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.uC_MenuTop1);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(916, 665);
            this.ResumeLayout(false);

        }

        #endregion
        private Yuh.TransitionPage transitionPage;
        private Yuh.UC_MenuTop uC_MenuTop1;
        private System.Windows.Forms.Panel panel_main;
    }
}
