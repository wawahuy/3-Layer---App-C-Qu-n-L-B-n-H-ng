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

    }
}
