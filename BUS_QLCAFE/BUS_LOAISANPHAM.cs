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
    public class BUS_LOAISANPHAM
    {
        DAL_LOAISANPHAM dalLoaiSanPham = new DAL_LOAISANPHAM();

        public DataTable GetLoai()
        {
            return dalLoaiSanPham.GetLoai();
        }
        public DataTable GetTenSanPham()
        {
            return dalLoaiSanPham.GetTenSanPham();
        }
    }
}
