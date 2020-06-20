using BanVeRapChieuPhim.GUI_QLPhim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QuanLyPhim
{
    public partial class GUI_ThemPhim : Form
    {
        public string _password = "";
        GUI_Phim GUI_Phim = new GUI_Phim();
        string fName;
        string folder;
        string pathString;
        public GUI_ThemPhim()
        {
            InitializeComponent();
            if (GUI_Phim.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới
                btnThem.Text = "Thêm mới";
                txtMaPhim.Enabled = false;

                //Viết các hàm này bên dưới
                LoadTenTheLoai();
                LoadTenQuocGia();
                LoadTenNhanVien();
                LoadTenDinhDang();
            }    
            else
            {
                //Nếu là sửa
                btnThem.Text = "Sửa";
                txtMaPhim.Enabled = false;

                LoadTenTheLoai();
                LoadTenQuocGia();
                LoadTenNhanVien();
                LoadTenDinhDang();
                LoadData();
            }   
        }
        private void LoadData()
        {
            DataTable dt = BUS.BUS_QuanLyPhim.BUS_Phim.LayPhimTheoMa(GUI_Phim._maPhim);
            txtMaPhim.Text = dt.Rows[0]["MaPhim"].ToString();
            txtTenPhim.Text = dt.Rows[0]["TenPhim"].ToString();
            pathString = dt.Rows[0]["AnhDaiDien"].ToString();
            txtKhoiChieu.Text = dt.Rows[0]["KhoiChieu"].ToString().Substring(0,10);
            txtKetThuc.Text = dt.Rows[0]["KetThuc"].ToString().Substring(0,10);
            txtNoiDung.Text = dt.Rows[0]["NoiDung"].ToString();
            txtDaoDien.Text = dt.Rows[0]["DaoDien"].ToString();
            txtTrailer.Text = dt.Rows[0]["Trailer"].ToString();
            txtThoiLuong.Text = dt.Rows[0]["ThoiLuong"].ToString();

            if (pathString != "")
            {
                pictureBox1.Image = Image.FromFile(pathString);
            }

            //dt = BUS.BUS_QuanLyPhim.BUS_TheLoai.LayTheLoaiTheoMa(int.Parse(dt.Rows[0]["MaTheLoai"].ToString()));
            cboTenTheLoai.SelectedValue = dt.Rows[0]["MaTheLoai"].ToString();
            //dt = BUS.BUS_QuanLyPhim.BUS_DinhDang.LayDinhDangTheoMa(int.Parse(dt.Rows[0]["MaDinhDang"].ToString()));
            cboTenDinhDang.SelectedValue = dt.Rows[0]["MaDinhDang"].ToString();
            //dt = BUS.BUS_QuanLyPhim.BUS_QuocGia.LayQuocGiaTheoMa(int.Parse(dt.Rows[0]["MaQuocGia"].ToString()));
            cboTenQuocGia.SelectedValue = dt.Rows[0]["MaQuocGia"].ToString();
            //dt = BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.ThongTinNhanVienTHeoMa(int.Parse(dt.Rows[0]["MaNhanVien"].ToString()));
            cboTenNhanVien.SelectedValue = dt.Rows[0]["MaNhanVien"].ToString();

            }

        private void LoadTenDinhDang()
        {
            DataTable dt = BUS.BUS_QuanLyPhim.BUS_DinhDang.LayTatCaDinhDang();
            cboTenDinhDang.DataSource = dt ;
            cboTenDinhDang.DisplayMember = "TenDinhDang";
            cboTenDinhDang.ValueMember = "MaDinhDang";
        }

        private void LoadTenNhanVien()
        {
            DataTable dt = BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.ThongTinNhanVien();
            cboTenNhanVien.DataSource = dt;
            cboTenNhanVien.DisplayMember = "HoTen";
            cboTenNhanVien.ValueMember = "MaNhanVien";
        }

        private void LoadTenQuocGia()
        {
            DataTable dt = BUS.BUS_QuanLyPhim.BUS_QuocGia.LayTatCaQuocGia();
            cboTenQuocGia.DataSource = dt;
            cboTenQuocGia.DisplayMember = "TenQuocGia";
            cboTenQuocGia.ValueMember = "MaQuocGia";
            
        }

        private void LoadTenTheLoai()
        {
            DataTable dt = BUS.BUS_QuanLyPhim.BUS_TheLoai.LayTatCaTheLoai();
            cboTenTheLoai.DataSource = dt;
            cboTenTheLoai.DisplayMember = "TenTheLoai";
            cboTenTheLoai.ValueMember = "MaTheLoai";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fName = "AnhDaiDienPhim_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".jpg";
            folder = "D:\\Images";
            pathString = System.IO.Path.Combine(folder, fName);

            if (GUI_Phim.ThaoTac == "themmoi")
            {
                //Nếu là thêm mới  
                if (   txtTenPhim.Text == "" || txtNoiDung.Text == ""
                    || txtKhoiChieu.Text == "" || txtKetThuc.Text == "" || txtDaoDien.Text == "" || txtThoiLuong.Text == "" ) 
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }    
                else
                {
                    if (pictureBox1.Image != null)
                    {
                        Image a = pictureBox1.Image;
                        MessageBox.Show(pathString);
                        a.Save(pathString);

                        BUS.BUS_QuanLyPhim.BUS_Phim.Themmoiphim(txtTenPhim.Text, pathString, int.Parse(cboTenTheLoai.SelectedValue.ToString()), int.Parse(cboTenQuocGia.SelectedValue.ToString()),
                            txtThoiLuong.Text, txtKhoiChieu.Text, txtKetThuc.Text, txtDaoDien.Text, txtNoiDung.Text, txtTrailer.Text, int.Parse(cboTenDinhDang.SelectedValue.ToString()), int.Parse(cboTenNhanVien.SelectedValue.ToString()));
                        MessageBox.Show("Thêm thành công!");
                        GUI_Phim.LoadData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Chọn ảnh từ thư mục!");
                    }
                }    
            }                
            else
            {
                //Nếu là chỉnh sửa
                if ( txtDaoDien.Text == "" || txtKetThuc.Text == ""
                    || txtKhoiChieu.Text == "" || txtMaPhim.Text == "" || txtNoiDung.Text == ""
                    || txtTenPhim.Text == "" || txtThoiLuong.Text == "" ) 
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    if(txtMaPhim.Text == "")
                    {

                    }
                    MessageBox.Show("Sửa thành công!");
                    BUS.BUS_QuanLyPhim.BUS_Phim.CapNhatPhim(int.Parse(txtMaPhim.Text), txtTenPhim.Text, pathString, int.Parse(cboTenTheLoai.SelectedValue.ToString()), int.Parse(cboTenQuocGia.SelectedValue.ToString()),
                        txtThoiLuong.Text, txtKhoiChieu.Text, txtKetThuc.Text, txtDaoDien.Text, txtNoiDung.Text, txtTrailer.Text, int.Parse(cboTenDinhDang.SelectedValue.ToString()), int.Parse(cboTenNhanVien.SelectedValue.ToString()));
                    GUI_Phim.LoadData();
                    this.Close();
                }    
            }    


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p=sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png)|*.jpeg;*.pjpeg;*.x-png;*.png;*.gif;*.x-shockwave-flash ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }
    }
}
