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
            this.uC_Mau1 = new App_QLBan_Hang.Dashboard.SizeMau.UC_Mau();
            this.transitionPage = new App_QLBan_Hang.Yuh.TransitionPage(this.components);
            this.uC_KichCo1 = new App_QLBan_Hang.Dashboard.SizeMau.UC_KichCo();
            this.SuspendLayout();
            // 
            // uC_Mau1
            // 
            this.uC_Mau1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Mau1.Location = new System.Drawing.Point(0, 0);
            this.uC_Mau1.Name = "uC_Mau1";
            this.uC_Mau1.Size = new System.Drawing.Size(913, 324);
            this.uC_Mau1.TabIndex = 0;
            // 
            // transitionPage
            // 
            this.transitionPage.Yuh_Anim_type = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transitionPage.Yuh_interval = 1;
            this.transitionPage.Yuh_Panel_main = null;
            this.transitionPage.Yuh_timemax = 500;
            // 
            // uC_KichCo1
            // 
            this.uC_KichCo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_KichCo1.Location = new System.Drawing.Point(0, 338);
            this.uC_KichCo1.Name = "uC_KichCo1";
            this.uC_KichCo1.Size = new System.Drawing.Size(916, 324);
            this.uC_KichCo1.TabIndex = 1;
            // 
            // UCSizeMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_KichCo1);
            this.Controls.Add(this.uC_Mau1);
            this.Name = "UCSizeMau";
            this.Size = new System.Drawing.Size(916, 665);
            this.ResumeLayout(false);

        }

        #endregion
        private Yuh.TransitionPage transitionPage;
        private SizeMau.UC_Mau uC_Mau1;
        private SizeMau.UC_KichCo uC_KichCo1;
    }
}
