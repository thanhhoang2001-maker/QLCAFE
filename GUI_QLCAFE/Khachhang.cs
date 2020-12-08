using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLCAFE;
using DTO_QLCAFE;

namespace GUI_QLCAFE
{
    public partial class Khachhang : Form
    {
        BUS_KHACHHANG busKhach = new BUS_KHACHHANG();
        public Khachhang()
        {
            InitializeComponent();
        }
        private void LoadGirdview_Khach()
        {
            dgvKH.DataSource = busKhach.GetKhach();
            dgvKH.Columns[0].HeaderText = "Họ và Tên";
            dgvKH.Columns[1].HeaderText = "Điện thoại";
            dgvKH.Columns[2].HeaderText = "Ngày sinh";
            dgvKH.Columns[3].HeaderText = "Email";
        }
        public void ResetValues()
        {
            txtTimKH.Text = "Nhập số điện thoại khách hàng";

            txtTenKH.Text = null;
            txtSdtKH.Text = null;
            txtEmailKH.Text = null;
            dtpNgaysinhKH.Text = null;

            txtTenKH.Enabled = false;
            txtSdtKH.Enabled = false;
            txtEmailKH.Enabled = false;
            dtpNgaysinhKH.Enabled = false;
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGirdview_Khach();
        }
        private void btThemKH_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = null;
            txtSdtKH.Text = null;
            txtEmailKH.Text = null;
            dtpNgaysinhKH.Text = null;

            txtTenKH.Enabled = true;
            txtSdtKH.Enabled = true;
            txtEmailKH.Enabled = true;
            dtpNgaysinhKH.Enabled = true;

            //btluu.Enabled = true;
            //btdong.Enabled = true;
            //btsua.Enabled = true;
            //btxoa.Enabled = true;
        }

        private void btXoaKH_Click(object sender, EventArgs e)
        {
            string sodienthoai = txtSdtKH.Text;

            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKhach.DeleteKhach(sodienthoai))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGirdview_Khach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btSuaKH_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSdtKH.Text.Trim().ToString(), out intDienThoai);

            if (!isInt || float.Parse(txtSdtKH.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại > 0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdtKH.Focus();
                return;
            }
            else
            {
                DTO_KHACHHANG kh = new DTO_KHACHHANG(txtTenKH.Text, txtSdtKH.Text, txtEmailKH.Text, dtpNgaysinhKH.Value.Date);
                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKhach.UpdateKhach(kh))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGirdview_Khach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    ResetValues();
                }
            }
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            txtTimKH.Text = null;
            txtTimKH.BackColor = Color.White;

        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            string sodienthoai = txtTimKH.Text;
            DataTable ds = busKhach.SearchKhach(sodienthoai);
            if (ds.Rows.Count > 0)
            {
                dgvKH.DataSource = ds;
                dgvKH.Columns[0].HeaderText = "Họ và Tên";
                dgvKH.Columns[1].HeaderText = "Điện thoại";
                dgvKH.Columns[2].HeaderText = "Ngày sinh";
                dgvKH.Columns[3].HeaderText = "Email";

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimKH.Text = "Nhập số điện thoại khách hàng";
            txtTimKH.BackColor = Color.LightGray;
            ResetValues();
        }

        private void btThoatKH_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Main main = new Main();

            main.Activate();
            main.Show();
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            
            if (dgvKH.Rows.Count > 1)
            {
                btLuuKH.Enabled = false;
                txtTenKH.Enabled = true;
                txtEmailKH.Enabled = true;
                txtSdtKH.Enabled = true;

                btXoaKH.Enabled = true;
                btSuaKH.Enabled = true;

                txtTenKH.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
                txtSdtKH.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
                txtEmailKH.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();

                string phai = dgvKH.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btLuuKH_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSdtKH.Text.Trim().ToString(), out intDienThoai);
            if (!isInt || float.Parse(txtSdtKH.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại > 0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdtKH.Focus();
                return;
            }
            else
            {
                DTO_KHACHHANG kh = new DTO_KHACHHANG(txtTenKH.Text, txtSdtKH.Text, txtEmailKH.Text, dtpNgaysinhKH.Value.Date);
                if (busKhach.InsertKhach(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadGirdview_Khach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }
    }
}
