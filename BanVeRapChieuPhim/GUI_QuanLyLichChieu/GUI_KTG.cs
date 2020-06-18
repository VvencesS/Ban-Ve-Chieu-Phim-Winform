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
    public partial class GUI_KTG : Form
    {
        public static string ThaoTac;
        public static int _maKTG;
        public GUI_KTG()
        {
            InitializeComponent();

            LoadData();
            txtMaKTG.Enabled = false;
        }
        public void LoadData()
        {
            dgvKTG.DataSource = BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.LayTatCaKTG();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            if (txtNgayChieu.Text == "" || txtGioChieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.ThemMoiKTG(txtNgayChieu.Text.Trim(), txtGioChieu.Text.Trim());
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.CapNhatKTG(int.Parse(txtMaKTG.Text.ToString()), txtNgayChieu.Text.Trim(), txtGioChieu.Text.Trim());
            MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maKTG <= 0)
            {
                MessageBox.Show("Vui lòng chọn khung thời gian cần xóa!");
            }
            else
            {
                DialogResult drt = MessageBox.Show("Bạn muốn xóa khung thời gian này?", "Xóa khung thời gian", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.XoaKhungThoiGian(_maKTG);
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvKTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                txtMaKTG.Text = dgvKTG.Rows[rindex].Cells["MaKTG"].Value.ToString();
                _maKTG = int.Parse(dgvKTG.Rows[rindex].Cells["MaKTG"].Value.ToString());
                txtNgayChieu.Text = (dgvKTG.Rows[rindex].Cells["NgayChieu"].Value.ToString().Substring(0, 10));
                txtGioChieu.Text = dgvKTG.Rows[rindex].Cells["GioChieu"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                dgvKTG.DataSource = BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.Search(txtTimKiem.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
