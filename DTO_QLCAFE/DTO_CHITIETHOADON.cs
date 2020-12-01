using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    class DTO_CHITIETHOADON
    {
        private int mahd;
        private int masp;
        private int soluongmua;

        public int MAHD
        {
            get
            {
                return mahd;
            }
            set
            {
                mahd = value;
            }
        }
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
        public int SOLUONGMUA
        {
            get
            {
                return soluongmua;
            }
            set
            {
                soluongmua = value;
            }
        }

        public DTO_CHITIETHOADON(int MaHoaDon, int MaSanPham, int SoLuongMua)
        {
            this.mahd = MaHoaDon;
            this.masp = MaSanPham;
            this.soluongmua = SoLuongMua;
        }
    }
}
