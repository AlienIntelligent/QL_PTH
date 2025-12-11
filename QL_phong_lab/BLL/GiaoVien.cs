using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_phong_lab
{
    public class GiaoVien
    {
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MaBomon { get; set; }
        public string MaGiaoVien { get; set; }

        public GiaoVien(string hoTen, string ngaySinh, string gioiTinh, string soDienThoai, string email, string maBomon, string maGV)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            Email = email;
            MaBomon = maBomon;
            MaGiaoVien = maGV;
        }
    }
}
