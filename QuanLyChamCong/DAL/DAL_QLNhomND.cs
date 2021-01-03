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
    class DAL_QLNhomND:SQLConnection
    {
        DataSet ds_QLChamCong=new DataSet();
        public DAL_QLNhomND()
        {
            SqlDataAdapter da_NhomND = new SqlDataAdapter("select * from QL_NhomNguoiDung", cnn);
            da_NhomND.Fill(ds_QLChamCong, "QL_NhomNguoiDung");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLChamCong.Tables["QL_NhomNguoiDung"].Columns[0];
            ds_QLChamCong.Tables["QL_NhomNguoiDung"].PrimaryKey = keys;
        }

        public int Them(QL_NhomND pNhomND)
        {
            try
            {
                SqlDataAdapter sqlda_NhomND = new SqlDataAdapter("select * from QL_NhomNguoiDung", cnn);
                DataRow dr_NhomND = ds_QLChamCong.Tables["QL_NhomNguoiDung"].NewRow();
                dr_NhomND["MaNhom"] = pNhomND.MaNhom;
                dr_NhomND["TenNhom"] = pNhomND.TenNhom;
                dr_NhomND["GhiChu"] = pNhomND.GhiChu;
                ds_QLChamCong.Tables["QL_NhomNguoiDung"].Rows.Add(dr_NhomND);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_NhomND);
                sqlda_NhomND.Update(ds_QLChamCong, "QL_NhomNguoiDung");
                return 1;

            }
            catch
            {
                return 0;
            }
        }

        public int Xoa(QL_NhomND pNhomND)
        {
            try
            {
                SqlDataAdapter sqlda_NhomND = new SqlDataAdapter("select * from QL_NhomNguoiDung", cnn);
                DataRow dr_NhomND = ds_QLChamCong.Tables["QL_NhomNguoiDung"].Rows.Find(pNhomND.MaNhom);
                if (dr_NhomND != null)
                {
                    dr_NhomND.Delete();
                }
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_NhomND);
                sqlda_NhomND.Update(ds_QLChamCong, "QL_NhomNguoiDung");
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public int Sua(QL_NhomND pNhomND)
        {
            try
            {
                SqlDataAdapter sqlda_NhomND = new SqlDataAdapter("select * from QL_NhomNguoiDung", cnn);
                DataRow dr_NhomND = ds_QLChamCong.Tables["QL_NhomNguoiDung"].Rows.Find(pNhomND.MaNhom);
                if (dr_NhomND != null)
                {
                    dr_NhomND["TenNhom"] = pNhomND.TenNhom;
                    dr_NhomND["GhiChu"] = pNhomND.GhiChu;
                }
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_NhomND);
                sqlda_NhomND.Update(ds_QLChamCong, "QL_NhomNguoiDung");
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
            SqlDataAdapter da_NhomND = new SqlDataAdapter("select * from QL_NhomNguoiDung", cnn);
            da_NhomND.Fill(dt_NhomND);
            return dt_NhomND;
        }
    }
}
