using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DTO;
using QuanLyChamCong.DAL;
using System.Data;
namespace QuanLyChamCong.BUS
{
    class BUS_QLNguoiDung
    {
        DAL_QLNguoiDung dalND = new DAL_QLNguoiDung();
        public int Them(QL_NguoiDung pNguoiDung)
        {
            return dalND.Them(pNguoiDung);
        }
        public int Xoa(QL_NguoiDung pNguoiDung)
        {
            return dalND.Xoa(pNguoiDung);
        }
        public int Sua(QL_NguoiDung pNguoiDung)
        {
            return dalND.Sua(pNguoiDung);
        }
        public DataTable Load_NhomND()
        {
            return dalND.Load_NhomND();
        }
    }
}
