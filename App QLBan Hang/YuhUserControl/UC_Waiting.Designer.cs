namespace App_QLBan_Hang
{
    partial class UC_Waiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Waiting));
            this.lb_deltail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cWaiting = new App_QLBan_Hang.CT_Waiting();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_deltail
            // 
            this.lb_deltail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_deltail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_deltail.Location = new System.Drawing.Point(12, 211);
            this.lb_deltail.Name = "lb_deltail";
            this.lb_deltail.Size = new System.Drawing.Size(312, 75);
            this.lb_deltail.TabIndex = 0;
            this.lb_deltail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cWaiting);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 141);
            this.panel1.TabIndex = 1;
            // 
            // cWaiting
            // 
            this.cWaiting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cWaiting.animated = true;
            this.cWaiting.animationIterval = 2;
            this.cWaiting.animationSpeed = 1;
            this.cWaiting.BackColor = System.Drawing.Color.Transparent;
            this.cWaiting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cWaiting.BackgroundImage")));
            this.cWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cWaiting.ForeColor = System.Drawing.Color.SeaGreen;
            this.cWaiting.LabelVisible = false;
            this.cWaiting.LineProgressThickness = 8;
            this.cWaiting.LineThickness = 5;
            this.cWaiting.Location = new System.Drawing.Point(100, 23);
            this.cWaiting.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cWaiting.MaxValue = 100;
            this.cWaiting.Name = "cWaiting";
            this.cWaiting.ProgressBackColor = System.Drawing.Color.Transparent;
            this.cWaiting.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cWaiting.Size = new System.Drawing.Size(109, 109);
            this.cWaiting.TabIndex = 0;
            this.cWaiting.Value = 35;
            // 
            // UC_Waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_deltail);
            this.Name = "UC_Waiting";
            this.Size = new System.Drawing.Size(334, 304);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_deltail;
        private System.Windows.Forms.Panel panel1;
        private CT_Waiting cWaiting;
    }
}