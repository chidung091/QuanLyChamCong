using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QuanLyChamCong.DAL
{
    public class DAL_ChamCong
    {
       SQLConnection con;
        public DAL_ChamCong()
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
        public DataTable LoadCTCC(string maphieu)
        {
            return con.ExcuteDataTable("select NgayCong,Ngay,SoGioTangCa,SoGioTre from QL_ChiTietChamCong where MaPhieu="+maphieu +" order by Ngay");
        }
        public DataTable LoadNV(string PhongBan, int Thang, int Nam)
        {
            return con.ExcuteDataTable(@"select a.MaNhanVien, a.HoTen, b.Thang,b.Nam,b.SoNgayChamCong, b.SoGioTangCa, b.SoGioTre
                                        from QL_NhanVien a, QL_ChamCong b
                                        where a.MaNhanVien=b.MaNhanVien and a.MaPhongBan='" + PhongBan + "' and b.Thang='" + Thang + "' and b.Nam='" + Nam + "'");
        }
         public DataTable LoadNV_PB(string MaPhongBan)
        {
            return con.ExcuteDataTable(@"select MaNhanVien, HoTen
                                        from QL_NhanVien 
                                        where MaPhongBan='" + MaPhongBan + "'");
        }

        public int GetMaPhieu(String MaNV,int Nam,int Thang)
        {
            DataRow dr = con.ExcuteDataRow("select MaPhieu from QL_ChamCong where MaNhanVien='"+MaNV+"' and Nam="+Nam+" and Thang="+Thang);
            if (dr != null)
                return int.Parse(dr[0].ToString());
            return -1;
        }
        public int ooInsertCC(string MaNV,int Nam,int Thang,int SoNgayCC,int SoGioTangCa,int SoGioTre)
        {
            return con.ooInsert("QL_ChamCong", "MaNhanVien", MaNV, "Thang", Thang, "Nam", Nam,"SoNgayChamCong",SoNgayCC,"SoGioTangCa",SoGioTangCa,"SoGioTre",SoGioTre);
        }
        public int ooInsertCTCC(int MaPhieu,int _Ngay, bool _NgayCong, int _GioTangCa, int _Giotre)
        {
            return con.ooInsert("QL_ChiTietChamCong","MaPhieu",MaPhieu, "Ngay", _Ngay, "NgayCong", _NgayCong, "SoGioTangCa", _GioTangCa, "SoGioTre", _Giotre);
        }

        // insert Chi tiet cham cong
        public int ooDelCC(int MaPhieu)
        {
            con.ooDelete("QL_ChiTietChamCong", "where MaPhieu=" + MaPhieu);
            return con.ooDelete("Ql_ChamCong", "where MaPhieu=" + MaPhieu );
           
        }
        public int ooUpdateChiTietCC(int MaPhieu, int _Ngay, bool _NgayCong, int _GioTangCa, int _Giotre)
        {
            return con.ooUpdate("QL_ChiTietChamCong", "where MaPhieu='" + MaPhieu + "' and Ngay=" + _Ngay, "NgayCong", _NgayCong, "SoGioTangCa", _GioTangCa, "SoGioTre", _Giotre);
        }

        public int ooDeleteChiTietCC(int MaPhieu, int Ngay)
        {
            return con.ooDelete("QL_ChiTietChamCong", "where MaPhieu='" + MaPhieu + "' and Ngay=" + Ngay);
        }

       
        
        public int ooUpdateCC(int MaPhieu)//tu viet tuong tu
        {
            int giotre = (int)con.ExcuteScale("select isnull(sum(SoGioTre),0) from QL_ChiTietChamCong where MaPhieu=" + MaPhieu + " and NgayCong=1");
            int ngaycong = (int)con.ExcuteScale("select count(*) from QL_ChiTietChamCong where MaPhieu=" + MaPhieu + " and NgayCong=1");
            int giotangca = (int)con.ExcuteScale("select isnull(sum(SoGioTangCa),0) from QL_ChiTietChamCong where MaPhieu=" + MaPhieu + " and NgayCong=1");
            return con.ooUpdate("QL_ChamCong", "where MaPhieu='" + MaPhieu + "'","SoNgayChamCong",ngaycong,"SoGioTangCa",giotangca,"SoGioTre",giotre);
        }
    }
}
