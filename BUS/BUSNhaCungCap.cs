using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSNhaCungCap
    {

        public int xoa(DataGridViewSelectedRowCollection rows)
        {
            int soDongXoa = 0;
            foreach (DataGridViewRow row in rows)
            {
                DTO.DTONhaCungCap ncc = (DTO.DTONhaCungCap)row.DataBoundItem;
                DAO.DAONhaCungCap daoncc = new DAO.DAONhaCungCap();
                soDongXoa += daoncc.Xoa(ncc) ? 1 : 0;
            }
            return soDongXoa;
        }

        public bool xoa(DTO.DTONhaCungCap ncc)
        {
            return new DAO.DAONhaCungCap().Xoa(ncc);
        }

        public bool them(DTO.DTONhaCungCap ncc)
        {
            return new DAO.DAONhaCungCap().Them(ncc);
        }


        public bool sua(DTO.DTONhaCungCap kh)
        {
            return new DAO.DAONhaCungCap().Sua(kh);
        }



        public bool tonTaiTen(string cmnd)
        {
            return new DAO.DAONhaCungCap().layNCCQuaTen(cmnd).Count > 0;
        }


        public List<DTO.DTONhaCungCap> layHeNhaCungCap()
        {
            return new DAO.DAONhaCungCap().Lay();
        }




        public List<DTO.DTONhaCungCap> TimTheoTen(string tennv)
        {
            return new DAO.DAONhaCungCap().TimKH_Ten(tennv);
        }



        public List<DTO.DTONhaCungCap> TimTheoSDT(string sdt)
        {
            return new DAO.DAONhaCungCap().TimKH_SDT(sdt);
        }

        public List<DTO.DTONhaCungCap> TimTheoDiaChi(string diachi)
        {
            return new DAO.DAONhaCungCap().TimKH_DiaChi(diachi);
        }

    }
}
