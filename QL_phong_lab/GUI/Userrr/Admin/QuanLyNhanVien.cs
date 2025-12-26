using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QL_phong_lab
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataGrid();

                dtv_danhsachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtv_danhsachNV.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                dtv_danhsachNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dtv_danhsachNV.AllowUserToAddRows = true;

                // Chặn sửa mã nhân viên
                cbx_maNhanvien.KeyPress += cbx_maNhanvien_KeyPress;
                cbx_maNhanvien.MouseDown += cbx_maNhanvien_MouseDown;

                // Tự động sinh mã mới khi mở form (chế độ thêm mới)
                SinhMaNhanVienMoi();
                LoadComboBoxTimKiem(); // Tải dữ liệu cho combobox tìm kiếm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chặn gõ phím vào ô mã nhân viên
        private void cbx_maNhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Không thể sửa mã nhân viên!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Chặn click chuột trái vào ô mã nhân viên
        private void cbx_maNhanvien_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Không thể sửa mã nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Tải dữ liệu lên grid
        private void LoadDataGrid()
        {
            string query = "SELECT * FROM NhanVien ORDER BY MaNhanVien";
            DataTable dt = new NhanVien().TableNV(query);
            dtv_danhsachNV.DataSource = dt;
            dtv_danhsachNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtv_danhsachNV.AllowUserToAddRows = true;
        }

        // Hàm lấy giá trị cell an toàn
        private string SafeCellString(DataGridViewRow row, string columnName)
        {
            if (row == null || !dtv_danhsachNV.Columns.Contains(columnName)) return string.Empty;
            var cell = row.Cells[columnName];
            if (cell.Value == null || cell.Value == DBNull.Value) return string.Empty;
            return cell.Value.ToString().Trim();
        }

        // Parse ngày an toàn
        private DateTime SafeParseDate(string s, DateTime fallback)
        {
            if (DateTime.TryParse(s, out DateTime result))
            {
                if (result < dtp_ngaysinh.MinDate) return dtp_ngaysinh.MinDate;
                if (result > dtp_ngaysinh.MaxDate) return dtp_ngaysinh.MaxDate;
                return result;
            }
            return fallback;
        }

        private void LoadComboBoxTimKiem()
        {
            string query = "SELECT MaNhanVien, HoTen FROM NhanVien ORDER BY HoTen";
            DataTable dt = new NhanVien().TableNV(query);

            // ComboBox theo Mã nhân viên
            cbx_maNhanvien.DataSource = dt.Copy();
            cbx_maNhanvien.DisplayMember = "MaNhanVien";
            cbx_maNhanvien.ValueMember = "MaNhanVien";
            cbx_maNhanvien.SelectedIndex = -1;

            // ComboBox theo Họ tên nhân viên
            cbx_tenNhanvien.DataSource = dt.Copy();
            cbx_tenNhanvien.DisplayMember = "HoTen";
            cbx_tenNhanvien.ValueMember = "MaNhanVien";
            cbx_tenNhanvien.SelectedIndex = -1;
        }

        // Click vào dòng trên grid
        private void dtv_danhsachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Nếu click vào hàng trống cuối cùng → chuyển sang chế độ thêm mới
                if (e.RowIndex == dtv_danhsachNV.Rows.Count - 1 || e.RowIndex < 0)
                {
                    ClearInputs();
                    SinhMaNhanVienMoi();
                    return;
                }

                var row = dtv_danhsachNV.Rows[e.RowIndex];

                string maNV = SafeCellString(row, "MaNhanVien");
                string hoTenNV = SafeCellString(row, "HoTen");

                cbx_maNhanvien.Text = maNV;
                cbx_tenNhanvien.Text = hoTenNV;

                // Nếu không tìm thấy (hiếm), gán Text thủ công
                if (cbx_maNhanvien.SelectedIndex == -1) cbx_maNhanvien.Text = maNV;
                if (cbx_tenNhanvien.SelectedIndex == -1) cbx_tenNhanvien.Text = hoTenNV;

                // Cập nhật các trường khác
                dtp_ngaysinh.Value = SafeParseDate(SafeCellString(row, "NgaySinh"), DateTime.Today);
                cbx_gioitinh.Text = SafeCellString(row, "GioiTinh");
                txt_sdt.Text = SafeCellString(row, "SoDienThoai");
                txt_email.Text = SafeCellString(row, "Email");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm sinh mã nhân viên tự tăng: NV001, NV002,...
        private void SinhMaNhanVienMoi()
        {
            try
            {
                string query = "SELECT MAX(MaNhanVien) FROM NhanVien WHERE MaNhanVien LIKE 'NV%'";
                DataTable dt = new NhanVien().TableNV(query);

                string maxMa = dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value
                              ? dt.Rows[0][0].ToString()
                              : null;

                int soThuTu = 0;

                if (!string.IsNullOrEmpty(maxMa) && maxMa.StartsWith("NV"))
                {
                    if (int.TryParse(maxMa.Substring(2), out int num))
                    {
                        soThuTu = num;
                    }
                }

                soThuTu++;
                cbx_maNhanvien.Text = "NV" + soThuTu.ToString("D3"); // 001, 002, ...
            }
            catch
            {
                cbx_maNhanvien.Text = "NV001"; // Dự phòng
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_tenNhanvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập Họ tên nhân viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbx_tenNhanvien.Focus();
                    return;
                }

                // Kiểm tra trùng mã (an toàn dù đã tự sinh)
                string maNV = cbx_maNhanvien.Text.Trim();
                DataTable check = new NhanVien().TableNV(
                    $"SELECT MaNhanVien FROM NhanVien WHERE MaNhanVien = '{maNV}'");

                if (check.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại! Đang sinh mã mới...", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SinhMaNhanVienMoi();
                    return;
                }

                bool ketQua = new NhanVien().ThemNhanVien(
                    maNV,
                    cbx_tenNhanvien.Text.Trim(),
                    dtp_ngaysinh.Value,
                    cbx_gioitinh.Text.Trim(),
                    txt_sdt.Text.Trim(),
                    txt_email.Text.Trim()
                );

                if (ketQua)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    ClearInputs();
                    SinhMaNhanVienMoi(); // Sẵn sàng cho lần thêm tiếp theo
                    LoadComboBoxTimKiem(); // Thêm dòng này
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_maNhanvien.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ketQua = new NhanVien().SuaNhanVien(
                    cbx_maNhanvien.Text.Trim(),
                    cbx_tenNhanvien.Text.Trim(),
                    dtp_ngaysinh.Value,
                    cbx_gioitinh.Text.Trim(),
                    txt_sdt.Text.Trim(),
                    txt_email.Text.Trim()
                );

                if (ketQua)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    LoadComboBoxTimKiem(); 
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_maNhanvien.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên {cbx_maNhanvien.Text.Trim()} không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes) return;

                bool ketQua = new NhanVien().XoaNhanVien(cbx_maNhanvien.Text.Trim());

                if (ketQua)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    ClearInputs();
                    SinhMaNhanVienMoi();
                    LoadComboBoxTimKiem(); 
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Có thể nhân viên đang được sử dụng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút tạo tài khoản cho nhân viên
        private void btn_taotk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_maNhanvien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần tạo tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = cbx_maNhanvien.Text.Trim();
            string hoTenNV = cbx_tenNhanvien.Text.Trim();

            // Kiểm tra đã có tài khoản chưa
            string queryCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNhanVien = @MaNV";
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryCheck, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show($"Nhân viên {hoTenNV} ({maNV}) đã có tài khoản rồi!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra tài khoản: " + ex.Message);
                return;
            }

            var info = new ThongTinTaoTaiKhoan
            {
                MaNhanVien = maNV,
                HoTenNhanVien = hoTenNV,
                TenDangNhapGoiY = maNV,
                VaiTro = "NhanVien"
            };

            TaoTaiKhoanMoi formTK = new TaoTaiKhoanMoi();
            formTK.Tag = info;
            formTK.ShowDialog();
        }

        // Làm mới form input
        private void ClearInputs()
        {
            cbx_tenNhanvien.Text = "";
            dtp_ngaysinh.Value = DateTime.Today;
            cbx_gioitinh.Text = "";
            txt_sdt.Clear();
            txt_email.Clear();
            // Không clear cbx_maNhanvien vì sẽ sinh mã mới
            SinhMaNhanVienMoi();
            cbx_tenNhanvien.Focus();
        }
    }
}