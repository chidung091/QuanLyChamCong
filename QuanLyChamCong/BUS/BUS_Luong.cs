using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
   public class BUS_Luong
    {

       DAL_Luong _dal;
        public BUS_Luong()
       {
           _dal = new DAL_Luong();
       }
        public DataTable Load_PhongBan()
        {
            return _dal.Load_PhongBan();
        }

        public DataTable Load_NhanVien()
        {
            return _dal.Load_NhanVien();
        }
        public int Update_ALL()
        {
            return _dal.Update_ALL();
        }
        public bool KT_SV(string pMaNV)
        {
            return _dal.KT_NV(pMaNV);
        }


        public int Luu(TinhLuong pLuong)
        {
            return _dal.Luu(pLuong);
        }

        public int KTTonTai(string ma)
        {
            return _dal.KTTonTai(ma);
        }
    }
}
