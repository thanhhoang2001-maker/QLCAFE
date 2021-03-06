﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCAFE
{
    public class DTO_KHACHHANG
    {
        private string sdtkh;
        private string emailkh;
        private string tenkh;
        private DateTime ngaysinh;

        public string SDTKH
        {
            get
            {
                return sdtkh;
            }
            set
            {
                sdtkh = value;
            }
        }
        public string EMAILKH
        {
            get
            {
                return emailkh;
            }
            set
            {
                emailkh = value;
            }
        }
        public string TENKH
        {
            get
            {
                return tenkh;
            }
            set
            {
                tenkh = value;
            }
        }
        public DateTime NGAYSINH
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                ngaysinh = value;
            }
        }

        public DTO_KHACHHANG(string SoDienThoai, string TenKhachHang, string Email,  DateTime NgaySinh)
        {
            this.sdtkh = SoDienThoai;
            this.tenkh = TenKhachHang;
            this.emailkh = Email;
            this.ngaysinh = NgaySinh;
        }
    }
}
