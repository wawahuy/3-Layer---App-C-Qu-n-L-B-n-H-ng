using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_CTHD
    {
        private int _mahd;
        private int _mactsp;
        private int _soluong;
        private int _gia;
        private int _thanhtien;

        public int mahd
        {
            get
            {
                return _mahd;
            }
            set
            {
                _mahd = value;
            }
        }
        public int mactsp
        {
            get
            {
                return _mactsp;
            }
            set
            {
                _mactsp = value;
            }
        }
        public int makh
        {
            get
            {
                return _soluong;
            }
            set
            {
                _soluong = value;
            }
        }
        public int thanhtien
        {
            get
            {
                return _thanhtien;
            }
            set
            {
                _thanhtien = value;
            }
        }
        public int gia
        {
            get
            {
                return _gia;
            }
            set
            {
                _gia = value;
            }
        }
     

        public DTO_CTHD()
        {

        }

        public DTO_CTHD(int mahd, int thanhtien, int mactsp, int gia, int soluong)
        {
            this._mahd = mahd; 
            this._thanhtien = thanhtien;
            this._mactsp = mactsp;
            this._soluong = soluong;
            this._gia = gia;
        }
    }
}
