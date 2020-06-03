using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        #region Phương thức lấy ra danh sách tất cả Nhân viên
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinNhanvien()
        {
            SqlCommand cmd = new SqlCommand("Select * from tb_NhanVien");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
