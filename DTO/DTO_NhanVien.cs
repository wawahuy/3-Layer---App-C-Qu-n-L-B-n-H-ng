using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_NhanVien
    {
        private int _maNV;
        private string _tenNV;
        private string _diachi;
        private bool _gtinh;
        private string _cmnd;
        private DateTime _ngaysinh;
        private string _taikhoan;
        private string _matkhau;
        private int _luong;
        private DateTime _gianhap;
        private int _macv;


        private DTOPermission permission;
        public int macv
        {
            get
            {
                return _macv;
            }
            set
            {
                _macv = value;
            }
        }
        public DateTime gianhap
        {
            get
            {
                return _gianhap;
            }
            set
            {
                _gianhap = value;
            }
        }
        public int luong
        {
            get
            {
                return _luong;
            }
            set
            {
                _luong = value;
            }
        }
        public string matkhau
        {
            get
            {
                return _matkhau;
            }
            set
            {
                _matkhau = value;
            }
        }
        public string taikhoan
        {
            get
            {   
                return _taikhoan;
            }
            set
            {
                _taikhoan = value;
            }
        }
        public int manv
        {
            get
            {
                return _maNV;
            }
            set
            {
                _maNV = value;
            }
        }
        public string tenNV
        {
            get
            {
                return _tenNV;
            }
            set
            {
                _tenNV = value;
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
      
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(int maNV, string tenNV, string diachi, Boolean gioitinh, string cmnd, DateTime ngaysinh, int macv,DateTime gianhap,string matkhau, string taikhoan, int  luong)
        {
            this._maNV = maNV;
            this._tenNV = tenNV;
            this._diachi = diachi;
            this._gtinh = gioitinh;
            this._cmnd = cmnd;
            this._ngaysinh = ngaysinh;
            this._macv = macv;
            this._gianhap = gianhap;
            this._matkhau = matkhau;
            this._taikhoan = taikhoan;
            this._luong = luong;
             
        }
    }

}
