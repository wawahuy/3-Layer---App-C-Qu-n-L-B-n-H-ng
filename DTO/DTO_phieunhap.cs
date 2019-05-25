using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_phieunhap
    {
        private int _mapn;
        private DateTime _ngaylap;
        private int _thanhtien;
        private int _thue;
        private int _trangthai;
        private int _manv;
        private int _mancc;

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
        public int trangthai
        {
            get
            {
                return _trangthai;
            }
            set
            {
                _trangthai = value;
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

        public DTO_phieunhap()
        {

        }
        public DTO_phieunhap(int mapn, DateTime ngaylap, int thanhtien, int thue, int trangthai, int manv, int mancc)
        {
            this._manv = mapn;
            this._ngaylap = ngaylap;
            this._thanhtien = thanhtien;
            this._thue = thue;
            this._trangthai = trangthai;
            this._manv = manv;
            this._mancc = mancc;
        }
    }
}
