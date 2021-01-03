using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamCong.DTO
{
    class QL_PhongBan
    {
        string MaPB;

        public string MaPB1
        {
            get { return MaPB; }
            set { MaPB = value; }
        }
        string TenPB;

        public string TenPB1
        {
            get { return TenPB; }
            set { TenPB = value; }
        }
        public QL_PhongBan()
        {
            MaPB = " ";
            TenPB = " ";
        }
        public QL_PhongBan(string ma, string ten)
        {
            MaPB = ma;
            TenPB = ten;
        }
    }
}
