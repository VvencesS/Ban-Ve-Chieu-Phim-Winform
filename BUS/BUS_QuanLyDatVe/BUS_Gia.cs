using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyDatVe
{
    public class BUS_Gia
    {
        /// <summary>
        /// Phuong thức lấy tất cả giá
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaGia()
        {
            return DAL.DAL_QuanLyDatVe.DAL_Gia.LayTatCaGia();
        }
        /// <summary>
        /// Phuong thức lấy giá theo mã giá
        /// </summary>
        /// <param name="maGia"></param>
        /// <returns></returns>
        public static DataTable LayGiaMaGia(int maGia)
        {
            return DAL.DAL_QuanLyDatVe.DAL_Gia.LayGiaMaGia(maGia);
        }
    }
}
