using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyDatVe
{
    public class DAL_Gia
    {
        #region Phuong thức lấy tất cả giá
        /// <summary>
        /// Phuong thức lấy tất cả giá
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[tb_Gia]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phuong thức lấy giá theo mã giá
        /// <summary>
        /// Phuong thức lấy giá theo mã giá
        /// </summary>
        /// <param name="maGia"></param>
        /// <returns></returns>
        public static DataTable LayGiaMaGia(int maGia)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[tb_Gia] WHERE MaGia=@maGia");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maGia", maGia);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
