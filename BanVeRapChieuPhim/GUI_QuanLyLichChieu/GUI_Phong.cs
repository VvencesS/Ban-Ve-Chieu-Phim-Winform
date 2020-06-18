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
    public partial class GUI_Phong : Form
    {
        public static string ThaoTac;
        public static int _maPhong;
        public GUI_Phong()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            dgvPhong.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Phong.LayTatCaPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            GUI_ThemPhong themP = new GUI_ThemPhong();
            themP.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maPhong <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
            }
            else
            {
                ThaoTac = "sua";
                GUI_ThemPhong SuaP = new GUI_ThemPhong();
                SuaP.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maPhong <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
            }
            else
            {
                DialogResult drt = MessageBox.Show("Bạn muốn xóa phòng này?", "Xóa phòng", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    BUS.BUS_QuanLyLichChieu.BUS_Phong.XoaPhong(_maPhong);
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                _maPhong = int.Parse(dgvPhong.Rows[rindex].Cells["MaPhong"].Value.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
