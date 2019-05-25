using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_mausp
    {
        private int _mamau;
        private string _tenmau;

        public int mamau
        {
            get
            {
                return _mamau;
            }
            set
            {
                _mamau = value;
            }
        }
        public string tenmau
        {
            get
            {
                return _tenmau;
            }
            set
            {
                _tenmau = value;
            }
        }
        public DTO_mausp()
        {

        }
        public DTO_mausp(int mamau, string tenmau)
        {
            this._mamau = mamau;
            this._tenmau = tenmau;
        }
    }
}
