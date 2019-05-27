using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace App_QLBan_Hang.Dashboard.KhachHang
{
    public partial class UC_KH_Them : UserControl
    {
        public UC_KH_Them()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO.DTOKhachHang kh = themNhanVien();
            if ( kh != null)
            {
                xoaNoiDungForm();
            }
        }

        private void btn_themvaxem_Click(object sender, EventArgs e)
        {
            DTO.DTOKhachHang kh = themNhanVien();
            if (kh != null)
            {
                UCKhachHang uckh = new UCKhachHang();
                uckh.xemThongTin(kh);
                FDashboard.openUserControl(uckh);
            }
        }


        private DTO.DTOKhachHang themNhanVien()
        {
            if (!checkTextBox())
            {
                MessageBox.Show("Vui lòng kiểm tra tính hợp lệ của thông tin nhập!");
                return null;
            }

            DTO.DTOKhachHang kh = new DTO.DTOKhachHang();
            kh.Ten = txb_hoten.Text;
            kh.Giotinh = txb_gioitinh.selectedIndex == 1;
            kh.Diachi = txb_diachi.Text;
            kh.Sdt = txb_sdt.Text;
            kh.Cmnd = txb_cmnd.Text;
            kh.Ngaysinh = txb_ngaysinh.Value;

            bool status = (new BUS.BUSKhachHang()).them(kh);

            if (!status)
            {
                MessageBox.Show("Thêm khách hàng thất bại!");
                return null;
            } else
            {
                MessageBox.Show("Thêm Khách hàng thành công!");
                return kh;
            }

        }

        private void xoaNoiDungForm()
        {
            txb_cmnd.Text = txb_diachi.Text = txb_hoten.Text =  txb_sdt.Text =   "";
        }

        private void txb_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txb_update_OnValueChanged(object sender, EventArgs e)
        {
            checkTextBox();
        }

        private bool checkTextBox()
        {
            bool complete = true;

            //Kiểm tra họ tên
            lb_hoten.Text = "";
            if (txb_hoten.Text == "")
            {
                complete = false;
            }
            else if (!Regex.IsMatch(txb_hoten.Text, @"\s"))
            {
                lb_hoten.Text = "Vui lòng nhập tên đầy đủ!\r\n";
                complete = false;
            }


            //Kiểm tra địa chỉ
            lb_diachi.Text = "";
            if (txb_diachi.Text == "")
            {
                complete = false;
            }
            else if (!Regex.IsMatch(txb_diachi.Text, @",") || txb_diachi.Text.Length <= 10)
            {
                lb_diachi.Text = "Vui lòng nhập địa chỉ đúng!\r\n";
                complete = false;
            }

            

            lb_gioitinh.Text = "";
            if (txb_gioitinh.selectedIndex == -1)
            {
                lb_gioitinh.Text = "Vui lòng chọn giới tính!\r\n";
                complete = false;
            }


            lb_sdt.Text = "";
            if (txb_sdt.Text == "")
            {
                complete = false;
            }
            else if (!(txb_sdt.Text.Length >=9 && txb_sdt.Text.Length <= 12))
            {
                lb_sdt.Text = "Vui lòng nhập đúng sđt!\r\n";
                complete = false;
            }

            //kiểm tra cmnd
            lb_cmnd.Text = "";
            if (txb_cmnd.Text == "")
            {
                complete = false;
            }
            else if(txb_cmnd.Text.Length < 9 || txb_cmnd.Text.Length >13)
            {
                lb_cmnd.Text = "Vui lòng nhập đúng cmnd!\r\n";
                complete = false;
            }
            else if(new BUS.BUSKhachHang().tonTaiCMND(txb_cmnd.Text))
            {
                lb_cmnd.Text = "CMND này đã được sử dụng!\r\n";
                complete = false;
            }

            return complete;
        }

        private void UC_NV_Them_Load(object sender, EventArgs e)
        {
        }

        private void btn_refer_Click(object sender, EventArgs e)
        {
            xoaNoiDungForm();
        }

        private void txb_gioitinh_onItemSelected(object sender, EventArgs e)
        {
            checkTextBox();
        }
    }
}
