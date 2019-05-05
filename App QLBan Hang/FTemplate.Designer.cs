namespace App_QLBan_Hang
{
    partial class FTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTemplate));
            this.panel_title = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.pn_exitmin = new System.Windows.Forms.Panel();
            this.panel_minimized = new System.Windows.Forms.Panel();
            this.pb_min = new System.Windows.Forms.PictureBox();
            this.panel_maximized = new System.Windows.Forms.Panel();
            this.pb_maxi = new System.Windows.Forms.PictureBox();
            this.panel_exit = new System.Windows.Forms.Panel();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            this.pn_exitmin.SuspendLayout();
            this.panel_minimized.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_min)).BeginInit();
            this.panel_maximized.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maxi)).BeginInit();
            this.panel_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_title.Controls.Add(this.lb_title);
            this.panel_title.Controls.Add(this.pb_title);
            this.panel_title.Controls.Add(this.pn_exitmin);
            this.panel_title.Controls.Add(this.panel1);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(1, 1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(726, 33);
            this.panel_title.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(97)))), ((int)(((byte)(104)))));
            this.lb_title.Location = new System.Drawing.Point(42, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lb_title.Size = new System.Drawing.Size(349, 33);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "YUH";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_title
            // 
            this.pb_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_title.Image = global::App_QLBan_Hang.Properties.Resources.icons8_small_business_161;
            this.pb_title.Location = new System.Drawing.Point(10, 0);
            this.pb_title.Name = "pb_title";
            this.pb_title.Size = new System.Drawing.Size(32, 33);
            this.pb_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_title.TabIndex = 2;
            this.pb_title.TabStop = false;
            // 
            // pn_exitmin
            // 
            this.pn_exitmin.Controls.Add(this.panel_minimized);
            this.pn_exitmin.Controls.Add(this.panel_maximized);
            this.pn_exitmin.Controls.Add(this.panel_exit);
            this.pn_exitmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_exitmin.Location = new System.Drawing.Point(589, 0);
            this.pn_exitmin.Name = "pn_exitmin";
            this.pn_exitmin.Size = new System.Drawing.Size(137, 33);
            this.pn_exitmin.TabIndex = 1;
            // 
            // panel_minimized
            // 
            this.panel_minimized.Controls.Add(this.pb_min);
            this.panel_minimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_minimized.Location = new System.Drawing.Point(38, 0);
            this.panel_minimized.Name = "panel_minimized";
            this.panel_minimized.Size = new System.Drawing.Size(33, 33);
            this.panel_minimized.TabIndex = 2;
            // 
            // pb_min
            // 
            this.pb_min.Image = global::App_QLBan_Hang.Properties.Resources.icons8_minimize_window_16;
            this.pb_min.Location = new System.Drawing.Point(16, 8);
            this.pb_min.Name = "pb_min";
            this.pb_min.Size = new System.Drawing.Size(16, 16);
            this.pb_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_min.TabIndex = 1;
            this.pb_min.TabStop = false;
            this.pb_min.Click += new System.EventHandler(this.pb_min_Click);
            this.pb_min.MouseLeave += new System.EventHandler(this.pb_min_MouseLeave);
            this.pb_min.MouseHover += new System.EventHandler(this.pb_min_MouseHover);
            // 
            // panel_maximized
            // 
            this.panel_maximized.Controls.Add(this.pb_maxi);
            this.panel_maximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_maximized.Location = new System.Drawing.Point(71, 0);
            this.panel_maximized.Name = "panel_maximized";
            this.panel_maximized.Size = new System.Drawing.Size(33, 33);
            this.panel_maximized.TabIndex = 1;
            // 
            // pb_maxi
            // 
            this.pb_maxi.Image = global::App_QLBan_Hang.Properties.Resources.icons8_maximize_window_16;
            this.pb_maxi.Location = new System.Drawing.Point(12, 8);
            this.pb_maxi.Name = "pb_maxi";
            this.pb_maxi.Size = new System.Drawing.Size(16, 16);
            this.pb_maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_maxi.TabIndex = 2;
            this.pb_maxi.TabStop = false;
            this.pb_maxi.Click += new System.EventHandler(this.pb_maxi_Click);
            this.pb_maxi.MouseLeave += new System.EventHandler(this.pb_maxi_MouseLeave);
            this.pb_maxi.MouseHover += new System.EventHandler(this.pb_maxi_MouseHover);
            // 
            // panel_exit
            // 
            this.panel_exit.Controls.Add(this.pb_exit);
            this.panel_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_exit.Location = new System.Drawing.Point(104, 0);
            this.panel_exit.Name = "panel_exit";
            this.panel_exit.Size = new System.Drawing.Size(33, 33);
            this.panel_exit.TabIndex = 0;
            // 
            // pb_exit
            // 
            this.pb_exit.Image = global::App_QLBan_Hang.Properties.Resources.icons8_close_window_filled_16;
            this.pb_exit.Location = new System.Drawing.Point(5, 8);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(16, 16);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_exit.TabIndex = 0;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            this.pb_exit.MouseHover += new System.EventHandler(this.pb_exit_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 33);
            this.panel1.TabIndex = 4;
            // 
            // FTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(728, 474);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTemplate";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FormTemplate";
            this.Load += new System.EventHandler(this.FTemplate_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FTemplate_ControlAdded);
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            this.pn_exitmin.ResumeLayout(false);
            this.panel_minimized.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_min)).EndInit();
            this.panel_maximized.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_maxi)).EndInit();
            this.panel_exit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel pn_exitmin;
        private System.Windows.Forms.PictureBox pb_min;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_maxi;
        private System.Windows.Forms.Panel panel_minimized;
        private System.Windows.Forms.Panel panel_maximized;
        private System.Windows.Forms.Panel panel_exit;
    }
}