using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    public class DTO_NHANVIEN
    {
        private int manv;
        private string tennv;     
        private string diachi;
        private string sdt;
        private int chucvu;
        private string email;
        private string matkhau;
        
        public int MANV
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
            }
        }
        public string TENNV
        {
            get
            {
                return tennv;
            }
            set
            {
                tennv = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
        public int CHUCVU
        {
            get
            {
                return chucvu;
            }
            set
            {
                chucvu = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string MATKHAU
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }

        public DTO_NHANVIEN(int MaNhanVien, string TenNhanVien, string DiaChi, string SoDienThoai, int ChucVu, string Email, string MatKhau)
        {
            this.manv = MaNhanVien;
            this.tennv = TenNhanVien;
            this.diachi = DiaChi;
            this.sdt = SoDienThoai;
            this.chucvu = ChucVu;
            this.email = Email;
            this.matkhau = MatKhau;
        }
        public DTO_NHANVIEN(string Email, string MatKhau)
        {
            this.email = Email;
            this.matkhau = MatKhau;
        }
        public DTO_NHANVIEN( string TenNhanVien, string Email, string DiaChi, string SoDienThoai, int ChucVu)
        {
            
            this.tennv = TenNhanVien;
            this.email = Email;
            this.diachi = DiaChi;
            this.sdt = SoDienThoai;
            this.chucvu = ChucVu;
            
        }
        public DTO_NHANVIEN()
        {

        }
    }
}
