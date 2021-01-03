using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyChamCong
{
    public partial class frm_QLTinhLuong : Form
    {
        DataView dv;
        SqlConnection cn = new SqlConnection(Program.ConnectionString);
        DataSet ds_QLLuong1 = new DataSet();
        BUS_Luong bus_luong;
        BUS_TinhLuong _bus;
        public void LoadLuong()
        {
            ds_QLLuong1 = new DataSet();
            SqlDataAdapter da_Khoa = new SqlDataAdapter("select * from QL_Luong", cn);
            da_Khoa.Fill(ds_QLLuong1, "QL_Luong");
            dgv_TinhLuong.DataSource = _bus.Load_Luong();

          
        }
        public frm_QLTinhLuong()
        {
            InitializeComponent();
            _bus = new BUS_TinhLuong();
            bus_luong = new BUS_Luong();
        }
        
   
       
        public void LoadData()
        {
            cbo_Phong.DataSource = _bus.Load_PhongBan();
            cbo_Phong.DisplayMember = "TenPhongBan";
            cbo_Phong.ValueMember = "MaPhongBan";


            dv = new DataView(_bus.Load_NhanVien());
            dgv_NhanVien.DataSource = dv;

          

        }
        public void LoadData2()
        {
            

            dgv_TinhLuong.DataSource = bus_luong.Load_NhanVien();
       



        }
        private void Enable_Clear(TableLayoutPanel tbl, bool en, bool clear = false)
        {
            foreach (Control c in tbl.Controls)
            {
                if (c is Label || c is DataGridView) continue;
                c.Enabled = en;
                if (clear)
                {
                    if (c is TextBox)
                        c.Text = string.Empty;
                    if (c is ComboBox)
                        ((ComboBox)c).SelectedIndex = 0;

                }
            }
        }

        private void frm_QLTinhLuong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLuong();
            LoadData2();
            dgv_TinhLuong.AutoGenerateColumns = false;
            dgv_NhanVien.AutoGenerateColumns = false;

            dgv_NhanVien.ReadOnly = true;

            dgv_NhanVien.AllowUserToAddRows = false;

            dgv_NhanVien.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_NhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        

        private void dgv_NhanVien_SelectionChanged(object sender, MouseEventArgs e)
        {
            if (dgv_NhanVien.CurrentRow != null)
            {
                txt_ThanhTien.Clear();
                txt_MaPhieu.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
                txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
                txt_TenNV.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
                txt_SoNC.Text = dgv_NhanVien.CurrentRow.Cells[6].Value.ToString();
                txt_HeSoLuong.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
                txt_HeSoChucVu.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
                txt_LuongCoBan.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
                txt_SoGioTangCa.Text = dgv_NhanVien.CurrentRow.Cells[7].Value.ToString();
                txt_SoGioTre.Text = dgv_NhanVien.CurrentRow.Cells[8].Value.ToString();
                
            }
            btn_Luu.Enabled = false;
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
   
            if (dgv_NhanVien.RowCount != 0)
            {
                int luongcoban = int.Parse(txt_LuongCoBan.Text);
                int songaycc = int.Parse(txt_SoNC.Text);
                float hesoluong = float.Parse(txt_HeSoLuong.Text);
                float hesocv = float.Parse(txt_HeSoChucVu.Text);
                int sogiotangca = int.Parse(txt_SoGioTangCa.Text);
                int sogiotre = int.Parse(txt_SoGioTre.Text);


                txt_ThanhTien.Text = ((int)(((songaycc*8+sogiotangca*1.5-sogiotre*1.5)*hesocv*hesoluong*(luongcoban/26/24)))).ToString("N0");

                btn_Luu.Enabled = true;
            
               
            }
            else
                    MessageBox.Show("Chưa chọn nhân viên nào!");
                
       
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //TinhLuong nguoidung = new TinhLuong();

            //nguoidung.MaNV = txt_MaNV.Text;
            //nguoidung.MaPhieu = txt_MaPhieu.Text;
            //nguoidung.TongLuong = double.Parse(txt_ThanhTien.Text);

            //if (bus_luong.Luu(nguoidung) == 1)
            //{
            //    MessageBox.Show("Thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Thất bại");
            //}
            DataRow dr = ds_QLLuong1.Tables["QL_Luong"].NewRow();
            dr["MaNhanVien"] = txt_MaNV.Text;
            dr["MaPhieu"] = txt_MaPhieu.Text;
            dr["TongLuong"] = txt_ThanhTien.Text;
            ds_QLLuong1.Tables["QL_Luong"].Rows.Add(dr);


            string caulenh = "select *from QL_Luong";
            SqlDataAdapter sqlda_Luong = new SqlDataAdapter(caulenh, cn);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlda_Luong);
            sqlda_Luong.Update(ds_QLLuong1, "QL_Luong");
           
         
            if (bus_luong.KTTonTai(txt_MaPhieu.Text) == 1)
            {
                MessageBox.Show("Thành công");

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
          
            frm_QLTinhLuong_Load(null, null);
        }



       

        private void cbo_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( dv != null)
            {
                dv.RowFilter = string.Format("MaPhongBan like '" + cbo_Phong.SelectedValue.ToString().Replace("'", "''") + "'");
                dgv_NhanVien.DataSource = dv;
            }
        }


    
      
      
       
        

      

       

    }

}
