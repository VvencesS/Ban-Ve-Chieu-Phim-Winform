using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyDatVe
{
    public class DAL_DSDatVe
    {
        #region Phương thức thêm mới ds vé
        /// <summary>
        /// Phương thức thêm mới ds vé
        /// </summary>
        /// <param name="maVe"></param>
        /// <param name="maThanhVien"></param>
        public static void DSDatVe_Inser(int maVe, int maThanhVien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_DSVeDat]([MaVe],[MaThanhVien]) VALUES(@maVe,@maThanhVien)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@maVe", maVe);
            cmd.Parameters.AddWithValue("@maThanhVien", maThanhVien);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả ds vé
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả ds vé
        /// </summary>
        /// <returns></returns>
        public static DataTable ThongTinTatCaDSDatVe()
        {
            SqlCommand cmd = new SqlCommand("SELECT tb_Ve.MaVe,tb_Phim.TenPhim,tb_Phong.TenPhong,tb_DinhDang.TenDinhDang,tb_DatGhe.SoGhe,tb_KTG.NgayChieu,tb_KTG.GioChieu,tb_Gia.DonGia,tb_ThanhVien.HoTen FROM [dbo].[tb_DSVeDat]"+
                "INNER JOIN tb_Ve ON tb_Ve.MaVe = tb_DSVeDat.MaVe"+
                "INNER JOIN tb_Phim ON tb_Phim.MaPhim = tb_Ve.MaPhim"+
                "INNER JOIN tb_Phong ON tb_Phong.MaPhong = tb_Ve.MaPhong"+
                "INNER JOIN tb_DinhDang ON tb_Phong.MaDinhDang = tb_DinhDang.MaDinhDang"+
                "INNER JOIN tb_DatGhe ON tb_DatGhe.MaVe = tb_Ve.MaVe"+
                "INNER JOIN tb_KTG ON tb_KTG.MaKTG = tb_Ve.MaKTG"+
                "INNER JOIN tb_Gia ON tb_Gia.MaGia = tb_Ve.MaGia"+
                "INNER JOIN tb_ThanhVien ON tb_ThanhVien.MaThanhVien = tb_DSVeDat.MaThanhVien");
            cmd.CommandType = CommandType.Text;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
