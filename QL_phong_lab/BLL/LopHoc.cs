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
    public class LopHoc
    {
        private string MaLop { get; set; }
        private string TenLop { get; set; }
        private string LopTruong { get; set; }
        private string SoDienThoai { get; set; }
        private int QuanSo { get; set; }

        public LopHoc(string maLop, string tenLop, string lopTruong, string soDienThoai, int quanSo)
        {
            MaLop = maLop;
            TenLop = tenLop;
            LopTruong = lopTruong;
            SoDienThoai = soDienThoai;
            QuanSo = quanSo;
        }
        public LopHoc() { }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableLopHoc(string query)
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

        public static void Load_CBX_lophoc(ComboBox cbx)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT MaLop FROM LopHoc", conn))
                {
                    conn.Open();
                    cbx.Items.Clear();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbx.Items.Add(reader["MaLop"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading class data: " + ex.Message);
            }
        }

    }
}
