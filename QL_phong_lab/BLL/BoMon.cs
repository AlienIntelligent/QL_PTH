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
    public class BoMon
    {
        public string MaBoMon { get; set; }
        public string TenBoMon { get; set; }
        public string ChuyenMon { get; set; }

        public BoMon(string maBoMon, string tenBoMon, string chuyenMon)
        {
            MaBoMon = maBoMon;
            TenBoMon = tenBoMon;
            ChuyenMon = chuyenMon;
        }
        public BoMon()
        {
        }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableBoMon(string query)
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
