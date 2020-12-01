using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    class DTO_LOAISANPHAM
    {
        private string maloai;
        private string tenloai;

        public string MALOAI
        {
            get
            {
                return maloai;
            }
            set
            {
                maloai = value;
            }
        }
        public string TENLOAI
        {
            get
            {
                return tenloai;
            }
            set
            {
                tenloai = value;
            }
        }

        public DTO_LOAISANPHAM(string MaLoai, string TenLoai)
        {
            this.maloai = MaLoai;
            this.tenloai = TenLoai;
        }
    }
}
