using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_LoaiGhe
    {
        /// <summary>
        /// Phương thức lấy tất cả loại ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaLoaiGhe()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_LoaiGhe.ThongTinTatCaLoaiGhe();
        }
        /// <summary>
        /// Phương thức lấy loại ghế theo mã
        /// </summary>
        /// <param name="maLoaiGhe"></param>
        /// <returns></returns>
        public static DataTable LayLoaiGheTheoMa(int maLoaiGhe)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_LoaiGhe.ThongTinLoaiGheTheoMa(maLoaiGhe);
        }
    }
}
