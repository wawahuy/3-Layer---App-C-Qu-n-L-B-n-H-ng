using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_hoadon
    {
        private int _mahd;
        private DateTime _ngaylap;
        private int _thanhtien;
        private int _thue;
        private int _manv;
        private int _makh;

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
        public int manv
        {
            get
            {
                return _manv;
            }
            set
            {
                _manv = value;
            }
        }
        public int makh
        {
            get
            {
                return _makh;
            }
            set
            {
                _makh = value;
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
        public int thue
        {
            get
            {
                return _thue;
            }
            set
            {
                _thue = value;
            }
        }
        public DateTime ngaylap
        {
            get
            {
                return _ngaylap;
            }
            set
            {
                _ngaylap = value;
            }
        }

        public DTO_hoadon()
        {

        }

        public DTO_hoadon(int mahd, DateTime ngaylap, int thanhtien, int thue, int manv, int makh)
        {
            this._mahd = mahd;
            this._ngaylap = ngaylap;
            this._thanhtien = thanhtien;
            this._thue = thue;
            this._manv = manv;
            this._makh = makh;
        }
    }
}
