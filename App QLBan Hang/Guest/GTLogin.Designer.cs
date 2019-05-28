namespace App_QLBan_Hang.UCGuest
{
    partial class GTLogin
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
            this.txb_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txb_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_login = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_thongbao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_username
            // 
            this.txb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_username.HintForeColor = System.Drawing.Color.Empty;
            this.txb_username.HintText = "Tài khoản";
            this.txb_username.isPassword = false;
            this.txb_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.txb_username.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.txb_username.LineThickness = 3;
            this.txb_username.Location = new System.Drawing.Point(139, 208);
            this.txb_username.Margin = new System.Windows.Forms.Padding(4);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(370, 44);
            this.txb_username.TabIndex = 2;
            this.txb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txb_password
            // 
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_password.HintForeColor = System.Drawing.Color.Empty;
            this.txb_password.HintText = "Mật khẩu";
            this.txb_password.isPassword = true;
            this.txb_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.txb_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txb_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.txb_password.LineThickness = 3;
            this.txb_password.Location = new System.Drawing.Point(139, 281);
            this.txb_password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(370, 44);
            this.txb_password.TabIndex = 3;
            this.txb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txb_password.OnValueChanged += new System.EventHandler(this.txb_password_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::App_QLBan_Hang.Properties.Resources.icons8_male_user_filled_100;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_QLBan_Hang.Properties.Resources.icons8_lock_50;
            this.pictureBox2.Location = new System.Drawing.Point(92, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::App_QLBan_Hang.Properties.Resources.icons8_user_male_50;
            this.pictureBox3.Location = new System.Drawing.Point(92, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.Image = global::App_QLBan_Hang.Properties.Resources.icons8_enter_100;
            this.btn_login.ImageActive = null;
            this.btn_login.Location = new System.Drawing.Point(272, 388);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(45, 45);
            this.btn_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_login.TabIndex = 8;
            this.btn_login.TabStop = false;
            this.btn_login.Zoom = 10;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_thongbao.Location = new System.Drawing.Point(89, 151);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(420, 37);
            this.lb_thongbao.TabIndex = 9;
            this.lb_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GTLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Name = "GTLogin";
            this.Size = new System.Drawing.Size(587, 505);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txb_password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton btn_login;
        private System.Windows.Forms.Label lb_thongbao;
    }
}
