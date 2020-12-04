using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    public class DTO_KHACHHANG
    {
        private string sdtkh;
        private string emailkh;
        private string tenkh;
        private DateTime ngaysinh;
        private int manv;

        public string SDTKH
        {
            get
            {
                return sdtkh;
            }
            set
            {
                sdtkh = value;
            }
        }
        public string EMAILKH
        {
            get
            {
                return emailkh;
            }
            set
            {
                emailkh = value;
            }
        }
        public string TENKH
        {
            get
            {
                return tenkh;
            }
            set
            {
                tenkh = value;
            }
        }
        public DateTime NGAYSINH
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                ngaysinh = value;
            }
        }

        public DTO_KHACHHANG(string SoDienThoai, string Email, string TenKhachHang, DateTime NgaySinh)
        {
            this.sdtkh = SoDienThoai;
            this.emailkh = Email;
            this.tenkh = TenKhachHang;
            this.ngaysinh = NgaySinh;
        }
    }
}
