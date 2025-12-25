using QL_phong_lab.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TablePhong(string query)
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
    }
}
