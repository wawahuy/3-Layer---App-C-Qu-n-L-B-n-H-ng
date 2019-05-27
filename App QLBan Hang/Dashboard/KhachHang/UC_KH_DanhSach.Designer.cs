namespace App_QLBan_Hang.Dashboard.KhachHang
{
    partial class UC_KH_DanhSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dd_loaitimkiem = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_alert_search = new System.Windows.Forms.Label();
            this.dd_search = new Bunifu.Framework.UI.BunifuDropdown();
            this.txb_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xem_ds_hoa_don = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeight = 40;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.gioitinh,
            this.Column2,
            this.ngaysinh,
            this.sdt,
            this.cmnd,
            this.diachi,
            this.ma,
            this.Column1,
            this.Column3});
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(18, 27);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.RowHeadersWidth = 20;
            this.datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.datagrid.RowTemplate.Height = 30;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(847, 373);
            this.datagrid.TabIndex = 1;
            this.datagrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagrid_CellMouseMove);
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
            // dd_loaitimkiem
            // 
            this.dd_loaitimkiem.BackColor = System.Drawing.Color.Transparent;
            this.dd_loaitimkiem.BorderRadius = 3;
            this.dd_loaitimkiem.ForeColor = System.Drawing.Color.White;
            this.dd_loaitimkiem.Items = new string[] {
        "Tấc cả",
        "Tìm theo Tên",
        "Tìm theo CMND",
        "Tìm theo SĐT",
        "Tìm theo Giới tính"};
            this.dd_loaitimkiem.Location = new System.Drawing.Point(18, 21);
            this.dd_loaitimkiem.Name = "dd_loaitimkiem";
            this.dd_loaitimkiem.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.dd_loaitimkiem.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.dd_loaitimkiem.selectedIndex = 0;
            this.dd_loaitimkiem.Size = new System.Drawing.Size(260, 35);
            this.dd_loaitimkiem.TabIndex = 6;
            this.dd_loaitimkiem.onItemSelected += new System.EventHandler(this.dd_loaitimkiem_onItemSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_alert_search);
            this.groupBox2.Controls.Add(this.dd_search);
            this.groupBox2.Controls.Add(this.txb_search);
            this.groupBox2.Controls.Add(this.dd_loaitimkiem);
            this.groupBox2.Location = new System.Drawing.Point(17, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // lb_alert_search
            // 
            this.lb_alert_search.ForeColor = System.Drawing.Color.Brown;
            this.lb_alert_search.Location = new System.Drawing.Point(15, 102);
            this.lb_alert_search.Name = "lb_alert_search";
            this.lb_alert_search.Size = new System.Drawing.Size(263, 23);
            this.lb_alert_search.TabIndex = 9;
            this.lb_alert_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dd_search
            // 
            this.dd_search.BackColor = System.Drawing.Color.Transparent;
            this.dd_search.BorderRadius = 3;
            this.dd_search.ForeColor = System.Drawing.Color.White;
            this.dd_search.Items = new string[0];
            this.dd_search.Location = new System.Drawing.Point(18, 63);
            this.dd_search.Name = "dd_search";
            this.dd_search.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.dd_search.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.dd_search.selectedIndex = -1;
            this.dd_search.Size = new System.Drawing.Size(260, 35);
            this.dd_search.TabIndex = 8;
            this.dd_search.Visible = false;
            this.dd_search.onItemSelected += new System.EventHandler(this.dd_search_onItemSelected);
            // 
            // txb_search
            // 
            this.txb_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txb_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txb_search.BorderThickness = 3;
            this.txb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_search.isPassword = false;
            this.txb_search.Location = new System.Drawing.Point(18, 64);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(260, 34);
            this.txb_search.TabIndex = 7;
            this.txb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_search.Visible = false;
            this.txb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_search_KeyPress);
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
            this.groupBox3.Size = new System.Drawing.Size(285, 128);
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
            this.btn_xem_ds_hoa_don.Location = new System.Drawing.Point(19, 64);
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
            // Column2
            // 
            this.Column2.DataPropertyName = "Diem";
            this.Column2.HeaderText = "Điểm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "Ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
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
            // ma
            // 
            this.ma.DataPropertyName = "Ma";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            this.ma.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Xoa";
            this.Column1.HeaderText = "Xoa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Giotinh";
            this.Column3.HeaderText = "Gioitinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // UC_KH_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_KH_DanhSach";
            this.Size = new System.Drawing.Size(916, 584);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xem;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xoa;
        private Bunifu.Framework.UI.BunifuDropdown dd_loaitimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sua;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xem_ds_hoa_don;
        private Bunifu.Framework.UI.BunifuFlatButton btn_lammoi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txb_search;
        private Bunifu.Framework.UI.BunifuDropdown dd_search;
        private System.Windows.Forms.Label lb_alert_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
