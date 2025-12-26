using QL_phong_lab.BLL;
using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_phong_lab.GUI.Userrr
{
    public partial class DanhSachBoMon : Form
    {
        bool isLoading = false;
        public DanhSachBoMon()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void DanhSachBoMon_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadBoMon();
                LoadComboBox();
                isLoading = false;

                if (DangNhap.vaitro == "Giáo viên" || DangNhap.vaitro == "Nhân viên")
                {
                    btn_them.Visible = false;
                    btn_sua.Visible = false;
                    btn_xoa.Visible = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Lỗi kết nối DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper: kiểm tra bảng có tồn tại không
        private bool TableExists(string tableName)
        {
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", tableName);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // ================= LOAD GRID =================
        void LoadBoMon()
        {
            try
            {
                const string table = "BoMon";
                if (!TableExists(table))
                {
                    MessageBox.Show($"Bảng '{table}' không tìm thấy trong database.\nKiểm tra __Connection.GetConnectionString()__ và cấu trúc DB.", "Bảng thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtv_boMon.DataSource = null;
                    return;
                }

                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaBoMon, TenBoMon, ChuyenMon FROM dbo.BoMon", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtv_boMon.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error when loading BoMon: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= LOAD COMBOBOX =================
        void LoadComboBox()
        {
            try
            {
                const string table = "BoMon";
                if (!TableExists(table)) return;

                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();

                    // Mã bộ môn
                    SqlDataAdapter daMa = new SqlDataAdapter("SELECT DISTINCT MaBoMon FROM dbo.BoMon", conn);
                    DataTable dtMa = new DataTable();
                    daMa.Fill(dtMa);
                    cbx_maBoMon.DataSource = dtMa;
                    cbx_maBoMon.DisplayMember = "MaBoMon";
                    cbx_maBoMon.SelectedIndex = -1;

                    // Tên bộ môn
                    SqlDataAdapter daTen = new SqlDataAdapter("SELECT DISTINCT TenBoMon FROM dbo.BoMon", conn);
                    DataTable dtTen = new DataTable();
                    daTen.Fill(dtTen);
                    cbx_tenBoMon.DataSource = dtTen;
                    cbx_tenBoMon.DisplayMember = "TenBoMon";
                    cbx_tenBoMon.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error when loading combobox: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= CLICK GRID =================
        private void dtv_boMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbx_maBoMon.Text = dtv_boMon.Rows[e.RowIndex].Cells["MaBoMon"].Value.ToString();
                cbx_tenBoMon.Text = dtv_boMon.Rows[e.RowIndex].Cells["TenBoMon"].Value.ToString();
                txt_chuyenMon.Text = dtv_boMon.Rows[e.RowIndex].Cells["ChuyenMon"].Value.ToString();
            }
        }

        // ================= TÌM KIẾM THEO MÃ =================
        private void cbx_maBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // ================= TÌM KIẾM THEO TÊN =================
        private void cbx_tenBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.BoMon(MaBoMon, TenBoMon, ChuyenMon) VALUES (@MaBoMon, @TenBoMon, @ChuyenMon)", conn);
                    cmd.Parameters.AddWithValue("@MaBoMon", cbx_maBoMon.Text);
                    cmd.Parameters.AddWithValue("@TenBoMon", cbx_tenBoMon.Text);
                    cmd.Parameters.AddWithValue("@ChuyenMon", txt_chuyenMon.Text);

                    cmd.ExecuteNonQuery();
                }

                LoadBoMon();
                LoadComboBox();
                MessageBox.Show("Thêm bộ môn thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error when inserting: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE dbo.BoMon SET TenBoMon=@TenBoMon, ChuyenMon=@ChuyenMon WHERE MaBoMon=@MaBoMon", conn);

                    cmd.Parameters.AddWithValue("@MaBoMon", cbx_maBoMon.Text);
                    cmd.Parameters.AddWithValue("@TenBoMon", cbx_tenBoMon.Text);
                    cmd.Parameters.AddWithValue("@ChuyenMon", txt_chuyenMon.Text);

                    cmd.ExecuteNonQuery();
                }

                LoadBoMon();
                LoadComboBox();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error when updating: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM dbo.BoMon WHERE MaBoMon=@MaBoMon", conn);
                        cmd.Parameters.AddWithValue("@MaBoMon", cbx_maBoMon.Text);
                        cmd.ExecuteNonQuery();
                    }

                    LoadBoMon();
                    LoadComboBox();
                    txt_chuyenMon.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL error when deleting: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}