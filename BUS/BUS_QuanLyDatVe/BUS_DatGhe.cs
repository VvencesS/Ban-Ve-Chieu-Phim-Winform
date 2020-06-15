using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyDatVe
{
    public class BUS_DatGhe
    {
        #region Phương thức thêm mới đặt ghế
        /// <summary>
        /// Phương thức thêm mới đặt ghế
        /// </summary>
        /// <param name="soGhe"></param>
        /// <param name="maVe"></param>
        public static void DatGhe_Insert(string soGhe, int maVe)
        {
            DAL.DAL_QuanLyDatVe.DAL_DatGhe.DatGhe_Insert(soGhe, maVe);
        }
        #endregion
    }
}
