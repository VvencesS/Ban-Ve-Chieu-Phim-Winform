using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_TrangThai
    {
        /// <summary>
        /// Phương thức lấy tất cả trạng thái
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTrangThai()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_TrangThai.ThongTinTrangThai();
        }
    }
}
