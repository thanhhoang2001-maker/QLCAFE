using BUS_QLCAFE;
using DTO_QLCAFE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCAFE
{
    public partial class Sanpham : Form
    {
        BUS_SANPHAM busSanPham = new BUS_SANPHAM();
        string strEmail;
        string duongdanImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        string checkUrlImage;

        public Sanpham()
        {
            InitializeComponent();
        }
        public Sanpham(string email)
        {
            InitializeComponent();
            strEmail = email;

        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busSanPham.GetSanPham();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSP.CurrentRow.Index < dgvSP.Rows.Count - 1)
            {
                int i;
                i = dgvSP.CurrentRow.Index;
                txtMaSanPham.Text = dgvSP.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSP.Rows[i].Cells[1].Value.ToString();
                txtGiabanSP.Text = dgvSP.Rows[i].Cells[2].Value.ToString();
                txtSoluongSP.Text = dgvSP.Rows[i].Cells[3].Value.ToString();
                txtMotaSP.Text = dgvSP.Rows[i].Cells[4].Value.ToString();

                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                btMoanhSP.Enabled = false;
                btLuuSP.Enabled = false;
                btSuaSP.Enabled = true;
                txtTenSP.Enabled = true;
                txtSoluongSP.Enabled = true;
                txtGiabanSP.Enabled = true;
                txtMotaSP.Enabled = true;

                btXoaSP.Enabled = true;
                checkUrlImage = duongdanImage;
                ptbHinhanhSP.Image = Image.FromFile(saveDirectory + dgvSP.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }

        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            btLuuSP.Enabled = true;
            btXoaSP.Enabled = false;
            btThemSP.Enabled = false;
            btSuaSP.Enabled = false;
            txtMaSanPham.Enabled = false;
            txtTenSP.Text = "";
            txtGiabanSP.Text = "";
            txtSoluongSP.Text = "";
            txtMotaSP.Text = "";
            duongdanImage = "";
        }

        private void btLuuSP_Click(object sender, EventArgs e)
        {
            DTO_SANPHAM hang = new DTO_SANPHAM();
            hang.TENSP = txtTenSP.Text;
            hang.GIABAN = float.Parse(txtGiabanSP.Text);
            hang.SOLUONGCON = int.Parse(txtSoluongSP.Text);
            hang.MOTA = txtMotaSP.Text;
            hang.HINHANH = duongdanImage;
            hang.EMAIL = strEmail;
            File.Copy(fileAddress, fileSavePath, true);
            MessageBox.Show("Đã cập nhật sản phẩm!");
            if (txtTenSP.Text == "" || txtSoluongSP.Text == "" || txtGiabanSP.Text == "" || txtMotaSP.Text == "" || duongdanImage == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ các dữ liệu và chọn hình ảnh !!");
            }
            else
            {
                busSanPham.InsertSanPham(hang);
            }
        }

        private void btMoanhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                ptbHinhanhSP.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                duongdanImage = "\\Images\\" + fileName;
            }
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {
            busSanPham.DeleteSanPham(txtMaSanPham.Text);
            MessageBox.Show("Đã xóa sản phẩm!!");
        }

        private void btThoatSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSuaSP_Click(object sender, EventArgs e)
        {
            DTO_SANPHAM hang = new DTO_SANPHAM();
            hang.MASP = int.Parse(txtMaSanPham.Text);
            hang.TENSP = txtTenSP.Text;
            hang.GIABAN = float.Parse(txtGiabanSP.Text);
            hang.SOLUONGCON = int.Parse(txtSoluongSP.Text);
            hang.HINHANH = duongdanImage;
            hang.MOTA = txtMotaSP.Text;
            busSanPham.UpdateSanPham(hang);
            MessageBox.Show("Đã chỉnh sửa sản phẩm!!");
        }

        private void btTimSP_Click(object sender, EventArgs e)
        {
            busSanPham.SearchSanPham(txtTimSP.Text);
        }
    }
}
