using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_XaPhuong
    {
        #region Phương thức lấy ra danh sách tất cả xã/phường
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả xã/phường
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaXaPhuong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_XaPhuong");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin xã phường theo mã xã/phường
        /// <summary>
        /// Phương thức lấy ra thông tin xã phường theo mã xã/phường
        /// </summary>
        /// <param name="maXaPhuong"></param>
        /// <returns></returns>
        public static DataTable ThongTinXaPhuongTheoMa(int maXaPhuong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_XaPhuong WHERE [IDXaPhuong]=@maXaPhuong");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maXaPhuong", maXaPhuong);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra thông tin xã phường theo mã quận/huyện
        /// <summary>
        /// Phương thức lấy ra thông tin xã phường theo mã quận/huyện
        /// </summary>
        /// <param name="maQuanHuyen"></param>
        /// <returns></returns>
        public static DataTable ThongTinXaPhuongTheoMaQuanHuyen(int maQuanHuyen)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_XaPhuong WHERE [IDQuanHuyen]=@maQuanHuyen");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maQuanHuyen", maQuanHuyen);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra thông tin xã phường theo tên xã/phường
        /// <summary>
        /// Phương thức lấy ra thông tin xã phường theo tên xã/phường
        /// </summary>
        /// <param name="maXaPhuong"></param>
        /// <returns></returns>
        public static DataTable ThongTinXaPhuongTheoTen(string tenXaPhuong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_XaPhuong WHERE [TenXaPhuong]=@tenXaPhuong");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@tenXaPhuong", tenXaPhuong);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
