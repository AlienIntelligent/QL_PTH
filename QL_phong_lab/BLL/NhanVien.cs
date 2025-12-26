using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_phong_lab
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public NhanVien() { }

        public NhanVien(string hoTen, string ngaySinh, string gioiTinh, string soDienThoai, string email, string maNV)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            Email = email;
            MaNhanVien = maNV;
        }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;

        public DataTable TableNV(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                DataProvider.OpenConnection();
                dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(dt);
                DataProvider.CloseConnection();
            }
            return dt;
        }

        public void Command(string query)
        {
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                DataProvider.OpenConnection();
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                DataProvider.CloseConnection();
            }
        }

        public bool ThemNhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string soDT, string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = @"INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email)
                             VALUES (@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNV.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", hoTen ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDT ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string soDT, string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = @"UPDATE NhanVien
                             SET HoTen = @HoTen,
                                 NgaySinh = @NgaySinh,
                                 GioiTinh = @GioiTinh,
                                 SoDienThoai = @SoDienThoai,
                                 Email = @Email
                             WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNV.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", hoTen ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDT ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool XoaNhanVien(string maNV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNV.Trim());
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