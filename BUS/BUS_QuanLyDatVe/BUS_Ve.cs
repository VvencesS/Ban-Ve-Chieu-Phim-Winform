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
        /// <param name="maGia"></param>
        public static void ThemMoiVe(int maPhim, int maPhong, string soGhe, int maKTG, int maGia)
        {
            DAL.DAL_QuanLyDatVe.DAL_Ve.Ve_Insert(maPhim, maPhong, soGhe, maKTG, maGia);
        }
        /// <summary>
        /// Phương thức lấy tất cả vé
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaVe()
        {
            return DAL.DAL_QuanLyDatVe.DAL_Ve.ThongTinTatCaVe();
        }
    }
}
