namespace App_QLBan_Hang.Dashboard
{
    partial class FNhaCungCap
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
            this.ucNhaCungCap1 = new App_QLBan_Hang.Dashboard.UCNhaCungCap();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucNhaCungCap1
            // 
            this.ucNhaCungCap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNhaCungCap1.Location = new System.Drawing.Point(0, 0);
            this.ucNhaCungCap1.Name = "ucNhaCungCap1";
            this.ucNhaCungCap1.Size = new System.Drawing.Size(951, 669);
            this.ucNhaCungCap1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 21);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucNhaCungCap1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 669);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhấn đúp chuột vào nhà cung cấp cần chọn!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FNhaCungCap";
            this.Text = "Lựa chọn nhà cung cấp";
            this.YuhControlParent = this.panel3;
            this.YuhIconVisible = true;
            this.YuhMinimizedVisible = true;
            this.YuhText = "Lựa chọn nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FNhaCungCap_FormClosing);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCNhaCungCap ucNhaCungCap1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}