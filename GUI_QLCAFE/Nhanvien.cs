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
using System.Net.Mail;

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
            dgvNV.Columns[0].HeaderText = "Tên Nhân Viên";
            dgvNV.Columns[1].HeaderText = "Số Điện Thoại";
            dgvNV.Columns[2].HeaderText = "Email";
            dgvNV.Columns[3].HeaderText = "Địa chỉ";
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
            txtTenNV.Text = null;
            txtEmailNV.Text = null;
            txtSdtNV.Text = null;
            txtDiachiNV.Text = null;

            txtTenNV.Enabled = false;
            txtSdtNV.Enabled = false;
            txtEmailNV.Enabled = false;
            txtDiachiNV.Enabled = false;
            

            rbRoleNV.Enabled = false;
            rbRoleQL.Enabled = false;

        }

        private void Nhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            txtEmailNV.Text = null;
            txtTenNV.Text = null;
            txtDiachiNV.Text = null;
            txtSdtNV.Text = null;

            txtEmailNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtDiachiNV.Enabled = true;
            txtSdtNV.Enabled = true;

            rbRoleNV.Enabled = true;
            rbRoleQL.Enabled = true;

            rbRoleNV.Checked = false;
            rbRoleQL.Checked = false;

        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            string email = txtEmailNV.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNhanVien.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValues();
                    LoadGridview_NhanVien();
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

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            else if (txtDiachiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachiNV.Focus();
                return;
            }
            else
            {
                int role = 0;
                if (rbRoleQL.Checked)
                    role = 1;

                DTO_NHANVIEN nv = new DTO_NHANVIEN(txtTenNV.Text, txtEmailNV.Text, txtSdtNV.Text, txtDiachiNV.Text, role);

                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNhanVien.UpdateNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGridview_NhanVien();
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

        private void btLuuNV_Click(object sender, EventArgs e)
        {
            string email;
            int role = 0;
            if (rbRoleQL.Checked)
                role = 1;
            
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            else if (txtSdtNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdtNV.Focus();
                return;
            }
            if (txtEmailNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailNV.Focus();
                return;
            }
            else if (!IsValid(txtEmailNV.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailNV.Focus();
                return;
            }
            if (txtDiachiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachiNV.Focus();
                return;
            }
            if (rbRoleQL.Checked == false && rbRoleNV.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            else
            {
                DTO_NHANVIEN nv = new DTO_NHANVIEN(txtTenNV.Text, txtSdtNV.Text, txtEmailNV.Text,  txtDiachiNV.Text, role);
                if (busNhanVien.insertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadGridview_NhanVien();
                    email = txtEmailNV.Text;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btThoatNV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNV.Rows.Count > 1)
            {
                btLuuNV.Enabled = false;
                txtTenNV.Enabled = true;
                txtSdtNV.Enabled = true;
                txtEmailNV.Enabled = true;
                txtDiachiNV.Enabled = true;
                rbRoleNV.Enabled = true;
                rbRoleQL.Enabled = true;
                btSuaNV.Enabled = true;
                btXoaNV.Enabled = true;

                txtTenNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
                txtSdtNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
                txtEmailNV.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
                txtDiachiNV.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();

                if (int.Parse(dgvNV.CurrentRow.Cells[4].Value.ToString()) == 1)
                    rbRoleQL.Checked = true;
                else
                    rbRoleNV.Checked = true;
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
