using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyLichChieu
{
    public class  DAL_TrangThai
    {
        #region Phương thức lấy ra danh sách tất cả trạng thái
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả trạng thái
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTrangThai()
        {
            SqlCommand cmd = new SqlCommand("select * from tb_TrangThai");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
