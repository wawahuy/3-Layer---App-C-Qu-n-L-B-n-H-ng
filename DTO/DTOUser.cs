using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOUser
    {
        private int _maKH;
        private string _tenKH;
        private string _diachi;
        private bool _gtinh;
        private string _cmnd;
        private DateTime _ngaysinh;
        private int _diem;

        private DTOPermission permission;
        public int maKH
        {
            get
            {
                return _maKH;
            }
            set
            {
                _maKH = value;
            }
        }
        public string tenKH
        {
            get
            {
                return _tenKH;
            }
            set
            {
                _tenKH = value;
            }
        }
        public string diachi
        {
            get
            {
                return _diachi;
            }
            set
            {
                _diachi = value;
            }
        }
        public bool gtinh
        {
            get
            {
                return _gtinh;
            }
            set
            {
                _gtinh = value;
            }
        }
        public string cmnd
        {
            get
            {
                return _cmnd;
            }
            set
            {
                _cmnd = value;
            }
        }
        public DateTime ngaysinh
        {
            get
            {
                return _ngaysinh;
            }
            set
            {
                _ngaysinh = value;
            }
        }
        public int diem
        {
            get
            {
                return _diem;
            }
            set
            {
                _diem = value;
            }
        }
        public DTOUser()
        {

        }
        public DTOUser(int makh, string tenkh, string diachi, Boolean gioitinh, string cmnd, DateTime ngaysinh, int diem)
        {
            this._maKH = makh;
            this._tenKH = tenkh;
            this._diachi = diachi;
            this._gtinh = gioitinh;
            this._cmnd = cmnd;
            this._ngaysinh = ngaysinh;
            this._diem = diem;
        }
    }
}
