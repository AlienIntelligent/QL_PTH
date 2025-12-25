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
    public class CaTrucNV
    {
        public int MaCaTruc { get; set; }
        public string MaNV { get; set; }
        public string CaTruc { get; set; }

        public DateTime ngaytruc { get; set; }

        public CaTrucNV(int maCaTruc, string maNV, string caTruc, DateTime ngaytruc)
        {
            MaCaTruc = maCaTruc;
            MaNV = maNV;
            CaTruc = caTruc;
            this.ngaytruc = ngaytruc;
        }

        public CaTrucNV()
        {
        }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableCaTruc(string query)
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
