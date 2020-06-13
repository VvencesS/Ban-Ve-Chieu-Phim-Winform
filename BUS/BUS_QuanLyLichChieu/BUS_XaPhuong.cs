using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_XaPhuong
    {
        #region Phương thức lấy ra danh sách tất cả xã/phường
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả xã/phường
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaXaPhuong()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_XaPhuong.ThongTinTatCaXaPhuong();
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
            return DAL.DAL_QuanLyLichChieu.DAL_XaPhuong.ThongTinXaPhuongTheoMa(maXaPhuong);
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
            return DAL.DAL_QuanLyLichChieu.DAL_XaPhuong.ThongTinXaPhuongTheoMaQuanHuyen(maQuanHuyen);
        }
        #endregion
        #region Phương thức lấy ra thông tin xã phường theo tên xã/phường
        /// <summary>
        /// Phương thức lấy ra thông tin xã phường theo tên xã/phường
        /// </summary>
        /// <param name="tenXaPhuong"></param>
        /// <returns></returns>
        public static DataTable ThongTinXaPhuongTheoTen(string tenXaPhuong)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_XaPhuong.ThongTinXaPhuongTheoTen(tenXaPhuong);
        }
        #endregion
    }
}
