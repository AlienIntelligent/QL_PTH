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
    public class SuCo
    {
        public string MaSuCo { get; set; }
        public string MaLichPhong { get; set; }
        public string MoTa { get; set; }
        public int MaCaTruc { get; set; }
        public DateTime ThoiGianGhiNhan { get; set; }
        public DateTime NgayBaoCao { get; set; }
        public string KetQuaXuLy { get; set; }

        public SuCo(string maSuCo, string maLichPhong, string moTa, int maCaTruc, DateTime thoiGianGhiNhan, DateTime ngayBaoCao, string ketQuaXuLy)
        {
            MaSuCo = maSuCo;
            MaLichPhong = maLichPhong;
            MoTa = moTa;
            MaCaTruc = maCaTruc;
            ThoiGianGhiNhan = thoiGianGhiNhan;
            NgayBaoCao = ngayBaoCao;
            KetQuaXuLy = ketQuaXuLy;
        }
        public SuCo() { }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable TableSuCo(string query)
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
