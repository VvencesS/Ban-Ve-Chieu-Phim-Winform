using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyTaiKhoan
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
        #region Phương thức lấy ra Nhân viên theo mã
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable LayNhanvienTheoMa(int maNhanVien)
        {
            SqlCommand cmd = new SqlCommand("select tb_NhanVien.MaNhanVien, tb_NhanVien.HoTen, tb_NhanVien.Email, " +
                "tb_NhanVien.GioiTinh, tb_NhanVien.Sdt, tb_NhanVien.NgaySinh, tb_NhanVien.UserName, tb_NhanVien.PassWord, " +
                "tb_XaPhuong.TenXaPhuong, tb_QuanHuyen.TenQuanHuyen, tb_TinhThanhPho.TenTinhThanhPho from tb_NhanVien " +
                "inner join tb_XaPhuong on tb_NhanVien.IDXaPhuong = tb_XaPhuong.IDXaPhuong " +
                "inner join tb_QuanHuyen on tb_QuanHuyen.IDQuanHuyen = tb_XaPhuong.IDQuanHuyen " +
                "inner join tb_TinhThanhPho on tb_TinhThanhPho.IDTinhThanhPho = tb_QuanHuyen.IDTinhThanhPho where MaNhanVien=@maNhaVien");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maNhaVien", maNhanVien);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức xóa nhân viên theo mã nhân viên truyền vào
        /// <summary>
        /// Phương thức xóa nhân viên theo mã nhân viên truyền vào
        /// </summary>
        /// <param name="maNhanVien"></param>
        public static void Nhanvien_Delete(int maNhanVien)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[tb_NhanVien] WHERE MaNhanVien=@maNhanVien");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Nhanvien vào bảng Nhanvien
        /// <summary>
        /// Phương thức thêm mới Nhanvien vào bảng Nhanvien
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="email"></param>
        /// <param name="sdt"></param>
        /// <param name="soThe"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <param name="idXaPhuong"></param>
        public static void Nhanvien_Inser(string userName, string hoTen, string email, string sdt, string soThe, bool gioiTinh, DateTime ngaySinh, string passWord, int idXaPhuong)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_NhanVien] ([UserName],[HoTen],[Email],[Sdt],[SoThe],[NgaySinh],[GioiTinh],[PassWord],[IDXaPhuong]) " +
                "VALUES(@userName,@hoTen,@email,@sdt,@soThe,@ngaySinh,@gioiTinh,@passWord,@idXaPhuong)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@hoTen", hoTen);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@soThe", soThe);
            cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@passWord", passWord);
            cmd.Parameters.AddWithValue("@idXaPhuong", idXaPhuong);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Nhanvien
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Nhanvien
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="email"></param>
        /// <param name="sdt"></param>
        /// <param name="soThe"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <param name="idXaPhuong"></param>
        /// <param name="maNhanVien"></param>
        public static void Nhanvien_Update(string userName, string hoTen, string email, string sdt, string soThe, bool gioiTinh, DateTime ngaySinh, string passWord, int idXaPhuong, int maNhanVien)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_NhanVien] SET[UserName] = @userName,[HoTen] = @hoTen,[Email] = @email,[Sdt] = @sdt,[SoThe] = @soThe," +
                "[NgaySinh] = @ngaySinh,[GioiTinh] = @gioiTinh,[PassWord] = @passWord,[IDXaPhuong] = @idXaPhuong WHERE MaNhanVien=@maNhanVien");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@hoTen", hoTen);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@soThe", soThe);
            cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@passWord", passWord);
            cmd.Parameters.AddWithValue("@idXaPhuong", idXaPhuong);
            cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
        #region Login
        public static DataTable Login(string userName,string passWord)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_ThanhVien WHERE UserName=@userName and PassWord=@passWord");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@passWord", passWord);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
