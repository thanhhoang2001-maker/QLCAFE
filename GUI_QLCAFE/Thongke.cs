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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void btTroveTK_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Main main = new Main();
            main.Activate();
            main.Show();
        }
    }
}
