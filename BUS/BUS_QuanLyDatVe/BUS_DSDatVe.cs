using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyDatVe
{
    public class BUS_DSDatVe
    {
        /// <summary>
        /// Phương thức thêm mới ds đặt vé
        /// </summary>
        /// <param name="maVe"></param>
        /// <param name="maThanhVien"></param>
        public static void ThemMoiDSDatVe(int maVe, int maThanhVien)
        {
            DAL.DAL_QuanLyDatVe.DAL_DSDatVe.DSDatVe_Insert(maVe, maThanhVien);
        }
        /// <summary>
        /// Phương thức lấy ds đăt vé theo mã thành viên
        /// </summary>
        /// <param name="maThanhVien"></param>
        /// <returns></returns>
        public static DataTable LayDSDatVeTheoMaThanhVien(int maThanhVien)
        {
            return DAL.DAL_QuanLyDatVe.DAL_DSDatVe.ThongTinDSDatVeTheMaTV(maThanhVien);
        }
    }
}
