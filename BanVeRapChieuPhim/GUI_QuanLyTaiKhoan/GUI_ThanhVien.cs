using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QuanLyTaiKhoan
{
    public partial class GUI_ThanhVien : Form
    {
        public static string ThaoTac;
        public static int _maThanhVien;

        //public static object SQLDatabase { get; private set; }

        public GUI_ThanhVien()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvThanhVien.DataSource = BUS.BUS_QuanLyTaiKhoan.BUS_ThanhVien.ThongTinThanhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            GUI_ThemThanhVien themTV = new GUI_ThemThanhVien();
            themTV.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maThanhVien <= 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên cần sửa!");
            }
            else
            {
                ThaoTac = "sua";
                GUI_ThemThanhVien SuaTV = new GUI_ThemThanhVien();
                SuaTV.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maThanhVien <= 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên cần xóa!");
            }
            else
            {
                DialogResult drt = MessageBox.Show("Bạn muốn xóa thành viên này?", "Xóa thành viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    BUS.BUS_QuanLyTaiKhoan.BUS_ThanhVien.XoaThanhVien(_maThanhVien);
                    LoadData();
                }
            }
        }

        public void GUI_ThanhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLichSuDatVe_Click(object sender, EventArgs e)
        {
            ThaoTac = "lichsuve";
            GUI_QuanLyDatVe.GUI_DanhSachDatVe dsDatVe = new GUI_QuanLyDatVe.GUI_DanhSachDatVe();
            dsDatVe.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                _maThanhVien = int.Parse(dgvThanhVien.Rows[rindex].Cells["MaThanhVien"].Value.ToString());
            }
        }
    }  
}
