using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyPhim
{
    public class DAL_Phim
    {
        #region Phương thức xóa phim
        /// <summary>
        /// Phương thức xóa phim
        /// </summary>
        /// <param name="maPhim"></param>
        public static void Phim_Delete(int maPhim)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[tb_Phim] WHERE MaPhim=@maPhim");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới phim
        /// <summary>
        /// Phương thức thêm mới phim
        /// </summary>
        /// <param name="tenPhim"></param>
        /// <param name="anhDaiDien"></param>
        /// <param name="maTheLoai"></param>
        /// <param name="maQuocGia"></param>
        /// <param name="thoiLuong"></param>
        /// <param name="khoiChieu"></param>
        /// <param name="ketThuc"></param>
        /// <param name="daoDien"></param>
        /// <param name="noiDung"></param>
        /// <param name="trailer"></param>
        /// <param name="maDinhDang"></param>
        /// <param name="maNhanVien"></param>
        public static void Phim_Inser(string tenPhim, string anhDaiDien, int maTheLoai, int maQuocGia, string thoiLuong, DateTime khoiChieu, DateTime ketThuc, 
            string daoDien, string noiDung, string trailer, int maDinhDang, int maNhanVien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_Phim]([TenPhim],[AnhDaiDien],[MaTheLoai],[MaQuocGia],[ThoiLuong],[KhoiChieu],[KetThuc],[DaoDien],[NoiDung],[Trailer],[MaDinhDang],[MaNhanVien]) " +
                "VALUES(@tenPhim,@anhDaiDien,@maTheLoai,@maQuocGia,@thoiLuong,@khoiChieu,@ketThuc,@daoDien,@noiDung,@trailer,@maDinhDang,@maNhanVien)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenPhim", tenPhim);
            cmd.Parameters.AddWithValue("@anhDaiDien", anhDaiDien);
            cmd.Parameters.AddWithValue("@maTheLoai", maTheLoai);
            cmd.Parameters.AddWithValue("@maQuocGia", maQuocGia);
            cmd.Parameters.AddWithValue("@thoiLuong", thoiLuong);
            cmd.Parameters.AddWithValue("@khoiChieu", khoiChieu);
            cmd.Parameters.AddWithValue("@ketThuc", ketThuc);
            cmd.Parameters.AddWithValue("@daoDien", daoDien);
            cmd.Parameters.AddWithValue("@noiDung", noiDung);
            cmd.Parameters.AddWithValue("@trailer", trailer);
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một phim
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một phim
        /// </summary>
        /// <param name="maPhim"></param>
        /// <param name="tenPhim"></param>
        /// <param name="anhDaiDien"></param>
        /// <param name="maTheLoai"></param>
        /// <param name="maQuocGia"></param>
        /// <param name="thoiLuong"></param>
        /// <param name="khoiChieu"></param>
        /// <param name="ketThuc"></param>
        /// <param name="daoDien"></param>
        /// <param name="noiDung"></param>
        /// <param name="trailer"></param>
        /// <param name="maDinhDang"></param>
        /// <param name="maNhanVien"></param>
        public static void Phim_Update(int maPhim, string tenPhim, string anhDaiDien, int maTheLoai, int maQuocGia, string thoiLuong, DateTime khoiChieu, DateTime ketThuc,
            string daoDien, string noiDung, string trailer, int maDinhDang, int maNhanVien)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tb_Phim] SET [TenPhim] = @tenPhim,[AnhDaiDien] = @anhDaiDien,[MaTheLoai] = @maTheLoai,[MaQuocGia] = @maQuocGia," +
                "[ThoiLuong] = @thoiLuong,[KhoiChieu] = @khoiChieu,[KetThuc] = ketThuc,[DaoDien] = @daoDien,[NoiDung] = @noiDung,[Trailer] = @trailer,[MaDinhDang] = @maDinhDang,[MaNhanVien] = @maNhanVien WHERE [MaPhim] = @maPhim");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenPhim", tenPhim);
            cmd.Parameters.AddWithValue("@anhDaiDien", anhDaiDien);
            cmd.Parameters.AddWithValue("@maTheLoai", maTheLoai);
            cmd.Parameters.AddWithValue("@maQuocGia", maQuocGia);
            cmd.Parameters.AddWithValue("@thoiLuong", thoiLuong);
            cmd.Parameters.AddWithValue("@khoiChieu", khoiChieu);
            cmd.Parameters.AddWithValue("@ketThuc", ketThuc);
            cmd.Parameters.AddWithValue("@daoDien", daoDien);
            cmd.Parameters.AddWithValue("@noiDung", noiDung);
            cmd.Parameters.AddWithValue("@trailer", trailer);
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả phim
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả phim
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaPhim()
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaPhim],[TenPhim],[AnhDaiDien],tb_TheLoai.TenTheLoai,tb_QuocGia.TenQuocGia,[ThoiLuong],[KhoiChieu],[KetThuc],[DaoDien],[NoiDung],[Trailer],tb_DinhDang.TenDinhDang,tb_NhanVien.HoTen FROM[dbo].[tb_Phim] INNER JOIN tb_TheLoai ON tb_Phim.MaTheLoai = tb_TheLoai.MaTheLoai INNER JOIN tb_QuocGia ON tb_Phim.MaQuocGia = tb_QuocGia.MaQuocGia INNER JOIN tb_DinhDang ON tb_Phim.MaDinhDang = tb_DinhDang.MaDinhDang INNER JOIN tb_NhanVien ON tb_Phim.MaNhanVien = tb_NhanVien.MaNhanVien");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin phim theo mã phim
        /// <summary>
        /// Phương thức lấy ra thông tin phim theo mã phim
        /// </summary>
        /// <param name="maPhim"></param>
        /// <returns></returns>
        public static DataTable ThongTinPhimTheoMa(int maPhim)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaPhim],[TenPhim],[AnhDaiDien],tb_TheLoai.TenTheLoai,tb_QuocGia.TenQuocGia,[ThoiLuong],[KhoiChieu],[KetThuc],[DaoDien]" +
                ",[NoiDung],[Trailer],tb_DinhDang.TenDinhDang,tb_NhanVien.HoTen, tb_DinhDang.MaDinhDang, tb_TheLoai.MaTheLoai, tb_QuocGia.MaQuocGia, tb_NhanVien.MaNhanVien FROM[dbo].[tb_Phim] INNER JOIN tb_TheLoai ON tb_Phim.MaTheLoai = tb_TheLoai.MaTheLoai " +
                "INNER JOIN tb_QuocGia ON tb_Phim.MaQuocGia = tb_QuocGia.MaQuocGia INNER JOIN tb_DinhDang ON tb_Phim.MaDinhDang = tb_DinhDang.MaDinhDang " +
                "INNER JOIN tb_NhanVien ON tb_Phim.MaNhanVien = tb_NhanVien.MaNhanVien WHERE [MaPhim]=@maPhim");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

    }
}
