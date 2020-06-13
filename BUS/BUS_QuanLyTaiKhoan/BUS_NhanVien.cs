using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_QuanLyTaiKhoan
{
    public class BUS_NhanVien
    {
        /// <summary>
        /// Phương thức lấy tất cả nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinNhanVien()
        {
            return DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.ThongTinNhanvien();
        }
        /// <summary>
        /// Phương thức lấy nhân viên theo mã
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinNhanVienTHeoMa(int maNhanVien)
        {
            return DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.LayNhanvienTheoMa(maNhanVien);
        }
        /// <summary>
        /// Phương thức xóa nhân viên bằng mã
        /// </summary>
        /// <param name="maNhanVien"></param>
        public static void XoaNhanVien(int maNhanVien)
        {
            DataTable dt = DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.LayNhanvienTheoMa(maNhanVien);
            if (dt.Rows.Count > 0)
            {
                DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.Nhanvien_Delete(maNhanVien);
            }
        }
        /// <summary>
        /// Phương thức thêm mới nhân viên
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="hoTen"></param>
        /// <param name="email"></param>
        /// <param name="sdt"></param>
        /// <param name="soThe"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="passWord"></param>
        /// <param name="idXaPhuong"></param>
        public static void ThemMoiNhanVien(string userName, string hoTen, string email, string sdt, string soThe, string gioiTinh, string ngaySinh, string passWord, string idXaPhuong)
        {
            DateTime ns = XuLyNgayThang.XuLyChuoiNgayThang(ngaySinh);
            int idXP = int.Parse(idXaPhuong);
            bool gt = (gioiTinh == "Nam") ? true : false;
            DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.Nhanvien_Inser(userName, hoTen, email, sdt, soThe, gt, ns, passWord, idXP);
        }
        /// <summary>
        /// Phương thức cập nhật nhân viên
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="hoTen"></param>
        /// <param name="email"></param>
        /// <param name="sdt"></param>
        /// <param name="soThe"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="passWord"></param>
        /// <param name="idXaPhuong"></param>
        /// <param name="maNhanVien"></param>
        public static void CapNhatNhanVien(string userName, string hoTen, string email, string sdt, string soThe, string gioiTinh, string ngaySinh, string passWord, string idXaPhuong, int maNhanVien)
        {
            DataTable dt = DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.LayNhanvienTheoMa(maNhanVien);
            if (dt.Rows.Count > 0)
            {
                DateTime ns = XuLyNgayThang.XuLyChuoiNgayThang(ngaySinh);
                int idXP = int.Parse(idXaPhuong);
                bool gt = (gioiTinh == "Nam" || gioiTinh == "nam") ? true : false;
                DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.Nhanvien_Update(userName, hoTen, email, sdt, soThe, gt, ns, passWord, idXP, maNhanVien);
            }
        }
        /// <summary>
        /// Phương thức login
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public static DataTable Login(string userName, string passWord)
        {
            return DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.Login(userName, MaHoa.MaHoaMD5(passWord));
        }
        /// <summary>
        /// Phương thức tìm kiếm
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static DataTable TimKiem(string search)
        {
            return DAL.DAL_QuanLyTaiKhoan.DAL_NhanVien.Search(search);
        }
    }
}
