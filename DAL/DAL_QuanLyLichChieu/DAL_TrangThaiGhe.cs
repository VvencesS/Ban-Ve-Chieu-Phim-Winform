using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_TrangThaiGhe
    {
        #region Phương thức lấy ra danh sách trạng thái ghế
        /// <summary>
        /// Phương thức lấy ra danh sách trạng thái ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaTrangThai()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tb_TrangThai]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra trạng thái ghế theo mã
        /// <summary>
        /// Phương thức lấy ra trạng thái ghế theo mã
        /// </summary>
        /// <param name="maTrangThai"></param>
        /// <returns></returns>
        public static DataTable ThongTinTrangThaiTheoMa(int maTrangThai)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tb_TrangThai] WHERE [MaTrangThai]=@maTrangThai");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maTrangThai", maTrangThai);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
