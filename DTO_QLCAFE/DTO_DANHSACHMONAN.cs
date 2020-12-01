using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    class DTO_DANHSACHMONAN
    {
        private string maloai;
        private int mamonan;
        private string tenmonan;
        private float dongia;
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
        public int MAMONAN
        {
            get
            {
                return mamonan;
            }
            set
            {
                mamonan = value;
            }
        }
        public string TENMONAN
        {
            get
            {
                return tenmonan;
            }
            set
            {
                tenmonan = value;
            }
        }
        public float DONGIA
        {
            get
            {
                return dongia;
            }
            set
            {
                dongia = value;
            }
        }

        public DTO_DANHSACHMONAN(string MaLoai, int MaMonAn, string TenMonAn, float DonGia)
        {
            this.maloai = MaLoai;
            this.mamonan = MaMonAn;
            this.tenmonan = TenMonAn;
            this.dongia = DonGia;
        }
    }
}
