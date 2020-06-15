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
    public partial class GUI_ThemPhong : Form
    {
        public GUI_ThemPhong()
        {
            InitializeComponent();
            if (GUI_Phong.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                btnThem.Text = "Thêm mới";
                txtMaPhong.Enabled = false;

                LoadDinhDang();
            }
            else
            {
                //Nếu là sửa
                btnThem.Text = "Sửa";
                txtMaPhong.Enabled = false;

                LoadDinhDang();
                LoadData();
            }
        }

        private void LoadData()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_Phong.LayPhongTheoMa(GUI_Phong._maPhong);
            txtMaPhong.Text = dt.Rows[0]["MaPhong"].ToString();
            txtTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
            txtSoHangMax.Text = dt.Rows[0]["SoHangMax"].ToString();
            txtSoCotMax.Text = dt.Rows[0]["SoCotMax"].ToString();
            cboMaDinhDang.SelectedValue = dt.Rows[0]["MaDinhDanh"].ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GUI_Phong.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                if (txtTenPhong.Text == "" || txtSoHangMax.Text == "" || 
                    txtSoCotMax.Text == "" || cboMaDinhDang.Text =="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyLichChieu.BUS_Phong.ThemMoiPhong(txtTenPhong.Text,int.Parse(txtSoHangMax.Text),
                        int.Parse(txtSoCotMax.Text), int.Parse(cboMaDinhDang.SelectedValue.ToString()));
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
            }
            else
            {
                //Nếu là chỉnh sửa
                if (txtTenPhong.Text == "" || txtSoHangMax.Text == "" ||
                    txtSoCotMax.Text == "" || cboMaDinhDang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyLichChieu.BUS_Phong.CapNhatPhong(int.Parse(txtMaPhong.Text.ToString()),txtTenPhong.Text.Trim(), int.Parse(txtSoHangMax.Text),
                        int.Parse(txtSoCotMax.Text.Trim()), int.Parse(cboMaDinhDang.SelectedValue.ToString()));
                    MessageBox.Show("Sửa thành công!");
                    this.Close();
                }
            }
        }

        void LoadDinhDang()
        {
            DataTable dt = BUS.BUS_QuanLyPhim.BUS_DinhDang.LayTatCaDinhDang();
            cboMaDinhDang.DataSource = dt;
            cboMaDinhDang.DisplayMember = "TenDinhDang";
            cboMaDinhDang.ValueMember = "MaDinhDang";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
