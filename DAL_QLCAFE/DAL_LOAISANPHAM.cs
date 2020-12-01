using DTO_QLCAFE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCAFE
{
    public class DAL_LOAISANPHAM : DBConnect
    {
        public DataTable GetLoai()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachSanPham";
                cmd.Connection = _conn;
                DataTable dtLoai = new DataTable();
                dtLoai.Load(cmd.ExecuteReader());
                return dtLoai;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable GetTenSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachSanPham";
                cmd.Connection = _conn;
                DataTable dtTenSp = new DataTable();
                dtTenSp.Load(cmd.ExecuteReader());
                return dtTenSp;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
