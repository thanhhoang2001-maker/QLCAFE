using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    class DTO_DANHSACHMONAN
    {
        private int maloai;
        private int mamonan;
        private string tenmonan;
        private float dongia;
        public int MALOAI
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

        public DTO_DANHSACHMONAN(int MaLoai, int MaMonAn, string TenMonAn, float DonGia)
        {
            this.maloai = MaLoai;
            this.mamonan = MaMonAn;
            this.tenmonan = TenMonAn;
            this.dongia = DonGia;
        }
        public DTO_DANHSACHMONAN(DataRow row)
        {
            this.maloai = (int)row["MaLoai"];
            this.mamonan = (int)row["MaMonAn"];
            this.dongia = (float)Convert.ToDouble(row["DonGia"].ToString());
        }
    }
}
