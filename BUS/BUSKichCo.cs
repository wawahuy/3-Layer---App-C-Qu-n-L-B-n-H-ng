using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSKichCo
    {

        public List<DTO.DTOKichCo> lay()
        {
            return new DAO.DaoKichCo().Lay();
        }

        public bool them(DTO.DTOKichCo mau)
        {
            DAO.DaoKichCo dao = new DAO.DaoKichCo();

            if(dao.layQuaTen(mau.Ten).Count > 0)
            {
                return false;
            }

            return dao.Them(mau);
        }


        public bool xoa(DTO.DTOKichCo mau)
        {
            return new DAO.DaoKichCo().Xoa(mau);
        }


        public bool sua(DTO.DTOKichCo mau)
        {
            return new DAO.DaoKichCo().Sua(mau);
        }


        public List<DTO.DTOKichCo> search(string se)
        {
            return new DAO.DaoKichCo().timKiemTen(se);
        }

    }
}
