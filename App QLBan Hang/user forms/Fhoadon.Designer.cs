namespace App_QLBan_Hang.user_forms
{
    partial class Fhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fhoadon));
            this.cbx_thue = new Bunifu.Framework.UI.BunifuDropdown();
            this.txb_thanhtien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx_mahd = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txb_ghichu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtp_ngaylap = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // cbx_thue
            // 
            this.cbx_thue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.cbx_thue.BorderRadius = 3;
            this.cbx_thue.ForeColor = System.Drawing.Color.White;
            this.cbx_thue.Items = new string[] {
        "5%",
        "10%",
        "15%",
        "20%"};
            this.cbx_thue.Location = new System.Drawing.Point(501, 340);
            this.cbx_thue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_thue.Name = "cbx_thue";
            this.cbx_thue.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.cbx_thue.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.cbx_thue.selectedIndex = -1;
            this.cbx_thue.Size = new System.Drawing.Size(425, 44);
            this.cbx_thue.TabIndex = 3;
            // 
            // txb_thanhtien
            // 
            this.txb_thanhtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_thanhtien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_thanhtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_thanhtien.HintForeColor = System.Drawing.Color.Empty;
            this.txb_thanhtien.HintText = "";
            this.txb_thanhtien.isPassword = false;
            this.txb_thanhtien.LineFocusedColor = System.Drawing.Color.Gray;
            this.txb_thanhtien.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_thanhtien.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txb_thanhtien.LineThickness = 3;
            this.txb_thanhtien.Location = new System.Drawing.Point(501, 470);
            this.txb_thanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.txb_thanhtien.Name = "txb_thanhtien";
            this.txb_thanhtien.Size = new System.Drawing.Size(425, 29);
            this.txb_thanhtien.TabIndex = 4;
            this.txb_thanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(272, 474);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 25);
            this.bunifuCustomLabel2.TabIndex = 90;
            this.bunifuCustomLabel2.Text = "Thành tiền";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(272, 149);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(122, 25);
            this.bunifuCustomLabel6.TabIndex = 89;
            this.bunifuCustomLabel6.Text = "Mã Hóa Đơn";
            // 
            // cbx_mahd
            // 
            this.cbx_mahd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.cbx_mahd.BorderRadius = 3;
            this.cbx_mahd.ForeColor = System.Drawing.Color.White;
            this.cbx_mahd.Items = new string[0];
            this.cbx_mahd.Location = new System.Drawing.Point(501, 130);
            this.cbx_mahd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_mahd.Name = "cbx_mahd";
            this.cbx_mahd.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.cbx_mahd.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.cbx_mahd.selectedIndex = -1;
            this.cbx_mahd.Size = new System.Drawing.Size(425, 44);
            this.cbx_mahd.TabIndex = 1;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(272, 563);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(79, 25);
            this.bunifuCustomLabel10.TabIndex = 88;
            this.bunifuCustomLabel10.Text = "Ghi chú";
            // 
            // txb_ghichu
            // 
            this.txb_ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_ghichu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_ghichu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_ghichu.HintForeColor = System.Drawing.Color.Empty;
            this.txb_ghichu.HintText = "";
            this.txb_ghichu.isPassword = false;
            this.txb_ghichu.LineFocusedColor = System.Drawing.Color.Gray;
            this.txb_ghichu.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_ghichu.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txb_ghichu.LineThickness = 7;
            this.txb_ghichu.Location = new System.Drawing.Point(501, 563);
            this.txb_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ghichu.Name = "txb_ghichu";
            this.txb_ghichu.Size = new System.Drawing.Size(425, 246);
            this.txb_ghichu.TabIndex = 5;
            this.txb_ghichu.Text = " ";
            this.txb_ghichu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(272, 253);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(96, 25);
            this.bunifuCustomLabel9.TabIndex = 87;
            this.bunifuCustomLabel9.Text = "Ngày Lập";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.dtp_ngaylap.BorderRadius = 0;
            this.dtp_ngaylap.ForeColor = System.Drawing.Color.White;
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaylap.FormatCustom = "dd/MM/yyyy";
            this.dtp_ngaylap.Location = new System.Drawing.Point(501, 234);
            this.dtp_ngaylap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(425, 44);
            this.dtp_ngaylap.TabIndex = 2;
            this.dtp_ngaylap.Value = new System.DateTime(2019, 5, 11, 11, 18, 35, 443);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(272, 359);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 25);
            this.bunifuCustomLabel3.TabIndex = 86;
            this.bunifuCustomLabel3.Text = "Thuế";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 32);
            this.bunifuCustomLabel1.TabIndex = 85;
            this.bunifuCustomLabel1.Text = "HÓA ĐƠN";
            // 
            // btn_add
            // 
            this.btn_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 7;
            this.btn_add.ButtonText = "THÊM";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_add.Iconimage")));
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 90D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(1159, 917);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(182, 74);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "THÊM";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Fhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 1023);
            this.Controls.Add(this.cbx_thue);
            this.Controls.Add(this.txb_thanhtien);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.cbx_mahd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.txb_ghichu);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.dtp_ngaylap);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fhoadon";
            this.Text = "Fhoadon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown cbx_thue;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_thanhtien;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDropdown cbx_mahd;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_ghichu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_ngaylap;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}