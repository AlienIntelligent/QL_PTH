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

namespace QL_phong_lab.GUI.Userrr.GiaoVien
{
    public partial class DatLich : Form
    {
        BanDangKy BanDangKy = new BanDangKy();
        public DatLich()
        {
            InitializeComponent();
        }

        private void DatLich_Load(object sender, EventArgs e)
        {
            try
            {
                LopHoc.Load_CBX_lophoc(cbo_lop);
                MonHoc.Load_CBX_monhoc(cbo_mon);
                PhongThucHanh.Load_CBX_phong(cbo_phong);
                BanDangKy.Load_BanDKGV(dtv_Bandangky, DangNhap.maGV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dtv_Bandangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem hàng được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_Bandangky.Rows[e.RowIndex];

                // Gán giá trị từ các cột của hàng vào các điều khiển tương ứng
                cbo_maDK.Text = row.Cells["MaDangKy"].Value?.ToString();
                cbo_phong.Text = row.Cells["TenPhong"].Value?.ToString();
                txt_hocky.Text = row.Cells["HocKy"].Value?.ToString();
                txt_namhoc.Text = row.Cells["NamHoc"].Value?.ToString();
                cbo_lop.Text = row.Cells["TenLop"].Value?.ToString();
                cbo_mon.Text = row.Cells["TenMonHoc"].Value?.ToString();
                txt_thu.Text = row.Cells["ThuTrongTuan"].Value?.ToString();
                dtp_ngaydau.Value = DateTime.TryParse(row.Cells["NgayBatDau"].Value?.ToString(), out DateTime ngaybatdau) ? ngaybatdau : DateTime.Now;
                dtp_ngaysau.Value = DateTime.TryParse(row.Cells["NgayKetThuc"].Value?.ToString(), out DateTime ngayketthuc) ? ngayketthuc : DateTime.Now;
                txt_tietdau.Text = row.Cells["TietBatDauMongMuon"].Value?.ToString();
                txt_tietsau.Text = row.Cells["TietKetThucMongMuon"].Value?.ToString();
                txt_trangthai.Text = row.Cells["Chot"].Value?.ToString();
            }
        }

        private void DeleteTextBoxes()
        {
            cbo_maDK.Text = "";
            cbo_phong.Text = "";
            txt_hocky.Text = "";
            txt_namhoc.Text = "";
            cbo_lop.Text = "";
            cbo_mon.Text = "";
            txt_thu.Text = "";
            dtp_ngaydau.Value = DateTime.Now;
            dtp_ngaysau.Value = DateTime.Now;
            txt_tietdau.Text = "";
            txt_tietsau.Text = "";
            txt_trangthai.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (string.IsNullOrWhiteSpace(cbo_maDK.Text) ||
                string.IsNullOrWhiteSpace(cbo_phong.Text) ||
                string.IsNullOrWhiteSpace(txt_hocky.Text) ||
                string.IsNullOrWhiteSpace(txt_namhoc.Text) ||
                string.IsNullOrWhiteSpace(cbo_lop.Text) ||
                string.IsNullOrWhiteSpace(cbo_mon.Text) ||
                string.IsNullOrWhiteSpace(txt_thu.Text) ||
                string.IsNullOrWhiteSpace(txt_tietdau.Text) ||
                string.IsNullOrWhiteSpace(txt_tietsau.Text))
            {
                return false; // Có ít nhất một TextBox trống
            }
            return true; // Tất cả TextBox đều có dữ liệu
        }

        private void GetValueTextBoxs()
        {
            string maBanDK = cbo_maDK.Text;
            string maPhong = cbo_phong.Text;
            string hocKy = txt_hocky.Text;
            string namHoc = txt_namhoc.Text;
            string maLop = cbo_lop.Text;
            string maMonHoc = cbo_mon.Text;
            int thuTrongTuan = int.Parse(txt_thu.Text);
            DateTime ngayBatDau = dtp_ngaydau.Value;
            DateTime ngayKetThuc = dtp_ngaysau.Value;
            int tietBatDau = int.Parse(txt_tietdau.Text);
            int tietKetThuc = int.Parse(txt_tietsau.Text);
            BanDangKy = new BanDangKy(maBanDK, namHoc, hocKy, DangNhap.maGV, maPhong, maLop, maMonHoc, tietBatDau, tietKetThuc, ngayBatDau, ngayKetThuc, thuTrongTuan, false);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi đặt lịch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy giá trị từ các TextBox
                string maDangKy = cbo_maDK.Text;
                string maPhong = cbo_phong.Text;
                string hocKy = txt_hocky.Text;
                string namHoc = txt_namhoc.Text;
                string maLop = cbo_lop.Text;
                string maMonHoc = cbo_mon.Text;
                int thuTrongTuan = int.Parse(txt_thu.Text);
                DateTime ngayBatDau = dtp_ngaydau.Value;
                DateTime ngayKetThuc = dtp_ngaysau.Value;
                int tietBatDau = int.Parse(txt_tietdau.Text);
                int tietKetThuc = int.Parse(txt_tietsau.Text);

                // Gọi stored procedure để thêm bản ghi
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("sp_GiaoVien_ThemDangKy", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                        command.Parameters.AddWithValue("@NamHoc", namHoc);
                        command.Parameters.AddWithValue("@HocKy", hocKy);
                        command.Parameters.AddWithValue("@MaGiaoVien", DangNhap.maGV);
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@MaLop", maLop);
                        command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                        command.Parameters.AddWithValue("@ThuTrongTuan", thuTrongTuan);
                        command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                        command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        command.Parameters.AddWithValue("@TietBatDau", tietBatDau);
                        command.Parameters.AddWithValue("@TietKetThuc", tietKetThuc);
                        command.Parameters.AddWithValue("@TrangThai", false);

                        // Thêm tham số đầu ra
                        SqlParameter tongSoBuoiParam = new SqlParameter("@TongSoBuoi", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(tongSoBuoiParam);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Đặt lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đăng ký
                BanDangKy.Load_BanDKGV(dtv_Bandangky, DangNhap.maGV);

                // Xóa thông tin trong các TextBox
                DeleteTextBoxes();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Lỗi khi đặt lịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_maDK.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã chốt hay chưa
            if (!string.IsNullOrWhiteSpace(txt_trangthai.Text) && txt_trangthai.Text.ToLower() == "true")
            {
                MessageBox.Show("Không thể sửa đăng ký đã chốt. Vui lòng liên hệ quản lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu đầu vào
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy giá trị từ các TextBox
                string maDangKy = cbo_maDK.Text;
                string maPhong = cbo_phong.Text;
                string hocKy = txt_hocky.Text;
                string namHoc = txt_namhoc.Text;
                string maLop = cbo_lop.Text;
                string maMonHoc = cbo_mon.Text;
                int thuTrongTuan = int.Parse(txt_thu.Text);
                DateTime ngayBatDau = dtp_ngaydau.Value;
                DateTime ngayKetThuc = dtp_ngaysau.Value;
                int tietBatDau = int.Parse(txt_tietdau.Text);
                int tietKetThuc = int.Parse(txt_tietsau.Text);

                // Gọi stored procedure để sửa bản ghi
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("sp_GiaoVien_SuaDangKy", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                        command.Parameters.AddWithValue("@NamHoc", namHoc);
                        command.Parameters.AddWithValue("@HocKy", hocKy);
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@MaLop", maLop);
                        command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                        command.Parameters.AddWithValue("@ThuTrongTuan", thuTrongTuan);
                        command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                        command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        command.Parameters.AddWithValue("@TietBatDau", tietBatDau);
                        command.Parameters.AddWithValue("@TietKetThuc", tietKetThuc);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Sửa đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đăng ký và xóa thông tin trong các TextBox
                BanDangKy.Load_BanDKGV(dtv_Bandangky, DangNhap.maGV);
                DeleteTextBoxes();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Lỗi khi sửa đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_maDK.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã duyệt hay chưa
            if (!string.IsNullOrWhiteSpace(txt_trangthai.Text) && txt_trangthai.Text.ToLower() == "true")
            {
                MessageBox.Show("Không thể hủy đăng ký đã duyệt. Vui lòng liên hệ quản lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng ký này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Lấy mã đăng ký từ ComboBox
                    string maDangKy = cbo_maDK.Text;
                    string maGV = DangNhap.maGV;

                    // Gọi stored procedure để hủy đăng ký
                    using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand("sp_GiaoVien_HuyDangKy", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số
                            command.Parameters.AddWithValue("@MaDangKy", maDangKy);
                            command.Parameters.AddWithValue("@MaGiaoVien", maGV);

                            // Thực thi stored procedure
                            command.ExecuteNonQuery();
                        }
                    }

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Hủy đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại danh sách đăng ký và xóa thông tin trong các TextBox
                    BanDangKy.Load_BanDKGV(dtv_Bandangky, DangNhap.maGV);
                    DeleteTextBoxes();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                    MessageBox.Show("Lỗi khi hủy đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
