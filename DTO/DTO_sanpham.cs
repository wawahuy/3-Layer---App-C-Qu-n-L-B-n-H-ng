using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_sanpham
    {
        private int _masp;
        private string _tensp;
        private int _gia;
        private int _malsp;

        public int masp
        {
            get
            {
                return _masp;
            }
            set
            {
                _masp = value;
            }
        }
        public string tensp
        {
            get
            {
                return _tensp;
            }
            set
            {
                _tensp = value;
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
        public int malsp
        {
            get
            {
                return _malsp;
            }
            set
            {
                _malsp = value;
            }
        }

        public DTO_sanpham()
        {

        }

        public DTO_sanpham(int masp, string tensp, int gia, int malsp)
        {
            this._masp = masp;
            this._tensp = tensp;
            this._gia = gia;
            this._malsp = malsp;
        }
    }
}
