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
    public class ThietBiPhong
    {
        public string MaThietBi { get; set; }
        public string MaThietBiPhong { get; set; }
        public string MaPhong { get; set; }
        public int SL_Cap1 { get; set; }
        public int SL_Cap2 { get; set; }
        public int SL_Cap3 { get; set; }
        public int SL_Cap4 { get; set; }
        public int SL_Cap5 { get; set; }
        public int SL_Hong { get; set; }
        public ThietBiPhong(string maThietBi, string maThietBiPhong, string maPhong, int sL_Cap1, int sL_Cap2, int sL_Cap3, int sL_Cap4, int sL_Cap5, int sL_Hong)
        {
            MaThietBi = maThietBi;
            MaThietBiPhong = maThietBiPhong;
            MaPhong = maPhong;
            SL_Cap1 = sL_Cap1;
            SL_Cap2 = sL_Cap2;
            SL_Cap3 = sL_Cap3;
            SL_Cap4 = sL_Cap4;
            SL_Cap5 = sL_Cap5;
            SL_Hong = sL_Hong;
        }
        public ThietBiPhong() { }


        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableThietBiPhong(string query)
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
