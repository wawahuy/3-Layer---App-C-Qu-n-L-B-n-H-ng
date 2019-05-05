using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace App_QLBan_Hang
{
    public partial class FTemplate : Form
    {
        public FTemplate()
        {
            InitializeComponent();
            YuhAddCursorMove(this);
            YuhAddCursorMove(panel_title);
            YuhAddCursorMove(pn_exitmin);
            YuhAddCursorMove(lb_title);
            StartPosition = FormStartPosition.CenterScreen;
            Hide();
        }


        private Control yuhControlParent;
        public Control YuhControlParent
        {
            get
            {
                return yuhControlParent;
            }

            set
            {
                yuhControlParent = value;
            }
        }


        public Image YuhIcon
        {
            get { return pb_title.Image; }
            set {
                pb_title.Image = value;
            }
        }


        public bool YuhIconVisible
        {
            get { return pb_title.Visible; }
            set { pb_title.Visible = value; }
        }


        private bool yuhMaximizedVisible = true;
        public bool YuhMaximizedVisible
        {
            get { return yuhMaximizedVisible; }
            set { panel_maximized.Visible = yuhMaximizedVisible = value; }
        }


        private bool yuhMinimizedVisible = true;
        public bool YuhMinimizedVisible
        {
            get { return panel_minimized.Visible; }
            set { panel_minimized.Visible = yuhMinimizedVisible = value; }
        }

        /// <summary>
        /// Title Form
        /// </summary>
        public String YuhText {
            get { return lb_title.Text;  }
            set {
                lb_title.Text = value;
                Text = value;
            }
        }


        /// <summary>
        /// Visible Header title
        /// </summary>
        public bool yuhTitleVisible = true;
        public bool YuhTitleVisible {
            get { return yuhTitleVisible; }
            set { panel_title.Visible = yuhTitleVisible = value; }
        }

        

        /// <summary>
        /// Move window with Border None
        /// </summary>
        protected void YuhAddCursorMove(Control obj)
        {
            obj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseDown);
            obj.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseUp);
            obj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FIX_MouseMove);
        }

        Point mousedownpoint = Point.Empty;

        private void FIX_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void FIX_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty) return;
            Control f = sender as Control;
            this.Location = new Point(this.Location.X + (e.X - mousedownpoint.X), this.Location.Y + (e.Y - mousedownpoint.Y));

        }

        private void FIX_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }


        /// <summary>
        /// Hover PictureBox
        /// </summary>
        /// <param name="pb"></param>
        private void pb_hover(PictureBox pb)
        {
            pb.BackColor = Color.FromArgb(201, 201, 201);
        }

        /// <summary>
        /// Leave PictureBox
        /// </summary>
        /// <param name="pb"></param>
        private void pb_leave(PictureBox pb)
        {
            pb.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pb_min_MouseLeave(object sender, EventArgs e)
        {
            pb_leave(sender as PictureBox);
        }

        private void pb_min_MouseHover(object sender, EventArgs e)
        {
            pb_hover(sender as PictureBox);
        }

        private void pb_exit_MouseHover(object sender, EventArgs e)
        {
            pb_hover(sender as PictureBox);
        }

        private void pb_exit_MouseLeave(object sender, EventArgs e)
        {
            pb_leave(sender as PictureBox);
        }

        private void pb_maxi_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ?
                FormWindowState.Normal : FormWindowState.Maximized;

        }

        private void pb_maxi_MouseHover(object sender, EventArgs e)
        {
            pb_hover(sender as PictureBox);
        }

        private void pb_maxi_MouseLeave(object sender, EventArgs e)
        {
            pb_leave(sender as PictureBox);
        }

        private void FTemplate_ControlAdded(object sender, ControlEventArgs e)
        {
            YuhControlParent = e.Control;
        }

        private void FTemplate_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
