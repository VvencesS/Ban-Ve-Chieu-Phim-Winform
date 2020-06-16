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
    public partial class GUI_ThemThanhVien : Form
    {
        GUI_ThanhVien GUI_TV = new GUI_ThanhVien();
        public GUI_ThemThanhVien()
        {
            InitializeComponent();
            if (GUI_ThanhVien.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                btnThem.Text = "Thêm mới";
                txtMaThanhVien.Enabled = false;

                LoadXaPhuong();
                LoadQuanHuyen();
                LoadTinhThanhPho();
            }
            else
            {
                //Nếu là sửa
                btnThem.Text = "Sửa";
                txtMaThanhVien.Enabled = false;

                LoadXaPhuong();
                LoadQuanHuyen();
                LoadTinhThanhPho();
                LoadData();
            }
        }

        private void LoadData()
        {
            DataTable dt = BUS.BUS_QuanLyTaiKhoan.BUS_ThanhVien.ThongTinThanhVienTHeoMa(GUI_ThanhVien._maThanhVien);
            txtMaThanhVien.Text = dt.Rows[0]["MaThanhVien"].ToString();
            txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtPassWord.Text = dt.Rows[0]["Password"].ToString();
            txtSDT.Text = dt.Rows[0]["Sdt"].ToString();
            txtSoThe.Text = dt.Rows[0]["SoThe"].ToString();
            txtNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString().Substring(0, 10);
            if ((bool)dt.Rows[0]["TrangThai"] == true)
            {
                cboTrangThai.SelectedItem = "Đã kích hoạt";
            }
            else
            {
                cboGioiTinh.SelectedItem = "Chưa kích hoạt";
            }
            if ((bool)dt.Rows[0]["GioiTinh"] == true)
            {
                cboGioiTinh.SelectedItem = "Nam";
            }
            else
            {
                cboGioiTinh.SelectedItem = "Nữ";
            }
            dt = BUS.BUS_QuanLyLichChieu.BUS_XaPhuong.ThongTinXaPhuongTheoTen(dt.Rows[0]["TenXaPhuong"].ToString());
            cboXaPhuong.SelectedValue = dt.Rows[0]["IDXaPhuong"].ToString();
            LoadQuanHuyenTheoIDXaPhuong(int.Parse(dt.Rows[0]["IDXaPhuong"].ToString()));
        }

        private void LoadTinhThanhPhoTheoIDQuanHuyen(int idQuanHuyen)
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_QuanHuyen.ThongTinQuanHuyenTheoMa(idQuanHuyen);
            dt = BUS.BUS_QuanLyLichChieu.BUS_TinhThanhPho.ThongTinTinhThanhPhoTheoMa(int.Parse(dt.Rows[0]["IDTinhThanhPho"].ToString()));
            cboTinhThanhPho.SelectedValue = dt.Rows[0]["IDTinhThanhPho"].ToString();
        }

        private void LoadQuanHuyenTheoIDXaPhuong(int idXaPhuong)
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_XaPhuong.ThongTinXaPhuongTheoMa(idXaPhuong);
            dt = BUS.BUS_QuanLyLichChieu.BUS_QuanHuyen.ThongTinQuanHuyenTheoMa(int.Parse(dt.Rows[0]["IDQuanHuyen"].ToString()));
            cboQuanHuyen.SelectedValue = dt.Rows[0]["IDQuanHuyen"].ToString();

            LoadTinhThanhPhoTheoIDQuanHuyen(int.Parse(dt.Rows[0]["IDQuanHuyen"].ToString()));
        }

        private void LoadQuanHuyenTheoMaTinhThanhPho(int maTinhThanhPho)
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_QuanHuyen.ThongTinQuanHuyenTheoMaTinhThanhPho(maTinhThanhPho);
            cboQuanHuyen.DataSource = dt;
            cboQuanHuyen.DisplayMember = "TenQuanHuyen";
            cboQuanHuyen.ValueMember = "IDQuanHuyen";
        }

        private void LoadXaPhuongTheoMaQuanHuyen(int maQuanHuyen)
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_XaPhuong.ThongTinXaPhuongTheoMaQuanHuyen(maQuanHuyen);
            cboXaPhuong.DataSource = dt;
            cboXaPhuong.DisplayMember = "TenXaPhuong";
            cboXaPhuong.ValueMember = "IDXaPhuong";
        }

        void LoadXaPhuong()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_XaPhuong.ThongTinTatCaXaPhuong();
            cboXaPhuong.DataSource = dt;
            cboXaPhuong.DisplayMember = "TenXaPhuong";
            cboXaPhuong.ValueMember = "IDXaPhuong";
        }
        void LoadQuanHuyen()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_QuanHuyen.ThongTinTatCaQuanHuyen();
            cboQuanHuyen.DataSource = dt;
            cboQuanHuyen.DisplayMember = "TenQuanHuyen";
            cboQuanHuyen.ValueMember = "IDQuanHuyen";
        }
        void LoadTinhThanhPho()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_TinhThanhPho.ThongTinTatCaTinhThanhPho();
            cboTinhThanhPho.DataSource = dt;
            cboTinhThanhPho.DisplayMember = "TenTinhThanhPho";
            cboTinhThanhPho.ValueMember = "IDTinhThanhPho";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GUI_ThanhVien.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                if (txtEmail.Text == "" || txtHoTen.Text == "" || txtPassWord.Text == ""
                    || txtSoThe.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyTaiKhoan.BUS_ThanhVien.ThemMoiThanhVien(txtHoTen.Text.Trim(),
                        txtEmail.Text.Trim(), txtSDT.Text.Trim(), txtSoThe.Text.Trim(), cboGioiTinh.SelectedItem.ToString(),
                        txtNgaySinh.Text.Trim(), txtPassWord.Text.Trim(), cboXaPhuong.SelectedValue.ToString(), cboTrangThai.SelectedItem.ToString());
                    MessageBox.Show("Thêm thành công!");
                    GUI_TV.LoadData();
                    this.Close();
                }
            }
            else
            {
                //Nếu là chỉnh sửa
                if (txtEmail.Text == "" || txtHoTen.Text == "" || txtPassWord.Text == ""
                    || txtSoThe.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyTaiKhoan.BUS_ThanhVien.CapNhatThanhVien(txtHoTen.Text.Trim(),
                            txtEmail.Text.Trim(), txtSDT.Text.Trim(), txtSoThe.Text.Trim(), cboGioiTinh.SelectedItem.ToString(),
                            txtNgaySinh.Text.Trim(), txtPassWord.Text.Trim(), cboXaPhuong.SelectedValue.ToString(),
                            cboTrangThai.SelectedItem.ToString(), int.Parse(txtMaThanhVien.Text.ToString()));

                    MessageBox.Show("Sửa thành công!");
                    GUI_TV.LoadData();
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTinhThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinhThanhPho.ValueMember.Length > 0)
            {
                LoadQuanHuyenTheoMaTinhThanhPho(int.Parse(cboTinhThanhPho.SelectedValue.ToString()));
            }
        }

        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuanHuyen.ValueMember.Length > 0)
            {
                LoadXaPhuongTheoMaQuanHuyen(int.Parse(cboQuanHuyen.SelectedValue.ToString()));
            }
        }

        private void cboXaPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
