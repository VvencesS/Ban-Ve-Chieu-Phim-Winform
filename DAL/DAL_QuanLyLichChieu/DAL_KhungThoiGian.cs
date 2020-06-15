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
        public static void KTG_Insert(DateTime ngayChieu, string gioChieu)
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
        public static void KTG_Update(int maKTG, DateTime ngayChieu, string gioChieu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_KTG] SET [NgayChieu] = @ngayChieu, [GioChieu]=@gioChieu WHERE MaKTG=@maKTG");
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
        /// <summary>
        /// Phương thức login
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public static DataTable Login(string userName, string passWord)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_NhanVien WHERE UserName=@userName and PassWord=@passWord");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@passWord", passWord);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Tìm kiếm
        /// <summary>
        /// Phương thức tìm kiếm theo ngày chiếu hoặc theo giờ chiếu
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static DataTable Search(string ngayChieu,string gioChieu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_KTG WHERE NgayChieu LIKE N'%'+ @ngayChieu + '%' OR GioChieu LIKE N'%'+@gioChieu+'%'");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ngayChieu", ngayChieu);
            cmd.Parameters.AddWithValue("@gioChieu", gioChieu);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
