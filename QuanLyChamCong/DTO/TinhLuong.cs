using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhLuong
    {
        string _MaPhieu;

        public string MaPhieu
        {
            get { return _MaPhieu; }
            set { _MaPhieu = value; }
        }
        string _MaPhong;

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        float _HeSoLuong;

        public float HeSoLuong
        {
            get { return _HeSoLuong; }
            set { _HeSoLuong = value; }
        }

        
        int _LuongCB;

        public int LuongCB
        {
            get { return _LuongCB; }
            set { _LuongCB = value; }
        }

        
        int _LuongTangCa;

        public int LuongTangCa
        {
            get { return _LuongTangCa; }
            set { _LuongTangCa = value; }
        }
        int _HeSoChucVu;

        public int HeSoChucVu
        {
            get { return _HeSoChucVu; }
            set { _HeSoChucVu = value; }
        }
        

        int _SoNgayCong;

        public int SoNgayCong
        {
            get { return _SoNgayCong; }
            set { _SoNgayCong = value; }
        }

        private double _TongLuong;

        public double TongLuong
        {
            get { return _TongLuong; }
            set { _TongLuong = value; }
        }
    }
}
