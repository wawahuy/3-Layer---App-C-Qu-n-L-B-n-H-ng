using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBan_Hang.Dashboard
{
    public partial class UCNhanVien : UserControl
    {
        public static UCNhanVien CurrentShow;

        Color PASS_COLOR = Color.FromArgb(199, 199, 199);
        Color ACTI_COLOR = Color.DimGray;

        public UCNhanVien()
        {
            InitializeComponent();
            llb_danhsach_LinkClicked(llb_danhsach, null);
            CurrentShow = this;
        }

        Label lableCurrent;
        Color oldColor;
        private void selectColor(object sender, Color cl)
        {
            if (lableCurrent != null) 
                setFullColor(lableCurrent, oldColor);
            oldColor = cl;
            lableCurrent = (Label)sender;
            setFullColor(sender, Color.DarkBlue);
        }

        private void setFullColor(object control, Color cl)
        {
            ((Control)control).ForeColor = cl;
            if (control is LinkLabel)
            {
                LinkLabel llb = (LinkLabel)control;
                llb.LinkColor = cl;
            }
        }


        private void llb_danhsach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_DanhSach());
            selectColor(sender, ACTI_COLOR);
        }

        private void llb_themnhanvien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectColor(sender, ACTI_COLOR);
        }

        public void xemThongTin(DTO.DTONhanVien nhanvien)
        {
            transitionPage.openGUI(new Dashboard.NhanVien.UC_NV_Xem(nhanvien));
            selectColor(label_xemnv, PASS_COLOR);
        }

    }
}
