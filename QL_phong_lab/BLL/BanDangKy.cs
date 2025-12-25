using QL_phong_lab.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_phong_lab.BLL
{
    public class BanDangKy
    {
        public string MaBanDK { get; set; }
        public string NamHoc { get; set; }
        public string HocKy { get; set; }
        public string MaGiaoVien { get; set; }
        public string MaPhong { get; set; }
        public string MaLop { get; set; }
        public string MaMonHoc { get; set; }
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int ThuTrongTuan { get; set; }
        public bool TrangThai { get; set; }

        public BanDangKy(string maBanDK, string namHoc, string hocKy, string maGiaoVien, string maPhong, string maLop, string maMonHoc, int tietBatDau, int tietKetThuc, DateTime ngayBatDau, DateTime ngayKetThuc, int thuTrongTuan, bool trangThai)
        {
            MaBanDK = maBanDK;
            NamHoc = namHoc;
            HocKy = hocKy;
            MaGiaoVien = maGiaoVien;
            MaPhong = maPhong;
            MaLop = maLop;
            MaMonHoc = maMonHoc;
            TietBatDau = tietBatDau;
            TietKetThuc = tietKetThuc;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            ThuTrongTuan = thuTrongTuan;
            TrangThai = trangThai;
        }
        public BanDangKy() { }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableBanDangKy(string query)
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

        public static void Load_BanDKGV(DataGridView view, string tieuchi)
        {
            string procName = "sp_XemBanDangKyGV";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                try
                {
                    DataProvider.OpenConnection();
                    using (var command = new SqlCommand(procName, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaHoacTen", tieuchi);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    view.DataSource = dt;
                    view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DataProvider.CloseConnection();
                }
            }
        }

        public static void Load_DSChuaChot(DataGridView view, string tieuchi, string maBDK, string phong)
        {
            string procName = "sp_DSChuaChot";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                try
                {
                    DataProvider.OpenConnection();
                    using (var command = new SqlCommand(procName, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaHoacTen", tieuchi);
                        command.Parameters.AddWithValue("@MaBDK", maBDK);
                        command.Parameters.AddWithValue("@Phong", phong);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    view.DataSource = dt;
                    view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DataProvider.CloseConnection();
                }
            }
        }
        public static void Load_DSChoduyet(DataGridView view,string tieuchi, string maBDK, string phong)
        {
            string procName = "sp_XemDSchoduyet";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                try
                {
                    DataProvider.OpenConnection();
                    using (var command = new SqlCommand(procName, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaHoacTen", tieuchi);
                        command.Parameters.AddWithValue("@MaBDK", maBDK);
                        command.Parameters.AddWithValue("@Phong", phong);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    view.DataSource = dt;
                    view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DataProvider.CloseConnection();
                }
            }
        }
    }
}
