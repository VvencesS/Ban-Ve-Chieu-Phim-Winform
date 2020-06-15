using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyDatVe
{
    public class BUS_GiaVeDat
    {
        /// <summary>
        /// Phương thức thêm mới giá vé đặt
        /// </summary>
        /// <param name="maGia"></param>
        /// <param name="maVe"></param>
        public static void GiaVeDat_Insert(int maGia, int maVe)
        {
            DAL.DAL_QuanLyDatVe.DAL_GiaVeDat.GiaVeDat_Insert(maGia, maVe);
        }
    }
}
