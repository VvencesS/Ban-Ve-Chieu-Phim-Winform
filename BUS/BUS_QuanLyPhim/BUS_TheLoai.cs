using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyPhim
{
    public class BUS_TheLoai
    {
        /// <summary>
        /// Phương thức xóa thể loại
        /// </summary>
        /// <param name="maTheLoai"></param>
        public static void XoaTheLoai(int maTheLoai)
        {
            DataTable dt = DAL.DAL_QuanLyPhim.DAL_TheLoai.ThongTinTheLoaiTheoMa(maTheLoai);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyPhim.DAL_TheLoai.TheLoai_Delete(maTheLoai);
            }
        }
        /// <summary>
        /// Phương thức thêm mới thể loại
        /// </summary>
        /// <param name="tenTheLoai"></param>
        public static void ThemMoiTheLoai(string tenTheLoai)
        {
            DAL.DAL_QuanLyPhim.DAL_TheLoai.TheLoai_Inser(tenTheLoai);
        }
        /// <summary>
        /// Phương thức cập nhật thể loại
        /// </summary>
        /// <param name="maTheLoai"></param>
        /// <param name="tenTheLoai"></param>
        public static void CapNhatTheLoai(int maTheLoai, string tenTheLoai)
        {
            DataTable dt = DAL.DAL_QuanLyPhim.DAL_TheLoai.ThongTinTheLoaiTheoMa(maTheLoai);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyPhim.DAL_TheLoai.TheLoai_Update(maTheLoai,tenTheLoai);
            }
        }
        /// <summary>
        /// Phương thức lấy tất cả thể loại
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaTheLoai()
        {
            return DAL.DAL_QuanLyPhim.DAL_TheLoai.ThongTinTatCaTheLoai();
        }
        /// <summary>
        /// Phương thức lấy thể loại theo mã
        /// </summary>
        /// <param name="maTheLoai"></param>
        /// <returns></returns>
        public static DataTable LayTheLoaiTheoMa(int maTheLoai)
        {
            return DAL.DAL_QuanLyPhim.DAL_TheLoai.ThongTinTheLoaiTheoMa(maTheLoai);
        }
    }
}
