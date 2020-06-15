using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_QuanLyDatVe
{
    public class DAL_DatGhe
    {
        #region Phương thức thêm mới đặt ghế
        /// <summary>
        /// Phương thức thêm mới đặt ghế
        /// </summary>
        /// <param name="soGhe"></param>
        /// <param name="maVe"></param>
        public static void DatGhe_Insert(string soGhe, int maVe)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tb_DatGhe] ([SoGhe],[MaVe]) VALUES(@soGhe,@maVe)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@soGhe", soGhe);
            cmd.Parameters.AddWithValue("@maVe", maVe);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
