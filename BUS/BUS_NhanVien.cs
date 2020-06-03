using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        public static DataTable ThongtinTatCaNhanvien()
        {
            return DAL_NhanVien.ThongTinNhanvien();
        }
    }
}
