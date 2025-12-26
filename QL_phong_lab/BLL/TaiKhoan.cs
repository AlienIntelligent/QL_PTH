using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_phong_lab
{
    public class TaiKhoan
    {
        public int MaTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public string MaNhanVien { get; set; }
        public string MaGiaoVien { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThai { get; set; }

        public TaiKhoan() { }

        // Load dữ liệu chung
        public DataTable LoadTaiKhoan(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                DataProvider.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                DataProvider.CloseConnection();
            }
            return dt;
        }

        // Load danh sách giáo viên
        public DataTable LoadGiaoVien()
        {
            string query = "SELECT MaGiaoVien, HoTen FROM GiaoVien ORDER BY HoTen";
            return LoadTaiKhoan(query);
        }

        // Load danh sách nhân viên
        public DataTable LoadNhanVien()
        {
            string query = "SELECT MaNhanVien, HoTen FROM NhanVien ORDER BY HoTen";
            return LoadTaiKhoan(query);
        }

        // ===> THÊM TÀI KHOẢN MỚI - TỰ ĐỘNG SINH MaTaiKhoan <===
        // Trong class TaiKhoan (thay thế hoàn toàn phương thức ThemTaiKhoan cũ)
        public bool ThemTaiKhoan(string tenDN, string matKhau, string vaiTro,
                         string maNV = null, string maGV = null, bool trangThai = true)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();

                    string maTaiKhoanMoi = "";

                    if (!string.IsNullOrWhiteSpace(maGV))
                    {
                        maTaiKhoanMoi = "TK" + maGV.Trim();
                    }
                    else if (!string.IsNullOrWhiteSpace(maNV))
                    {
                        maTaiKhoanMoi = "TK" + maNV.Trim();
                    }
                    else
                    {
                        // Dự phòng cho admin hoặc tài khoản đặc biệt không thuộc GV/NV
                        // Sinh mã dạng TKAD001, TKAD002...
                        string maxQuery = "SELECT ISNULL(MAX(CAST(SUBSTRING(MaTaiKhoan, 5, LEN(MaTaiKhoan)) AS INT)), 0) " +
                                          "FROM TaiKhoan WHERE MaTaiKhoan LIKE 'TKAD%'";
                        using (SqlCommand cmdMax = new SqlCommand(maxQuery, conn))
                        {
                            int soThuTu = Convert.ToInt32(cmdMax.ExecuteScalar()) + 1;
                            maTaiKhoanMoi = "TKAD" + soThuTu.ToString("D3"); // TKAD001, TKAD002...
                        }
                    }

                    // Kiểm tra trùng MaTaiKhoan
                    string checkMaQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTaiKhoan = @MaTK";
                    using (SqlCommand cmdCheck = new SqlCommand(checkMaQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@MaTK", maTaiKhoanMoi);
                        if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show($"Mã tài khoản {maTaiKhoanMoi} đã tồn tại!", "Lỗi");
                            return false;
                        }
                    }

                    string query = @"INSERT INTO TaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, VaiTro,
                             MaNhanVien, MaGiaoVien, NgayTao, TrangThai)
                             VALUES (@MaTaiKhoan, @TenDangNhap, @MatKhau, @VaiTro,
                                     @MaNhanVien, @MaGiaoVien, GETDATE(), @TrangThai)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoanMoi);
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDN.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@VaiTro", vaiTro ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNhanVien", string.IsNullOrWhiteSpace(maNV) ? (object)DBNull.Value : maNV.Trim());
                        cmd.Parameters.AddWithValue("@MaGiaoVien", string.IsNullOrWhiteSpace(maGV) ? (object)DBNull.Value : maGV.Trim());
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai); // ← Luôn là true (1)

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message);
                return false;
            }
        }

        // Sửa tài khoản (không cần chạm đến MaTaiKhoan)
        public bool SuaTaiKhoan(string tenDN, string matKhau, string vaiTro,
                                string maNV, string maGV, string trangThai)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = @"UPDATE TaiKhoan
                                     SET MatKhau = @MatKhau,
                                         VaiTro = @VaiTro,
                                         MaNhanVien = @MaNhanVien,
                                         MaGiaoVien = @MaGiaoVien,
                                         TrangThai = @TrangThai
                                     WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDN.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", string.IsNullOrWhiteSpace(matKhau) ? (object)DBNull.Value : matKhau);
                        cmd.Parameters.AddWithValue("@VaiTro", vaiTro ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNhanVien", string.IsNullOrWhiteSpace(maNV) ? (object)DBNull.Value : maNV.Trim());
                        cmd.Parameters.AddWithValue("@MaGiaoVien", string.IsNullOrWhiteSpace(maGV) ? (object)DBNull.Value : maGV.Trim());
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Xóa tài khoản theo tên đăng nhập
        public bool XoaTaiKhoan(string tenDN)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = "DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDN.Trim());
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}