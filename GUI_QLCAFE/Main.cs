using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCAFE
{
    public partial class Main : Form
    {
        public static int profile = 0;
        public static int session = 0;
        public static string main;
        public Main()
        {
            InitializeComponent();
        }

        public Main(string dnmail)
        {
            main = dnmail;
        }

        public static string mail;
        public static int chucvu;
        private void btNhanvien_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Nhanvien nhanvien = new Nhanvien();

            nhanvien.Activate();
            nhanvien.Show();
        }

        private void btKhachhang_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Khachhang khachhang = new Khachhang();
            khachhang.Activate();
            khachhang.Show();
        }

        private void btSanpham_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Sanpham sanpham = new Sanpham();
            sanpham.Activate();
            sanpham.Show();
        }

        private void btBanhang_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Banhang banhang = new Banhang();
            banhang.Activate();
            banhang.Show();
        }

        private void btThongke_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Thongke thongke = new Thongke();
            thongke.Activate();
            thongke.Show();
        }

        private void btDoimatkhau_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            DoiMK doimatkhau = new DoiMK(mail);
            doimatkhau.Activate();
            doimatkhau.Show();
        }

        private void btDangxuat_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            FormDangnhap dangnhap = new FormDangnhap();
            dangnhap.Activate();
            dangnhap.Show();
        }

        private void btThoatMain_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
