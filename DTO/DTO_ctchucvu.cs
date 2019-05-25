using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ctchucvu
    {
        private int _maquyen;
        private int _machucvu;

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
        public int machucvu
        {
            get
            {
                return _machucvu;
            }
            set
            {
                _machucvu = value;
            }
        }
        public DTO_ctchucvu()
        {

        }
        public DTO_ctchucvu(int maquyen, int machucvu)
        {
            this._maquyen = maquyen;
            this._machucvu = machucvu;
        }
    }
}
