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
    public partial class Banhang : Form
    {
        public Banhang()
        {
            InitializeComponent();
        }
        #region TangGIamSoLuong
        private void btSoluongTru_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSoLuong.Text);
            sl--;
            if (sl < 0)
            {
                MessageBox.Show("Khong the nho hon!");
            }
            else
            {
                txtSoLuong.Text = sl.ToString();
            }
        }

        private void btSoluongThem_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSoLuong.Text);
            sl++;
            txtSoLuong.Text = sl.ToString();
        }
        #endregion

        #region LoadDoAn
        void LoadCategory()
        {

        }
        void LoadFoodCategoryID(int id)
        {

        }
        #endregion
        private void btThoatBH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Banhang_Load(object sender, EventArgs e)
        {
            
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btTroveBH_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Main main = new Main();
            main.Activate();
            main.Show();
        }
    }
}
