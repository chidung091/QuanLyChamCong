using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyChamCong.DTO;
using QuanLyChamCong.DAL;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyChamCong.BUS
{
    public class BUS_QLNhanVien
    {
        DAL_QLNhanVien dal_qlnv = new DAL_QLNhanVien();
        public DataTable Load_PhongBan()
        {
            return dal_qlnv.Load_PhongBan();
        }

        public DataTable Load_ChucVu()
        {
            return dal_qlnv.Load_ChucVu();
        }

        public DataTable Load_NhanVien()
        {
            return dal_qlnv.Load_NhanVien();
        }
        public int Them_NhanVien(QL_NhanVien pNhanVien)
        {
            return dal_qlnv.Them_NhanVien(pNhanVien);
        }
        public int Sua_NhanVien(QL_NhanVien pNhanVien)
        {
            return dal_qlnv.Sua_NhanVien(pNhanVien);
        }
        public int Xoa_NhanVien(QL_NhanVien pNhanVien)
        {
            return dal_qlnv.Xoa_NhanVien(pNhanVien);
        }
        public bool KT_NV(string pNhanVien)
        {
            return dal_qlnv.KT_NV(pNhanVien);
        }
        public int KTtontai(string ma)
        {
            return dal_qlnv.KTtontai(ma);
        }
    }
}
