namespace App_QLBan_Hang.Dashboard.NhanVien
{
    partial class UC_NV_DanhSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giotinht = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xem_ds_hoa_don = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xem = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid.ColumnHeadersHeight = 40;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taikhoan,
            this.ten,
            this.gioitinh,
            this.chucvu2,
            this.ngaysinh,
            this.ngaygianhap,
            this.sdt,
            this.cmnd,
            this.diachi,
            this.Luong,
            this.matkhau,
            this.chucvur,
            this.giotinht,
            this.ma});
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(18, 27);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid.RowHeadersWidth = 20;
            this.datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.datagrid.RowTemplate.Height = 30;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(847, 373);
            this.datagrid.TabIndex = 1;
            this.datagrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagrid_CellMouseMove);
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "Taikhoan";
            this.taikhoan.HeaderText = "Tài Khoản";
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            this.ten.HeaderText = "Họ & Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Tengioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // chucvu2
            // 
            this.chucvu2.DataPropertyName = "Tenchucvu";
            this.chucvu2.HeaderText = "Chức vụ";
            this.chucvu2.Name = "chucvu2";
            this.chucvu2.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "Ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // ngaygianhap
            // 
            this.ngaygianhap.DataPropertyName = "Gianhap";
            this.ngaygianhap.HeaderText = "Gia Nhập";
            this.ngaygianhap.Name = "ngaygianhap";
            this.ngaygianhap.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "Cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "Diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "Matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            this.matkhau.Visible = false;
            // 
            // chucvur
            // 
            this.chucvur.DataPropertyName = "Chucvu";
            this.chucvur.HeaderText = "Chức Vụ R";
            this.chucvur.Name = "chucvur";
            this.chucvur.ReadOnly = true;
            this.chucvur.Visible = false;
            // 
            // giotinht
            // 
            this.giotinht.DataPropertyName = "Giotinh";
            this.giotinht.HeaderText = "Giới tính R";
            this.giotinht.Name = "giotinht";
            this.giotinht.ReadOnly = true;
            this.giotinht.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.giotinht.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.giotinht.Visible = false;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "Ma";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            this.ma.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.datagrid);
            this.groupBox1.Location = new System.Drawing.Point(17, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 418);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(18, 21);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(207, 35);
            this.bunifuDropdown1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox1);
            this.groupBox2.Controls.Add(this.bunifuImageButton1);
            this.groupBox2.Controls.Add(this.bunifuDropdown1);
            this.groupBox2.Location = new System.Drawing.Point(17, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(18, 63);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(260, 35);
            this.bunifuMetroTextbox1.TabIndex = 7;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::App_QLBan_Hang.Properties.Resources.icons8_detective_filled_32;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(242, 21);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_lammoi);
            this.groupBox3.Controls.Add(this.btn_xem_ds_hoa_don);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_xem);
            this.groupBox3.Location = new System.Drawing.Point(617, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 116);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_lammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lammoi.BorderRadius = 5;
            this.btn_lammoi.ButtonText = "Làm Mới";
            this.btn_lammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lammoi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_lammoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_lammoi.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_recurring_appointment_exception_32;
            this.btn_lammoi.Iconimage_right = null;
            this.btn_lammoi.Iconimage_right_Selected = null;
            this.btn_lammoi.Iconimage_Selected = null;
            this.btn_lammoi.IconMarginLeft = 0;
            this.btn_lammoi.IconMarginRight = 0;
            this.btn_lammoi.IconRightVisible = true;
            this.btn_lammoi.IconRightZoom = 0D;
            this.btn_lammoi.IconVisible = true;
            this.btn_lammoi.IconZoom = 50D;
            this.btn_lammoi.IsTab = false;
            this.btn_lammoi.Location = new System.Drawing.Point(178, 63);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_lammoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_lammoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_lammoi.selected = false;
            this.btn_lammoi.Size = new System.Drawing.Size(93, 35);
            this.btn_lammoi.TabIndex = 7;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lammoi.Textcolor = System.Drawing.Color.White;
            this.btn_lammoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xem_ds_hoa_don
            // 
            this.btn_xem_ds_hoa_don.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xem_ds_hoa_don.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xem_ds_hoa_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xem_ds_hoa_don.BorderRadius = 5;
            this.btn_xem_ds_hoa_don.ButtonText = "Xem  DS Hóa Đơn";
            this.btn_xem_ds_hoa_don.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xem_ds_hoa_don.DisabledColor = System.Drawing.Color.Gray;
            this.btn_xem_ds_hoa_don.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_xem_ds_hoa_don.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_view_filled_32;
            this.btn_xem_ds_hoa_don.Iconimage_right = null;
            this.btn_xem_ds_hoa_don.Iconimage_right_Selected = null;
            this.btn_xem_ds_hoa_don.Iconimage_Selected = null;
            this.btn_xem_ds_hoa_don.IconMarginLeft = 0;
            this.btn_xem_ds_hoa_don.IconMarginRight = 0;
            this.btn_xem_ds_hoa_don.IconRightVisible = true;
            this.btn_xem_ds_hoa_don.IconRightZoom = 0D;
            this.btn_xem_ds_hoa_don.IconVisible = true;
            this.btn_xem_ds_hoa_don.IconZoom = 50D;
            this.btn_xem_ds_hoa_don.IsTab = false;
            this.btn_xem_ds_hoa_don.Location = new System.Drawing.Point(19, 63);
            this.btn_xem_ds_hoa_don.Name = "btn_xem_ds_hoa_don";
            this.btn_xem_ds_hoa_don.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xem_ds_hoa_don.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_xem_ds_hoa_don.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_xem_ds_hoa_don.selected = false;
            this.btn_xem_ds_hoa_don.Size = new System.Drawing.Size(153, 35);
            this.btn_xem_ds_hoa_don.TabIndex = 6;
            this.btn_xem_ds_hoa_don.Text = "Xem  DS Hóa Đơn";
            this.btn_xem_ds_hoa_don.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xem_ds_hoa_don.Textcolor = System.Drawing.Color.White;
            this.btn_xem_ds_hoa_don.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem_ds_hoa_don.Click += new System.EventHandler(this.btn_xem_ds_hoa_don_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(105, 21);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_sua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_sua.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sua.selected = false;
            this.btn_sua.Size = new System.Drawing.Size(80, 35);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sua.Textcolor = System.Drawing.Color.White;
            this.btn_sua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_xoa.Location = new System.Drawing.Point(19, 21);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_xoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_xoa.selected = false;
            this.btn_xoa.Size = new System.Drawing.Size(80, 35);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.Textcolor = System.Drawing.Color.White;
            this.btn_xoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xem.BorderRadius = 5;
            this.btn_xem.ButtonText = "Xem";
            this.btn_xem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_xem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_xem.Iconimage = global::App_QLBan_Hang.Properties.Resources.icons8_view_filled_32;
            this.btn_xem.Iconimage_right = null;
            this.btn_xem.Iconimage_right_Selected = null;
            this.btn_xem.Iconimage_Selected = null;
            this.btn_xem.IconMarginLeft = 0;
            this.btn_xem.IconMarginRight = 0;
            this.btn_xem.IconRightVisible = true;
            this.btn_xem.IconRightZoom = 0D;
            this.btn_xem.IconVisible = true;
            this.btn_xem.IconZoom = 50D;
            this.btn_xem.IsTab = false;
            this.btn_xem.Location = new System.Drawing.Point(191, 21);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_xem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_xem.selected = false;
            this.btn_xem.Size = new System.Drawing.Size(80, 35);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Text = "Xem";
            this.btn_xem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xem.Textcolor = System.Drawing.Color.White;
            this.btn_xem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // UC_NV_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_NV_DanhSach";
            this.Size = new System.Drawing.Size(916, 584);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn giotinht;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xem;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xoa;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sua;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xem_ds_hoa_don;
        private Bunifu.Framework.UI.BunifuFlatButton btn_lammoi;
    }
}
