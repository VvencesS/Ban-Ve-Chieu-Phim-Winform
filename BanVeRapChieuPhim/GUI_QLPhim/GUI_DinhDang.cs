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
    public partial class GUI_DinhDang : Form
    {
        public GUI_DinhDang()
        {
            InitializeComponent();

            LoadDinhDang();
        }

        private void LoadDinhDang()
        {
            dgvDinhDang.DataSource = BUS.BUS_QuanLyPhim.BUS_DinhDang.LayTatCaDinhDang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
