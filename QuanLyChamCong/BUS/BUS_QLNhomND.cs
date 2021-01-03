using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DAL;
using QuanLyChamCong.DTO;
namespace QuanLyChamCong.BUS
{
    class BUS_QLNhomND
    {
        DAL_QLNhomND dalNhomND = new DAL_QLNhomND();
        public int Them(QL_NhomND pNhomND)
        {
            return dalNhomND.Them(pNhomND);
        }
        public int Xoa(QL_NhomND pNhomND)
        {
            return dalNhomND.Xoa(pNhomND);
        }
        public int Sua(QL_NhomND pNhomND)
        {
            return dalNhomND.Sua(pNhomND);
        }
        public DataTable Load_NhomND()
        {
            return dalNhomND.Load_NhomND();
        }
    }
}
