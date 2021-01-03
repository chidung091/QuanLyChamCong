using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using QuanLyChamCong.DAL;

namespace DAL
{
    public class DAL_TinhLuong : SQLConnection
    {
       DataSet ds_QLLuong;

        public DAL_TinhLuong()
        {
            load();

          
        }

        void load()
        {
            ds_QLLuong = new DataSet();
            SqlDataAdapter da_NV = new SqlDataAdapter(@"select MaPhieu,QL_ChamCong.MaNhanVien,HoTen,HeSoLuong,HeSoChucVu,LuongcoBan,SoNgayChamCong,SoGioTangCa,SoGioTre,MaPhongBan
from QL_ChamCong ,QL_NhanVien,QL_ChucVu 
where QL_ChamCong.MaNhanVien=QL_NhanVien.MaNhanVien and QL_ChucVu.MaChucVu=QL_NhanVien.MaChucVu 
and QL_ChamCong.MaPhieu not in(select MaPhieu from QL_Luong)", cnn);
            da_NV.Fill(ds_QLLuong, "QL_ChamCong");

            da_NV.FillSchema(ds_QLLuong, SchemaType.Mapped);

            SqlDataAdapter da_Phong = new SqlDataAdapter("select * from QL_PhongBan", cnn);

            da_Phong.Fill(ds_QLLuong, "QL_PhongBan");
        }
      public DataTable Load_PhongBan()
      {
          return ds_QLLuong.Tables["QL_PhongBan"];
      }
      
      public DataTable Load_NhanVien()
      {
          load();
          return ds_QLLuong.Tables["QL_ChamCong"];
      }

      public int Update_ALL()
      {
          try
          {

              SqlDataAdapter da_NV = new SqlDataAdapter("select MaPhieu,QL_ChamCong.MaNhanVien,HoTen,HeSoLuong,HeSoChucVu,LuongcoBan,SoNgayChamCong,SoGioTangCa,SoGioTre from QL_ChamCong ,QL_NhanVien,QL_ChucVu where QL_ChamCong.MaNhanVien=QL_NhanVien.MaNhanVien and QL_ChucVu.MaChucVu=QL_NhanVien.MaChucVu", cnn);
              SqlCommandBuilder build = new SqlCommandBuilder(da_NV);
              da_NV.Update(ds_QLLuong, "QL_ChamCong");

              return 1;
          }
          catch
          {
              return 0;
          }
      }

      

      public bool KT_NV(string pMaNV)
      {
          DataTable dt = new DataTable();
          SqlDataAdapter da_NV = new SqlDataAdapter("select MaNhanVien,SoNgayChamCong,SoGioTangCa,SoGioTre from QL_ChamCong where MaNV='" + pMaNV + "'", cnn);
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


      public int Luu(TinhLuong pLuong)
      {
          try
          {

              SqlDataAdapter sqlda_Luong = new SqlDataAdapter("select * from QL_Luong", cnn);
              
              DataRow newrow = ds_QLLuong.Tables["QL_NguoiDung"].NewRow();
              newrow["MaNhanVien"] = pLuong.MaNV;
              newrow["MaPhieu"] = pLuong.MaPhieu;
              newrow["TongLuong"] = pLuong.TongLuong;
              
              ds_QLLuong.Tables["QL_Luong"].Rows.Add(newrow);
              
              SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_Luong);
              
              sqlda_Luong.Update(ds_QLLuong, "QL_Luong");
              return 1;
          }
          catch
          {
              return 0;
          }


      }

      public DataTable Load_Luong()
      {
          DataTable dt_luong = new DataTable();

          SqlDataAdapter da_luong = new SqlDataAdapter("select * from QL_Luong", cnn);
         
          da_luong.Fill(dt_luong);
          return dt_luong;


      }
    }
}
