using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyPhim
{
    public class BUS_QuocGia
    {
        /// <summary>
        /// Phương thức xóa Quốc gia
        /// </summary>
        /// <param name="maQuocGia"></param>
        public static void XoaQuocGia(int maQuocGia)
        {
            DataTable dt = DAL.DAL_QuanLyPhim.DAL_QuocGia.ThongTinQuocGiaTheoMa(maQuocGia);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyPhim.DAL_QuocGia.QuocGia_Delete(maQuocGia);
            }
        }
        /// <summary>
        /// Phương thức thêm mới quốc gia
        /// </summary>
        /// <param name="tenQuocGia"></param>
        public static void ThemMoiQuocGia(string tenQuocGia)
        {
            DAL.DAL_QuanLyPhim.DAL_QuocGia.QuocGia_Inser(tenQuocGia);
        }
        /// <summary>
        /// Phương thức cập nhật quốc gia
        /// </summary>
        /// <param name="maQuocGia"></param>
        /// <param name="tenQuocGia"></param>
        public static void CapNhatQuocGia(int maQuocGia, string tenQuocGia)
        {
            DataTable dt = DAL.DAL_QuanLyPhim.DAL_QuocGia.ThongTinQuocGiaTheoMa(maQuocGia);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyPhim.DAL_QuocGia.QuocGia_Update(maQuocGia,tenQuocGia);
            }
        }
        /// <summary>
        /// Phương thức lấy tất cả quốc gia
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaQuocGia()
        {
            return DAL.DAL_QuanLyPhim.DAL_QuocGia.ThongTinTatCaQuocGia();
        }
        /// <summary>
        /// Phương thức lấy quốc gia theo mã
        /// </summary>
        /// <param name="maQuocGia"></param>
        /// <returns></returns>
        public static DataTable LayQuocGiaTheoMa(int maQuocGia)
        {
            return DAL.DAL_QuanLyPhim.DAL_QuocGia.ThongTinQuocGiaTheoMa(maQuocGia);
        }
    }
}
