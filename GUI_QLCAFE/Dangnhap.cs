using BUS_QLCAFE;
using DTO_QLCAFE;
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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN busNhanvien = new BUS_NHANVIEN();

        public string vaitro { get; set; }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN(txtEmail.Text, txtMatkhau.Text);
            nv.EMAIL = txtEmail.Text;
            nv.MATKHAU = busNhanvien.encryption(txtMatkhau.Text);

            if (busNhanvien.NhanVienDangNhap(nv))
            {
                //Main = nv.EMAIL;
                //DataTable dt = busNhanvien.VaiTroNhanVien(nv.EMAIL);
                MessageBox.Show("Đăng nhập thành công");
                Visible = false;
                ShowInTaskbar = false;

                Main main = new Main();
               
                main.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, vui lòng kiểm tra lại Email hoặc mật khẩu");

            }
        }

        private void lbQuenmk_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (busNhanvien.NhanVienQuenMatKhau(txtEmail.Text))//show from input email. if true will send pass random
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(busNhanvien.RandomString(4, true));
                    builder.Append(busNhanvien.RandomNumber(1000, 9999));
                    builder.Append(busNhanvien.RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = busNhanvien.encryption(builder.ToString());
                    busNhanvien.TaoMatKhau(txtEmail.Text, matkhaumoi);
                    busNhanvien.SendMail(txtEmail.Text, builder.ToString()); // send new pass to email
                }
                else
                {
                    MessageBox.Show("Email không đúng, vui lòng nhập lại email");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới đã được gửi đển email, mời kiểm tra");
            }

        }

        private void btThoatDN_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            DoiMK doimatkhau = new DoiMK();
            doimatkhau.Activate();
            doimatkhau.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Visible = false;
            ShowInTaskbar = false;

            Main main = new Main();
            main.Activate();
            main.Show();
        }
    }
}
