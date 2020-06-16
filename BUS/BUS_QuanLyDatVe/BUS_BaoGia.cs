using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyDatVe
{
    public class BUS_BaoGia
    {
        #region Phương thức thêm mới báo giá
        /// <summary>
        /// Phương thức thêm mới báo giá
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <param name="maLoaiGhe"></param>
        /// <param name="maKTG"></param>
        /// <param name="maGia"></param>
        public static void ThemMoiBaoGia(int maDinhDang, int maLoaiGhe, int maKTG, int maGia)
        {
            DAL.DAL_QuanLyDatVe.DAL_BaoGia.BaoGia_Insert(maDinhDang, maLoaiGhe, maKTG, maGia);
        }
        #endregion
        /// <summary>
        /// Phương thức lấy báo giá
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <param name="maLoaiGhe"></param>
        /// <param name="maKTG"></param>
        /// <param name="maGia"></param>
        /// <returns></returns>
        public static DataTable LayBaoGia()
        {
            return DAL.DAL_QuanLyDatVe.DAL_BaoGia.LayBaoGia();
        }
    }
}
