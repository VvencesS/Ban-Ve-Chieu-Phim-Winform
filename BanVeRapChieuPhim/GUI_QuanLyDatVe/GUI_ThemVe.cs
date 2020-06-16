using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeRapChieuPhim.GUI_QuanLyDatVe
{
    public partial class GUI_ThemVe : Form
    {
        int countTG, countVP, countDoi;
        float tong = 0;
        public GUI_ThemVe()
        {
            InitializeComponent();

            lblTenTK.Visible = false;
            cboThanhVien.Visible = false;

            countTG = 0;
            countVP = 0;
            countDoi = 0;

            
        }
        private void TinhTong()
        {
            tong = 0;
            if (txtGheThuong.Text != "")
            {
                string[] gheThuongs = txtGheThuong.Text.Split(',');
                DataTable dt = BUS.BUS_QuanLyDatVe.BUS_Gia.LayGiaMaGia(int.Parse(cboGiaGheThuong.SelectedValue.ToString()));
                tong = (gheThuongs.Length - 1) * int.Parse(dt.Rows[0]["DonGia"].ToString());
            }
            if (txtGheVip.Text != "")
            {
                string[] gheVips = txtGheVip.Text.Split(',');
                DataTable dt = BUS.BUS_QuanLyDatVe.BUS_Gia.LayGiaMaGia(int.Parse(cboGiaGheVip.SelectedValue.ToString()));
                tong += (gheVips.Length - 1) * int.Parse(dt.Rows[0]["DonGia"].ToString());
            }
            if (txtGheDoi.Text != "")
            {
                string[] gheDois = txtGheDoi.Text.Split(',');
                DataTable dt = BUS.BUS_QuanLyDatVe.BUS_Gia.LayGiaMaGia(int.Parse(cboGiaGheDoi.SelectedValue.ToString()));
                tong += (gheDois.Length - 1) * int.Parse(dt.Rows[0]["DonGia"].ToString());
            }
            txtTongTien.Text = tong + " VNĐ";
        }
        private void LoadGheDoi()
        {
            cboGheDoi.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThongTinTatCaGhe1();
            cboGheDoi.DisplayMember = "SoGhe";
            cboGheDoi.ValueMember = "MaGhe";
        }

        private void LoadGheVip()
        {
            cboGheVip.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThongTinTatCaGhe1();
            cboGheVip.DisplayMember = "SoGhe";
            cboGheVip.ValueMember = "MaGhe";
        }

        private void LoadGheThuong()
        {
            cboGheThuong.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThongTinTatCaGhe1();
            cboGheThuong.DisplayMember = "SoGhe";
            cboGheThuong.ValueMember = "MaGhe";
        }

        private void LoadThanhVien()
        {
            cboThanhVien.DataSource = BUS.BUS_QuanLyTaiKhoan.BUS_ThanhVien.ThongTinTatCaThanhVien();
            cboThanhVien.DisplayMember = "Email";
            cboThanhVien.ValueMember = "MaThanhVien";
        }

        private void LoadGia()
        {
            cboGiaGheThuong.DataSource = BUS.BUS_QuanLyDatVe.BUS_Gia.LayTatCaGia();
            cboGiaGheThuong.DisplayMember = "DonGia";
            cboGiaGheThuong.ValueMember = "MaGia";

            cboGiaGheVip.DataSource = BUS.BUS_QuanLyDatVe.BUS_Gia.LayTatCaGia();
            cboGiaGheVip.DisplayMember = "DonGia";
            cboGiaGheVip.ValueMember = "MaGia";

            cboGiaGheDoi.DataSource = BUS.BUS_QuanLyDatVe.BUS_Gia.LayTatCaGia();
            cboGiaGheDoi.DisplayMember = "DonGia";
            cboGiaGheDoi.ValueMember = "MaGia";
        }

        private void LoadPhong()
        {
            cboPhong.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Phong.LayTatCaPhong();
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
        }

        private void LoadDinhDang()
        {
            cboDinhDang.DataSource = BUS.BUS_QuanLyPhim.BUS_DinhDang.LayTatCaDinhDang();
            cboDinhDang.DisplayMember = "TenDinhDang";
            cboDinhDang.ValueMember = "MaDinhDang";
        }

        private void LoadGioChieu()
        {
            cboGioChieu.DataSource = BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.LayTatCaKTG();
            cboGioChieu.DisplayMember = "GioChieu";
            cboGioChieu.ValueMember = "MaKTG";
        }

        private void LoadNgayChieu()
        {
            cboNgayChieu.DataSource = BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.LayTatCaKTG();
            cboNgayChieu.DisplayMember = "NgayChieu";
            cboNgayChieu.ValueMember = "NgayChieu";
        }

        private void LoadTenPhim()
        {
            cboPhim.DataSource = BUS.BUS_QuanLyPhim.BUS_Phim.LayTatCaPhim();
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //Lưu dữ liệu vào bảng báo giá
            if (txtGheThuong.Text != "") {
                BUS.BUS_QuanLyDatVe.BUS_BaoGia.ThemMoiBaoGia(int.Parse(cboDinhDang.SelectedValue.ToString()), 1
                    , int.Parse(cboGioChieu.SelectedValue.ToString()), int.Parse(cboGiaGheThuong.SelectedValue.ToString()));
            }
            if (txtGheVip.Text != "")
            {
                BUS.BUS_QuanLyDatVe.BUS_BaoGia.ThemMoiBaoGia(int.Parse(cboDinhDang.SelectedValue.ToString()), 2
                    , int.Parse(cboGioChieu.SelectedValue.ToString()), int.Parse(cboGiaGheVip.SelectedValue.ToString()));
            }
            if (txtGheDoi.Text != "")
            {
                BUS.BUS_QuanLyDatVe.BUS_BaoGia.ThemMoiBaoGia(int.Parse(cboDinhDang.SelectedValue.ToString()), 3
                    , int.Parse(cboGioChieu.SelectedValue.ToString()), int.Parse(cboGiaGheDoi.SelectedValue.ToString()));
            }

            //Lưu dữ liệu vào bảng vé
            BUS.BUS_QuanLyDatVe.BUS_Ve.ThemMoiVe(int.Parse(cboPhim.SelectedValue.ToString()), int.Parse(cboPhong.SelectedValue.ToString())
                , int.Parse(cboGioChieu.SelectedValue.ToString()));
            DataTable dt = BUS.BUS_QuanLyDatVe.BUS_Ve.ThongTinTatCaVeTheo3Ma(int.Parse(cboPhim.SelectedValue.ToString())
                , int.Parse(cboPhong.SelectedValue.ToString()), int.Parse(cboGioChieu.SelectedValue.ToString()));
            int maVe = int.Parse(dt.Rows[0]["MaVe"].ToString());

            //Lưu giá vé cho từng loại ghế
            if (txtGheThuong.Text != "")
            {
                BUS.BUS_QuanLyDatVe.BUS_GiaVeDat.GiaVeDat_Insert(int.Parse(cboGiaGheThuong.SelectedValue.ToString()), maVe);
            }
            if (txtGheVip.Text != "")
            {
                BUS.BUS_QuanLyDatVe.BUS_GiaVeDat.GiaVeDat_Insert(int.Parse(cboGiaGheVip.SelectedValue.ToString()), maVe);
            }
            if (txtGheDoi.Text != "")
            {
                BUS.BUS_QuanLyDatVe.BUS_GiaVeDat.GiaVeDat_Insert(int.Parse(cboGiaGheDoi.SelectedValue.ToString()), maVe);
            }

            //Lưu dữ liệu vào bảng đặt ghế và cập nhật trạng thái cho các ghế đã đặt
            if (txtGheThuong.Text != "")
            {
                string[] gheThuongs = txtGheThuong.Text.Split(',');
                for(int i = 0; i < gheThuongs.Length-1; i++)
                {
                    BUS.BUS_QuanLyDatVe.BUS_DatGhe.DatGhe_Insert(gheThuongs[i], maVe);
                    BUS.BUS_QuanLyLichChieu.BUS_Ghe.Ghe_UpdateBySoGhe(gheThuongs[i], 1);
                }
            }
            if (txtGheVip.Text != "")
            {
                string[] gheVips = txtGheVip.Text.Split(',');
                for (int i = 0; i < gheVips.Length-1; i++)
                {
                    BUS.BUS_QuanLyDatVe.BUS_DatGhe.DatGhe_Insert(gheVips[i], maVe);
                    BUS.BUS_QuanLyLichChieu.BUS_Ghe.Ghe_UpdateBySoGhe(gheVips[i], 1);
                }
            }
            if (txtGheDoi.Text != "")
            {
                string[] gheDois = txtGheDoi.Text.Split(',');
                for (int i = 0; i < gheDois.Length-1; i++)
                {
                    BUS.BUS_QuanLyDatVe.BUS_DatGhe.DatGhe_Insert(gheDois[i], maVe);
                    BUS.BUS_QuanLyLichChieu.BUS_Ghe.Ghe_UpdateBySoGhe(gheDois[i], 1);
                }
            }

            //Nếu khách có tài khoản thành viên thì lưu lại lịch sửa vé và bảng ds vé đặt
            if (cbxLaThanhVien.Checked == true)
            {
                BUS.BUS_QuanLyDatVe.BUS_DSDatVe.ThemMoiDSDatVe(maVe, int.Parse(cboThanhVien.SelectedValue.ToString()));
            }
            this.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxChonGhe_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnJ1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxLaThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLaThanhVien.Checked == true)
            {
                lblTenTK.Visible = true;
                cboThanhVien.Visible = true;
            }
            else
            {
                lblTenTK.Visible = false;
                cboThanhVien.Visible = false;
            }
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedValue.ToString().Equals("0") || cboPhim.SelectedValue.ToString().Equals("") || cboPhim.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                LoadTenPhim();
                LoadNgayChieu();
                LoadGioChieu();
                LoadDinhDang();
                LoadPhong();
                LoadGheThuong();
                LoadGheVip();
                LoadGheDoi();
                LoadGia();
                LoadThanhVien();
            }
            else
            {
                //Lấy định dạng theo phim
                cboDinhDang.DataSource = BUS.BUS_QuanLyPhim.BUS_DinhDang.ThongTinDinhDangTheoMaPhim(int.Parse(cboPhim.SelectedValue.ToString()));
                cboDinhDang.DisplayMember = "TenDinhDang";
                cboDinhDang.ValueMember = "MaDinhDang";

                //Lấy phòng theo phim
                cboPhong.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Phong.LayPhongTheoMaPhim(int.Parse(cboPhim.SelectedValue.ToString()));
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.ValueMember = "MaPhong";

                //Lấy ngày chiếu theo phim
                cboNgayChieu.DataSource = BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.LayKTGTheoMaPhim(int.Parse(cboPhim.SelectedValue.ToString()));
                cboNgayChieu.DisplayMember = "NgayChieu";
                cboNgayChieu.ValueMember = "NgayChieu";

                //Lấy giờ chiếu theo phim
                cboGioChieu.DataSource = BUS.BUS_QuanLyLichChieu.BUS_KhungThoiGian.LayGioChieuTheoMaPhim(int.Parse(cboPhim.SelectedValue.ToString()));
                cboGioChieu.DisplayMember = "GioChieu";
                cboGioChieu.ValueMember = "MaKTG";
            }
            TinhTong();
        }

        private void GUI_ThemVe_Load(object sender, EventArgs e)
        {
            LoadTenPhim();
            LoadNgayChieu();
            LoadGioChieu();
            LoadDinhDang();
            LoadPhong();
            LoadGheThuong();
            LoadGheVip();
            LoadGheDoi();
            LoadGia();
            LoadThanhVien();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue.ToString().Equals("0") || cboPhong.SelectedValue.ToString().Equals("") || cboPhong.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                LoadGheThuong();
                LoadGheVip();
                LoadGheDoi();
            }
            else
            {
                //Lấy ghế thường theo mã phòng
                cboGheThuong.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThongTinGheThuongTheoMaPhong(int.Parse(cboPhong.SelectedValue.ToString()));
                cboGheThuong.DisplayMember = "SoGhe";
                cboGheThuong.ValueMember = "MaGhe";

                //Lấy ghế vip theo mã phòng
                cboGheVip.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThongTinGheVipTheoMaPhong(int.Parse(cboPhong.SelectedValue.ToString()));
                cboGheVip.DisplayMember = "SoGhe";
                cboGheVip.ValueMember = "MaGhe";

                //Lấy ghế đôi theo mã phòng
                cboGheDoi.DataSource = BUS.BUS_QuanLyLichChieu.BUS_Ghe.ThongTinGheDoiTheoMaPhong(int.Parse(cboPhong.SelectedValue.ToString()));
                cboGheDoi.DisplayMember = "SoGhe";
                cboGheDoi.ValueMember = "MaGhe";
            }
            TinhTong();
        }

        private void cboGheThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGheThuong.SelectedValue.ToString().Equals("0") || cboGheThuong.SelectedValue.ToString().Equals("") || cboGheThuong.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                //Nếu chưa chọn giá trị
            }
            else
            {
                //Nếu đã chọn
                if (countTG >= 6) { 
                    DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_Ghe.LayGheTheoMa(int.Parse(cboGheThuong.SelectedValue.ToString()));
                    string[] gheThuongs = txtGheThuong.Text.Split(',');
                    bool check = false;
                    for(int i = 0; i < gheThuongs.Length; i++)
                    {
                        if (gheThuongs[i].Equals(dt.Rows[0]["SoGhe"].ToString())){
                            check = true;
                        }
                    }
                    if (check == false) { 
                        txtGheThuong.Text += dt.Rows[0]["SoGhe"].ToString() + ",";
                    }
                }
                else
                {
                    countTG++;
                }
            }
            TinhTong();
        }

        private void cboGiaGheThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTong();
        }

        private void cboGiaGheVip_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTong();
        }

        private void cboGiaGheDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTong();
        }

        private void cboGheVip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGheVip.SelectedValue.ToString().Equals("0") || cboGheVip.SelectedValue.ToString().Equals("") || cboGheVip.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                //Nếu chưa chọn giá trị
            }
            else
            {
                //Nếu đã chọn
                if (countVP >= 6)
                {
                    DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_Ghe.LayGheTheoMa(int.Parse(cboGheVip.SelectedValue.ToString()));
                    string[] gheVips = txtGheVip.Text.Split(',');
                    bool check = false;
                    for (int i = 0; i < gheVips.Length; i++)
                    {
                        if (gheVips[i].Equals(dt.Rows[0]["SoGhe"].ToString()))
                        {
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        txtGheVip.Text += dt.Rows[0]["SoGhe"].ToString() + ",";
                    }
                }
                else
                {
                    countVP++;
                }
            }
            TinhTong();
        }

        private void cboGheDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGheDoi.SelectedValue.ToString().Equals("0") || cboGheDoi.SelectedValue.ToString().Equals("") || cboGheDoi.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                //Nếu chưa chọn giá trị
            }
            else
            {
                //Nếu đã chọn
                if (countDoi >= 6)
                {
                    DataTable dt = BUS.BUS_QuanLyLichChieu.BUS_Ghe.LayGheTheoMa(int.Parse(cboGheDoi.SelectedValue.ToString()));
                    string[] gheDois = txtGheDoi.Text.Split(',');
                    bool check = false;
                    for (int i = 0; i < gheDois.Length; i++)
                    {
                        if (gheDois[i].Equals(dt.Rows[0]["SoGhe"].ToString()))
                        {
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        txtGheDoi.Text += dt.Rows[0]["SoGhe"].ToString() + ",";
                    }
                }
                else
                {
                    countDoi++;
                }
            }
            TinhTong();
        }
    }
}
