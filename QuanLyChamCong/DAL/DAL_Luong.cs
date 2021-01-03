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
    public class DAL_Luong : SQLConnection
    {



      DataSet ds_QLLuong1;

        public DAL_Luong()
        {
            load();

          
        }
        void load()
        {
            ds_QLLuong1 = new DataSet();
            SqlDataAdapter da_NV = new SqlDataAdapter("select QL_ChamCong.MaPhieu,QL_ChamCong.MaNhanVien,HoTen,Thang,Nam,HeSoLuong,HeSoChucVu,LuongcoBan,SoNgayChamCong,SoGioTangCa,SoGioTre,TongLuong from QL_ChamCong ,QL_NhanVien,QL_ChucVu,QL_Luong where QL_ChamCong.MaNhanVien=QL_NhanVien.MaNhanVien and QL_ChucVu.MaChucVu=QL_NhanVien.MaChucVu and QL_Luong.MaNhanVien=QL_ChamCong.MaNhanVien and QL_Luong.MaPhieu=QL_ChamCong.MaPhieu", cnn);

            da_NV.Fill(ds_QLLuong1, "QL_ChamCong");

            da_NV.FillSchema(ds_QLLuong1, SchemaType.Mapped);
        }

      public DataTable Load_PhongBan()
      {
          return ds_QLLuong1.Tables["QL_PhongBan"];
      }
      
      public DataTable Load_NhanVien()
      {
          load();
          return ds_QLLuong1.Tables["QL_ChamCong"];
      }

      public int Update_ALL()
      {
          try
          {

              SqlDataAdapter da_NV = new SqlDataAdapter("select MaPhieu,QL_ChamCong.MaNhanVien,HoTen,HeSoLuong,HeSoChucVu,LuongcoBan,SoNgayChamCong,SoGioTangCa,SoGioTre from QL_ChamCong ,QL_NhanVien,QL_ChucVu where QL_ChamCong.MaNhanVien=QL_NhanVien.MaNhanVien and QL_ChucVu.MaChucVu=QL_NhanVien.MaChucVu", cnn);
      
              SqlCommandBuilder build = new SqlCommandBuilder(da_NV);
              da_NV.Update(ds_QLLuong1, "QL_ChamCong");

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
              string caulenh = "select *from QL_Luong";
              SqlDataAdapter sqlda_Luong = new SqlDataAdapter(caulenh, cnn);
              DataRow dr = ds_QLLuong1.Tables["QL_Luong"].NewRow();
              dr["MaNhanVien"] =pLuong.MaNV;
              dr["MaPhieu"] = pLuong.MaPhieu;
              dr["TongLuong"] = pLuong.TongLuong;
              ds_QLLuong1.Tables["QL_Luong"].Rows.Add(dr);


            
             
              SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_Luong);
              sqlda_Luong.Update(ds_QLLuong1, "QL_Luong");
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
          // B1
          SqlDataAdapter da_luong = new SqlDataAdapter("select * from QL_Luong", cnn);
          // B2
          da_luong.Fill(dt_luong);
          return dt_luong;


      }

      public int KTTonTai(string ma)
      {
          string sql = "select * from dbo.QL_Luong where MaPhieu='"+ma+"'";
          SqlDataAdapter apter = new SqlDataAdapter(sql, cnn);
          DataTable dt = new DataTable();
          apter.Fill(dt);
          if (dt.Rows.Count == 0)
              return 0;
          return 1;
      }
    }
}
