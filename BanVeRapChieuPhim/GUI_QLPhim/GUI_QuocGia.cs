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
    public partial class GUI_QuocGia : Form
    {
        public GUI_QuocGia()
        {
            InitializeComponent();

            LoadQuocGia();
        }

        private void LoadQuocGia()
        {
            dgvQuocGia.DataSource = BUS.BUS_QuanLyPhim.BUS_QuocGia.LayTatCaQuocGia();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
