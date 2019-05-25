using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_kichcosp
    {
        private int _makc;
        private string _tenkc;

        public int makc
        {
            get
            {
                return _makc;
            }
            set
            {
                _makc = value;
            }
        }
        public string tenkc
        {
            get
            {
                return _tenkc;
            }
            set
            {
                _tenkc = value;
            }
        }
        public DTO_kichcosp()
        {

        }
        public DTO_kichcosp(int makc, string tenkc)
        {
            this._makc = makc;
            this._tenkc = tenkc;
        }
    }
}
