
using System.Collections;

namespace QL_phong_lab
{
    public class LoginInfo
    {
        public string TaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public string VaiTro { get; set; }

        public string MaNV { get; set; }
        public string MaGV { get; set; }

        public bool TrangThai { get; set; }

        public LoginInfo(string taiKhoan, string matKhau, string vaiTro, bool trangThai, string maNV, string maGV)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            VaiTro = vaiTro;
            TrangThai = trangThai;
            MaNV = maNV;
            MaGV = maGV;
        }
        
    }
}
