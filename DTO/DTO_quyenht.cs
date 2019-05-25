using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_quyenht
    {
        private int _maquyen;
        private string _tenquyen;

        public int maquyen
        {
            get 
            {
                return _maquyen;
            }
            set
            {
                _maquyen = value;
            }
        }
        public string tenquyen
        {
            get
            {
                return _tenquyen;

            }
            set
            {
                _tenquyen = value;
            }
        }
        public DTO_quyenht()
        {

        }
        public DTO_quyenht(int maquyen, string tenquyen)
        {
            this._maquyen =  maquyen;
            this._tenquyen =  tenquyen;
        }
    }
}
