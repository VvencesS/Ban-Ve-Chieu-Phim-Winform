using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QLPhim
{
    public partial class GUI_TheLoai : Form
    {
        public GUI_TheLoai()
        {
            InitializeComponent();

            LoadTheLoai();
        }

        private void LoadTheLoai()
        {
            dgvTheLoai.DataSource = BUS.BUS_QuanLyPhim.BUS_TheLoai.LayTatCaTheLoai();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
