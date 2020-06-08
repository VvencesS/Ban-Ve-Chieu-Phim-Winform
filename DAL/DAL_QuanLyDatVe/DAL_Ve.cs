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
        public static void Ve_Inser(int maPhim, int maPhong, string soGhe, int maKTG, int maGia)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_Ve]([MaPhim],[MaPhong],[SoGhe],[MaKTG],[MaGia]) VALUES(@maPhim,@maPhong,@soGhe,@maKTG,@maGia)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maPhim", maPhim);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            cmd.Parameters.AddWithValue("@soGhe", soGhe);
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            cmd.Parameters.AddWithValue("@maGia", maGia);
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
            SqlCommand cmd = new SqlCommand("SELECT tb_Ve.MaVe,tb_Phim.TenPhim,tb_Phong.TenPhong,tb_DinhDang.TenDinhDang,tb_DatGhe.SoGhe,tb_KTG.NgayChieu,tb_KTG.GioChieu,tb_Gia.DonGia FROM [dbo].[tb_Ve]" +
                "INNER JOIN tb_Phim ON tb_Phim.MaPhim = tb_Ve.MaPhim" +
                "INNER JOIN tb_Phong ON tb_Phong.MaPhong = tb_Ve.MaPhong" +
                "INNER JOIN tb_DinhDang ON tb_Phong.MaDinhDang = tb_DinhDang.MaDinhDang" +
                "INNER JOIN tb_DatGhe ON tb_DatGhe.MaVe = tb_Ve.MaVe" +
                "INNER JOIN tb_KTG ON tb_KTG.MaKTG = tb_Ve.MaKTG" +
                "INNER JOIN tb_Gia ON tb_Gia.MaGia = tb_Ve.MaGia");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

    }
}
