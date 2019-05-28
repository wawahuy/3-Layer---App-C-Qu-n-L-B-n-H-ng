namespace App_QLBan_Hang.Dashboard.SanPham
{
    partial class FThemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThemSanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.btn_loai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txb_ten = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txb_gia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_them = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lb_tensp);
            this.panel2.Controls.Add(this.lb_gia);
            this.panel2.Controls.Add(this.btn_loai);
            this.panel2.Controls.Add(this.txb_ten);
            this.panel2.Controls.Add(this.txb_gia);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 355);
            this.panel2.TabIndex = 1;
            // 
            // lb_tensp
            // 
            this.lb_tensp.Location = new System.Drawing.Point(137, 113);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(320, 24);
            this.lb_tensp.TabIndex = 27;
            // 
            // lb_gia
            // 
            this.lb_gia.Location = new System.Drawing.Point(137, 251);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(320, 24);
            this.lb_gia.TabIndex = 26;
            // 
            // btn_loai
            // 
            this.btn_loai.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_loai.BackColor = System.Drawing.Color.Gray;
            this.btn_loai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_loai.BorderRadius = 0;
            this.btn_loai.ButtonText = "  (Click để chọn)";
            this.btn_loai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loai.DisabledColor = System.Drawing.Color.Gray;
            this.btn_loai.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_loai.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_loai.Iconimage")));
            this.btn_loai.Iconimage_right = null;
            this.btn_loai.Iconimage_right_Selected = null;
            this.btn_loai.Iconimage_Selected = null;
            this.btn_loai.IconMarginLeft = 7;
            this.btn_loai.IconMarginRight = 0;
            this.btn_loai.IconRightVisible = true;
            this.btn_loai.IconRightZoom = 0D;
            this.btn_loai.IconVisible = false;
            this.btn_loai.IconZoom = 90D;
            this.btn_loai.IsTab = false;
            this.btn_loai.Location = new System.Drawing.Point(137, 151);
            this.btn_loai.Name = "btn_loai";
            this.btn_loai.Normalcolor = System.Drawing.Color.Gray;
            this.btn_loai.OnHovercolor = System.Drawing.Color.Gray;
            this.btn_loai.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_loai.selected = false;
            this.btn_loai.Size = new System.Drawing.Size(134, 30);
            this.btn_loai.TabIndex = 25;
            this.btn_loai.Text = "  (Click để chọn)";
            this.btn_loai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loai.Textcolor = System.Drawing.Color.White;
            this.btn_loai.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loai.Click += new System.EventHandler(this.btn_loai_Click);
            // 
            // txb_ten
            // 
            this.txb_ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_ten.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_ten.HintForeColor = System.Drawing.Color.Empty;
            this.txb_ten.HintText = "(Không quá ngắn hoặc quá dài)";
            this.txb_ten.isPassword = false;
            this.txb_ten.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_ten.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_ten.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_ten.LineThickness = 3;
            this.txb_ten.Location = new System.Drawing.Point(137, 77);
            this.txb_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ten.Name = "txb_ten";
            this.txb_ten.Size = new System.Drawing.Size(320, 32);
            this.txb_ten.TabIndex = 24;
            this.txb_ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_ten.OnValueChanged += new System.EventHandler(this.txb_gia_OnValueChanged);
            // 
            // txb_gia
            // 
            this.txb_gia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_gia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_gia.HintForeColor = System.Drawing.Color.Empty;
            this.txb_gia.HintText = "(Đây là giá bán, Tính bằng VNĐ)";
            this.txb_gia.isPassword = false;
            this.txb_gia.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_gia.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_gia.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_gia.LineThickness = 3;
            this.txb_gia.Location = new System.Drawing.Point(137, 215);
            this.txb_gia.Margin = new System.Windows.Forms.Padding(4);
            this.txb_gia.Name = "txb_gia";
            this.txb_gia.Size = new System.Drawing.Size(320, 32);
            this.txb_gia.TabIndex = 23;
            this.txb_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_gia.OnValueChanged += new System.EventHandler(this.txb_gia_OnValueChanged);
            // 
            // btn_them
            // 
            this.btn_them.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.BorderRadius = 5;
            this.btn_them.ButtonText = "Thêm ";
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.DisabledColor = System.Drawing.Color.Gray;
            this.btn_them.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_them.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_edit_property_filled_321;
            this.btn_them.Iconimage_right = null;
            this.btn_them.Iconimage_right_Selected = null;
            this.btn_them.Iconimage_Selected = null;
            this.btn_them.IconMarginLeft = 0;
            this.btn_them.IconMarginRight = 0;
            this.btn_them.IconRightVisible = true;
            this.btn_them.IconRightZoom = 0D;
            this.btn_them.IconVisible = true;
            this.btn_them.IconZoom = 50D;
            this.btn_them.IsTab = false;
            this.btn_them.Location = new System.Drawing.Point(361, 305);
            this.btn_them.Name = "btn_them";
            this.btn_them.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_them.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_them.selected = false;
            this.btn_them.Size = new System.Drawing.Size(96, 35);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.Textcolor = System.Drawing.Color.White;
            this.btn_them.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm thông tin sản phẩm";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 26);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(480, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // FThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 390);
            this.Controls.Add(this.panel2);
            this.Name = "FThemSanPham";
            this.Text = "Thêm thông tin sản phẩm";
            this.YuhControlParent = this.panel2;
            this.YuhIconVisible = true;
            this.YuhMinimizedVisible = true;
            this.YuhText = "Thêm thông tin sản phẩm";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_them;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_ten;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_gia;
        private Bunifu.Framework.UI.BunifuFlatButton btn_loai;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_tensp;
    }
}