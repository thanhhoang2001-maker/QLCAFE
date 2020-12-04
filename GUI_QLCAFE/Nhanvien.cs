using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLCAFE;
using BUS_QLCAFE;

namespace GUI_QLCAFE
{
    public partial class Nhanvien : Form
    {
        BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public Nhanvien()
        {
            InitializeComponent();
        }
        private void LoadGridview_NhanVien()
        {
            dgvNV.DataSource = busNhanVien.getNhanVien();
            dgvNV.Columns[0].HeaderText = "Email";
            dgvNV.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNV.Columns[2].HeaderText = "Địa chỉ";
            dgvNV.Columns[3].HeaderText = "Số Điện Thoại";
            dgvNV.Columns[4].HeaderText = "Chức Vụ";
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
                ResetValues();
                LoadGridview_NhanVien();
        }
        public void ResetValues()
        {
            txtTimNV.Text = "Nhập tên nhân viên";
            //.Text = null;
            //tbten.Text = null;
            //tbdiachi.Text = null;
            //tbemail.Enabled = false;
            //tbten.Enabled = false;
            //tbdiachi.Enabled = false;
            //rdnhanvien.Enabled = false;
            //rdquantri.Enabled = false;
            //rdhoatdong.Enabled = false;
            //rdnghoatdong.Enabled = false;
            
        }
    }
}
