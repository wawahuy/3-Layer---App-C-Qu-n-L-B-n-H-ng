namespace App_QLBan_Hang.Dashboard.SanPham
{
    partial class FChonSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_SP_DanhSach1 = new App_QLBan_Hang.Dashboard.SanPham.UC_SP_DanhSach();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 30);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhấn đúp chuột vào sản phẩm cần chọn!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_SP_DanhSach1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 581);
            this.panel3.TabIndex = 2;
            // 
            // uC_SP_DanhSach1
            // 
            this.uC_SP_DanhSach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SP_DanhSach1.Location = new System.Drawing.Point(0, 0);
            this.uC_SP_DanhSach1.Name = "uC_SP_DanhSach1";
            this.uC_SP_DanhSach1.Size = new System.Drawing.Size(925, 581);
            this.uC_SP_DanhSach1.TabIndex = 0;
            // 
            // FChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 646);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FChonSanPham";
            this.Text = "Lựa chọn sản phẩm";
            this.YuhControlParent = this.panel3;
            this.YuhIconVisible = true;
            this.YuhMinimizedVisible = true;
            this.YuhText = "Lựa chọn sản phẩm";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private UC_SP_DanhSach uC_SP_DanhSach1;
    }
}