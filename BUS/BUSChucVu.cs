using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSChucVu
    {

        public DTO.DTOChucVu LayChucVuQuaTen(string tenChucVu)
        {
            return (new DAO.DAOChucVu()).LayChucVuQuaTen(tenChucVu);
        }

        public List<DTO.DTOChucVu> layHetChucVu()
        {
            return (new DAO.DAOChucVu()).Lay();
        }

    }
}
