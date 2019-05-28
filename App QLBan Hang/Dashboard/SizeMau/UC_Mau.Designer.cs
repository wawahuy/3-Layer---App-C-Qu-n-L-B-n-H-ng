namespace App_QLBan_Hang.Dashboard.SizeMau
{
    partial class UC_Mau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Mau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_them = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_tenmau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txb_search);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách màu";
            // 
            // txb_search
            // 
            this.txb_search.BackColor = System.Drawing.Color.Silver;
            this.txb_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txb_search.BackgroundImage")));
            this.txb_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_search.Icon = ((System.Drawing.Image)(resources.GetObject("txb_search.Icon")));
            this.txb_search.Location = new System.Drawing.Point(15, 34);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(327, 36);
            this.txb_search.TabIndex = 5;
            this.txb_search.text = "";
            this.txb_search.OnTextChange += new System.EventHandler(this.txb_search_OnTextChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btn_huy);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txb_tenmau);
            this.groupBox2.Location = new System.Drawing.Point(15, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm, Sửa, Xóa";
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
            this.btn_huy.Location = new System.Drawing.Point(214, 93);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_huy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_huy.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_huy.selected = false;
            this.btn_huy.Size = new System.Drawing.Size(90, 35);
            this.btn_huy.TabIndex = 24;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huy.Textcolor = System.Drawing.Color.White;
            this.btn_huy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(18, 93);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_sua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_sua.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sua.selected = false;
            this.btn_sua.Size = new System.Drawing.Size(91, 35);
            this.btn_sua.TabIndex = 23;
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
            this.btn_xoa.Location = new System.Drawing.Point(115, 93);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_xoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_xoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_xoa.selected = false;
            this.btn_xoa.Size = new System.Drawing.Size(90, 35);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.Textcolor = System.Drawing.Color.White;
            this.btn_xoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btn_them.Location = new System.Drawing.Point(18, 93);
            this.btn_them.Name = "btn_them";
            this.btn_them.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_them.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btn_them.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_them.selected = false;
            this.btn_them.Size = new System.Drawing.Size(91, 35);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.Textcolor = System.Drawing.Color.White;
            this.btn_them.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên màu:";
            // 
            // txb_tenmau
            // 
            this.txb_tenmau.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_tenmau.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_tenmau.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.txb_tenmau.BorderThickness = 3;
            this.txb_tenmau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_tenmau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_tenmau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_tenmau.isPassword = false;
            this.txb_tenmau.Location = new System.Drawing.Point(18, 52);
            this.txb_tenmau.Margin = new System.Windows.Forms.Padding(4);
            this.txb_tenmau.Name = "txb_tenmau";
            this.txb_tenmau.Size = new System.Drawing.Size(286, 34);
            this.txb_tenmau.TabIndex = 3;
            this.txb_tenmau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datagrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.ten,
            this.gioitinh});
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(9, 14);
            this.datagrid.MultiSelect = false;
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
            this.datagrid.Size = new System.Drawing.Size(280, 227);
            this.datagrid.TabIndex = 2;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ma";
            this.ten.HeaderText = "Mã Màu";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Ten";
            this.gioitinh.HeaderText = "Tên Màu";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.datagrid);
            this.groupBox3.Location = new System.Drawing.Point(374, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 247);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // UC_Mau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Mau";
            this.Size = new System.Drawing.Size(716, 324);
            this.Load += new System.EventHandler(this.UC_Mau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private Bunifu.Framework.UI.BunifuTextbox txb_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txb_tenmau;
        private Bunifu.Framework.UI.BunifuFlatButton btn_them;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xoa;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private Bunifu.Framework.UI.BunifuFlatButton btn_huy;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
