using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_Phong
    {
        /// <summary>
        /// Phương thức xóa phòng
        /// </summary>
        /// <param name="maPhong"></param>
        public static void XoaPhong(int maPhong)
        {
            DataTable dt = DAL.DAL_QuanLyLichChieu.DAL_Phong.ThongTinPhongTheoMa(maPhong);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyLichChieu.DAL_Phong.Phong_Delete(maPhong);
            }
        }
        /// <summary>
        /// Phương thức thêm mới phòng
        /// </summary>
        /// <param name="tenPhong"></param>
        /// <param name="soHangMax"></param>
        /// <param name="soCotMax"></param>
        /// <param name="maDinhDang"></param>
        public static void ThemMoiPhong(string tenPhong, int soHangMax, int soCotMax, int maDinhDang)
        {
            DAL.DAL_QuanLyLichChieu.DAL_Phong.Phong_Insert(tenPhong, soHangMax, soCotMax, maDinhDang);
        }
        /// <summary>
        /// Phương thức cập nhật phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tenPhong"></param>
        /// <param name="soHangMax"></param>
        /// <param name="soCotMax"></param>
        /// <param name="maDinhDang"></param>
        public static void CapNhatPhong(int maPhong, string tenPhong, int soHangMax, int soCotMax, int maDinhDang)
        {
            DataTable dt = DAL.DAL_QuanLyLichChieu.DAL_Phong.ThongTinPhongTheoMa(maPhong);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyLichChieu.DAL_Phong.Phong_Update(maPhong, tenPhong, soHangMax, soCotMax, maDinhDang);
            }
        }
        /// <summary>
        /// Phương thức lấy tất cả phòng
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaPhong()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Phong.ThongTinTatCaPhong();
        }
        /// <summary>
        /// Phương thức lấy phòng theo mã phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns></returns>
        public static DataTable LayPhongTheoMa(int maPhong)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Phong.ThongTinPhongTheoMa(maPhong);
        }
    }
}
