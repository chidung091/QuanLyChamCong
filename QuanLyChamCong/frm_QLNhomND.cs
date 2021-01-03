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
    public partial class frm_QLNhomND : Form
    {
        BUS_QLNhomND busNhomND = new BUS_QLNhomND();
        public frm_QLNhomND()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            QL_NhomND nhomND = new QL_NhomND();
            nhomND.MaNhom = txt_MaNhom.Text;
            nhomND.TenNhom = txt_TenNhom.Text;
            nhomND.GhiChu = txt_GhiChu.Text;

            if (busNhomND.Them(nhomND) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            QL_NhomND nhomND = new QL_NhomND();
            nhomND.MaNhom = txt_MaNhom.Text;
            nhomND.TenNhom = txt_TenNhom.Text;
            nhomND.GhiChu = txt_GhiChu.Text;

            if (busNhomND.Xoa(nhomND) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            QL_NhomND nhomND = new QL_NhomND();
            nhomND.MaNhom = txt_MaNhom.Text;
            nhomND.TenNhom = txt_TenNhom.Text;
            nhomND.GhiChu = txt_GhiChu.Text;

            if (busNhomND.Sua(nhomND) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
