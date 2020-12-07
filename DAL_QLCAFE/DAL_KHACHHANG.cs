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
    public class DAL_KHACHHANG : DBConnect
    {
        public DataTable GetKhach()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachKhach]";
                cmd.Connection = _conn;
                DataTable dtKH = new DataTable();
                dtKH.Load(cmd.ExecuteReader());
                return dtKH;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool InsertKhach(DTO_KHACHHANG khach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertDataIntoTblKhach]";
                cmd.Parameters.AddWithValue("DienThoai", khach.SDTKH);
                cmd.Parameters.AddWithValue("TenKhach", khach.TENKH);
                cmd.Parameters.AddWithValue("NgaySinh", khach.NGAYSINH);
                cmd.Parameters.AddWithValue("Email", khach.EMAILKH);

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
        public bool DeleteKhach(string sodienthoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteDataFromtblKhach]";
                cmd.Parameters.AddWithValue("sodienthoai", sodienthoai);

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
        public bool UpdateKhach(DTO_KHACHHANG khach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateDataIntoTblKhach]";
                cmd.Parameters.AddWithValue("SoDienThoai", khach.SDTKH);
                cmd.Parameters.AddWithValue("TenKhach", khach.TENKH);
                cmd.Parameters.AddWithValue("NgaySinh", khach.NGAYSINH);



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
        public DataTable SearchKhach(string sodienthoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchKhach]";
                cmd.Parameters.AddWithValue("SoDienThoai", sodienthoai);
                cmd.Connection = _conn;
                DataTable dtkhach = new DataTable();
                dtkhach.Load(cmd.ExecuteReader());
                return dtkhach;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
