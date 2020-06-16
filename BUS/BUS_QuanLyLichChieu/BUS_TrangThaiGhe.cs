using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_TrangThaiGhe
    {
        /// <summary>
        /// Phương thức lấy ra danh sách trạng thái ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaTrangThai()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_TrangThaiGhe.ThongTinTatCaTrangThai();
        }
        /// <summary>
        /// Phương thức lấy ra trạng thái ghế theo mã
        /// </summary>
        /// <param name="maTrangThai"></param>
        /// <returns></returns>
        public static DataTable ThongTinTrangThaiTheoMa(int maTrangThai)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_TrangThaiGhe.ThongTinTrangThaiTheoMa(maTrangThai);
        }
    }
}
