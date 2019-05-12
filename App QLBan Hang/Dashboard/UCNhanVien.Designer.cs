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
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.llb_danhsach = new System.Windows.Forms.LinkLabel();
            this.llb_themnhanvien = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_suanv = new System.Windows.Forms.Label();
            this.label_xemnv = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.transitionPage = new App_QLBan_Hang.Yuh.TransitionPage(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(889, 35);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // llb_danhsach
            // 
            this.llb_danhsach.ActiveLinkColor = System.Drawing.Color.Gray;
            this.llb_danhsach.AutoSize = true;
            this.llb_danhsach.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.llb_danhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llb_danhsach.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.llb_danhsach.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llb_danhsach.LinkColor = System.Drawing.Color.DimGray;
            this.llb_danhsach.Location = new System.Drawing.Point(23, 26);
            this.llb_danhsach.Name = "llb_danhsach";
            this.llb_danhsach.Size = new System.Drawing.Size(74, 16);
            this.llb_danhsach.TabIndex = 3;
            this.llb_danhsach.TabStop = true;
            this.llb_danhsach.Text = "Danh Sách";
            this.llb_danhsach.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_danhsach_LinkClicked);
            // 
            // llb_themnhanvien
            // 
            this.llb_themnhanvien.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.llb_themnhanvien.AutoSize = true;
            this.llb_themnhanvien.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.llb_themnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llb_themnhanvien.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.llb_themnhanvien.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llb_themnhanvien.LinkColor = System.Drawing.Color.DimGray;
            this.llb_themnhanvien.Location = new System.Drawing.Point(155, 26);
            this.llb_themnhanvien.Name = "llb_themnhanvien";
            this.llb_themnhanvien.Size = new System.Drawing.Size(108, 16);
            this.llb_themnhanvien.TabIndex = 4;
            this.llb_themnhanvien.TabStop = true;
            this.llb_themnhanvien.Text = "Thêm Nhân Viên";
            this.llb_themnhanvien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_themnhanvien_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_suanv);
            this.panel1.Controls.Add(this.label_xemnv);
            this.panel1.Controls.Add(this.llb_themnhanvien);
            this.panel1.Controls.Add(this.llb_danhsach);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 81);
            this.panel1.TabIndex = 5;
            // 
            // label_suanv
            // 
            this.label_suanv.AutoSize = true;
            this.label_suanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_suanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label_suanv.Location = new System.Drawing.Point(493, 26);
            this.label_suanv.Name = "label_suanv";
            this.label_suanv.Size = new System.Drawing.Size(97, 16);
            this.label_suanv.TabIndex = 6;
            this.label_suanv.Text = "Sửa Nhân Viên";
            // 
            // label_xemnv
            // 
            this.label_xemnv.AutoSize = true;
            this.label_xemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_xemnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label_xemnv.Location = new System.Drawing.Point(328, 26);
            this.label_xemnv.Name = "label_xemnv";
            this.label_xemnv.Size = new System.Drawing.Size(100, 16);
            this.label_xemnv.TabIndex = 5;
            this.label_xemnv.Text = "Xem Nhân Viên";
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 81);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(916, 584);
            this.panel_main.TabIndex = 6;
            // 
            // transitionPage
            // 
            this.transitionPage.Yuh_Anim_type = BunifuAnimatorNS.AnimationType.Particles;
            this.transitionPage.Yuh_interval = 1;
            this.transitionPage.Yuh_Panel_main = this.panel_main;
            this.transitionPage.Yuh_timemax = 1000;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(916, 665);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.LinkLabel llb_danhsach;
        private System.Windows.Forms.LinkLabel llb_themnhanvien;
        private System.Windows.Forms.Panel panel1;
        private Yuh.TransitionPage transitionPage;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_suanv;
        private System.Windows.Forms.Label label_xemnv;
    }
}
