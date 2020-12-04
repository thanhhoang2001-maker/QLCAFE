using DAL_QLCAFE;
using DTO_QLCAFE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS_QLCAFE
{
    public class BUS_SANPHAM
    {
        DAL_SANPHAM dalSanPham = new DAL_SANPHAM();

        public DataTable GetSanPham()
        {
            return dalSanPham.GetSanPham();
        }
        public bool InsertSanPham(DTO_SANPHAM hang)
        {
            return dalSanPham.InsertSanPham(hang);
        }
        public bool DeleteSanPham(string mahang)
        {
            return dalSanPham.DeleteSanPham(mahang);
        }
        public bool UpdateSanPham(DTO_SANPHAM hang)
        {
            return dalSanPham.UpdateSanPham(hang);
        }
        public DataTable SearchSanPham(string tenhang)
        {
            return dalSanPham.SearchSanPham(tenhang);
        }
    }
}
