using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_phong_lab
{
    public class GiaoVien
    {
        public string MaGiaoVien { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }        // Bạn đang lưu dưới dạng string trong DB
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MaBoMon { get; set; }

        // Constructor mặc định (bắt buộc cho một số trường hợp)
        public GiaoVien() { }

        // Constructor 7 tham số - để bạn có thể dùng:
        // giaoViens.Add(new GiaoVien(hoTen, ngaySinh, gioiTinh, soDienThoai, email, maBoMon, maGiaoVien));
        public GiaoVien(string hoTen, string ngaySinh, string gioiTinh, string soDienThoai,
                        string email, string maBoMon, string maGiaoVien)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            Email = email;
            MaBoMon = maBoMon;
            MaGiaoVien = maGiaoVien;
        }

        // Hàm lấy dữ liệu chung (dùng cho DataGridView và các ComboBox)
        public DataTable TableGV(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                DataProvider.OpenConnection();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(dt);
                DataProvider.CloseConnection();
            }
            return dt;
        }

        // Load danh sách bộ môn để đổ vào cbx_bomon
        public DataTable LoadBoMon()
        {
            string query = "SELECT MaBoMon, TenBoMon FROM BoMon ORDER BY TenBoMon";
            return TableGV(query);
        }

        // Thêm giáo viên mới
        public bool ThemGiaoVien(string maGV, string hoTen, DateTime ngaySinh, string gioiTinh,
                                 string soDT, string email, string maBoMon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = @"INSERT INTO GiaoVien (MaGiaoVien, HoTen, NgaySinh, GioiTinh,
                                     SoDienThoai, Email, MaBoMon)
                                     VALUES (@MaGiaoVien, @HoTen, @NgaySinh, @GioiTinh,
                                             @SoDienThoai, @Email, @MaBoMon)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGiaoVien", maGV.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", hoTen ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDT ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaBoMon", string.IsNullOrWhiteSpace(maBoMon) ? (object)DBNull.Value : maBoMon.Trim());

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Sửa giáo viên
        public bool SuaGiaoVien(string maGV, string hoTen, DateTime ngaySinh, string gioiTinh,
                                string soDT, string email, string maBoMon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = @"UPDATE GiaoVien
                                     SET HoTen = @HoTen,
                                         NgaySinh = @NgaySinh,
                                         GioiTinh = @GioiTinh,
                                         SoDienThoai = @SoDienThoai,
                                         Email = @Email,
                                         MaBoMon = @MaBoMon
                                     WHERE MaGiaoVien = @MaGiaoVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGiaoVien", maGV.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", hoTen ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDT ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaBoMon", string.IsNullOrWhiteSpace(maBoMon) ? (object)DBNull.Value : maBoMon.Trim());

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Xóa giáo viên
        public bool XoaGiaoVien(string maGV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = "DELETE FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGiaoVien", maGV.Trim());
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