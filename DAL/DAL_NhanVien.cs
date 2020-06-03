using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        #region Phương thức lấy ra danh sách tất cả Nhân viên
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinNhanvien()
        {
            SqlCommand cmd = new SqlCommand("select tb_NhanVien.MaNhanVien, tb_NhanVien.HoTen, tb_NhanVien.Email, " +
                "tb_NhanVien.GioiTinh, tb_NhanVien.Sdt, tb_NhanVien.NgaySinh, tb_NhanVien.UserName, tb_NhanVien.PassWord, " +
                "tb_XaPhuong.TenXaPhuong, tb_QuanHuyen.TenQuanHuyen, tb_TinhThanhPho.TenTinhThanhPho from tb_NhanVien " +
                "inner join tb_XaPhuong on tb_NhanVien.IDXaPhuong = tb_XaPhuong.IDXaPhuong " +
                "inner join tb_QuanHuyen on tb_QuanHuyen.IDQuanHuyen = tb_XaPhuong.IDQuanHuyen " +
                "inner join tb_TinhThanhPho on tb_TinhThanhPho.IDTinhThanhPho = tb_QuanHuyen.IDTinhThanhPho");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
