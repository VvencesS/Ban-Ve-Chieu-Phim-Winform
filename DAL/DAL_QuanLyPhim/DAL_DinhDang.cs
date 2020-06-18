using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyPhim
{
    public class DAL_DinhDang
    {
        #region Phương thức xóa định dang
        /// <summary>
        /// Phương thức xóa định dang
        /// </summary>
        /// <param name="maDinhDang"></param>
        public static void DinhDang_Delete(int maDinhDang)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[tb_DinhDang] WHERE MaDinhDang=@maDinhDang");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới định dạng
        /// <summary>
        /// Phương thức thêm mới định dạng
        /// </summary>
        /// <param name="tenDinhDang"></param>
        public static void DinhDang_Inser(string tenDinhDang)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_DinhDang] ([TenDinhDang]) VALUES(@tenDinhDang)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenDinhDang", tenDinhDang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một định dạng
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một định dạng
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <param name="tenDinhDang"></param>
        public static void DinhDang_Update(int maDinhDang, string tenDinhDang)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_DinhDang] SET [TenDinhDang] = @tenDinhDang WHERE MaDinhDang=@maDinhDang");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            cmd.Parameters.AddWithValue("@tenDinhDang", tenDinhDang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả định dang
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả định dang
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaDinhDang()
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaDinhDang],[TenDinhDang] FROM [dbo].[tb_DinhDang]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin định dạng theo mã định dạng
        /// <summary>
        /// Phương thức lấy ra thông tin định dạng theo mã định dạng
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <returns></returns>
        public static DataTable ThongTinDinhDangTheoMa(int maDinhDang)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaDinhDang],[TenDinhDang] FROM [dbo].[tb_DinhDang] WHERE [MaDinhDang]=@maDinhDang");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra thông tin định dạng theo tên định dạng
        /// <summary>
        /// Phương thức lấy ra thông tin định dạng theo tên định dạng
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <returns></returns>
        public static DataTable ThongTinDinhDangTheoTen(string tenDinhDang)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaDinhDang],[TenDinhDang] FROM [dbo].[tb_DinhDang] WHERE [TenDinhDang]=@tenDinhDang");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenDinhDang", tenDinhDang);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra thông tin định dạng theo mã phim
        /// <summary>
        /// Phương thức lấy ra thông tin định dạng theo mã phim
        /// </summary>
        /// <param name="maPhim"></param>
        /// <returns></returns>
        public static DataTable ThongTinDinhDangTheoMaPhim(int maPhim)
        {
            SqlCommand cmd = new SqlCommand("SELECT tb_DinhDang.MaDinhDang,TenDinhDang FROM [dbo].[tb_DinhDang] INNER JOIN tb_Phim ON tb_Phim.MaDinhDang = tb_DinhDang.MaDinhDang WHERE tb_Phim.MaPhim = @maPhim");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
