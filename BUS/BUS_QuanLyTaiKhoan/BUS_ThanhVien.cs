using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyTaiKhoan
{
    public class BUS_ThanhVien
    {
        /// <summary>
        /// Phương thức lấy tất cả thành viên
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinThanhVien()
        {
            return DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThongTinThanhVien();
        }
        /// <summary>
        /// Phương thức lấy thành viên theo mã
        /// </summary>
        /// <param name="maThanhVien"></param>
        /// <returns></returns>
        public static DataTable ThongTinThanhVienTHeoMa(int maThanhVien)
        {
            return DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThongTinThanhVienByMa(maThanhVien);
        }
        /// <summary>
        /// Phương thức xóa thành viên bằng mã
        /// </summary>
        /// <param name="maThanhVien"></param>
        public static void XoaThanhVien(int maThanhVien)
        {
            DataTable dt = DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThongTinThanhVienByMa(maThanhVien);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThanhVien_Delete(maThanhVien);
            }
        }
        /// <summary>
        /// Phương thức thêm mới thành viên
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="email"></param>
        /// <param name="sdt"></param>
        /// <param name="soThe"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="passWord"></param>
        /// <param name="idXaPhuong"></param>
        /// <param name="trangThai"></param>
        public static void ThemMoiThanhVien(string hoTen, string email, string sdt, string soThe, string gioiTinh, string ngaySinh, string passWord, string idXaPhuong, bool trangThai)
        {
            DateTime ns = XuLyNgayThang.XuLyChuoiNgayThang(ngaySinh);
            int idXP = int.Parse(idXaPhuong);
            bool gt = (gioiTinh == "Nam" || gioiTinh == "nam") ? true : false;
            DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThanhVien_Inser(hoTen, email, sdt, soThe, gt, ns, MaHoa.MaHoaMD5(passWord), idXP, trangThai);
        }
        /// <summary>
        /// Phương thức cập nhật Thành viên
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="email"></param>
        /// <param name="sdt"></param>
        /// <param name="soThe"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="passWord"></param>
        /// <param name="idXaPhuong"></param>
        /// <param name="trangThai"></param>
        /// <param name="maThanhVien"></param>
        public static void CapNhatThanhVien(string hoTen, string email, string sdt, string soThe, string gioiTinh, string ngaySinh, string passWord, string idXaPhuong, bool trangThai ,int maThanhVien)
        {
            DataTable dt = DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThongTinThanhVienByMa(maThanhVien);
            if (dt.Rows.Count > 0)
            {
                DateTime ns = XuLyNgayThang.XuLyChuoiNgayThang(ngaySinh);
                int idXP = int.Parse(idXaPhuong);
                bool gt = (gioiTinh == "Nam" || gioiTinh == "nam") ? true : false;
                DAL.DAL_QuanLyTaiKhoan.DAL_ThanhVien.ThanhVien_Update(hoTen, email, sdt, soThe, gt, ns, MaHoa.MaHoaMD5(passWord), idXP, trangThai,maThanhVien);
            }
        }
    }
}
