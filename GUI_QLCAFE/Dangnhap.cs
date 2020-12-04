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
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN busNhanvien = new BUS_NHANVIEN();

        public string vaitro { get; set; }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN;
            nv.EMAIL = txtEmail.Text;
            nv.MATKHAU = txtMatkhau.Text;
            if (busNhanvien.NhanVienDangNhap(nv))
            {

            }
        }
    }
}
