using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_QuanHuyen
    {
        #region Phương thức lấy ra danh sách tất cả quận/huyện
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả quận/huyện
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaQuanHuyen()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_QuanHuyen.ThongTinTatCaQuanHuyen();
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
            return DAL.DAL_QuanLyLichChieu.DAL_QuanHuyen.ThongTinQuanHuyenTheoMa(maQuanHuyen);
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
            return DAL.DAL_QuanLyLichChieu.DAL_QuanHuyen.ThongTinQuanHuyenTheoMaTinhThanhPho(maTinhThanhPho);
        }
        #endregion
    }
}
