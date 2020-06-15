using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyPhim
{
    public class BUS_DinhDang
    {
        /// <summary>
        /// Phương thức xóa Định dạng
        /// </summary>
        /// <param name="maDinhDang"></param>
        public static void XoaDinhDang(int maDinhDang)
        {
            DataTable dt = DAL.DAL_QuanLyPhim.DAL_DinhDang.ThongTinDinhDangTheoMa(maDinhDang);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyPhim.DAL_DinhDang.DinhDang_Delete(maDinhDang);
            }
        }
        /// <summary>
        /// Phương thức thêm mới định dạng
        /// </summary>
        /// <param name="tenDinhDang"></param>
        public static void ThemMoiDinhDang(string tenDinhDang)
        {
            DAL.DAL_QuanLyPhim.DAL_DinhDang.DinhDang_Inser(tenDinhDang);
        }
        /// <summary>
        /// Phương thức cập nhật Định dạng
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <param name="tenDinhDang"></param>
        public static void CapNhatDinhDang(int maDinhDang, string tenDinhDang)
        {
            DataTable dt = DAL.DAL_QuanLyPhim.DAL_DinhDang.ThongTinDinhDangTheoMa(maDinhDang);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyPhim.DAL_DinhDang.DinhDang_Update(maDinhDang, tenDinhDang);
            }
        }
        /// <summary>
        /// Phương thức lấy tất cả Định dạng
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaDinhDang()
        {
            return DAL.DAL_QuanLyPhim.DAL_DinhDang.ThongTinTatCaDinhDang();
        }
        /// <summary>
        /// Phương thức lấy Định dang theo mã định dang
        /// </summary>
        /// <param name="maDinhDang"></param>
        /// <returns></returns>
        public static DataTable LayDinhDangTheoMa(int maDinhDang)
        {
            return DAL.DAL_QuanLyPhim.DAL_DinhDang.ThongTinDinhDangTheoMa(maDinhDang);
        }
        /// <summary>
        /// Phương thức lấy ra thông tin định dạng theo mã phim
        /// </summary>
        /// <param name="maPhim"></param>
        /// <returns></returns>
        public static DataTable ThongTinDinhDangTheoMaPhim(int maPhim)
        {
            return DAL.DAL_QuanLyPhim.DAL_DinhDang.ThongTinDinhDangTheoMaPhim(maPhim);
        }
    }
}
