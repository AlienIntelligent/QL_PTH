using QL_phong_lab.BLL;
using QL_phong_lab.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_phong_lab.GUI.Userrr.NhanVien
{
    public partial class ChotLich : Form
    {
        public ChotLich()
        {
            InitializeComponent();
        }

        private void ChotLich_Load(object sender, EventArgs e)
        {
            try
            {
                BanDangKy.Load_DSChuaChot(dtv_chot, cbx_Giaovien.Text = null, cbx_MaBDK.Text = null, cbx_phong.Text = null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dtv_chot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_Giaovien.Text = dtv_chot.Rows[e.RowIndex].Cells["HoTen"].Value?.ToString();
            cbx_MaBDK.Text = dtv_chot.Rows[e.RowIndex].Cells["MaDangKy"].Value?.ToString();
            cbx_phong.Text = dtv_chot.Rows[e.RowIndex].Cells["TenPhong"].Value?.ToString();
            txt_hocky.Text = dtv_chot.Rows[e.RowIndex].Cells["HocKy"].Value?.ToString();
            txt_lop.Text = dtv_chot.Rows[e.RowIndex].Cells["TenLop"].Value?.ToString();
            txt_mon.Text = dtv_chot.Rows[e.RowIndex].Cells["TenMonHoc"].Value?.ToString();
            txt_nam.Text = dtv_chot.Rows[e.RowIndex].Cells["NamHoc"].Value?.ToString();
            txt_ngayBD.Text = dtv_chot.Rows[e.RowIndex].Cells["NgayBatDau"].Value?.ToString();
            txt_ngayKT.Text = dtv_chot.Rows[e.RowIndex].Cells["NgayKetThuc"].Value?.ToString();
            txt_thu.Text = dtv_chot.Rows[e.RowIndex].Cells["ThuTrongTuan"].Value?.ToString();
            txt_tietBD.Text = dtv_chot.Rows[e.RowIndex].Cells["TietBatDauMongMuon"].Value?.ToString();
            txt_tietKT.Text = dtv_chot.Rows[e.RowIndex].Cells["TietKetThucMongMuon"].Value?.ToString();
            txt_trangthai.Text = dtv_chot.Rows[e.RowIndex].Cells["TrangThai"].Value?.ToString();
        }

        private bool isCheckSuccessful = false;
        private bool hasConflicts = false;

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = cbx_phong.Text;
                DateTime ngayBatDau = DateTime.Parse(txt_ngayBD.Text);
                DateTime ngayKetThuc = DateTime.Parse(txt_ngayKT.Text);
                int tietBatDau = int.Parse(txt_tietBD.Text);
                int tietKetThuc = int.Parse(txt_tietKT.Text);
                int thuTrongTuan = int.Parse(txt_thu.Text);

                // Gọi Stored Procedure
                using (var connection = new SqlConnection(Connection.GetConnectionString()))
                {
                    connection.Open();
                    using (var command = new SqlCommand("sp_kiemtraphongtrong", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                        command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        command.Parameters.AddWithValue("@TietBatDau", tietBatDau);
                        command.Parameters.AddWithValue("@TietKetThuc", tietKetThuc);
                        command.Parameters.AddWithValue("@ThuTrongTuan", thuTrongTuan);

                        // Đọc kết quả trả về
                        using (var reader = command.ExecuteReader())
                        {
                            List<string> ngayPhongTrong = new List<string>();
                            List<string> ngayPhongCoLich = new List<string>();

                            while (reader.Read())
                            {
                                string ngay = reader["Ngay"].ToString();
                                string trangThai = reader["TrangThai"].ToString();

                                if (trangThai == "Phòng trống")
                                {
                                    ngayPhongTrong.Add(ngay);
                                }
                                else
                                {
                                    ngayPhongCoLich.Add(ngay);
                                }
                            }

                            // Hiển thị kết quả
                            if (ngayPhongCoLich.Count > 0)
                            {
                                hasConflicts = true;
                                isCheckSuccessful = false;
                                MessageBox.Show("Phòng đã có lịch vào các ngày: " + string.Join(", ", ngayPhongCoLich) + ". Vui lòng kiểm tra lại lịch.");
                                btn_phanhoi.Enabled = true;
                                btn_duyet.Enabled = false;
                            }
                            else if (ngayPhongTrong.Count > 0)
                            {
                                hasConflicts = false;
                                isCheckSuccessful = true;
                                MessageBox.Show("Phòng trống vào các ngày: " + string.Join(", ", ngayPhongTrong) + ".");
                                btn_duyet.Enabled = true;
                                btn_phanhoi.Enabled = false;
                            }
                            else
                            {
                                hasConflicts = false;
                                isCheckSuccessful = false;
                                MessageBox.Show("Không có dữ liệu trả về. Vui lòng kiểm tra lại thông tin đầu vào.");
                                btn_duyet.Enabled = false;
                                btn_phanhoi.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_duyet_Click(object sender, EventArgs e)
        {
            if (isCheckSuccessful && !hasConflicts)
            {
                try
                {
                    string maDangKy = cbx_MaBDK.Text;
                    string maPhong = cbx_phong.Text;
                    DateTime ngayBatDau = DateTime.Parse(txt_ngayBD.Text);
                    DateTime ngayKetThuc = DateTime.Parse(txt_ngayKT.Text);
                    int tietBatDau = int.Parse(txt_tietBD.Text);
                    int tietKetThuc = int.Parse(txt_tietKT.Text);
                    int thuTrongTuan = int.Parse(txt_thu.Text);

                    using (var connection = new SqlConnection(Connection.GetConnectionString()))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("sp_ThemLichSuDungPhong", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                            command.Parameters.AddWithValue("@MaPhong", maPhong);
                            command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                            command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                            command.Parameters.AddWithValue("@TietBatDau", tietBatDau);
                            command.Parameters.AddWithValue("@TietKetThuc", tietKetThuc);
                            command.Parameters.AddWithValue("@ThuTrongTuan", thuTrongTuan);
                            command.Parameters.AddWithValue("@TrangThai", 1);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã duyệt và thêm vào lịch sử sử dụng phòng.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại lịch trước khi duyệt.");
            }
        }

        private void btn_phanhoi_Click(object sender, EventArgs e)
        {
            if (hasConflicts)
            {
                MessageBox.Show("Đã gửi phản hồi.");
                btn_boqua.Enabled = true;
            }
            else
            {
                MessageBox.Show("Đã thông báo chốt lịch cho Giáo viên");
            }
        }
    }
}
