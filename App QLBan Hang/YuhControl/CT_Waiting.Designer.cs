namespace App_QLBan_Hang
{
    partial class CT_Waiting
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
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            //this.SuspendLayout();

            // 
            // bp_process
            // 
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animated = true;
            this.animationIterval = 2;
            this.animationSpeed = 1;
            this.AutoSize = false;
            this.BackColor = System.Drawing.Color.Transparent;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CT_Waiting));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundImage")));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.LabelVisible = false;
            this.LineProgressThickness = 8;
            this.LineThickness = 5;
            this.Location = new System.Drawing.Point(34, 117);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaxValue = 100;
            this.Name = "bp_process";
            this.ProgressBackColor = System.Drawing.Color.Transparent;
            this.ProgressColor = System.Drawing.Color.SeaGreen;
            this.Size = new System.Drawing.Size(81, 81);
            this.TabIndex = 0;
            this.Value = 40;

            // 
            // timerProcess
            // 
            this.timerProcess.Interval = 30;
            this.timerProcess.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCWaiting
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.Color.Transparent;

            //this.Name = "UCWaiting";
            //this.Size = new System.Drawing.Size(170, 170);
            //this.ResumeLayout(false);
            //this.PerformLayout();




        }

        #endregion

        private System.Windows.Forms.Timer timerProcess;
    }
}
