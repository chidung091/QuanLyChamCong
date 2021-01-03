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
namespace QuanLyChamCong
{
    public partial class frm_QLNguoiDung : Form
    {
        BUS_QLNguoiDung busNguoiDung = new BUS_QLNguoiDung();
        public frm_QLNguoiDung()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            QL_NguoiDung nd = new QL_NguoiDung();
            nd.TenDangNhap = txt_TenDangNhap.Text;
            nd.MatKhau = txt_MatKhau.Text;
            nd.MaNhom = cbo_NhomNguoiDung.SelectedValue.ToString();
            if (txt_TenDangNhap.Text == "" && txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busNguoiDung.Them(nd) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }


        public void LoadDataIntoCombobox()
        {
            cbo_NhomNguoiDung.DataSource = busNguoiDung.Load_NhomND();
            cbo_NhomNguoiDung.DisplayMember = "TenNhom";
            cbo_NhomNguoiDung.ValueMember = "MaNhom";
        }

        private void frm_QLNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataIntoCombobox();
        }
    }
}
