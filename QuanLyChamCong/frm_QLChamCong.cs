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

namespace QuanLyChamCong
{
    public partial class frm_QLChamCong : Form
    {
        BUS_ChamCong busCC;
        public frm_QLChamCong()
        {
            InitializeComponent();
            busCC = new BUS_ChamCong();
           
        }

        private void frm_QLChamCong_Load(object sender, EventArgs e)
        {
            cbo_PhongBan.DataSource = busCC.LoadPB();
            cbo_PhongBan.DisplayMember = "TenPhongBan";
            cbo_PhongBan.ValueMember = "MaPhongBan";
            cbo_Nam.Text = DateTime.Now.Year.ToString();
            cbo_Thang.Text = DateTime.Now.Month.ToString();
            cbo_Ngay.Text = DateTime.Now.Day.ToString();
            cbo_PhongBan.SelectedIndex = 0;
            txtGioTC.Text = "0";
            txtGioTre.Text = "0";
            xem();

        }

        void xem()
        {
            dataGridView1_MouseClick(null, null);
            try
            {
                dgv_ChamCong.DataSource = busCC.LoadNV(cbo_PhongBan.SelectedValue.ToString(), int.Parse(cbo_Thang.Text), int.Parse(cbo_Nam.Text));
            }
            catch { }
        }

        private void cbo_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_PhongBan.SelectedValue == null || cbo_Thang.Text==""||cbo_Nam.Text=="" )
                    return;
                dgv_ChamCong.DataSource = busCC.LoadNV(cbo_PhongBan.SelectedValue.ToString(), int.Parse(cbo_Thang.Text), int.Parse(cbo_Nam.Text));
                cbxNhanVien.DataSource = busCC.LoadNV_PB(cbo_PhongBan.SelectedValue.ToString());
                cbxNhanVien.DisplayMember = "HoTen";
                cbxNhanVien.ValueMember = "MaNhanVien";
            }
            catch 
            { 
                MessageBox.Show("Lỗi:");
            }
        }



        private void cbo_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_ChamCong.DataSource = busCC.LoadNV(cbo_PhongBan.SelectedValue.ToString(), int.Parse(cbo_Thang.Text), int.Parse(cbo_Nam.Text));
            }
            catch { }
        }

        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_ChamCong.DataSource = busCC.LoadNV(cbo_PhongBan.SelectedValue.ToString(), int.Parse(cbo_Thang.Text), int.Parse(cbo_Nam.Text));
            }
            catch { }
        }



        private void toolStripLuu_Click_1(object sender, EventArgs e)
        {
            DataTable sdt = busCC.LoadCTCC(busCC.GetMaPhieu(cbxNhanVien.SelectedValue.ToString(), int.Parse(cbo_Nam.Text), int.Parse(cbo_Thang.Text)).ToString());
            foreach (DataRow row in sdt.Rows)
            {
                if (row["Ngay"].ToString() == cbo_Ngay.Text)
                {
                    MessageBox.Show("Đã chấm công ngày này rồi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbxNhanVien.SelectedValue.ToString() != string.Empty || cbo_Nam.Text != string.Empty || cbo_Thang.Text != string.Empty || cbo_Ngay.Text != string.Empty
                || txtGioTC.Text != string.Empty || txtGioTre.Text != string.Empty || chkNgayCong.Checked == false)
            {
                if (busCC.Luu(cbxNhanVien.SelectedValue.ToString(), int.Parse(cbo_Nam.Text), int.Parse(cbo_Thang.Text), int.Parse(cbo_Ngay.Text), int.Parse(txtGioTC.Text), int.Parse(txtGioTre.Text), chkNgayCong.Checked))
                    MessageBox.Show("Lưu thành công");
                else
                    MessageBox.Show("Lưu thất bại");
            }
            else
                MessageBox.Show("Thiếu thông tin");
            xem();
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void toolStripThemMoi_Click(object sender, EventArgs e)
        {
           
            txtGioTC.Text = "0";
            txtGioTre.Text = "0";
        }

        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            if (chon == 2)
            {
                if (MessageBox.Show("Bạn muốn xóa chi tiết này", "Xóa chi tiết", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    if (busCC.ooDeleteChiTietCC(busCC.GetMaPhieu(cbxNhanVien.SelectedValue.ToString(), int.Parse(cbo_Nam.Text), int.Parse(cbo_Thang.Text)), int.Parse(cbo_Ngay.Text)) > 0)
                        MessageBox.Show("Xóa thành công");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa phiếu chấm công", "Phiếu chấm công", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    if (busCC.ooDelCC(busCC.GetMaPhieu(cbxNhanVien.SelectedValue.ToString(), int.Parse(cbo_Nam.Text), int.Parse(cbo_Thang.Text))) == 0)
                        MessageBox.Show("Xóa thành công");
            }
            xem();

        }



        int chon = 0;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_ChamCong.RowCount == 0)
                return;
            chon = 1;
            string Manv = dgv_ChamCong.CurrentRow.Cells["MaNV"].Value.ToString();
            int Thang = int.Parse(dgv_ChamCong.CurrentRow.Cells["Thang"].Value.ToString());
            int Nam = int.Parse(dgv_ChamCong.CurrentRow.Cells["Nam"].Value.ToString());
            cbo_Nam.Text = dgv_ChamCong.CurrentRow.Cells["Nam"].Value.ToString();
            cbo_Thang.Text = dgv_ChamCong.CurrentRow.Cells["Thang"].Value.ToString();
            cbxNhanVien.SelectedValue = Manv;
            dgvChitiet.DataSource = busCC.LoadCTCC(busCC.GetMaPhieu(Manv, Nam, Thang).ToString());
        }

        private void dgvChitiet_MouseClick(object sender, MouseEventArgs e)
        {
            chon = 2;
            if (dgvChitiet.RowCount > 0)
            {
                txtGioTre.Text = dgvChitiet.CurrentRow.Cells["GioTre"].Value.ToString();
                txtGioTC.Text = txtGioTC.Text = dgvChitiet.CurrentRow.Cells["GioTangCa"].Value.ToString();
                cbo_Ngay.Text = dgvChitiet.CurrentRow.Cells["Ngay"].Value.ToString();
                chkNgayCong.Checked = (bool)dgvChitiet.CurrentRow.Cells["NgayCong"].FormattedValue;
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            if (cbxNhanVien.SelectedValue.ToString() != string.Empty || cbo_Nam.Text != string.Empty || cbo_Thang.Text != string.Empty || cbo_Ngay.Text != string.Empty
               || txtGioTC.Text != string.Empty || txtGioTre.Text != string.Empty || chkNgayCong.Checked == false)
            {
                if (busCC.Sua(cbxNhanVien.SelectedValue.ToString(), int.Parse(cbo_Nam.Text), int.Parse(cbo_Thang.Text), int.Parse(cbo_Ngay.Text), int.Parse(txtGioTC.Text), int.Parse(txtGioTre.Text), chkNgayCong.Checked))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
            }
            else
                MessageBox.Show("Thiếu thông tin");
            xem();
        }

        private void txtGioTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGioTre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && int.Parse(txtGioTre.Text.ToString()) <= 12)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }      
    }

