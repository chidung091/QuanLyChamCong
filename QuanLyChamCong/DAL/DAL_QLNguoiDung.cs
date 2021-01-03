using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChamCong.DTO;
namespace QuanLyChamCong.DAL
{
    class DAL_QLNguoiDung:SQLConnection
    {
        DataSet ds_QLChamCong = new DataSet();
        public DAL_QLNguoiDung()
        {
            SqlDataAdapter da_QLNguoiDung = new SqlDataAdapter("select * from QL_NguoiDung", cnn);
            da_QLNguoiDung.Fill(ds_QLChamCong, "QL_NguoiDung");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLChamCong.Tables["QL_NguoiDung"].Columns[0];
            ds_QLChamCong.Tables["QL_NguoiDung"].PrimaryKey = keys;
        }

        public int Them(QL_NguoiDung pNguoiDung)
        {
            try
            {
                SqlDataAdapter sqlda_NguoiDung = new SqlDataAdapter("select * from QL_NguoiDung", cnn);
                DataRow dr_NguoiDung = ds_QLChamCong.Tables["QL_NguoiDung"].NewRow();
                dr_NguoiDung["TenDangNhap"] = pNguoiDung.TenDangNhap;
                dr_NguoiDung["MatKhau"] = pNguoiDung.MatKhau;
                dr_NguoiDung["MaNhom"] = pNguoiDung.MaNhom;
                ds_QLChamCong.Tables["QL_NguoiDung"].Rows.Add(dr_NguoiDung);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_NguoiDung);
                sqlda_NguoiDung.Update(ds_QLChamCong, "QL_NguoiDung");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Xoa(QL_NguoiDung pNguoiDung)
        {
            try
            {
                SqlDataAdapter sqlda_NguoiDung = new SqlDataAdapter("select * from QL_NguoiDung", cnn);
                DataRow dr_NguoiDung = ds_QLChamCong.Tables["QL_NguoiDung"].Rows.Find(pNguoiDung.TenDangNhap);
                if (dr_NguoiDung != null)
                {
                    dr_NguoiDung.Delete();
                }
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_NguoiDung);
                sqlda_NguoiDung.Update(ds_QLChamCong, "QL_NguoiDung");
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public int Sua(QL_NguoiDung pNguoiDung)
        {
            try
            {
                SqlDataAdapter sqlda_NguoiDung = new SqlDataAdapter("select * from QL_NguoiDung", cnn);
                DataRow dr_NguoiDung = ds_QLChamCong.Tables["QL_NguoiDung"].Rows.Find(pNguoiDung.TenDangNhap);
                if (dr_NguoiDung != null)
                {
                    dr_NguoiDung["MatKhau"] = pNguoiDung.MatKhau;
                    dr_NguoiDung["MaNhom"] = pNguoiDung.MaNhom;
                }
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_NguoiDung);
                sqlda_NguoiDung.Update(ds_QLChamCong, "QL_NguoiDung");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable Load_NhomND()
        {
            DataTable dt_NhomND = new DataTable();
            SqlDataAdapter da_NguoiDung = new SqlDataAdapter("select * from QL_NhomNguoiDung", cnn);
            da_NguoiDung.Fill(dt_NhomND);
            return dt_NhomND;
        }
    }
}
