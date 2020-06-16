using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyDatVe
{
    public class DAL_BaoGia
    {
        #region Phương thức thêm mới báo giá
        /// <summary>
        /// Phương thức thêm mới báo giá
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <param name="maLoaiGhe"></param>
        /// <param name="maKTG"></param>
        /// <param name="maGia"></param>
        public static void BaoGia_Insert(int maDinhDang, int maLoaiGhe, int maKTG, int maGia)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_BaoGia] ([MaDinhDang],[MaLoaiGhe],[MaKTG],[MaGia]) " +
                "VALUES(@maDinhDang,@maLoaiGhe,@maKTG,@maGia)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maDinhDang", maDinhDang);
            cmd.Parameters.AddWithValue("@maLoaiGhe", maLoaiGhe);
            cmd.Parameters.AddWithValue("@maKTG", maKTG);
            cmd.Parameters.AddWithValue("@maGia", maGia);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
        #region Phương thức lấy báo giá
        /// <summary>
        /// Phương thức lấy báo giá
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <param name="maLoaiGhe"></param>
        /// <param name="maKTG"></param>
        /// <param name="maGia"></param>
        /// <returns></returns>
        public static DataTable LayBaoGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT tb_DinhDang.TenDinhDang,tb_LoaiGhe.TenLoai,tb_KTG.NgayChieu,tb_KTG.GioChieu,tb_Gia.DonGia" +
                "FROM[dbo].[tb_BaoGia]" +
                "INNER JOIN tb_DinhDang ON tb_DinhDang.MaDinhDang = tb_BaoGia.MaDinhDang" +
                "INNER JOIN tb_LoaiGhe ON tb_LoaiGhe.MaLoaiGhe = tb_BaoGia.MaLoaiGhe" +
                "INNER JOIN tb_KTG ON tb_KTG.MaKTG = tb_BaoGia.MaKTG" +
                "INNER JOIN tb_Gia ON tb_Gia.MaGia = tb_BaoGia.MaGia" +
                "ORDER BY tb_LoaiGhe.TenLoai");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
