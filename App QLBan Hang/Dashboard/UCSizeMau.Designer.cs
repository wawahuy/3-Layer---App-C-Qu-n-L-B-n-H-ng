namespace App_QLBan_Hang.Dashboard
{
    partial class UCSizeMau
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transitionPage = new App_QLBan_Hang.Yuh.TransitionPage(this.components);
            this.uC_Mau1 = new App_QLBan_Hang.Dashboard.SizeMau.UC_Mau();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(53, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách kích thước";
            // 
            // transitionPage
            // 
            this.transitionPage.Yuh_Anim_type = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transitionPage.Yuh_interval = 1;
            this.transitionPage.Yuh_Panel_main = null;
            this.transitionPage.Yuh_timemax = 500;
            // 
            // uC_Mau1
            // 
            this.uC_Mau1.Location = new System.Drawing.Point(53, 0);
            this.uC_Mau1.Name = "uC_Mau1";
            this.uC_Mau1.Size = new System.Drawing.Size(822, 315);
            this.uC_Mau1.TabIndex = 2;
            // 
            // UCSizeMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Mau1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCSizeMau";
            this.Size = new System.Drawing.Size(916, 665);
            this.ResumeLayout(false);

        }

        #endregion
        private Yuh.TransitionPage transitionPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private SizeMau.UC_Mau uC_Mau1;
    }
}
