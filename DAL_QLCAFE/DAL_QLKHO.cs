using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLCAFE;

namespace DAL_QLCAFE
{
    public class DAL_QLKHO : DBConnect
    {
        public DataTable getNguyenLieu()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachSanPham";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool ThemHangHoa(DTO_SANPHAM sp, string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoTblSanPham";
                cmd.Parameters.AddWithValue("tenSanPham", sp.TENSP);
                cmd.Parameters.AddWithValue("soLuongCon", sp.SOLUONGCON);
                cmd.Parameters.AddWithValue("giaBan", sp.GIABAN);
                cmd.Parameters.AddWithValue("hinhAnh", sp.HINHANH);
                cmd.Parameters.AddWithValue("moTa", sp.MOTA);
                cmd.Parameters.AddWithValue("email", sp.EMAIL);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool XoaHangHoa(int masanpham)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromtblSanPham";
                cmd.Parameters.AddWithValue("maSanPham", masanpham);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool SuaHangHoa(int masanpham, string tensanpham, int soluong, float giaban, string hinhanh, string mota)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoTblSanPham";
                cmd.Parameters.AddWithValue("maSanPham", masanpham);
                cmd.Parameters.AddWithValue("tenSanPham", tensanpham);
                cmd.Parameters.AddWithValue("soLuong", soluong);
                cmd.Parameters.AddWithValue("giaBan", giaban);
                cmd.Parameters.AddWithValue("hinhAnh", hinhanh);
                cmd.Parameters.AddWithValue("moTa", mota);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable searchSanPham(string tensanpham)
        {
            SqlDataAdapter da = new SqlDataAdapter("EXEC SearchSanPham '" + tensanpham + "'", _conn);
            DataTable dtHang = new DataTable();
            da.Fill(dtHang);
            return dtHang;
        }
    }
}
