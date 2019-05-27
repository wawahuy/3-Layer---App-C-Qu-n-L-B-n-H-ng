using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSKhachHang
    {

        public int xoa(DataGridViewSelectedRowCollection rows)
        {
            int soDongXoa = 0;
            foreach (DataGridViewRow row in rows)
            {
                DTO.DTOKhachHang kh = (DTO.DTOKhachHang)row.DataBoundItem;
                DAO.DAOKhachHang daokh = new DAO.DAOKhachHang();
                soDongXoa += daokh.Xoa(kh) ? 1 : 0;
            }
            return soDongXoa;
        }

        public bool xoa(DTO.DTOKhachHang kh)
        {
            return new DAO.DAOKhachHang().Xoa(kh);
        }

        public bool them(DTO.DTOKhachHang nv)
        {
            return new DAO.DAOKhachHang().Them(nv);
        }


        public bool sua(DTO.DTOKhachHang kh)
        {
            return new DAO.DAOKhachHang().Sua(kh);
        }

        public bool tonTaiCMND(string cmnd)
        {
            return new DAO.DAOKhachHang().layKhachHangQuaCMND(cmnd).Count > 0;
        }


        public List<DTO.DTOKhachHang> layHetKhachHang()
        {
            return new DAO.DAOKhachHang().Lay();
        }

        //0 Nam , 1 Nữ
        public List<DTO.DTOKhachHang> TimTheoGioiTinh(bool gioitinh)
        {
            return new DAO.DAOKhachHang().TimKH_GioiTinh(gioitinh);
        }


        public List<DTO.DTOKhachHang> TimTheoTen(string tennv)
        {
            return new DAO.DAOKhachHang().TimKH_Ten(tennv);
        }

        public List<DTO.DTOKhachHang> TimTheoCMND(string cmnd)
        {
            return new DAO.DAOKhachHang().TimKH_CMND(cmnd);
        }

        public List<DTO.DTOKhachHang> TimTheoSDT(string sdt)
        {
            return new DAO.DAOKhachHang().TimKH_SDT(sdt);
        }

    }
}
