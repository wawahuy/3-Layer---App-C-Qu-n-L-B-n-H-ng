using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_cthoadon
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
        public int soluong
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
        public DTO_cthoadon()
        {

        }
        public DTO_cthoadon(int mahd, int mactsp, int gia, int soluong, int thanhtien)
        {
            this._mahd = mahd;
            this._mactsp = mactsp;
            this._gia = gia;
            this._thanhtien = thanhtien;
            this._soluong = soluong;
        }
    }
}
