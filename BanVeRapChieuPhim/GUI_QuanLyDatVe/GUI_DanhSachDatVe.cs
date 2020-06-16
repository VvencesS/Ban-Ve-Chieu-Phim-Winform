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
    public partial class GUI_DanhSachDatVe : Form
    {
        public GUI_DanhSachDatVe()
        {
            InitializeComponent();

            LoaDSDatVeCuaThanhVien();
        }

        private void LoaDSDatVeCuaThanhVien()
        {
            if (GUI_QuanLyTaiKhoan.GUI_ThanhVien._maThanhVien > 0)
            {
                dgvDanhSachDatVe.DataSource = BUS.BUS_QuanLyDatVe.BUS_DSDatVe.LayDSDatVeTheoMaThanhVien(GUI_QuanLyTaiKhoan.GUI_ThanhVien._maThanhVien);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
