using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamCong.DTO
{
    public class QL_ChamCong
    {
        int _MaPhieu;

        public int MaPhieu
        {
            get { return _MaPhieu; }        
        }

        string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        int _Thang;

        public int Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }

        int _Nam;

        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }

        int _SoNgayCC;

        public int SoNgayCC
        {
            get { return _SoNgayCC; }
            set { _SoNgayCC = value; }
        }

        int _SoGioTangCa;

        public int SoGioTangCa
        {
            get { return _SoGioTangCa; }
            set { _SoGioTangCa = value; }
        }

        int _SoGioTre;

        public int SoGioTre
        {
            get { return _SoGioTre; }
            set { _SoGioTre = value; }
        }
        public QL_ChamCong()
        {
            _MaNV = null;
            _Nam = DateTime.Now.Year;
            _Thang = DateTime.Now.Month;
            _SoNgayCC = 0;
            _SoGioTangCa = 0;
            _SoGioTre = 0;
        }

        public QL_ChamCong(string manv,int ngay,int thang, int ngaycc,int giotangca,int giotre)
        {
            _MaNV = manv;
            _Nam = ngay;
            _Thang =thang;
            _SoNgayCC = ngaycc;
            _SoGioTangCa = giotangca;
            _SoGioTre = giotre;
        }
    }
}
