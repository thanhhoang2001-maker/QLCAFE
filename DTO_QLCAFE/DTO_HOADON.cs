using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    class DTO_HOADON
    {
        private int mahd;
        private DateTime thoigian;
        private float tonggiatien;
        private int manv;

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
        public DateTime THOIGIAN
        {
            get
            {
                return thoigian;
            }
            set
            {
                thoigian = value;
            }
        }
        public float TONGGIATIEN
        {
            get
            {
                return tonggiatien;
            }
            set
            {
                tonggiatien = value;
            }
        }
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
        
        public DTO_HOADON(int MaHoaDon, DateTime ThoiGian, float TongGiaTien)
        {
            this.mahd = MaHoaDon;
            this.thoigian = ThoiGian;
            this.tonggiatien = TongGiaTien;
        }
    }
}
