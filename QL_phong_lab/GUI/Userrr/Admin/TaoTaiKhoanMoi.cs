using QL_phong_lab.BLL;
using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QL_phong_lab
{
    public partial class TaoTaiKhoanMoi : Form
    {
        public TaoTaiKhoanMoi()
        {
            InitializeComponent();
        }

        private void gr_timkiem_Enter(object sender, EventArgs e)
        {
            // Để trống nếu không cần
        }

        private void TaoTaiKhoanMoi_Load(object sender, EventArgs e)
        {
            try
            {
                LoadBangTaiKhoan();
                LoadComboGiaoVien();
                LoadComboNhanVien();
                dtv_Taikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtv_Taikhoan.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                dtv_Taikhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dtv_Taikhoan.AllowUserToAddRows = true;

                // Gắn event chặn sửa mã tài khoản
                cbx_maTaikhoan.KeyPress += cbx_maTaikhoan_KeyPress;
                cbx_maTaikhoan.MouseDown += cbx_maTaikhoan_MouseDown;

                // ===> PHẦN TỰ ĐỘNG ĐIỀN KHI MỞ TỪ FORM GIÁO VIÊN HOẶC NHÂN VIÊN <===
                if (this.Tag is ThongTinTaoTaiKhoan info)
                {
                    // TỰ ĐỘNG HIỂN THỊ MÃ TÀI KHOẢN DỰ KIẾN
                    if (!string.IsNullOrEmpty(info.MaGiaoVien))
                    {
                        cbx_maTaikhoan.Text = "TK" + info.MaGiaoVien.Trim();
                    }
                    else if (!string.IsNullOrEmpty(info.MaNhanVien))
                    {
                        cbx_maTaikhoan.Text = "TK" + info.MaNhanVien.Trim();
                    }
                    else
                    {
                        cbx_maTaikhoan.Text = "Mới";
                    }

                    // Gợi ý tên đăng nhập
                    txt_tenDangNhap.Text = info.TenDangNhapGoiY ?? "";

                    // Xử lý giáo viên
                    if (!string.IsNullOrEmpty(info.MaGiaoVien))
                    {
                        cbx_tenGiaovien.SelectedValue = info.MaGiaoVien;
                        cbx_vaiTro.Text = info.VaiTro ?? "GiaoVien";
                        MessageBox.Show(
                            $"Đang tạo tài khoản mới cho giáo viên:\n\nHọ tên: {info.HoTenGiaoVien}\nMã: {info.MaGiaoVien}\nTên đăng nhập gợi ý: {info.TenDangNhapGoiY}",
                            "Tạo tài khoản giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Xử lý nhân viên
                    else if (!string.IsNullOrEmpty(info.MaNhanVien))
                    {
                        cbx_tenNhanvien.SelectedValue = info.MaNhanVien;
                        cbx_vaiTro.Text = info.VaiTro ?? "NhanVien";
                        MessageBox.Show(
                            $"Đang tạo tài khoản mới cho nhân viên:\n\nHọ tên: {info.HoTenNhanVien}\nMã: {info.MaNhanVien}\nTên đăng nhập gợi ý: {info.TenDangNhapGoiY}",
                            "Tạo tài khoản nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Trạng thái mặc định khi tạo mới
                    txt_trangThai.Text = "True";
                    txt_trangThai.ForeColor = Color.Green;
                    txt_trangThai.ReadOnly = true;

                    // Xóa Tag để tránh chạy lại
                    this.Tag = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chặn gõ phím vào ô mã tài khoản
        private void cbx_maTaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Chặn mọi phím
            MessageBox.Show("Không thể sửa mã tài khoản!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_tenDangNhap.Focus(); // Chuyển focus sang tên đăng nhập
        }

        // Chặn click chuột vào ô mã tài khoản
        private void cbx_maTaikhoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Không thể sửa mã tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenDangNhap.Focus();
            }
        }

        private void LoadBangTaiKhoan()
        {
            string query = @"
        SELECT tk.MaTaiKhoan, tk.TenDangNhap, tk.VaiTro, tk.NgayTao, tk.TrangThai,
               nv.HoTen AS TenNhanVien, gv.HoTen AS TenGiaoVien
        FROM TaiKhoan tk
        LEFT JOIN NhanVien nv ON tk.MaNhanVien = nv.MaNhanVien
        LEFT JOIN GiaoVien gv ON tk.MaGiaoVien = gv.MaGiaoVien
        ORDER BY tk.NgayTao ASC";

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }

                dtv_Taikhoan.DataSource = null;
                dtv_Taikhoan.DataSource = dt;

                dtv_Taikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtv_Taikhoan.AllowUserToAddRows = true;

                dtv_Taikhoan.Update();
                dtv_Taikhoan.Refresh();

                if (dtv_Taikhoan.Rows.Count > 0)
                {
                    dtv_Taikhoan.FirstDisplayedScrollingRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message +
                                "\n\nQuery đang chạy:\n" + query, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboGiaoVien()
        {
            string query = "SELECT MaGiaoVien, HoTen FROM GiaoVien ORDER BY HoTen";
            DataTable dt = new LoginInfo().TableTaiKhoan(query);
            cbx_tenGiaovien.DataSource = dt;
            cbx_tenGiaovien.DisplayMember = "HoTen";
            cbx_tenGiaovien.ValueMember = "MaGiaoVien";
            cbx_tenGiaovien.SelectedIndex = -1;
        }

        private void LoadComboNhanVien()
        {
            string query = "SELECT MaNhanVien, HoTen FROM NhanVien ORDER BY HoTen";
            DataTable dt = new LoginInfo().TableTaiKhoan(query);
            cbx_tenNhanvien.DataSource = dt;
            cbx_tenNhanvien.DisplayMember = "HoTen";
            cbx_tenNhanvien.ValueMember = "MaNhanVien";
            cbx_tenNhanvien.SelectedIndex = -1;
        }

        private void UpdateMaTaiKhoan()
        {
            if (!string.IsNullOrEmpty(cbx_maTaikhoan.Text) && cbx_maTaikhoan.Text != "Mới")
            {
                return;
            }

            if (cbx_tenGiaovien.SelectedValue != null && !string.IsNullOrEmpty(cbx_tenGiaovien.SelectedValue.ToString()))
            {
                string maGV = cbx_tenGiaovien.SelectedValue.ToString().Trim();
                cbx_maTaikhoan.Text = "TK" + maGV;
            }
            else if (cbx_tenNhanvien.SelectedValue != null && !string.IsNullOrEmpty(cbx_tenNhanvien.SelectedValue.ToString()))
            {
                string maNV = cbx_tenNhanvien.SelectedValue.ToString().Trim();
                cbx_maTaikhoan.Text = "TK" + maNV;
            }
            else
            {
                cbx_maTaikhoan.Text = "Mới";
            }
        }

        private void cbx_tenGiaovien_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaTaiKhoan();
        }

        private void cbx_tenNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaTaiKhoan();
        }

        private void dtv_Taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtv_Taikhoan.Rows.Count) return;

            DataGridViewRow row = dtv_Taikhoan.Rows[e.RowIndex];

            cbx_maTaikhoan.Text = row.Cells["MaTaiKhoan"].Value?.ToString() ?? "";

            txt_tenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? "";
            txt_matKhau.Text = "";
            cbx_vaiTro.Text = row.Cells["VaiTro"].Value?.ToString() ?? "";

            object tt = row.Cells["TrangThai"].Value;
            if (tt != null && tt != DBNull.Value)
            {
                bool bitValue = (bool)tt;
                txt_trangThai.Text = bitValue.ToString();
                txt_trangThai.ForeColor = bitValue ? Color.Green : Color.Red;
            }
            else
            {
                txt_trangThai.Text = "True";
                txt_trangThai.ForeColor = Color.Green;
            }
            txt_trangThai.ReadOnly = true;

            string maTaiKhoan = row.Cells["MaTaiKhoan"].Value?.ToString() ?? "";
            if (maTaiKhoan.StartsWith("TK") && maTaiKhoan.Length > 2)
            {
                string ma = maTaiKhoan.Substring(2);
                cbx_tenGiaovien.SelectedValue = ma;
                cbx_tenNhanvien.SelectedValue = ma;
            }
            else
            {
                cbx_tenGiaovien.SelectedIndex = -1;
                cbx_tenNhanvien.SelectedIndex = -1;
            }

            UpdateMaTaiKhoan();

            cbx_vaiTro.Enabled = false;
            cbx_tenGiaovien.Enabled = false;
            cbx_tenNhanvien.Enabled = false;

            object trangThaiObj = row.Cells["TrangThai"].Value;
            if (trangThaiObj != null && trangThaiObj != DBNull.Value)
            {
                bool bitValue = (bool)trangThaiObj;
                CapNhatNutBanAcc(bitValue);
            }
            else
            {
                CapNhatNutBanAcc(true);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tenDangNhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên đăng nhập!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_matKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mật khẩu!");
                    return;
                }
                // Kiểm tra trùng tên đăng nhập
                string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDN";
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDN", txt_tenDangNhap.Text.Trim());
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại!");
                            return;
                        }
                    }
                }
                string maGV = cbx_tenGiaovien.SelectedValue?.ToString();
                string maNV = cbx_tenNhanvien.SelectedValue?.ToString();
                TaiKhoan tk = new TaiKhoan();
                bool ketQua = tk.ThemTaiKhoan(
                    txt_tenDangNhap.Text.Trim(),
                    txt_matKhau.Text,
                    cbx_vaiTro.Text,
                    maNV,
                    maGV
                );
                if (ketQua)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBangTaiKhoan();
                    LamMoiForm();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tenDangNhap.Text))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lấy tên đăng nhập cũ từ grid (để kiểm tra trùng và WHERE)
                string oldTenDN = dtv_Taikhoan.CurrentRow?.Cells["TenDangNhap"].Value?.ToString();
                // Kiểm tra tên đăng nhập mới có trùng không (trừ chính nó)
                if (txt_tenDangNhap.Text.Trim() != oldTenDN)
                {
                    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @NewTenDN";
                    using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@NewTenDN", txt_tenDangNhap.Text.Trim());
                            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                            {
                                MessageBox.Show("Tên đăng nhập mới đã tồn tại!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
                // CHỈ CẬP NHẬT Tên đăng nhập và Mật khẩu (nếu có)
                string query = @"UPDATE TaiKhoan
                                 SET TenDangNhap = @NewTenDN"
                               + (string.IsNullOrWhiteSpace(txt_matKhau.Text) ? "" : ", MatKhau = @MatKhau")
                               + " WHERE TenDangNhap = @OldTenDN";
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewTenDN", txt_tenDangNhap.Text.Trim());
                        cmd.Parameters.AddWithValue("@OldTenDN", oldTenDN);
                        if (!string.IsNullOrWhiteSpace(txt_matKhau.Text))
                        {
                            cmd.Parameters.AddWithValue("@MatKhau", txt_matKhau.Text);
                        }
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa tài khoản thành công!\n(Chỉ tên đăng nhập và mật khẩu được cập nhật)", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBangTaiKhoan();
                            LamMoiForm();
                        }
                        else
                        {
                            MessageBox.Show("Không có thay đổi nào được thực hiện.", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa tài khoản: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tenDangNhap.Text))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TaiKhoan tk = new TaiKhoan();
                    if (tk.XoaTaiKhoan(txt_tenDangNhap.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadBangTaiKhoan();
                        LamMoiForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_BanAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtv_Taikhoan.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần khóa/mở!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tenDN = dtv_Taikhoan.CurrentRow.Cells["TenDangNhap"].Value?.ToString();
                if (string.IsNullOrWhiteSpace(tenDN))
                {
                    MessageBox.Show("Không xác định được tên đăng nhập!", "Lỗi");
                    return;
                }
                bool trangThaiHienTai = (bool)dtv_Taikhoan.CurrentRow.Cells["TrangThai"].Value;
                bool trangThaiMoi = !trangThaiHienTai;
                string hanhDong = trangThaiMoi ? "mở khóa (kích hoạt lại)" : "khóa (cấm đăng nhập)";
                if (MessageBox.Show($"Bạn có chắc muốn {hanhDong} tài khoản \"{tenDN}\" không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                string query = "UPDATE TaiKhoan SET TrangThai = @TrangThai WHERE TenDangNhap = @TenDN";
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                        cmd.Parameters.AddWithValue("@TenDN", tenDN);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show($"Đã {hanhDong} tài khoản \"{tenDN}\" thành công!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBangTaiKhoan();
                            txt_trangThai.Text = trangThaiMoi.ToString();
                            txt_trangThai.ForeColor = trangThaiMoi ? Color.Green : Color.Red;
                            CapNhatNutBanAcc(trangThaiMoi);
                        }
                        else
                        {
                            MessageBox.Show("Thao tác thất bại!", "Lỗi");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void CapNhatNutBanAcc(bool trangThaiHienTai)
        {
            if (trangThaiHienTai)
            {
                btn_BanAcc.Text = "Khóa TK";
                btn_BanAcc.BackColor = Color.Orange;
            }
            else
            {
                btn_BanAcc.Text = "Mở TK";
                btn_BanAcc.BackColor = Color.MediumSeaGreen;
            }
        }

        private void LamMoiForm()
        {
            txt_tenDangNhap.Clear();
            txt_matKhau.Clear();
            cbx_vaiTro.SelectedIndex = -1;
            cbx_tenGiaovien.SelectedIndex = -1;
            cbx_tenNhanvien.SelectedIndex = -1;
            cbx_maTaikhoan.Text = "Mới";
            txt_trangThai.Text = "True";
            txt_trangThai.ForeColor = Color.Green;
            txt_trangThai.ReadOnly = true;

            cbx_vaiTro.Enabled = true;
            cbx_tenGiaovien.Enabled = true;
            cbx_tenNhanvien.Enabled = true;
        }
    }
}