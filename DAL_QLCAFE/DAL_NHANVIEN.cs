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
    public class DAL_NHANVIEN : DBConnect
    {
        public bool NhanVienDangNhap(DTO_NHANVIEN nv)
        {
            try
            {
                _conn.Open();
                string SQL = "exec dbo.DangNhap @email @matkhau";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("Email", nv.Email);
                cmd.Parameters.AddWithValue("MatKhau", nv.MatKhau);

                if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
                    return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("Email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
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
        public bool TaoMatKhau(string email, string matkhaumoi )
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("MatKhau", matkhaumoi);
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
        public bool UpdateMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "chgpwd";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("@opwd", matkhaucu);
                cmd.Parameters.AddWithValue("@npwd", matkhaumoi);
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
        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTroNV]";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Connection = _conn;
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
            finally
            {
                _conn.Close();
            }
        }
        //public DataTable getNhanVien()
        //{
        //    try
        //    {
        //        _conn.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "[DanhSachNV]";
        //        cmd.Connection = _conn;
        //        DataTable dtHang = new DataTable();
        //        dtHang.Load(cmd.ExecuteReader());
        //        return dtHang;
        //    }
        //    finally
        //    {
        //        _conn.Close();
        //    }
        public bool insertNhanVien(DTO_NHANVIEN)

    }
    
}
