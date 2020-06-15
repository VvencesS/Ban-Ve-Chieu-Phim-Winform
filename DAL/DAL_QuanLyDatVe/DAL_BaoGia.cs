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
    }
}
