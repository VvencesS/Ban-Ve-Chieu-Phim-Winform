using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyDatVe
{
    public class DAL_GiaVeDat
    {
        #region Phương thức thêm mới giá vé đặt
        /// <summary>
        /// Phương thức thêm mới giá vé đặt
        /// </summary>
        /// <param name="maGia"></param>
        /// <param name="maVe"></param>
        public static void GiaVeDat_Insert(int maGia, int maVe)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_GiaVeDat] ([MaGia],[MaVe]) VALUES(@maGia,@maVe)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maGia", maGia);
            cmd.Parameters.AddWithValue("@maVe", maVe);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
