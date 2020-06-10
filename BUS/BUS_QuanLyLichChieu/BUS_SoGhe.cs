using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_SoGhe
    {
        /// <summary>
        /// Phương thức lấy tất cả số ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaSoGhe()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_SoGhe.ThongTinTatCaSoGhe();
        }
        /// <summary>
        /// Phương thức lấy số ghế theo số
        /// </summary>
        /// <param name="soGhe"></param>
        /// <returns></returns>
        public static DataTable LaySoGheTheoSoGhe(string soGhe)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_SoGhe.ThongTinSoGheTheoSo(soGhe);
        }
    }
}
