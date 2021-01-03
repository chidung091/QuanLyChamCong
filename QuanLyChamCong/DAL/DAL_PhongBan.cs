using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DTO;

namespace QuanLyChamCong.DAL
{
    class DAL_PhongBan:SQLConnection
    {
        SQLConnection con;
        public DAL_PhongBan()
        {
            con = new SQLConnection();
        }

        public bool ooKiemTraKetNoi()
        {
            return con.Open();
        }

        public DataTable LoadPB()
        {
           return con.ExcuteDataTable("select * from QL_PhongBan");
        }

        public int LayMaPB(String MaPB)
        {
            DataRow dr = con.ExcuteDataRow("select MaPhongBan from QL_PhongBan where MaPhongBan='" + MaPB + "'");
            if (dr != null)
                return int.Parse(dr[0].ToString());
            return -1;
        }

        public int ooInsertPB(string MaPB,string TenPB)
        {
            return con.ooInsert("QL_PhongBan", "MaPhongBan", MaPB , " TenPhongBan", TenPB );
        }
        public int ooDeletePB(string MaPB)
        {
            return con.ooDelete("QL_PhongBan", "where MaPhongBan='" + MaPB + "'");
        }

        public int ooUpdatePB(string MaPB, string TenPB)
        {
            return con.ooUpdate("QL_PhongBan", "where MaPhongBan='" + MaPB +"'","TenPhongBan",TenPB);
        }
    }
}
