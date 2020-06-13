using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class DAL_QuanHuyen
    {
        #region Phương thức lấy ra danh sách tất cả quận/huyện
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả quận/huyện
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaQuanHuyen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_QuanHuyen");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin xã quận huyện theo mã quận/huyện
        /// <summary>
        /// Phương thức lấy ra thông tin xã phường theo mã xã/phường
        /// </summary>
        /// <param name="maQuanHuyen"></param>
        /// <returns></returns>
        public static DataTable ThongTinQuanHuyenTheoMa(int maQuanHuyen)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_QuanHuyen WHERE [IDQuanHuyen]=@maQuanHuyen");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maQuanHuyen", maQuanHuyen);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
        #region Phương thức lấy ra thông tin xã quận huyện theo mã tỉnh/thành phố
        /// <summary>
        /// Phương thức lấy ra thông tin xã phường theo mã tỉnh/thành phố
        /// </summary>
        /// <param name="maTinhThanhPho"></param>
        /// <returns></returns>
        public static DataTable ThongTinQuanHuyenTheoMaTinhThanhPho(int maTinhThanhPho)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_QuanHuyen WHERE [IDTinhThanhPho]=@maTinhThanhPho");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maTinhThanhPho", maTinhThanhPho);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
