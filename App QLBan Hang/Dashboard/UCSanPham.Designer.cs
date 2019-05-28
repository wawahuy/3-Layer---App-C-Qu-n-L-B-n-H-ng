namespace App_QLBan_Hang.Dashboard
{
    partial class UCSanPham
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.uC_MenuTop = new App_QLBan_Hang.Yuh.UC_MenuTop();
            this.transitionPage = new App_QLBan_Hang.Yuh.TransitionPage(this.components);
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 76);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(916, 589);
            this.panel_main.TabIndex = 1;
            // 
            // uC_MenuTop
            // 
            this.uC_MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MenuTop.Location = new System.Drawing.Point(0, 0);
            this.uC_MenuTop.Name = "uC_MenuTop";
            this.uC_MenuTop.Size = new System.Drawing.Size(916, 76);
            this.uC_MenuTop.TabIndex = 0;
            this.uC_MenuTop.Yuhfont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            uC_MenuTopChild1.Coloridel = System.Drawing.Color.Black;
            uC_MenuTopChild1.Colorselected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            uC_MenuTopChild1.Enable = true;
            uC_MenuTopChild1.Text = "Danh sách";
            uC_MenuTopChild2.Coloridel = System.Drawing.Color.Black;
            uC_MenuTopChild2.Colorselected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            uC_MenuTopChild2.Enable = true;
            uC_MenuTopChild2.Text = "Loại Sản Phẩm";
            this.uC_MenuTop.Yuhitems = new App_QLBan_Hang.Yuh.UC_MenuTop.UC_MenuTopChild[] {
        uC_MenuTopChild1,
        uC_MenuTopChild2};
            this.uC_MenuTop.YuhClick += new System.EventHandler(this.uC_MenuTop1_YuhClick);
            this.uC_MenuTop.Load += new System.EventHandler(this.uC_MenuTop_Load);
            // 
            // transitionPage
            // 
            this.transitionPage.Yuh_Anim_type = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transitionPage.Yuh_interval = 1;
            this.transitionPage.Yuh_Panel_main = this.panel_main;
            this.transitionPage.Yuh_timemax = 500;
            // 
            // UCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.uC_MenuTop);
            this.Name = "UCSanPham";
            this.Size = new System.Drawing.Size(916, 665);
            this.ResumeLayout(false);

        }

        #endregion
        private Yuh.TransitionPage transitionPage;
        private Yuh.UC_MenuTop uC_MenuTop;
        private System.Windows.Forms.Panel panel_main;
    }
}
