using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_TinhThanhPho
    {
        #region Phương thức lấy ra danh sách tất cả tỉnh/thành phố
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả tỉnh/thành phố
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaTinhThanhPho()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_TinhThanhPho.ThongTinTatCaTinhThanhPho();
        }
        #endregion

        #region Phương thức lấy ra thông tin tỉnh/thành phố theo mã tỉnh/thành phố
        /// <summary>
        /// Phương thức lấy ra thông tin tỉnh/thành phố theo mã tỉnh/thành phố
        /// </summary>
        /// <param name="maTinhThanhPho"></param>
        /// <returns></returns>
        public static DataTable ThongTinTinhThanhPhoTheoMa(int maTinhThanhPho)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_TinhThanhPho.ThongTinTinhThanhPhoTheoMa(maTinhThanhPho);
        }
        #endregion
    }
}
