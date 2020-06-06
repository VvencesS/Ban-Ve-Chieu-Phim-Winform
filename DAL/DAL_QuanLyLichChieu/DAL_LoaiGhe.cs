using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_LoaiGhe
    {
        #region Phương thức lấy ra danh sách tất cả loại ghế
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả loại ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaLoaiGhe()
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaLoaiGhe],[TenLoai] FROM [dbo].[tb_LoaiGhe]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin loại ghế theo mã
        /// <summary>
        /// Phương thức lấy ra thông tin loại ghế theo mã
        /// </summary>
        /// <param name="maLoaiGhe"></param>
        /// <returns></returns>
        public static DataTable ThongTinLoaiGheTheoMa(string maLoaiGhe)
        {
            SqlCommand cmd = new SqlCommand("SELECT [MaLoaiGhe],[TenLoai] FROM [dbo].[tb_LoaiGhe] WHERE [MaLoaiGhe]=@maLoaiGhe");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maLoaiGhe", maLoaiGhe);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
