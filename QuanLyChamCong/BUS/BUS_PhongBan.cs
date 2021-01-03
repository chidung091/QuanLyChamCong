using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DAL;
namespace QuanLyChamCong.BUS
{
    class BUS_PhongBan
    {
        DAL_PhongBan dalPB;
        public BUS_PhongBan()
        {
            dalPB = new DAL_PhongBan();
        }
        public bool ooKiemTraKetNoi()
        {
            return dalPB.ooKiemTraKetNoi();
        }
        public DataTable LoadPB()
        {
            return dalPB.LoadPB();
        }
        public int ooDeletePhongBan(string MaPB)
        {
            return dalPB.ooDeletePB(MaPB);
        }

        public int ooUpdatePhongBan(string MaPB, string TenPB)
        {
            return dalPB.ooUpdatePB(MaPB, TenPB);
        }
        public int ooInsertPhongBan(string MaPB, string TenPB)
        {
            return dalPB.ooInsertPB(MaPB, TenPB);
        }
    }
}
