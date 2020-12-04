using DAL_QLCAFE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLCAFE;

namespace BUS_QLCAFE
{
    public class BUS_QLKHO
    {
        DAL_QLKHO dalKho = new DAL_QLKHO();
        public DataTable getNguyenLieu()
        {
            return dalKho.getNguyenLieu();
        }
        public bool ThemSanPham(DTO_SANPHAM sp, string email)
        {
            return dalKho.ThemHangHoa(sp, email);
        }
        public bool XoaSanPham(int masanpham)
        {
            return dalKho.XoaHangHoa(masanpham);
        }
        public bool SuaSanPham(int masanpham, string tensanpham, int soluong, float giaban, string hinhanh, string mota)
        {
            return dalKho.SuaHangHoa(masanpham, tensanpham, soluong, giaban, hinhanh, mota);
        }
        public DataTable searchSanPham(string tensanpham)
        {
            return dalKho.searchSanPham(tensanpham);
        }
    }
}
