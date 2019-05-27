using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSMau
    {

        public List<DTO.DTOMau> lay()
        {
            return new DAO.DAOMau().Lay();
        }

        public bool them(DTO.DTOMau mau)
        {
            DAO.DAOMau dao = new DAO.DAOMau();

            if(dao.layQuaTen(mau.Ten).Count > 0)
            {
                return false;
            }

            return dao.Them(mau);
        }


        public bool xoa(DTO.DTOMau mau)
        {
            return new DAO.DAOMau().Xoa(mau);
        }


        public bool sua(DTO.DTOMau mau)
        {
            return new DAO.DAOMau().Sua(mau);
        }


        public List<DTO.DTOMau> search(string se)
        {
            return new DAO.DAOMau().timKiemTen(se);
        }

    }
}
