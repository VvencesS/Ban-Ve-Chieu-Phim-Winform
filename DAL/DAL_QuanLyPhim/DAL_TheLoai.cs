using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyPhim
{
    public class DAL_TheLoai
    {
        #region Phương thức xóa thể loại
        /// <summary>
        /// Phương thức xóa thể loại
        /// </summary>
        /// <param name="maTheLoai"></param>
        public static void TheLoai_Delete(int maTheLoai)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[tb_TheLoai] WHERE MaTheLoai=@maTheLoai");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maTheLoai", maTheLoai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Thể loại
        /// <summary>
        /// Phương thức thêm mới Thể loại
        /// </summary>
        /// <param name="tenTheLoai"></param>
        public static void TheLoai_Inser(string tenTheLoai)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_TheLoai] ([TenTheLoai]) VALUES(@tenTheLoai)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenTheLoai", tenTheLoai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một thể loại
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một thể loại
        /// </summary>
        /// <param name="maTheLoai"></param>
        /// <param name="tenTheLoai"></param>

        public static void TheLoai_Update(int maTheLoai, string tenTheLoai)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_TheLoai] SET [TenTheLoai] = @tenTheLoai WHERE MaTheLoai=@maTheLoai");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maTheLoai", maTheLoai);
            cmd.Parameters.AddWithValue("@tenTheLoai", tenTheLoai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả thể loại
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả thể loại
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaTheLoai()
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaTheLoai],[TenTheLoai] FROM [dbo].[tb_TheLoai]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin thể loại theo mã thể loại
        /// <summary>
        /// Phương thức lấy thể loại theo mã thể loại
        /// </summary>
        /// <param name="maTheLoai"></param>
        /// <returns></returns>
        public static DataTable ThongTinTheLoaiTheoMa(int maTheLoai)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaTheLoai],[TenTheLoai] FROM [dbo].[tb_TheLoai] WHERE [MaTheLoai]=@maTheLoai");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maTheLoai", maTheLoai);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
