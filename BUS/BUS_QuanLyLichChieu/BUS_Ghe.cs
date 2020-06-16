using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyLichChieu
{
    public class BUS_Ghe
    {
        /// <summary>
        /// Phương thức xóa ghế
        /// </summary>
        /// <param name="maGhe"></param>
        public static void XoaGhe(int maGhe)
        {
            DataTable dt = DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinGheTheoMa(maGhe);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyLichChieu.DAL_Ghe.Ghe_Delete(maGhe);
            }
        }
        /// <summary>
        /// Phương thức thêm mới ghế
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="maLoaiGhe"></param>
        /// <param name="soGhe"></param>
        /// <param name="trangThai"></param>
        public static void ThemMoiGhe(int maPhong, int maLoaiGhe, string soGhe, int trangThai)
        {
            DAL.DAL_QuanLyLichChieu.DAL_Ghe.Ghe_Inser(maPhong, maLoaiGhe, soGhe, trangThai);
        }
        /// <summary>
        /// Phương thức cập nhật ghế
        /// </summary>
        /// <param name="maGhe"></param>
        /// <param name="maPhong"></param>
        /// <param name="maLoaiGhe"></param>
        /// <param name="soGhe"></param>
        /// <param name="trangThai"></param>
        public static void CapNhatGhe(int maGhe, int maPhong, int maLoaiGhe, string soGhe, int trangThai)
        {
            DataTable dt = DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinGheTheoMa(maGhe);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyLichChieu.DAL_Ghe.Ghe_Update(maGhe, maPhong, maLoaiGhe, soGhe, trangThai);
            }
        }
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một ghế theo số ghế
        /// </summary>
        /// <param name="soGhe"></param>
        /// <param name="trangThai"></param>
        public static void Ghe_UpdateBySoGhe(string soGhe, int trangThai)
        {
            DAL.DAL_QuanLyLichChieu.DAL_Ghe.Ghe_UpdateBySoGhe(soGhe, trangThai);
        }
        /// <summary>
        /// Phương thức lấy thông tin tất cả ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable LayTatCaGhe()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinTatCaGhe();
        }
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả ghế
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaGhe1()
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinTatCaGhe1();
        }
        /// <summary>
        /// Phương thức lấy ra ghế theo mã ghế
        /// </summary>
        /// <param name="maGhe"></param>
        /// <returns></returns>
        public static DataTable LayGheTheoMa(int maGhe)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinGheTheoMa(maGhe);
        }
        
        /// <summary>
        /// Phương thức lấy ra thông tin ghế thường theo mã phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns></returns>
        public static DataTable ThongTinGheThuongTheoMaPhong(int maPhong)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinGheThuongTheoMaPhong(maPhong);
        }
        
        /// <summary>
        /// Phương thức lấy ra thông tin ghế vip theo mã phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns></returns>
        public static DataTable ThongTinGheVipTheoMaPhong(int maPhong)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinGheVipTheoMaPhong(maPhong);
        }
        
        /// <summary>
        /// Phương thức lấy ra thông tin ghế đôi theo mã phòng
        /// </summary>
        /// <param name="maPhong"></param>
        /// <returns></returns>
        public static DataTable ThongTinGheDoiTheoMaPhong(int maPhong)
        {
            return DAL.DAL_QuanLyLichChieu.DAL_Ghe.ThongTinGheDoiTheoMaPhong(maPhong);
        }
    }
}
