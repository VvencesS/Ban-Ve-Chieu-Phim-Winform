using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_KhungThoiGian
    {
        #region Phương thức xóa KTG
        /// <summary>
        /// Phương thức xóa KTG
        /// </summary>
        /// <param name="maKTG"></param>
        public static void KTG_Delete(int maKTG)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[tb_KTG] WHERE MaKTG=@maKTG");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới KTG
        /// <summary>
        /// Phương thức thêm mới KTG
        /// </summary>
        /// <param name="ngayChieu"></param>
        /// <param name="gioChieu"></param>
        public static void KTG_Inser(DateTime ngayChieu, DateTime gioChieu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_KTG]([NgayChieu],[GioChieu]) VALUES(@ngayChieu,@gioChieu)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ngayChieu", ngayChieu);
            cmd.Parameters.AddWithValue("@gioChieu", gioChieu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một KTG
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một KTG
        /// </summary>
        /// <param name="maKTG"></param>
        /// <param name="ngayChieu"></param>
        /// <param name="gioChieu"></param>
        public static void KTG_Update(int maKTG, DateTime ngayChieu, DateTime gioChieu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_DinhDang] SET [NgayChieu] = @ngayChieu, [GioChieu]=@gioChieu WHERE MaKTG=@maKTG");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ngayChieu", ngayChieu);
            cmd.Parameters.AddWithValue("@gioChieu", gioChieu);
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả KTG
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả KTG
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaKTG()
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaKTG],[NgayChieu],[GioChieu] FROM [dbo].[tb_KTG]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin KTG theo mã KTG
        /// <summary>
        /// Phương thức lấy ra thông tin KTG theo mã KTG
        /// </summary>
        /// <param name="maKTG"></param>
        /// <returns></returns>
        public static DataTable ThongTinKTGTheoMa(int maKTG)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaKTG],[NgayChieu],[GioChieu] FROM [dbo].[tb_KTG] WHERE [MaKTG]=@maKTG");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
