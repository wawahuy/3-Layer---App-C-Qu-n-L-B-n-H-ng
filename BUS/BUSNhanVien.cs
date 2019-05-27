using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSNhanVien
    {

        public DTO.DTONhanVien DangNhap(string taikhoan, string matkhau, ref string thongbao)
        {
            if(taikhoan == "")
            {
                thongbao = "Vui lòng nhập tài khoản!";
                return null;
            }

            if (matkhau == "")
            {
                thongbao = "Vui lòng nhập tài mật khẩu!";
                return null;
            }

            DTO.DTONhanVien nv = new DAO.DAONhanVien().LayVoiTK(taikhoan, matkhau);
            if(nv == null)
            {
                thongbao = "Sai tài khoản hoặc mật khẩu!";
            }

            return nv;
        }



        public int xoaNhanVien(DataGridViewSelectedRowCollection rows)
        {
            int soDongXoa = 0;
            foreach (DataGridViewRow row in rows)
            {
                DTO.DTONhanVien nv = (DTO.DTONhanVien)row.DataBoundItem;
                DAO.DAONhanVien daonv = new DAO.DAONhanVien();
                soDongXoa += daonv.Xoa(nv) ? 1 : 0;
            }

            return soDongXoa;
        }



        public List<DTO.DTONhanVien> layHetNhanVien()
        {
            return new DAO.DAONhanVien().Lay();
        }


        public bool them(DTO.DTONhanVien nv)
        {
            return new DAO.DAONhanVien().Them(nv);
        }


        public bool sua(DTO.DTONhanVien nv)
        {
            return new DAO.DAONhanVien().Sua(nv);
        }


        public bool xoaNhanVien(DTO.DTONhanVien nv)
        {
            return new DAO.DAONhanVien().Xoa(nv);
        }


        public bool tonTaiTaiKhoan(string tk)
        {
            return new DAO.DAONhanVien().LayVoiTenTK(tk) != null;
        }


        public List<DTO.DTONhanVien> TimTheoChucVu(string chucvu)
        {
            return new DAO.DAONhanVien().TimNV_ChucVu(chucvu);
        }

        //0 Nam , 1 Nữ
        public List<DTO.DTONhanVien> TimTheoGioiTinh(bool gioitinh)
        {
            return new DAO.DAONhanVien().TimNV_GioiTinh(gioitinh);
        }


        public List<DTO.DTONhanVien> TimTheoTaiKhoan(string tentaikhoan)
        {
            return new List<DTO.DTONhanVien>() { new DAO.DAONhanVien().LayVoiTenTK(tentaikhoan) };
        }

        public List<DTO.DTONhanVien> TimTheoTen(string tennv)
        {
            return new DAO.DAONhanVien().TimNV_Ten(tennv);
        }

        public List<DTO.DTONhanVien> TimTheoCMND(string cmnd)
        {
            return new DAO.DAONhanVien().TimNV_CMND(cmnd);
        }

        public List<DTO.DTONhanVien> TimTheoSDT(string sdt)
        {
            return new DAO.DAONhanVien().TimNV_SDT(sdt);
        }

    }
}
