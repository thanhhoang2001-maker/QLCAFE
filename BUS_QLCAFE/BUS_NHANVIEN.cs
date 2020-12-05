using DAL_QLCAFE;
using DTO_QLCAFE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BUS_QLCAFE
{
    public class BUS_NHANVIEN
    {
        DAL_NHANVIEN dalNhanVien = new DAL_NHANVIEN();



        public bool NhanVienDangNhap(DTO_NHANVIEN nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }

        public string encryption(string MATKHAU)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encryoted data 
            encrypt = md5.ComputeHash(encode.GetBytes(MATKHAU));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.NhanVienQuenMatKhau(email);
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder buider = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                buider.Append(ch);
            }
            if (lowerCase)
                return buider.ToString().ToLower();
            return buider.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public bool TaoMatKhau(string email, string matkhaumoi)
        {
            return dalNhanVien.TaoMatKhau(email, matkhaumoi);
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                
                NetworkCredential cred = new NetworkCredential("hoangntps11683@fpt.edu.vn", "07103659615aA");
                
                MailMessage Msg = new MailMessage();
                
                Msg.From = new MailAddress("hoangntps11683@fpt.edu.vn");
                
                Msg.To.Add(email);
               
                Msg.Subject = "Ban da su dung tinh nang quen Mat khau";
                
                Msg.Body = "Chào anh/chị. Mật khẩu moi truy cập phần mềm là " + matkhau;
                
                client.Credentials = cred;
                
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Mot Email phục hồi mat khau da duoc goi toi ban!");

            }
            catch (Exception ex)
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed 
                MessageBox.Show(ex.Message);
            }
        }

        public bool UpdateMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            return dalNhanVien.UpdateMatKhau(email, matkhaucu, matkhaumoi);
        }
        public DataTable VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }

        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }
        public bool insertNhanVien(DTO_NHANVIEN nv)
        {
            return dalNhanVien.insertNhanVien(nv);
        }

        public bool DeleteNhanVien(string tendangnhap)
        {
            return dalNhanVien.DeleteNhanVien(tendangnhap);
        }

        public bool UpdateNhanVien(DTO_NHANVIEN Nv)
        {
            return dalNhanVien.UpdateNhanVien(Nv);
        }

        public DataTable SearchNhanVien(string tennhanvien)
        {
            return dalNhanVien.SearchNhanVien(tennhanvien);
        }
    }
}
