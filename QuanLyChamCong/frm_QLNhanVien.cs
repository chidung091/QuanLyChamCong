using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChamCong.BUS;
using QuanLyChamCong.DTO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QuanLyChamCong
{
    public partial class frm_QLNhanVien : Form
    {
        BUS_QLNhanVien bus_qlnv = new BUS_QLNhanVien();
        BUS_ChamCong busCC = new BUS_ChamCong();
        public static DataSet QuanLyChamCong = new DataSet();
        public static string strConnect = Program.ConnectionString;
        public SqlConnection cnn;
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            cbo_PhongBan.DataSource = bus_qlnv.Load_PhongBan();
            cbo_PhongBan.DisplayMember = "TenPhongBan";
            cbo_PhongBan.ValueMember = "MaPhongBan";

            cbo_ChucVu.DataSource = bus_qlnv.Load_ChucVu();
            cbo_ChucVu.DisplayMember = "TenChucVu";
            cbo_ChucVu.ValueMember = "MaChucVu";

            dgv_HienThi.DataSource = bus_qlnv.Load_NhanVien();
        }

        public void Load_Enable(bool value)
        {
            cbo_PhongBan.Enabled = value;
            cbo_ChucVu.Enabled = value;
            cbo_GioiTinh.Enabled = value;
            txt_MaNV.Enabled = value;
            txt_TenNV.Enabled = value;
            txt_DiaChi.Enabled = value;
            txt_SoCMND.Enabled = value;
            txt_DienThoai.Enabled = value;
            txt_HeSoLuong.Enabled = value;
            dtp_NgayVaoLam.Enabled = value;
            dtp_NgaySinh.Enabled = value;
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = false;
            Load_data();
            Load_Enable(false);
        }

        private void dgv_HienThi_SelectionChanged(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            if (dgv_HienThi.CurrentRow != null)
            {
                txt_MaNV.Text = dgv_HienThi.CurrentRow.Cells[0].Value.ToString();
                txt_TenNV.Text = dgv_HienThi.CurrentRow.Cells[1].Value.ToString();
                dtp_NgaySinh.Text = dgv_HienThi.CurrentRow.Cells[2].Value.ToString();
                txt_DiaChi.Text = dgv_HienThi.CurrentRow.Cells[3].Value.ToString();
                cbo_GioiTinh.Text = dgv_HienThi.CurrentRow.Cells[4].Value.ToString();
                txt_SoCMND.Text = dgv_HienThi.CurrentRow.Cells[5].Value.ToString();
                txt_DienThoai.Text = dgv_HienThi.CurrentRow.Cells[6].Value.ToString();
                dtp_NgayVaoLam.Text = dgv_HienThi.CurrentRow.Cells[7].Value.ToString();
                cbo_PhongBan.Text = dgv_HienThi.CurrentRow.Cells[8].Value.ToString();
                cbo_ChucVu.Text = dgv_HienThi.CurrentRow.Cells[9].Value.ToString();
                txt_HeSoLuong.Text = dgv_HienThi.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           // TangMaTuDong();
           // txt_MaNV.Enabled = false;
            Load_data();
            Load_Enable(true);
            txt_MaNV.Text = txt_TenNV.Text = txt_DiaChi.Text = txt_SoCMND.Text = txt_DienThoai.Text =txt_HeSoLuong.Text = "";
            cbo_GioiTinh.Text =string.Empty;
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = false;


            for (int i = 0; i < dgv_HienThi.Rows.Count - 1; i++)
            {
                dgv_HienThi.Rows[i].ReadOnly = true;
            }
            dgv_HienThi.FirstDisplayedScrollingRowIndex = dgv_HienThi.Rows.Count - 1;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                QL_NhanVien nv = new QL_NhanVien();
                nv.MaNhanVien = txt_MaNV.Text;
                nv.HoTen = txt_TenNV.Text;
                nv.NgaySinh = dtp_NgaySinh.Text;
                nv.DiaChi = txt_DiaChi.Text;
                nv.GioiTinh = cbo_GioiTinh.Text;
                nv.CMND = txt_SoCMND.Text;
                nv.DienThoai = txt_DienThoai.Text;
                nv.NgayVaoLam = dtp_NgayVaoLam.Text;
                nv.MaPhongBan = cbo_PhongBan.Text;
                nv.MaChucVu = cbo_ChucVu.Text;
                nv.HeSoLuong = txt_HeSoLuong.Text;

                if (bus_qlnv.Xoa_NhanVien(nv) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Nhân viên đang chấm công!");
                }
            }

            else
            {
                MessageBox.Show("Thất bại");
            }
            Load_data();
              
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Load_Enable(true);
            txt_MaNV.Enabled = false;
            txt_TenNV.Focus();
            btn_Luu.Enabled = true;
            dgv_HienThi.AllowUserToAddRows = false;
            dgv_HienThi.ReadOnly = false;

            for (int i = 0; i < dgv_HienThi.Rows.Count - 1; i++)
            {
                dgv_HienThi.Rows[i].ReadOnly = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
           // TangMaTuDong();
           // txt_MaNV.Enabled = false;  
            if (txt_MaNV.Text.Trim() == string.Empty || txt_TenNV.Text.Trim() == string.Empty || txt_SoCMND.Text.Trim() == string.Empty || dtp_NgaySinh.Text.Trim() == string.Empty || txt_HeSoLuong.Text.Trim() == string.Empty || dtp_NgayVaoLam.Text.Trim() == string.Empty || cbo_ChucVu.Text.Trim() == string.Empty || cbo_GioiTinh.Text.Trim() == string.Empty || cbo_PhongBan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_SoCMND.Text.Length !=9 )
            {
                MessageBox.Show("Số CMND không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoCMND.Focus();
                return;
            }
            if (txt_DienThoai.Text.Length !=10 && txt_DienThoai.Text.Length !=11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DienThoai.Focus();
                return;
            }
          
            QL_NhanVien pNhanVien = new QL_NhanVien();
            pNhanVien.MaNhanVien = txt_MaNV.Text;
            pNhanVien.HoTen = txt_TenNV.Text;
            pNhanVien.NgaySinh = dtp_NgaySinh.Text;
            pNhanVien.DiaChi = txt_DiaChi.Text;
            pNhanVien.GioiTinh = cbo_GioiTinh.Text;
            pNhanVien.CMND = txt_SoCMND.Text;
            pNhanVien.DienThoai = txt_DienThoai.Text;
            pNhanVien.NgayVaoLam = dtp_NgayVaoLam.Text;
            pNhanVien.MaPhongBan = cbo_PhongBan.SelectedValue.ToString();
            pNhanVien.MaChucVu = cbo_ChucVu.SelectedValue.ToString();
            pNhanVien.HeSoLuong = txt_HeSoLuong.Text;

            if (txt_MaNV.Enabled == true)
            {
                if (bus_qlnv.KTtontai(txt_MaNV.Text) == 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (bus_qlnv.Them_NhanVien(pNhanVien) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if (bus_qlnv.Sua_NhanVien(pNhanVien) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }

            Load_data();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(bus_qlnv.Load_NhanVien());
            string ten = txt_TimKiem.Text;
            dv.RowFilter = "HoTen like '" + "%"+ ten +"%'";
            dgv_HienThi.DataSource = dv;
        }

        private void txt_SoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txt_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txt_HeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            Load_data();
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || e.KeyChar > 122)
            {
                e.Handled = true;
            }
        }
       // DataTable dt;
        //private void TangMaTuDong()
        //{
        //    if (cnn.State == ConnectionState.Closed)
        //        cnn.Open();
        //    string sql = "tb_NhanVien";
        //    SqlCommand cmd = new SqlCommand(sql, cnn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    cnn.Close();
        //    string ma = "";
        //    if (dt.Rows.Count <= 0)
        //    {
        //        ma = "NV1";
        //    }
        //    else
        //    {
        //        int k;
        //        ma = "NV";
        //        k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
        //        k = k + 1;
               
        //        ma = ma + k.ToString();
        //    }
        //    txt_MaNV.Text = ma;
        //}


       
    }
}
