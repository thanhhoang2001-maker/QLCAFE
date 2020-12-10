using BUS_QLCAFE;
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
    public partial class DoiMK : Form
    {
        public DoiMK(string email)
        {
            InitializeComponent();
            txtEmailDMK.Text = email;
        }
        BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();


        private void btThoatDoiMK_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Main main = new Main();
            main.Activate();
            main.Show();
        }

        private void btThuchien_Click(object sender, EventArgs e)
        {
            if(txtMKcu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
                return;
            }
            else if(txtMKmoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                return;
            }
            else if(txtXNMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa xác nhận lại mật khẩu");
                return;
            }
            else if(txtMKmoi.Text.Trim() != txtXNMK.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trung nhau");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật mật khẩu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = busNhanVien.encryption(txtMKmoi.Text);
                    string matkhaucu = busNhanVien.encryption(txtMKcu.Text);
                    if (busNhanVien.UpdateMatKhau(txtEmailDMK.Text, matkhaucu, matkhaumoi))
                    {

                        Main.profile = 1;
                        Main.session = 0;
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại");
                        //this.Close();

                        Visible = false;
                        ShowInTaskbar = false;

                        Main main = new Main(txtEmailDMK.Text);

                        main.Activate();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng");
                        txtMKcu.Text = null;
                        txtMKmoi.Text = null;
                        txtXNMK.Text = null;
                    }
                }
                else
                {
                    txtMKcu.Text = null;
                    txtMKmoi.Text = null;
                    txtXNMK.Text = null;
                }
            }
        }

        private void btThoatDoiMK_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
