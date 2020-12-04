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
        public Main()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Nhanvien nhanvien = new Nhanvien();

            nhanvien.Activate();
            nhanvien.Show();
        }

        private void btKhachhang_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Khachhang khachhang = new Khachhang();
            khachhang.Activate();
            khachhang.Show();
        }

        private void btSanpham_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Sanpham sanpham = new Sanpham();
            sanpham.Activate();
            sanpham.Show();
        }

        private void btBanhang_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Banhang banhang = new Banhang();
            banhang.Activate();
            banhang.Show();
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Thongke thongke = new Thongke();
            thongke.Activate();
            thongke.Show();
        }

        private void btDoimatkhau_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            DoiMK doimatkhau = new DoiMK();
            doimatkhau.Activate();
            doimatkhau.Show();
        }

        private void btDangxuat_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            FormDangnhap dangnhap = new FormDangnhap();
            dangnhap.Activate();
            dangnhap.Show();
        }

        private void btThoatMain_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
