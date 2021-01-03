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
    public partial class frm_QLPhongBan : Form
    {
        BUS_PhongBan busPB;
        public frm_QLPhongBan()
        {
            InitializeComponent();
            busPB = new BUS_PhongBan();
        }

        void LoadPhongBan()
        {
            dgvPhongBan.DataSource = busPB.LoadPB();
        }

        private void frm_QLPhongBan_Load(object sender, EventArgs e)
        {
            LoadPhongBan();
        }

        private void tsbThoatPB_Click(object sender, EventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void tsbThemMoiPB_Click(object sender, EventArgs e)
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaPB.Enabled = true;
        }

        private void dgvPhongBan_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaPB.Text = dgvPhongBan.CurrentRow.Cells["MaPhongBan"].Value.ToString();
            txtTenPB.Text = dgvPhongBan.CurrentRow.Cells["TenPhongBan"].Value.ToString();
            txtMaPB.Enabled = false;
        }

        private void tsbXoaPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xóa phòng ban", MessageBoxButtons.OKCancel) == DialogResult.OK)
                if (busPB.ooDeletePhongBan(txtMaPB.Text) > 0)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Có nhân viên trong phòng ban!");
            LoadPhongBan();
        }


        private void tsbLuuPB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPhongBan.Rows)
            {
                if (row.Cells[0].Value.ToString() == txtMaPB.Text)
                {
                    MessageBox.Show("Phòng ban này đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (txtMaPB.Text != string.Empty || txtTenPB.Text != string.Empty)
            {
                if (busPB.ooInsertPhongBan(txtMaPB.Text, txtTenPB.Text) == -1)
                    MessageBox.Show("Thêm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadPhongBan();
        }

        private void tsbSuaPB_Click_1(object sender, EventArgs e)
        {
            if (dgvPhongBan.RowCount == 0)
                return;
            foreach (DataGridViewRow row in dgvPhongBan.Rows)
            {
                if (row.Index != dgvPhongBan.CurrentRow.Index)
                {
                    if (row.Cells["TenPhongBan"].Value.ToString() == txtTenPB.Text)
                    {
                        MessageBox.Show("Phòng ban này đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (txtTenPB.Text != string.Empty)
            {
                if (busPB.ooUpdatePhongBan(txtMaPB.Text, txtTenPB.Text) == -1)
                    MessageBox.Show("Sửa thất bại");
                else
                    MessageBox.Show("Sửa thành công");
            }
            else
                MessageBox.Show("Thiếu thông tin");
            LoadPhongBan();
        }
    }
}
