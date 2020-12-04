using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QLCAFE;
using DAL_QLCAFE;
using System.Data;

namespace BUS_QLCAFE
{
    public class BUS_KHACHHANG
    {
        DAL_KHACHHANG dalKhach = new DAL_KHACHHANG();

        public DataTable GetKhach()
        {
            return dalKhach.GetKhach();
        }
        public bool InsertKhach(DTO_KHACHHANG khach)
        {
            return dalKhach.InsertKhach(khach);
        }
        public bool DeleteKhach(string sodienthoai)
        {
            return dalKhach.DeleteKhach(sodienthoai);
        }
        public bool UpdateKhach(DTO_KHACHHANG khach)
        {
            return dalKhach.UpdateKhach(khach);
        }
        public DataTable SearchKhach(string sodienthoai)
        {
            return dalKhach.SearchKhach(sodienthoai);
        }
    }
}
