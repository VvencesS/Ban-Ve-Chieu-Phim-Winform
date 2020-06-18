using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_KhungThoiGian
    {
        /// <summary>
        /// Phương thức xóa KTG
        /// </summary>
        /// <param name="maKTG"></param>
        public static void XoaKhungThoiGian(int maKTG)
        {
            DataTable dt = DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.ThongTinKTGTheoMa(maKTG);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.KTG_Delete(maKTG);
            }
        }
        /// <summary>
        /// Thêm mới KTG
        /// </summary>
        /// <param name="ngayChieu"></param>
        /// <param name="gioChieu"></param>
        public static void ThemMoiKTG(string ngayChieu, string gioChieu)
        {
            DateTime nc = XuLyNgayThang.XuLyChuoiNgayThang(ngayChieu);
            DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.KTG_Insert(nc, gioChieu); 
        }
        /// <summary>
        /// Phương thức cập nhật KTG
        /// </summary>
        /// <param name="maKTG"></param>
        /// <param name="ngayChieu"></param>
        /// <param name="gioChieu"></param>
        public static void CapNhatKTG(int maKTG, string ngayChieu, string gioChieu)
        {
            DataTable dt = DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.ThongTinKTGTheoMa(maKTG);
            if (dt.Rows.Count > 0)
            {
                DateTime nc = XuLyNgayThang.XuLyChuoiNgayThang(ngayChieu);
                DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.KTG_Update(maKTG, nc, gioChieu);
            }
        }
        /// <summary>
        /// Phương thức lấy tất cả KTG
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaKTG()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.ThongTinTatCaKTG();
        }
        /// <summary>
        /// Phương thức lấy KTG theo mã KTG
        /// </summary>
        /// <param name="maKTG"></param>
        /// <returns></returns>
        public static DataTable LayKTGTheoMa(int maKTG)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.ThongTinKTGTheoMa(maKTG);
        }
        
        /// <summary>
        /// Phương thức lấy ra thông tin giờ chiếu theo ngày chiếu
        /// </summary>
        /// <param name="ngayChieu"></param>
        /// <returns></returns>
        public static DataTable ThongTinGioChieuTheoNgayChieu(int ngayChieu)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.ThongTinGioChieuTheoNgayChieu(ngayChieu);
        }
        /// <summary>
        /// Phương thức lấy khung thời gian theo mã phim
        /// </summary>
        /// <param name="maPhim"></param>
        /// <returns></returns>
        public static DataTable LayKTGTheoMaPhim(int maPhim)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.LayKTGTheoMaPhim(maPhim);
        }
        /// <summary>
        /// Phương thức lấy giờ chiếu theo mã phim
        /// </summary>
        /// <param name="maPhim"></param>
        /// <returns></returns>
        public static DataTable LayGioChieuTheoMaPhim(int maPhim)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.LayGioChieuTheoMaPhim(maPhim);
        }
        /// <summary>
        /// Phương thức tìm kiếm theo ngày chiếu hoặc theo giờ chiếu
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static DataTable Search(string search)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_KhungThoiGian.Search(search);
        }
    }
}
