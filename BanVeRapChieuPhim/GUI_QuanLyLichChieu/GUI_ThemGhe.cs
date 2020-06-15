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
    public partial class GUI_ThemGhe : Form
    {
        GUI_Ghe GUI_Ghe = new GUI_Ghe();
        public GUI_ThemGhe()
        {
            InitializeComponent();
            if (GUI_Ghe.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                btnThem.Text = "Thêm mới";
                txtMaGhe.Enabled = false;

                LoadPhong();
                LoadLoaiGhe();
                LoadSoGhe();
                LoadTrangThai();
            }
            else
            {
                //Nếu là sửa
                btnThem.Text = "Sửa";
                txtMaGhe.Enabled = false;

                LoadPhong();
                LoadLoaiGhe();
                LoadSoGhe();
                LoadTrangThai();
                LoadData();
            }
        }

        private void LoadData()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_Ghe.LayGheTheoMa(GUI_Ghe._maGhe);
            txtMaGhe.Text = dt.Rows[0]["MaGhe"].ToString();
            cboMaPhong.SelectedValue = dt.Rows[0]["MaPhong"].ToString();
            cboMaLoaiGhe.SelectedValue = dt.Rows[0]["MaLoaiGhe"].ToString();
            cboSoGhe.SelectedValue = dt.Rows[0]["SoGhe"].ToString();
            cboMaTrangThai.SelectedValue = dt.Rows[0]["MaTrangThai"].ToString();
        }

      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GUI_Ghe.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                if (cboMaPhong.Text == ""||cboMaLoaiGhe.Text == "" || cboSoGhe.Text == "" || cboMaTrangThai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThemMoiGhe(int.Parse(cboMaPhong.SelectedValue.ToString()), int.Parse(cboMaLoaiGhe.SelectedValue.ToString()),
                        cboSoGhe.SelectedValue.ToString(), int.Parse(cboMaTrangThai.SelectedValue.ToString()));

                    MessageBox.Show("Thêm thành công!");
                    GUI_Ghe.LoadData();
                    this.Close();
                }
            }
            else
            {
                //Nếu là chỉnh sửa
                if (cboMaPhong.Text == "" || cboMaLoaiGhe.Text == "" || cboSoGhe.Text == "" || cboMaTrangThai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    BUS.BUS_QuanLyLichChieu.BUS_Ghe.CapNhatGhe(int.Parse(txtMaGhe.Text.ToString()), int.Parse(cboMaPhong.SelectedValue.ToString()), int.Parse(cboMaLoaiGhe.SelectedValue.ToString()),
                        cboSoGhe.SelectedValue.ToString(), int.Parse(cboMaTrangThai.SelectedValue.ToString()));

                    MessageBox.Show("Sửa thành công!");
                    GUI_Ghe.LoadData();
                    this.Close();
                }
            }
        }
        void LoadPhong()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_Phong.LayTatCaPhong();
            cboMaPhong.DataSource = dt;
            cboMaPhong.DisplayMember = "TenPhong";
            cboMaPhong.ValueMember = "MaPhong";
        }
        void LoadLoaiGhe()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_LoaiGhe.LayTatCaLoaiGhe();
            cboMaLoaiGhe.DataSource = dt;
            cboMaLoaiGhe.DisplayMember = "TenLoaiGhe";
            cboMaLoaiGhe.ValueMember = "MaLoaiGhe";
        }
        void LoadSoGhe()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_SoGhe.LayTatCaSoGhe();
            cboSoGhe.DataSource = dt;
            cboSoGhe.DisplayMember = "SoGhe";
            cboSoGhe.ValueMember = "SoGhe";
        }
        void LoadTrangThai()
        {
            DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_TrangThai.ThongTinTrangThai();
            cboMaTrangThai.DataSource = dt;
            cboMaTrangThai.DisplayMember = "MoTa";
            cboMaTrangThai.ValueMember = "MaTrangThai";
        }
    }
}
