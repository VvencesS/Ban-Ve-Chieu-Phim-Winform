using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_Phong
    {
        #region Phương thức xóa phòng
        /// <summary>
        /// Phương thức xóa phòng
        /// </summary>
        /// <param name="maPhong"></param>
        public static void Phong_Delete(int maPhong)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[tb_Phong] WHERE MaPhong=@maPhong");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới phòng
        /// <summary>
        /// Phương thức thêm mới phòng
        /// </summary>
        /// <param name="tenPhong"></param>
        /// <param name="soHangMax"></param>
        /// <param name="soCotMax"></param>
        /// <param name="maDinhDang"></param>
        public static void Phong_Inser(string tenPhong, int soHangMax, int soCotMax, int maDinhDang)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_Phong]([TenPhong],[SoHangMax],[SoCotMax],[MaDinhDang]) VALUES(@tenPhong,@soHangMax,@soCotMax,@maDinhDang)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenPhong", tenPhong);
            cmd.Parameters.AddWithValue("@soHangMax", soHangMax);
            cmd.Parameters.AddWithValue("@soCotMax", soCotMax);
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Phòng
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tenPhong"></param>
        /// <param name="soHangMax"></param>
        /// <param name="soCotMax"></param>
        /// <param name="maDinhDang"></param>
        public static void Phong_Update(int maPhong, string tenPhong, int soHangMax, int soCotMax, int maDinhDang)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_Phong] SET [TenPhong] = @tenPhong ,[SoHangMax] = @soHangMax,[SoCotMax] = @soCotMax,[MaDinhDang] = @maDinhDang WHERE MaPhong=@maPhong");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenPhong", tenPhong);
            cmd.Parameters.AddWithValue("@soHangMax", soHangMax);
            cmd.Parameters.AddWithValue("@soCotMax", soCotMax);
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả Phòng
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả phòng
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaPhong()
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaPhong],[TenPhong],[SoHangMax],[SoCotMax],tb_DinhDang.TenDinhDang FROM [dbo].[tb_Phong] INNER JOIN tb_DinhDang ON tb_Phong.MaDinhDang=tb_DinhDang.MaDinhDang");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin phòng theo mã phòng
        /// <summary>
        /// Phương thức lấy ra thông tin phòng theo mã phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns></returns>
        public static DataTable ThongTinKTGTheoMa(int maPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaPhong],[TenPhong],[SoHangMax],[SoCotMax],tb_DinhDang.TenDinhDang FROM [dbo].[tb_Phong] INNER JOIN tb_DinhDang ON tb_Phong.MaDinhDang=tb_DinhDang.MaDinhDang WHERE [MaPhong]=@maPhong");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
