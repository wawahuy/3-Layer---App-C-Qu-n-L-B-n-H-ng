using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ncc
    {
        private int _mancc;
        private string _tenncc;
        private string _diachi;
        private string _sdt;

        public int mancc
        {
            get
            {
                return _mancc;
            }
            set
            {
                _mancc = value;
            }
        }
        public string tenncc
        {
            get
            {
                return _tenncc;
            }
            set
            {
                _tenncc = value;
            }
        }
        
        public string diachi
        {
            get
            {
                return _diachi;
            }
            set
            {
                _diachi = value;
            }
        }
        public string sdt
        {
            get
            {
                return _sdt;
            }
            set
            {
                _sdt = value;
            }
        }
        public DTO_ncc()
        {

        }
        public DTO_ncc(int mancc, string tenncc, string diachi, string sdt)
        {
            this._mancc = mancc;
            this._tenncc = tenncc;
            this._diachi = diachi;
            this._sdt = sdt;
        }

    }
}
