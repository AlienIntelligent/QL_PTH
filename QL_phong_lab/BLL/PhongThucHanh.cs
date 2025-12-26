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
    public class PhongThucHanh
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SucChua { get; set; }
        public string ViTri { get; set; }
        public bool TrangThai { get; set; }
        public PhongThucHanh(string maPhong, string tenPhong, int sucChua, string viTri, bool trangThai)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            SucChua = sucChua;
            ViTri = viTri;
            TrangThai = trangThai;
        }
        public PhongThucHanh() { }

        public DataTable TablePhong(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
            {
                dataAdapter.Fill(dt);
            }
            return dt;
        }

        public void Command(string query)
        {
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            using (SqlCommand sqlCommand = new SqlCommand(query, conn))
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public static void Load_CBX_phong(ComboBox cbx)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT MaPhong FROM PhongThucHanh", conn))
                {
                    conn.Open();
                    cbx.Items.Clear();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbx.Items.Add(reader["MaPhong"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
