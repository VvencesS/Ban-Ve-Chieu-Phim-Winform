using BanVeRapChieuPhim.GUI_QuanLyPhim;
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
    public partial class GUI_Phim : Form
    {
        public static string ThaoTac;
        public static int _maPhim;
        public GUI_Phim()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgvPhim.DataSource = BUS.BUS_QuanLyPhim.BUS_Phim.LayTatCaPhim();

            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)dgvPhim.Columns[2];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            GUI_ThemPhim themPhim = new GUI_ThemPhim();
            themPhim.ShowDialog();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maPhim <= 0)
            {
                MessageBox.Show("Vui lòng chọn phim cần sửa!");
            }    
            else
            {
                ThaoTac = "sua";
                GUI_ThemPhim SuaPhim = new GUI_ThemPhim();
                SuaPhim.ShowDialog();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maPhim <= 0)
            {
                MessageBox.Show("Vui lòng chọn phim cần xóa!");
            }    
            else
            {
                DialogResult drt = MessageBox.Show("Bạn muốn xóa phim này?", "Xóa phim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    BUS.BUS_QuanLyPhim.BUS_Phim.XoaPhim(_maPhim);
                    LoadData();
                }    

            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                _maPhim = int.Parse(dgvPhim.Rows[rindex].Cells["MaPhim"].Value.ToString());
            }    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                  dgvPhim.DataSource = BUS.BUS_QuanLyPhim.BUS_Phim.TimKiem(txtTimKiem.Text.ToString());
            }    
        }

        private void GUI_Phim_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
