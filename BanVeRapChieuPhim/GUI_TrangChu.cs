using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim
{
    public partial class GUI_TrangChu : Form
    {
        public GUI_TrangChu()
        {
            InitializeComponent();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            GUI_QuanLyTaiKhoan.GUI_NhanVien nv = new GUI_QuanLyTaiKhoan.GUI_NhanVien();
            nv.ShowDialog();
        }

        private void mnuThanhVien_Click(object sender, EventArgs e)
        {
            GUI_QuanLyTaiKhoan.GUI_ThanhVien tv = new GUI_QuanLyTaiKhoan.GUI_ThanhVien();
            tv.ShowDialog();
        }

        private void mnuPhim_Click(object sender, EventArgs e)
        {
            GUI_QLPhim.GUI_Phim phim = new GUI_QLPhim.GUI_Phim();
            phim.ShowDialog();
        }

        private void mnuDinhDangPhim_Click(object sender, EventArgs e)
        {
            GUI_QLPhim.GUI_DinhDang dinhDang = new GUI_QLPhim.GUI_DinhDang();
            dinhDang.ShowDialog();
        }

        private void mnuQuocGia_Click(object sender, EventArgs e)
        {
            GUI_QLPhim.GUI_QuocGia quocGia = new GUI_QLPhim.GUI_QuocGia();
            quocGia.ShowDialog();
        }

        private void mnuTheLoai_Click(object sender, EventArgs e)
        {
            GUI_QLPhim.GUI_TheLoai theLoai = new GUI_QLPhim.GUI_TheLoai();
            theLoai.ShowDialog();
        }

        private void mnuKTG_Click(object sender, EventArgs e)
        {
            GUI_QuanLyLichChieu.GUI_KTG ktg = new GUI_QuanLyLichChieu.GUI_KTG();
            ktg.ShowDialog();
        }

        private void mnuPhongChieu_Click(object sender, EventArgs e)
        {
            GUI_QuanLyLichChieu.GUI_Phong phong = new GUI_QuanLyLichChieu.GUI_Phong();
            phong.ShowDialog();
        }

        private void mnuGhe_Click(object sender, EventArgs e)
        {
            GUI_QuanLyLichChieu.GUI_Ghe ghe = new GUI_QuanLyLichChieu.GUI_Ghe();
            ghe.ShowDialog();
        }

        private void mnuVe_Click(object sender, EventArgs e)
        {
            GUI_QuanLyDatVe.GUI_Ve ve = new GUI_QuanLyDatVe.GUI_Ve();
            ve.ShowDialog();
        }

        private void mnuDSDatVe_Click(object sender, EventArgs e)
        {
            GUI_QuanLyDatVe.GUI_DanhSachDatVe DSVeDat = new GUI_QuanLyDatVe.GUI_DanhSachDatVe();
            DSVeDat.ShowDialog();
        }

        private void mnuDN_DX_Click(object sender, EventArgs e)
        {
            if (mnuDN_DX.Text == "Đăng xuất")
            {
                DialogResult drt = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (drt == DialogResult.OK)
                {
                    mnuQLDatVe.Enabled = false;
                    mnuQLLichChieu.Enabled = false;
                    mnuQLPhim.Enabled = false;
                    mnuQLTaiKhoan.Enabled = false;
                    mnuDN_DX.Text = "Đăng nhập";
                }
            }
            else
            {
                GUI_DangNhap dn = new GUI_DangNhap();
                dn.ShowDialog();
                if (dn.GetCheckLogin() == true)
                {
                    mnuQLDatVe.Enabled = true;
                    mnuQLLichChieu.Enabled = true;
                    mnuQLPhim.Enabled = true;
                    mnuQLTaiKhoan.Enabled = true;
                    mnuDN_DX.Text = "Đăng xuất";
                }
            }
        }

        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {
            mnuQLDatVe.Enabled = false;
            mnuQLLichChieu.Enabled = false;
            mnuQLPhim.Enabled = false;
            mnuQLTaiKhoan.Enabled = false;
        }

        private void mnuBaoGia_Click(object sender, EventArgs e)
        {
            GUI_QuanLyDatVe.GUI_BaoGia GUI_BaoGia = new GUI_QuanLyDatVe.GUI_BaoGia();
            GUI_BaoGia.ShowDialog();
        }
    }
}
