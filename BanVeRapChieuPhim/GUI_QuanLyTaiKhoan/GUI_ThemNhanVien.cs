using BUS;
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
    public partial class GUI_ThemNhanVien : Form
    {
        public string _password = "";
        GUI_NhanVien GUI_NV = new GUI_NhanVien();
        public GUI_ThemNhanVien()
        {
            InitializeComponent();
            if (GUI_NhanVien.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                btnThem.Text = "Thêm mới";
                txtMaNhanVien.Enabled = false;

                LoadXaPhuong();
                LoadQuanHuyen();
                LoadTinhThanhPho();
            }
            else
            {
                //Nếu là sửa
                btnThem.Text = "Sửa";
                txtMaNhanVien.Enabled = false;

                LoadXaPhuong();
                LoadQuanHuyen();
                LoadTinhThanhPho();
                LoadData();
            }
        }
        private void LoadData()
        {
            DataTable dt = BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.ThongTinNhanVienTHeoMa(GUI_NhanVien._maNhanVien);
            txtMaNhanVien.Text = dt.Rows[0]["MaNhanVien"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
            txtNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString().Substring(0, 10);
            txtSDT.Text = dt.Rows[0]["Sdt"].ToString();
            txtSoThe.Text = dt.Rows[0]["SoThe"].ToString();
            txtTaiKhoan.Text = dt.Rows[0]["UserName"].ToString();
            _password = dt.Rows[0]["Password"].ToString();
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
            if (GUI_NhanVien.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                if(txtEmail.Text == "" ||  txtHoTen.Text == "" || txtMatKhau.Text == "" 
                    || txtSoThe.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "" || txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.ThemMoiNhanVien(txtTaiKhoan.Text.Trim(), txtHoTen.Text.Trim(), 
                        txtEmail.Text.Trim(), txtSDT.Text.Trim(), txtSoThe.Text.Trim(), cboGioiTinh.SelectedItem.ToString(), 
                        txtNgaySinh.Text.Trim(), MaHoa.MaHoaMD5(txtMatKhau.Text.Trim()), cboXaPhuong.SelectedValue.ToString());
                    MessageBox.Show("Thêm thành công!");
                    GUI_NV.LoadData();
                    this.Close();
                }
            }
            else
            {
                //Nếu là chỉnh sửa
                if (txtEmail.Text == "" || txtHoTen.Text == ""
                    || txtSoThe.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "" || txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    if(txtMatKhau.Text == "")
                    {
                        BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.CapNhatNhanVien(txtTaiKhoan.Text.Trim(), txtHoTen.Text.Trim(),
                        txtEmail.Text.Trim(), txtSDT.Text.Trim(), txtSoThe.Text.Trim(), cboGioiTinh.SelectedItem.ToString(),
                        txtNgaySinh.Text.Trim(), _password, cboXaPhuong.SelectedValue.ToString(), int.Parse(txtMaNhanVien.Text.ToString()));
                    }
                    else
                    {
                        BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.CapNhatNhanVien(txtTaiKhoan.Text.Trim(), txtHoTen.Text.Trim(),
                        txtEmail.Text.Trim(), txtSDT.Text.Trim(), txtSoThe.Text.Trim(), cboGioiTinh.SelectedItem.ToString(),
                        txtNgaySinh.Text.Trim(), MaHoa.MaHoaMD5(txtMatKhau.Text.Trim()), cboXaPhuong.SelectedValue.ToString(), int.Parse(txtMaNhanVien.Text.ToString()));
                    }
                    
                    MessageBox.Show("Sửa thành công!");
                    GUI_NV.LoadData();
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboXaPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuanHuyen.ValueMember.Length > 0)
            {
                LoadXaPhuongTheoMaQuanHuyen(int.Parse(cboQuanHuyen.SelectedValue.ToString()));
            }
        }

        private void cboTinhThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinhThanhPho.ValueMember.Length > 0)
            {
                LoadQuanHuyenTheoMaTinhThanhPho(int.Parse(cboTinhThanhPho.SelectedValue.ToString()));
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
