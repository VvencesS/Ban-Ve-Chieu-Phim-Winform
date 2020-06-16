using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyDatVe
{
    public class DAL_Ve
    {
        #region Phương thức thêm mới vé
        /// <summary>
        /// Phương thức thêm mới vé
        /// </summary>
        /// <param name="maPhim"></param>
        /// <param name="maPhong"></param>
        /// <param name="soGhe"></param>
        /// <param name="maKTG"></param>
        /// <param name="maGia"></param>
        public static void Ve_Insert(int maPhim, int maPhong, int maKTG)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_Ve]([MaPhim],[MaPhong],[MaKTG]) VALUES(@maPhim,@maPhong,@maKTG)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
        
        #region Phương thức lấy ra danh sách tất cả vé
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả vé
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaVe()
        {
            SqlCommand cmd = new SqlCommand("SELECT tb_Ve.[MaVe],tb_Phim.TenPhim,tb_Phim.AnhDaiDien,tb_TheLoai.TenTheLoai, tb_DinhDang.TenDinhDang, ThoiLuong, KhoiChieu, KetThuc, tb_Phong.TenPhong , tb_KTG.NgayChieu, tb_KTG.GioChieu, tb_SoGhe.SoGhe, tb_LoaiGhe.TenLoai, tb_Gia.DonGia FROM[dbo].[tb_Ve] INNER JOIN tb_DatGhe ON tb_DatGhe.MaVe = tb_Ve.MaVe INNER JOIN tb_SoGhe ON tb_SoGhe.SoGhe = tb_DatGhe.SoGhe INNER JOIN tb_Ghe ON tb_Ghe.SoGhe = tb_SoGhe.SoGhe INNER JOIN tb_LoaiGhe ON tb_LoaiGhe.MaLoaiGhe = tb_Ghe.MaLoaiGhe INNER JOIN tb_BaoGia ON tb_BaoGia.MaLoaiGhe = tb_LoaiGhe.MaLoaiGhe INNER JOIN tb_Gia ON tb_Gia.MaGia = tb_BaoGia.MaGia INNER JOIN tb_Phim ON tb_Phim.MaPhim = tb_Ve.MaPhim INNER JOIN tb_TheLoai ON tb_TheLoai.MaTheLoai = tb_Phim.MaTheLoai INNER JOIN tb_DinhDang ON tb_DinhDang.MaDinhDang = tb_Phim.MaDinhDang INNER JOIN tb_Phong ON tb_Phong.MaPhong = tb_Ve.MaPhong INNER JOIN tb_KTG ON tb_KTG.MaKTG = tb_Ve.MaKTG");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra vé theo mã phim, mã phòng, mã khung thời gian
        /// <summary>
        /// Phương thức lấy ra vé theo mã phim, mã phòng, mã khung thời gian
        /// </summary>
        /// <param name="maPhim"></param>
        /// <param name="maPhong"></param>
        /// <param name="maKTG"></param>
        /// <returns></returns>
        public static DataTable ThongTinTatCaVeTheo3Ma(int maPhim, int maPhong, int maKTG)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaVe] ,[MaPhim] ,[MaPhong] ,[MaKTG] FROM [dbo].[tb_Ve] WHERE MaPhim=@maPhim and MaPhong=@maPhong and MaKTG=@maKTG");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        
    }
}
