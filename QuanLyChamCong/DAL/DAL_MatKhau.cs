using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamCong.DAL
{
    class DAL_MatKhau:SQLConnection
    {
        SQLConnection con;
        public DAL_MatKhau()
        {
            con = new SQLConnection();
        }

        public bool ooKiemTraKetNoi()
        {
            return con.Open();
        }
        public int UpdateTL(string tendn, string mk)
        {
            return con.ooUpdate("QL_NguoiDung", "where TenDangNhap='" + tendn + "'", "MatKhau", mk);
        }

        public int GetPass(String pass)
        {
            DataRow dr = con.ExcuteDataRow("select MatKhau from QL_NguoiDung where MatKhau='" + pass + "'");
            if (dr != null)
                return int.Parse(dr[0].ToString());
            return -1;
        }
        public int GetTenDangNhap(String tendn)
        {
            DataRow dr = con.ExcuteDataRow("select TenDangNhap from QL_NguoiDung where TenDangNhap='" + tendn + "'");
            if (dr != null)
                return int.Parse(dr[0].ToString());
            return -1;
        }
    }
}
