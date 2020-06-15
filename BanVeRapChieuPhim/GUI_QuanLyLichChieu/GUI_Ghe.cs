using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QuanLyLichChieu
{
    public partial class GUI_Ghe : Form
    {
        public static string ThaoTac;
        public static int _maGhe;
        public GUI_Ghe()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvGhe.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.LayTatCaGhe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            GUI_ThemGhe themGhe = new GUI_ThemGhe();
            themGhe.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maGhe <= 0)
            {
                MessageBox.Show("Vui lòng chọn ghế cần sửa!");
            }
            else
            {
                ThaoTac = "sua";
                GUI_ThemGhe SuaGhe = new GUI_ThemGhe();
                SuaGhe.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maGhe <= 0)
            {
                MessageBox.Show("Vui lòng chọn ghế cần xóa!");
            }
            else
            {
                DialogResult drt = MessageBox.Show("Bạn muốn xóa ghế này?", "Xóa ghế", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    BUS.BUS_QuanLyLichChieu.BUS_Ghe.XoaGhe(_maGhe);
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGhe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                _maGhe = int.Parse(dgvGhe.Rows[rindex].Cells["MaGhe"].Value.ToString());
            }
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    if (txtTimKiem.Text != "")
        //    {
        //        dgvGhe.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.TimKiemGhe(txtTimKiem.Text.ToString());
        //    }
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GUI_Ghe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
