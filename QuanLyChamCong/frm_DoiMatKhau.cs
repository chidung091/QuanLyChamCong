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
    public partial class frm_DoiMatKhau : Form
    {
        BUS_MatKhau busTL;
        public frm_DoiMatKhau()
        {
            InitializeComponent();
            busTL = new BUS_MatKhau();
        }


        private void btnDMKXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == string.Empty || txtMKCu.Text == string.Empty || txtMKMoi.Text == string.Empty || txtXacNhanMK.Text == string.Empty)
            {
                MessageBox.Show("Thiếu thông tin");
                return;
            }

                if (int.Parse(txtMKCu.Text) != busTL.GetPass(txtMKCu.Text))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.");
                    return;
                }

            if (txtMKMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng");
                return;
            }
            if (int.Parse(txtXacNhanMK.Text) == busTL.GetPass(txtMKCu.Text))
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ");
                return;
            }
            if (busTL.UpdateThietLap(txtTenDangNhap.Text, txtXacNhanMK.Text) == 1)
            {
                MessageBox.Show("Sửa thành công");
                return;
            }
            else
                MessageBox.Show("Sửa thất bại");
        }
 
        private void btn_DMKThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
