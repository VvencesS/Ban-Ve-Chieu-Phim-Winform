using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QuanLyDatVe
{
    public partial class GUI_Ve : Form
    {
        public GUI_Ve()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadVe();
        }

        private void LoadVe()
        {
            dgvVe.DataSource = BUS.BUS_QuanLyDatVe.BUS_Ve.LayTatCaVe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUI_ThemVe gUI_ThemVe = new GUI_ThemVe();
            gUI_ThemVe.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadVe();
        }
    }
}
