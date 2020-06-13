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
    public partial class GUI_DangNhap : Form
    {
        private bool CheckLogin = false;
        public GUI_DangNhap()
        {
            InitializeComponent();
        }
        public void SetCheckLogin(bool checkLogin)
        {
            this.CheckLogin = checkLogin;
        }
        public bool GetCheckLogin()
        {
            return this.CheckLogin;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim().ToString() == "" || txtMatKhau.Text.Trim().ToString() == "")
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tài khoản và mật khẩu!";
            }
            else {
                DataTable dt = BUS.BUS_QuanLyTaiKhoan.BUS_NhanVien.Login(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    SetCheckLogin(true);
                    this.Hide();
                }
                else
                {
                    lblLoi.Text = "Tài khoản hoặc mật khẩu không đúng!";
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
