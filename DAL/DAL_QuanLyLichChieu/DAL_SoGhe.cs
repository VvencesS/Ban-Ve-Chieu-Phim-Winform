using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_SoGhe
    {
        #region Phương thức lấy ra danh sách tất cả ghế
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaSoGhe()
        {
            SqlCommand cmd = new SqlCommand("SELECT [SoGhe],[SoHang],[SoCot] FROM [dbo].[tb_SoGhe]");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin số ghế theo số ghế
        /// <summary>
        /// Phương thức lấy ra thông tin ghế theo số ghế
        /// </summary>
        /// <param name="soGhe"></param>
        /// <returns></returns>
        public static DataTable ThongTinSoGheTheoSo(string soGhe)
        {
            SqlCommand cmd = new SqlCommand("SELECT [SoGhe],[SoHang],[SoCot] FROM [dbo].[tb_SoGhe] WHERE [SoGhe]=@soGhe");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@soGhe", soGhe);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
