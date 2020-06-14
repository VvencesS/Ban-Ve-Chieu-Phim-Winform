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
    public partial class GUI_Ve : Form
    {
        public static string ThaoTac;
        public static int _maVe;
        public GUI_Ve()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvVe.DataSource = BUS.BUS_QuanLyDatVe.BUS_Ve.LayTatCaVe();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThaoTac = "themmoi";
            GUI_ThemVe themVe = new GUI_ThemVe();
            themVe.ShowDialog();
        }
        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    if (_maVe <= 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn vé cần sửa!");
        //    }
        //    else
        //    {
        //        ThaoTac = "sua";
        //        GUI_ThemVe SuaVe = new GUI_ThemVe();
        //        SuaVe.ShowDialog();
        //    }
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (_maVe <= 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn vé cần xóa!");
        //    }
        //    else
        //    {
        //        DialogResult drt = MessageBox.Show("Bạn muốn xóa vé này?", "Xóa vé", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        //        if (drt == DialogResult.OK)
        //        {
        //            //BUS.BUS_QuanLyDatVe.BUS_Ve.(_maVe);
        //            LoadData();
        //        }
        //    }
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                _maVe = int.Parse(dgvVe.Rows[rindex].Cells["MaVe"].Value.ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                //dgvVe.DataSource = BUS.BUS_QuanLyDatVe.BUS_Ve.(txtTimKiem.Text.ToString());
            }
        }

        public void GUI_Ve_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
