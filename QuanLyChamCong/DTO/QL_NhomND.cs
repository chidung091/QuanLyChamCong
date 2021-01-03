using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamCong.DTO
{
    class QL_NhomND
    {
        string _MaNhom, _TenNhom, _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        public string TenNhom
        {
            get { return _TenNhom; }
            set { _TenNhom = value; }
        }

        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }
    }
}
