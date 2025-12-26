using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QL_phong_lab
{
    public partial class QuanLyGiaoVien : Form
    {
        public QuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataGrid();
                LoadComboBoxBoMon();
                LoadComboBoxTimKiem();

                dtv_danhsachGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtv_danhsachGV.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                dtv_danhsachGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                dtv_danhsachGV.AllowUserToAddRows = true;

                // Chặn sửa mã giáo viên
                cbx_maGiaovien.KeyPress += cbx_maGiaovien_KeyPress;
                cbx_maGiaovien.MouseDown += cbx_maGiaovien_MouseDown;

                // Tự động sinh mã mới khi form load (trạng thái thêm mới)
                SinhMaGiaoVienMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chặn gõ phím vào ô mã giáo viên
        private void cbx_maGiaovien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Không thể sửa mã giáo viên!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Chặn click chuột trái vào ô mã giáo viên
        private void cbx_maGiaovien_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Không thể sửa mã giáo viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadDataGrid()
        {
            string query = @"SELECT gv.MaGiaoVien, gv.HoTen, gv.NgaySinh, gv.GioiTinh,
                                    gv.SoDienThoai, gv.Email, gv.MaBoMon, bm.TenBoMon
                             FROM GiaoVien gv
                             LEFT JOIN BoMon bm ON gv.MaBoMon = bm.MaBoMon
                             ORDER BY gv.MaGiaoVien";
            dtv_danhsachGV.DataSource = new GiaoVien().TableGV(query);
            dtv_danhsachGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtv_danhsachGV.AllowUserToAddRows = true;
        }

        private void LoadComboBoxBoMon()
        {
            DataTable dt = new GiaoVien().LoadBoMon();
            cbx_bomon.DataSource = dt;
            cbx_bomon.DisplayMember = "TenBoMon";
            cbx_bomon.ValueMember = "MaBoMon";
            cbx_bomon.SelectedIndex = -1;
        }

        private void LoadComboBoxTimKiem()
        {
            string query = "SELECT MaGiaoVien, HoTen FROM GiaoVien ORDER BY HoTen";
            DataTable dt = new GiaoVien().TableGV(query);

            cbx_maGiaovien.DataSource = dt.Copy();
            cbx_maGiaovien.DisplayMember = "MaGiaoVien";
            cbx_maGiaovien.ValueMember = "MaGiaoVien";
            cbx_maGiaovien.SelectedIndex = -1;

            cbx_tenGiaovien.DataSource = dt.Copy();
            cbx_tenGiaovien.DisplayMember = "HoTen";
            cbx_tenGiaovien.ValueMember = "MaGiaoVien";
            cbx_tenGiaovien.SelectedIndex = -1;
        }

        private string SafeCellString(DataGridViewRow row, string columnName)
        {
            if (row == null || row.Cells[columnName].Value == null || row.Cells[columnName].Value == DBNull.Value)
                return string.Empty;
            return row.Cells[columnName].Value.ToString().Trim();
        }

        private DateTime SafeParseDate(string s, DateTime fallback)
        {
            if (DateTime.TryParse(s, out DateTime result))
                return result;
            return fallback;
        }

        private void dtv_danhsachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtv_danhsachGV.Rows.Count - 1) // Trừ hàng trống cuối
            {
                // Nếu click vào hàng trống → chuyển sang chế độ thêm mới
                if (e.RowIndex == dtv_danhsachGV.Rows.Count - 1)
                {
                    ClearInputs();
                    SinhMaGiaoVienMoi();
                }
                return;
            }

            var row = dtv_danhsachGV.Rows[e.RowIndex];
            cbx_maGiaovien.Text = SafeCellString(row, "MaGiaoVien");
            cbx_tenGiaovien.Text = SafeCellString(row, "HoTen");
            dtp_ngaysinh.Value = SafeParseDate(SafeCellString(row, "NgaySinh"), DateTime.Today);
            cbx_gioitinh.Text = SafeCellString(row, "GioiTinh");
            txt_sdt.Text = SafeCellString(row, "SoDienThoai");
            txtemail.Text = SafeCellString(row, "Email");

            string maBoMon = SafeCellString(row, "MaBoMon");
            if (!string.IsNullOrEmpty(maBoMon))
                cbx_bomon.SelectedValue = maBoMon;
            else
                cbx_bomon.SelectedIndex = -1;
        }

        // Hàm sinh mã giáo viên tự tăng: GV001, GV002,...
        private void SinhMaGiaoVienMoi()
        {
            try
            {
                string query = "SELECT MAX(MaGiaoVien) FROM GiaoVien WHERE MaGiaoVien LIKE 'GV%'";
                DataTable dt = new GiaoVien().TableGV(query);

                string maxMa = dt.Rows[0][0]?.ToString();
                int soThuTu = 0;

                if (!string.IsNullOrEmpty(maxMa) && maxMa.StartsWith("GV"))
                {
                    if (int.TryParse(maxMa.Substring(2), out int num))
                    {
                        soThuTu = num;
                    }
                }

                soThuTu++;
                cbx_maGiaovien.Text = "GV" + soThuTu.ToString("D3"); // D3 → luôn 3 chữ số: 001, 002,...
            }
            catch
            {
                cbx_maGiaovien.Text = "GV001"; // Dự phòng nếu lỗi
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_tenGiaovien.Text))
                {
                    MessageBox.Show("Vui lòng nhập Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbx_tenGiaovien.Focus();
                    return;
                }
                if (cbx_bomon.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn Bộ môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng mã (dù đã tự sinh nhưng vẫn kiểm tra an toàn)
                DataTable check = new GiaoVien().TableGV(
                    $"SELECT MaGiaoVien FROM GiaoVien WHERE MaGiaoVien = '{cbx_maGiaovien.Text.Trim()}'");
                if (check.Rows.Count > 0)
                {
                    MessageBox.Show("Mã giáo viên đã tồn tại! (Có thể do trùng dữ liệu)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SinhMaGiaoVienMoi(); // Sinh lại mã mới
                    return;
                }

                string maBoMon = cbx_bomon.SelectedValue.ToString();
                bool ketQua = new GiaoVien().ThemGiaoVien(
                    cbx_maGiaovien.Text.Trim(),
                    cbx_tenGiaovien.Text.Trim(),
                    dtp_ngaysinh.Value,
                    cbx_gioitinh.Text.Trim(),
                    txt_sdt.Text.Trim(),
                    txtemail.Text.Trim(),
                    maBoMon
                );

                if (ketQua)
                {
                    MessageBox.Show("Thêm giáo viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    LoadComboBoxTimKiem();
                    ClearInputs();
                    SinhMaGiaoVienMoi(); // Sẵn sàng cho lần thêm tiếp theo
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Các nút Sửa, Xóa giữ nguyên logic cũ (chỉ sửa thông tin, không sửa mã)
        private void btnsua_Click(object sender, EventArgs e)
        {
            // Giữ nguyên code cũ của bạn, chỉ thêm kiểm tra bộ môn
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_maGiaovien.Text))
                {
                    MessageBox.Show("Vui lòng chọn giáo viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbx_bomon.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn Bộ môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maBoMon = cbx_bomon.SelectedValue.ToString();
                bool ketQua = new GiaoVien().SuaGiaoVien(
                    cbx_maGiaovien.Text.Trim(),
                    cbx_tenGiaovien.Text.Trim(),
                    dtp_ngaysinh.Value,
                    cbx_gioitinh.Text.Trim(),
                    txt_sdt.Text.Trim(),
                    txtemail.Text.Trim(),
                    maBoMon
                );

                if (ketQua)
                {
                    MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    LoadComboBoxTimKiem();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Giữ nguyên code cũ
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_maGiaovien.Text))
                {
                    MessageBox.Show("Vui lòng chọn giáo viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show($"Xóa giáo viên {cbx_maGiaovien.Text.Trim()}?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bool ketQua = new GiaoVien().XoaGiaoVien(cbx_maGiaovien.Text.Trim());
                if (ketQua)
                {
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    LoadComboBoxTimKiem();
                    ClearInputs();
                    SinhMaGiaoVienMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Có thể đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            cbx_tenGiaovien.Text = "";
            dtp_ngaysinh.Value = DateTime.Today;
            cbx_gioitinh.Text = "";
            txt_sdt.Clear();
            txtemail.Clear();
            cbx_bomon.SelectedIndex = -1;
            // Không clear cbx_maGiaovien vì sẽ sinh mới
            SinhMaGiaoVienMoi();
            cbx_tenGiaovien.Focus();
        }

        // Nút tạo tài khoản giữ nguyên (bạn đã có code tốt)
        private void btn_taotk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_maGiaovien.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần tạo tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maGV = cbx_maGiaovien.Text.Trim();
            string hoTenGV = cbx_tenGiaovien.Text.Trim();

            string queryCheck = $"SELECT COUNT(*) FROM TaiKhoan WHERE MaGiaoVien = '{maGV}'";
            DataTable dtCheck = new GiaoVien().TableGV(queryCheck);
            if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
            {
                MessageBox.Show($"Giáo viên {hoTenGV} ({maGV}) đã có tài khoản rồi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var info = new ThongTinTaoTaiKhoan
            {
                MaGiaoVien = maGV,
                HoTenGiaoVien = hoTenGV,
                TenDangNhapGoiY = maGV,
                VaiTro = "Giáo viên"
            };

            TaoTaiKhoanMoi formTK = new TaoTaiKhoanMoi();
            formTK.Tag = info;
            formTK.ShowDialog();
        }

        // Các event thừa
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}