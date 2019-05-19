using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_chucvu
    {
        private int _macv;
        private string _tencv;


        public int macv
        {
            get
            {
                return _macv;
            }
            set
            {
                _macv = value;
            }
        }
        public string tencv
        {
            get
            {
                return _tencv;
            }
            set
            {
                _tencv = value;
            }
        }
        public DTO_chucvu()
        {

        }

        public DTO_chucvu(int macv, string tencv)
        {
            this._macv = macv;
            this._tencv = tencv;
        }
    }
   
}
