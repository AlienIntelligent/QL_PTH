using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Documents;

namespace QL_phong_lab
{
    public class DataProvider
    {
        const string connectionString = @"Data Source=NEYUHTLAP\SQLEXPRESS;Initial Catalog=QL_lichphongthuchanh;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static List<LoginInfo> loginInfos = new List<LoginInfo>();
        public static List<GiaoVien> giaoViens = new List<GiaoVien>();
        public static List<NhanVien> nhanViens = new List<NhanVien>();

        public static void OpenConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private static bool ColumnExists(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }

        public static void GetAllDangNhap()
        {
            try
            {
                OpenConnection();
                string query = "SELECT TenDangNhap, MatKhau, VaiTro, TrangThai, MaGiaoVien, MaNhanVien  FROM TaiKhoan";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    loginInfos.Clear();
                    int idxTenDangNhap = reader.GetOrdinal("TenDangNhap");
                    int idxMatKhau = reader.GetOrdinal("MatKhau");
                    int idxVaiTro = reader.GetOrdinal("VaiTro");
                    int idxTrangThai = ColumnExists(reader, "TrangThai") ? reader.GetOrdinal("TrangThai") : -1;
                    int idxMaGiaoVien = ColumnExists(reader, "MaGiaoVien") ? reader.GetOrdinal("MaGiaoVien") : -1;
                    int idxMaNhanVien = ColumnExists(reader, "MaNhanVien") ? reader.GetOrdinal("MaNhanVien") : -1;

                    while (reader.Read())
                    {
                        string tenDangNhap = reader.IsDBNull(idxTenDangNhap) ? string.Empty : reader.GetString(idxTenDangNhap);
                        string matKhau = reader.IsDBNull(idxMatKhau) ? string.Empty : reader.GetString(idxMatKhau);
                        string vaiTro = reader.IsDBNull(idxVaiTro) ? string.Empty : reader.GetString(idxVaiTro);
                        bool trangThai = (idxTrangThai >= 0 && !reader.IsDBNull(idxTrangThai)) ? reader.GetBoolean(idxTrangThai) : false;
                        string maGiaoVien = (idxMaGiaoVien >= 0 && !reader.IsDBNull(idxMaGiaoVien)) ? reader.GetString(idxMaGiaoVien) : string.Empty;
                        string maNhanVien = (idxMaNhanVien >= 0 && !reader.IsDBNull(idxMaNhanVien)) ? reader.GetString(idxMaNhanVien) : string.Empty;

                        loginInfos.Add(new LoginInfo(tenDangNhap, matKhau, vaiTro, trangThai, maNhanVien, maGiaoVien));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static void GetAllNguoiDung()
        {
            try
            {
                OpenConnection();
                string query = "SELECT tk.MaTaiKhoan, tk.TenDangNhap, tk.VaiTro,\r\nnv.MaNhanVien, nv.HoTen AS HoTenNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, nv.Email,\r\ngv.MaGiaoVien, gv.HoTen AS HoTenGiaoVien, gv.NgaySinh, gv.GioiTinh, gv.SoDienThoai, gv.Email, gv.MaBoMon\r\nFROM TaiKhoan tk\r\nLEFT JOIN NhanVien nv ON tk.MaNhanVien = nv.MaNhanVien\r\nLEFT JOIN GiaoVien gv ON tk.MaGiaoVien = gv.MaGiaoVien";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    giaoViens.Clear();
                    nhanViens.Clear();
                    int idxVaiTro = reader.GetOrdinal("VaiTro");
                    while (reader.Read())
                    {
                        string vaiTro = reader.IsDBNull(idxVaiTro) ? string.Empty : reader.GetString(idxVaiTro);
                        if (vaiTro.Equals("Nhân viên", StringComparison.OrdinalIgnoreCase))
                        {
                            string hoTen = reader.IsDBNull(reader.GetOrdinal("HoTenNhanVien")) ? string.Empty : reader.GetString(reader.GetOrdinal("HoTenNhanVien"));
                            string ngaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? string.Empty : reader.GetDateTime(reader.GetOrdinal("NgaySinh")).ToString("yyyy-MM-dd");
                            string gioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? string.Empty : reader.GetString(reader.GetOrdinal("GioiTinh"));
                            string soDienThoai = reader.IsDBNull(reader.GetOrdinal("SoDienThoai")) ? string.Empty : reader.GetString(reader.GetOrdinal("SoDienThoai"));
                            string email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString(reader.GetOrdinal("Email"));
                            string maNhanVien = reader.IsDBNull(reader.GetOrdinal("MaNhanVien")) ? string.Empty : reader.GetString(reader.GetOrdinal("MaNhanVien"));
                            nhanViens.Add(new NhanVien(hoTen, ngaySinh, gioiTinh, soDienThoai, email, maNhanVien));
                        }
                        else if (vaiTro.Equals("Giáo viên", StringComparison.OrdinalIgnoreCase))
                        {
                            string hoTen = reader.IsDBNull(reader.GetOrdinal("HoTenGiaoVien")) ? string.Empty : reader.GetString(reader.GetOrdinal("HoTenGiaoVien"));
                            string ngaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? string.Empty : reader.GetDateTime(reader.GetOrdinal("NgaySinh")).ToString("yyyy-MM-dd");
                            string gioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? string.Empty : reader.GetString(reader.GetOrdinal("GioiTinh"));
                            string soDienThoai = reader.IsDBNull(reader.GetOrdinal("SoDienThoai")) ? string.Empty : reader.GetString(reader.GetOrdinal("SoDienThoai"));
                            string email =reader.IsDBNull( reader.GetOrdinal("Email")) ? string.Empty : reader.GetString( reader.GetOrdinal("Email"));
                            string maBoMon = reader.IsDBNull(reader.GetOrdinal("MaBoMon")) ? string.Empty : reader.GetString(reader.GetOrdinal("MaBoMon"));
                            string maGiaoVien = reader.IsDBNull(reader.GetOrdinal("MaGiaoVien")) ? string.Empty : reader.GetString(reader.GetOrdinal("MaGiaoVien"));
                            giaoViens.Add(new GiaoVien(hoTen, ngaySinh, gioiTinh, soDienThoai, email, maBoMon, maGiaoVien));
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
