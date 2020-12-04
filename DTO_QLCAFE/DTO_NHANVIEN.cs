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
        private string email;
        private string matkhau;
        private string tennv;     
        private string diachi;
        private string sdt;
        private int chucvu;
        
        

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
        

        public DTO_NHANVIEN(string Email, string MatKhau, string TenNhanVien, string DiaChi, string SoDienThoai, int ChucVu)
        {
            
            this.email = Email;
            this.matkhau = MatKhau;
            this.tennv = TenNhanVien; 
            this.diachi = DiaChi;
            this.sdt = SoDienThoai;
            this.chucvu = ChucVu; 
            
        }
        public DTO_NHANVIEN(string Email, string MatKhau)
        {
            this.email = Email;
            this.matkhau = MatKhau;
        }
        public DTO_NHANVIEN(string Email, string TenNhanVien, string SoDienThoai, string DiaChi, int ChucVu)
        {
            this.email = Email;
            this.tennv = TenNhanVien;
            this.diachi = DiaChi;
            this.sdt = SoDienThoai;
            this.chucvu = ChucVu;

        }


    }
}
