using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamCong.DTO
{
    class QL_NguoiDung
    {
        string _TenDangNhap, _MatKhau, _MaNhom;

        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
    }
}
