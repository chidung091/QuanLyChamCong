using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DAL;
namespace QuanLyChamCong.BUS
{
    class BUS_MatKhau
    {
        DAL_MatKhau dalTL;
         public BUS_MatKhau()
        {
            dalTL = new DAL_MatKhau();
        }
        public bool ooKiemTraKetNoi()
        {
            return dalTL.ooKiemTraKetNoi();
        }
        public int UpdateThietLap(string tendn, string mk)
        {
            return dalTL.UpdateTL(tendn, mk);
        }
        public int GetPass(string pass)
        {
            return dalTL.GetPass(pass);
        }
        public int GetTenDangNhap(string tendn)
        {
            return dalTL.GetTenDangNhap(tendn);
        }
    }
}
