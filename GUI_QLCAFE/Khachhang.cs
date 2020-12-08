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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        private void btThoatKH_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btTroveKH_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Main main = new Main();
            main.Activate();
            main.Show();
        }
    }
}
