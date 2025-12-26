using QL_phong_lab.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_phong_lab.BLL
{
    public class LichPhongThucHanh
    {
        public string MaLichPhong { get; set; }
        public string MaBanDK { get; set; }
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int ThuTrongTuan { get; set; }
        public bool TrangThai { get; set; }
        public bool SuCoThietBi { get; set; }
        public LichPhongThucHanh(string maLichPhong, string maBanDK, int tietBatDau, int tietKetThuc, DateTime ngayBatDau, DateTime ngayKetThuc, int thuTrongTuan, bool trangThai, bool suCoThietBi)
        {
            MaLichPhong = maLichPhong;
            MaBanDK = maBanDK;
            TietBatDau = tietBatDau;
            TietKetThuc = tietKetThuc;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            ThuTrongTuan = thuTrongTuan;
            TrangThai = trangThai;
            SuCoThietBi = suCoThietBi;
        }
        public LichPhongThucHanh() { }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableLichPTH(string query)
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

        public static void Load_LichTrongNgay(DataGridView view, DateTime tieuchi)
        {
            string procName = "sp_LayLichTrongNgay";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                try
                {
                    DataProvider.OpenConnection();
                    using (var command = new SqlCommand(procName, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Ngay", tieuchi);
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
        public static void Load_XemLichPhong(DataGridView view, DateTime? ngay, string maPhong, string ma_ten)
        {
            string procName = "sp_XemLichPhong";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                try
                {
                    DataProvider.OpenConnection();
                    using (var command = new SqlCommand(procName, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@Ngay", ngay);
                        command.Parameters.AddWithValue("@MaHoacTenGV", ma_ten);
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
