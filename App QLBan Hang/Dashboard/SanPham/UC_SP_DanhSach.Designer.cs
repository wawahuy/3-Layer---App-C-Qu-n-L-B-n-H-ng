namespace App_QLBan_Hang.Dashboard.SanPham
{
    partial class UC_SP_DanhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SP_DanhSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_them = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_huy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.btn_loai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txb_ten = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txb_gia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dd_loaitimkiem = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm, Sửa, Xóa Sản Phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_huy);
            this.panel2.Controls.Add(this.lb_tensp);
            this.panel2.Controls.Add(this.lb_gia);
            this.panel2.Controls.Add(this.btn_loai);
            this.panel2.Controls.Add(this.txb_ten);
            this.panel2.Controls.Add(this.txb_gia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 331);
            this.panel2.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.BorderRadius = 5;
            this.btn_them.ButtonText = "Thêm";
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
            this.btn_them.Location = new System.Drawing.Point(56, 251);
            this.btn_them.Name = "btn_them";
            this.btn_them.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_them.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_them.selected = false;
            this.btn_them.Size = new System.Drawing.Size(87, 35);
            this.btn_them.TabIndex = 32;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.Textcolor = System.Drawing.Color.White;
            this.btn_them.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xoa.BorderRadius = 5;
            this.btn_xoa.ButtonText = "Xóa";
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.DisabledColor = System.Drawing.Color.Gray;
            this.btn_xoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_xoa.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_delete_document_filled_32;
            this.btn_xoa.Iconimage_right = null;
            this.btn_xoa.Iconimage_right_Selected = null;
            this.btn_xoa.Iconimage_Selected = null;
            this.btn_xoa.IconMarginLeft = 0;
            this.btn_xoa.IconMarginRight = 0;
            this.btn_xoa.IconRightVisible = true;
            this.btn_xoa.IconRightZoom = 0D;
            this.btn_xoa.IconVisible = true;
            this.btn_xoa.IconZoom = 50D;
            this.btn_xoa.IsTab = false;
            this.btn_xoa.Location = new System.Drawing.Point(240, 251);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_xoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_xoa.selected = false;
            this.btn_xoa.Size = new System.Drawing.Size(89, 35);
            this.btn_xoa.TabIndex = 31;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.Textcolor = System.Drawing.Color.White;
            this.btn_xoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Visible = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sua.BorderRadius = 5;
            this.btn_sua.ButtonText = "Sửa";
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sua.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sua.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_edit_property_filled_321;
            this.btn_sua.Iconimage_right = null;
            this.btn_sua.Iconimage_right_Selected = null;
            this.btn_sua.Iconimage_Selected = null;
            this.btn_sua.IconMarginLeft = 0;
            this.btn_sua.IconMarginRight = 0;
            this.btn_sua.IconRightVisible = true;
            this.btn_sua.IconRightZoom = 0D;
            this.btn_sua.IconVisible = true;
            this.btn_sua.IconZoom = 50D;
            this.btn_sua.IsTab = false;
            this.btn_sua.Location = new System.Drawing.Point(149, 251);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_sua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_sua.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sua.selected = false;
            this.btn_sua.Size = new System.Drawing.Size(85, 35);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sua.Textcolor = System.Drawing.Color.White;
            this.btn_sua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Visible = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_huy.BorderRadius = 5;
            this.btn_huy.ButtonText = "Hủy";
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.DisabledColor = System.Drawing.Color.Gray;
            this.btn_huy.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_huy.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_delete_document_filled_32;
            this.btn_huy.Iconimage_right = null;
            this.btn_huy.Iconimage_right_Selected = null;
            this.btn_huy.Iconimage_Selected = null;
            this.btn_huy.IconMarginLeft = 0;
            this.btn_huy.IconMarginRight = 0;
            this.btn_huy.IconRightVisible = true;
            this.btn_huy.IconRightZoom = 0D;
            this.btn_huy.IconVisible = true;
            this.btn_huy.IconZoom = 50D;
            this.btn_huy.IsTab = false;
            this.btn_huy.Location = new System.Drawing.Point(335, 251);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_huy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_huy.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_huy.selected = false;
            this.btn_huy.Size = new System.Drawing.Size(89, 35);
            this.btn_huy.TabIndex = 29;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huy.Textcolor = System.Drawing.Color.White;
            this.btn_huy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Visible = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // lb_tensp
            // 
            this.lb_tensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_tensp.Location = new System.Drawing.Point(137, 55);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(320, 24);
            this.lb_tensp.TabIndex = 27;
            // 
            // lb_gia
            // 
            this.lb_gia.ForeColor = System.Drawing.Color.Green;
            this.lb_gia.Location = new System.Drawing.Point(137, 193);
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
            this.btn_loai.Location = new System.Drawing.Point(137, 93);
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
            this.txb_ten.Location = new System.Drawing.Point(137, 19);
            this.txb_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ten.Name = "txb_ten";
            this.txb_ten.Size = new System.Drawing.Size(287, 32);
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
            this.txb_gia.Location = new System.Drawing.Point(137, 157);
            this.txb_gia.Margin = new System.Windows.Forms.Padding(4);
            this.txb_gia.Name = "txb_gia";
            this.txb_gia.Size = new System.Drawing.Size(287, 32);
            this.txb_gia.TabIndex = 23;
            this.txb_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_gia.OnValueChanged += new System.EventHandler(this.txb_gia_OnValueChanged);
            this.txb_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_gia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.datagrid);
            this.groupBox2.Location = new System.Drawing.Point(482, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 554);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // datagrid
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.datagrid.ColumnHeadersHeight = 40;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.gioitinh,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column1,
            this.Column4});
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(6, 19);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.datagrid.RowHeadersWidth = 20;
            this.datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.datagrid.RowTemplate.Height = 30;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(403, 529);
            this.datagrid.TabIndex = 3;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            this.datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellDoubleClick);
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ma";
            this.ten.HeaderText = "Mã SP";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Ten";
            this.gioitinh.HeaderText = "Tên SP";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gia";
            this.Column2.HeaderText = "Giá SP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tongsl";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenLoai";
            this.Column5.HeaderText = "Loại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Xoa";
            this.Column1.HeaderText = "Xoa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Loai";
            this.Column4.HeaderText = "Loai";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dd_loaitimkiem);
            this.groupBox3.Location = new System.Drawing.Point(18, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // dd_loaitimkiem
            // 
            this.dd_loaitimkiem.BackColor = System.Drawing.Color.Transparent;
            this.dd_loaitimkiem.BorderRadius = 3;
            this.dd_loaitimkiem.ForeColor = System.Drawing.Color.White;
            this.dd_loaitimkiem.Items = new string[] {
        "Tấc cả",
        "Tìm theo Tên",
        "Tìm theo Mã"};
            this.dd_loaitimkiem.Location = new System.Drawing.Point(19, 19);
            this.dd_loaitimkiem.Name = "dd_loaitimkiem";
            this.dd_loaitimkiem.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.dd_loaitimkiem.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.dd_loaitimkiem.selectedIndex = 0;
            this.dd_loaitimkiem.Size = new System.Drawing.Size(400, 40);
            this.dd_loaitimkiem.TabIndex = 7;
            // 
            // UC_SP_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_SP_DanhSach";
            this.Size = new System.Drawing.Size(916, 584);
            this.Load += new System.EventHandler(this.UC_SP_DanhSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_tensp;
        private System.Windows.Forms.Label lb_gia;
        private Bunifu.Framework.UI.BunifuFlatButton btn_loai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_ten;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sua;
        private Bunifu.Framework.UI.BunifuFlatButton btn_huy;
        private Bunifu.Framework.UI.BunifuFlatButton btn_them;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xoa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuDropdown dd_loaitimkiem;
    }
}
