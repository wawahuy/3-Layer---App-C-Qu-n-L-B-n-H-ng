namespace App_QLBan_Hang.Dashboard.SizeMau
{
    partial class FMau
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_Mau1 = new App_QLBan_Hang.Dashboard.SizeMau.UC_Mau();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 26);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.uC_Mau1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 295);
            this.panel3.TabIndex = 2;
            // 
            // uC_Mau1
            // 
            this.uC_Mau1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Mau1.Location = new System.Drawing.Point(0, 0);
            this.uC_Mau1.Name = "uC_Mau1";
            this.uC_Mau1.Size = new System.Drawing.Size(726, 295);
            this.uC_Mau1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn vui lòng nháy đúp chuột vào màu bạn muốn chọn!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 356);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FMau";
            this.Text = "FMau";
            this.YuhControlParent = this.panel3;
            this.YuhIconVisible = true;
            this.YuhMinimizedVisible = true;
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UC_Mau uC_Mau1;
        private System.Windows.Forms.Label label1;
    }
}