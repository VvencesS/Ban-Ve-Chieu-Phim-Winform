using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class XuLyNgayThang
    {
        public static DateTime XuLyChuoiNgayThang(string date)
        {
            int ngay = Convert.ToInt32(date.Substring(0, 2));
            int thang = Convert.ToInt32(date.Substring(3, 2));
            int nam = Convert.ToInt32(date.Substring(6, 4));
            DateTime dt = new DateTime(nam, thang, ngay);

            return dt;
        }
    }
}
