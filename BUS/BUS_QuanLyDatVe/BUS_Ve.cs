using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyDatVe
{
    public class BUS_Ve
    {
        /// <summary>
        /// Phương thức thêm mới vé
        /// </summary>
        /// <param name="maPhim"></param>
        /// <param name="maPhong"></param>
        /// <param name="soGhe"></param>
        /// <param name="maKTG"></param>
        public static void ThemMoiVe(int maPhim, int maPhong, int maKTG)
        {
            DAL.DAL_QuanLyDatVe.DAL_Ve.Ve_Insert(maPhim, maPhong, maKTG);
        }
        /// <summary>
        /// Phương thức lấy tất cả vé
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaVe()
        {
            return DAL.DAL_QuanLyDatVe.DAL_Ve.ThongTinTatCaVe();
        }
        /// <summary>
        /// Phương thức lấy ra vé theo mã phim, mã phòng, mã khung thời gian
        /// </summary>
        /// <param name="maPhim"></param>
        /// <param name="maPhong"></param>
        /// <param name="maKTG"></param>
        /// <returns></returns>
        public static DataTable ThongTinTatCaVeTheo3Ma(int maPhim, int maPhong, int maKTG)
        {
            return DAL.DAL_QuanLyDatVe.DAL_Ve.ThongTinTatCaVeTheo3Ma(maPhim, maPhong, maKTG);
        }
    }
}
