using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DAL;
using System.Data;

namespace QuanLyChamCong.BUS
{
    public class BUS_ChamCong
    {
        DAL_ChamCong dalCC;
        public BUS_ChamCong()
        {
            dalCC = new DAL_ChamCong();
        }
        public bool ooKiemTraKetNoi()
        {
            return dalCC.ooKiemTraKetNoi();
        }
        public DataTable LoadPB()
        {
            return dalCC.LoadPB();
        }
        public DataTable LoadNV(string PhongBan, int Thang, int Nam)
        {
            return dalCC.LoadNV(PhongBan, Thang, Nam);
        }
        public DataTable LoadNV_PB(string MaPhongBan)
        {
            return dalCC.LoadNV_PB(MaPhongBan);
        }
        public int GetMaPhieu(string MaNV, int Nam, int Thang)
        {
            return dalCC.GetMaPhieu(MaNV, Nam, Thang);
        }

        public bool Luu(string MaNV, int Nam, int Thang, int Ngay, int GioTangCa, int GioTre, bool NgayCong)
        {

            int maphieu = dalCC.GetMaPhieu(MaNV, Nam, Thang);
            if (maphieu == -1)
            {
                dalCC.ooInsertCC(MaNV, Nam, Thang, 0, 0, 0);
                maphieu = dalCC.GetMaPhieu(MaNV, Nam, Thang);
            }
            if (dalCC.ooInsertCTCC(maphieu, Ngay, NgayCong, GioTangCa, GioTre) > 0)
            {
                dalCC.ooUpdateCC(maphieu);
                return true;
            }
            return false;
        }

        public bool Sua(string MaNV, int Nam, int Thang, int Ngay, int GioTangCa, int GioTre, bool NgayCong)
        {

            int maphieu = dalCC.GetMaPhieu(MaNV, Nam, Thang);
            if (maphieu > 0)
            {
                maphieu = dalCC.GetMaPhieu(MaNV, Nam, Thang);
                ooUpdateChiTietCC(maphieu, Ngay, NgayCong, GioTangCa, GioTre);
                dalCC.ooUpdateCC(maphieu);
                return true;
            }
            return false;
        }

        public int ooUpdateChiTietCC(int _MaPhieu, int _Ngay, bool _NgayCong, int _GioTangCa, int _Giotre)
        {
            return dalCC.ooUpdateChiTietCC(_MaPhieu, _Ngay, _NgayCong, _GioTangCa, _Giotre);
        }

        public int ooDeleteChiTietCC(int _MaPhieu, int _Ngay)
        {
            return dalCC.ooDeleteChiTietCC(_MaPhieu, _Ngay);
        }
        public int ooDelCC(int _MaPhieu)
        {
            return dalCC.ooDelCC(_MaPhieu);
        }
        public DataTable LoadCTCC(string maphieu)
        {
            return dalCC.LoadCTCC(maphieu);
        }
    }
}
