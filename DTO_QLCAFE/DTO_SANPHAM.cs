using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    public class DTO_SANPHAM
    {
        private int masp;
        private string maloai;
        private string tensp;
        private int soluongcon;
        private float giaban;
        private string hinhanh;
        private string mota;
        private string email;

        public int MASP
        {
            get
            {
                return masp;
            }
            set
            {
                masp = value;
            }
        }
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
        public string TENSP
        {
            get
            {
                return tensp;
            }
            set
            {
                tensp = value;
            }
        }
        public int SOLUONGCON
        {
            get
            {
                return soluongcon;
            }
            set
            {
                soluongcon = value;
            }
        }
        public float GIABAN
        {
            get
            {
                return giaban;
            }
            set
            {
                giaban = value;
            }
        }
        public string HINHANH
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }
        public string MOTA
        {
            get
            {
                return mota;
            }
            set
            {
                mota = value;
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

        public DTO_SANPHAM(int MaSanPham, string MaLoai, string TenSanPham, int SoLuongCon, float GiaBan, string HinhAnh, string MoTa)
        {
            this.masp = MaSanPham;
            this.maloai = MaLoai;
            this.tensp = TenSanPham;
            this.soluongcon = SoLuongCon;
            this.giaban = GiaBan;
            this.hinhanh = HinhAnh;
            this.mota = MoTa;
        }
        public DTO_SANPHAM()
        {

        }
    }
}
