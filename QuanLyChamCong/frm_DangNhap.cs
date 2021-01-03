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

namespace QuanLyChamCong
{
    public partial class frm_DangNhap : Form
    {
        private string con = Program.ConnectionString;
        private SqlConnection conn;
        public frm_DangNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(con);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập!");
                this.txt_TenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!");
                this.txt_MatKhau.Focus();
                return;
            }
            DataTable dt_DN = new DataTable();
            try
            {

                SqlDataAdapter da_dn = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + txt_TenDangNhap.Text + "' and MatKhau='" + txt_MatKhau.Text + "'", conn);
                da_dn.Fill(dt_DN);

                if (dt_DN.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Cơ sở dữ liệu không phù hợp!Vui lòng kiểm tra lại.");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frm_MainDev();
            }

            Program.mainForm.MaNhom = dt_DN.Rows[0][2].ToString();

            Program.mainForm.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Program.mainForm.Show();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            frm.Show();
        }
    }
}
