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
    public class DAL_SANPHAM : DBConnect
    {
        public DataTable GetSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachSanPham";
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool InsertSanPham(DTO_SANPHAM SP)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertDataIntoTblSanPham]";
                cmd.Parameters.AddWithValue("TenSP", SP.TENSP);
                //cmd.Parameters.AddWithValue("MaSP", SP.MASP);
                cmd.Parameters.AddWithValue("MaLoai", SP.MALOAI);
                cmd.Parameters.AddWithValue("SoLuongCon", SP.SOLUONGCON);
                cmd.Parameters.AddWithValue("GiaBan", SP.GIABAN);
                cmd.Parameters.AddWithValue("HinhAnh", SP.HINHANH);
                cmd.Parameters.AddWithValue("MoTa", SP.MOTA);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteSanPham(string masanpham)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromtblSanPham";
                cmd.Parameters.AddWithValue("masanpham", masanpham);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateSanPham(DTO_SANPHAM SP)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateDataIntoTblSanPham]";
                cmd.Parameters.AddWithValue("MaSP", SP.MASP);
                cmd.Parameters.AddWithValue("MaLoai", SP.MALOAI);
                cmd.Parameters.AddWithValue("TenHang", SP.TENSP);
                cmd.Parameters.AddWithValue("SoLuong", SP.SOLUONGCON);
                cmd.Parameters.AddWithValue("GiaBan", SP.GIABAN);
                cmd.Parameters.AddWithValue("HinhAnh", SP.HINHANH);
                cmd.Parameters.AddWithValue("MoTa", SP.MOTA);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable SearchSanPham(string tensanpham)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchSanPham]";
                cmd.Parameters.AddWithValue("tensanpham", tensanpham);
                cmd.Connection = _conn;
                DataTable dtnhanvien = new DataTable();
                dtnhanvien.Load(cmd.ExecuteReader());
                return dtnhanvien;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
