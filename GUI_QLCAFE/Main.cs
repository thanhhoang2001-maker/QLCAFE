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

        }

        private void btBanhang_Click(object sender, EventArgs e)
        {
            Form formBanHang = new Banhang();
            formBanHang.Show();
        }

        private void btSanpham_Click(object sender, EventArgs e)
        {
            Sanpham frmSanPham = new Sanpham();
            frmSanPham.Show();
        }
    }
}
