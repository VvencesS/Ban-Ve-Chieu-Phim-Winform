using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QuanLyTaiKhoan
{
    public partial class GUI_NhanVien : Form
    {
        public static string ThaoTac;
        public static int _maNhanVien;
        public GUI_NhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvNhanVien.DataSource = BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.ThongTinNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            GUI_ThemNhanVien themNV = new GUI_ThemNhanVien();
            themNV.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maNhanVien <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
            }
            else
            {
                ThaoTac = "sua";
                GUI_ThemNhanVien SuaNV = new GUI_ThemNhanVien();
                SuaNV.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maNhanVien <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
            }
            else
            {
                DialogResult drt = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.XoaNhanVien(_maNhanVien);
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                _maNhanVien = int.Parse(dgvNhanVien.Rows[rindex].Cells["MaNhanVien"].Value.ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                dgvNhanVien.DataSource = BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.TimKiem(txtTimKiem.Text.ToString());
            }
        }

        public void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
