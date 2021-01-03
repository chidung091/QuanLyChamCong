using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyChamCong.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChamCong.DAL
{
    public class DAL_QLNhanVien : SQLConnection
    {
        DataSet ds_QLChamCong = new DataSet();


        public DAL_QLNhanVien()
        {
            string selectString = "select * from QL_NhanVien";
            SqlDataAdapter da_QLNV = new SqlDataAdapter(selectString, cnn);
            da_QLNV.Fill(ds_QLChamCong, "QL_NhanVien");

            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLChamCong.Tables["QL_NhanVien"].Columns[0];
            ds_QLChamCong.Tables["QL_NhanVien"].PrimaryKey = keys;
        }

        public DataTable Load_PhongBan()
        {
            string addpb = "select * from QL_PhongBan";
            SqlDataAdapter da_pb = new SqlDataAdapter(addpb, cnn);
            DataTable dt = new DataTable();
            da_pb.Fill(dt);
            return dt;


        }
        public DataTable Load_ChucVu()
        {
            string addcv = "select * from QL_ChucVu";
            SqlDataAdapter da_cv = new SqlDataAdapter(addcv, cnn);
            DataTable dt = new DataTable();
            da_cv.Fill(dt);
            return dt;

        }
        public DataTable Load_NhanVien()
        {
            string addNhanVien = @"select a.MaNhanVien,a.HoTen,a.NgaySinh,a.DiaChi,a.GioiTinh,a.CMND,a.DienThoai,a.NgayVaoLam,b.TenPhongBan,c.TenChucVu,a.HeSoLuong
                                    from QL_NhanVien a, QL_PhongBan b, QL_ChucVu c 
                                    where a.MaPhongBan=b.MaPhongBan and a.MaChucVu=c.MaChucVu";
            SqlDataAdapter da_gv = new SqlDataAdapter(addNhanVien, cnn);
            DataTable dt = new DataTable();
            da_gv.Fill(dt);
            return dt;

        }

        public int Them_NhanVien(QL_NhanVien pNhanVien)
        {
            try
            {
                SqlDataAdapter sqlda_nv = new SqlDataAdapter("select * from QL_NhanVien", cnn);
                DataRow dr = ds_QLChamCong.Tables["QL_NhanVien"].NewRow();
                dr["MaNhanVien"] = pNhanVien.MaNhanVien;
                dr["HoTen"] = pNhanVien.HoTen;
                dr["NgaySinh"] = pNhanVien.NgaySinh;
                dr["DiaChi"] = pNhanVien.DiaChi;
                dr["GioiTinh"] = pNhanVien.GioiTinh;
                dr["CMND"] = pNhanVien.CMND;
                dr["DienThoai"] = pNhanVien.DienThoai;
                dr["NgayVaoLam"] = pNhanVien.NgayVaoLam;
                dr["MaPhongBan"] = pNhanVien.MaPhongBan;
                dr["MaChucVu"] = pNhanVien.MaChucVu;
                dr["HeSoLuong"] = pNhanVien.HeSoLuong;
                ds_QLChamCong.Tables["QL_NhanVien"].Rows.Add(dr);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_nv);
                sqlda_nv.Update(ds_QLChamCong, "QL_NhanVien");
                return 1;
            }
            catch
            {
                return 0;
            }


        }

        public int Sua_NhanVien(QL_NhanVien pNhanVien)
        {
            try
            {
                SqlDataAdapter sqlda_nv = new SqlDataAdapter("select * from QL_NhanVien", cnn);
                DataRow dr = ds_QLChamCong.Tables["QL_NhanVien"].Rows.Find(pNhanVien.MaNhanVien);
                if (dr != null)
                {
                    dr["HoTen"] = pNhanVien.HoTen;
                    dr["NgaySinh"] = pNhanVien.NgaySinh;
                    dr["DiaChi"] = pNhanVien.DiaChi;
                    dr["GioiTinh"] = pNhanVien.GioiTinh;
                    dr["CMND"] = pNhanVien.CMND;
                    dr["DienThoai"] = pNhanVien.DienThoai;
                    dr["NgayVaoLam"] = pNhanVien.NgayVaoLam;
                    dr["MaPhongBan"] = pNhanVien.MaPhongBan;
                    dr["MaChucVu"] = pNhanVien.MaChucVu;
                    dr["HeSoLuong"] = pNhanVien.HeSoLuong;
                }
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_nv);
                sqlda_nv.Update(ds_QLChamCong, "QL_NhanVien");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa_NhanVien(QL_NhanVien pNhanVien)
        {
            try
            {
                SqlDataAdapter sqlda_nv = new SqlDataAdapter("select * from QL_NhanVien", cnn);
                DataRow dr = ds_QLChamCong.Tables["QL_NhanVien"].Rows.Find(pNhanVien.MaNhanVien);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(sqlda_nv);

                sqlda_nv.Update(ds_QLChamCong, "QL_NhanVien");
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public bool KT_NV(string pNhanVien)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da_NV = new SqlDataAdapter("select * from QL_NhanVien where MaNhanVien='" + pNhanVien + "'", cnn);
            da_NV.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int KTtontai(string ma)
        {
            string sql = "Select * from dbo.QL_NhanVien where MaNhanVien='" + ma + "'";
            SqlDataAdapter apter = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            apter.Fill(dt);
            if (dt.Rows.Count == 0)
                return 1;
            return 0;
        }

    }
}
