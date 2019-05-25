using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_loaisp
    {
        private int _malsp;
        private string _tenlsp;
        private string _donvi;

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
        public string tenlsp
        {
            get
            {
                return _tenlsp;
            }
            set
            {
                _tenlsp = value;
            }
        }
        public string donvi
        {
            get
            {
                return _donvi;
            }
            set
            {
                _donvi = value;
            }
        }
        public DTO_loaisp()
        {

        }
        public DTO_loaisp(int malsp, string tenlsp,string donvi)
        {
            this._malsp = malsp;
            this._tenlsp = tenlsp;
            this._donvi = donvi;
        }
    }
}
