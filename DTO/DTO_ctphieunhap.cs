using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ctphieunhap
    {
        private int _mapn;
        private int _mactsp;
        private int _soluong;
        private int _gia;
        private int _thanhtien;
        

        public int mapn
        {
            get
            {
                return _mapn;
            }
            set
            {
                _mapn = value;
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
                _gia= value;
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
        

        public DTO_ctphieunhap()
        {

        }
        public DTO_ctphieunhap(int mapn, int thanhtien, int gia, int soluong, int mactsp )
        {
            this._mapn = mapn;
            this._thanhtien = thanhtien;
            this._gia = gia;
            this._thanhtien = thanhtien;
            this._soluong = soluong;
            this._mactsp = mactsp;
             
        }
    }
}
