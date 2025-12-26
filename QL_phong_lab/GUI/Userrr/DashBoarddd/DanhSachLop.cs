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

namespace QL_phong_lab.GUI.Userrr.Admin
{
    public partial class DanhSachLop : Form
    {
        bool isLoading = false;

        public DanhSachLop()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadLop();
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
        bool TableExists(string tableName)
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
        void LoadLop()
        {
            try
            {
                const string table = "LopHoc";
                if (!TableExists(table))
                {
                    MessageBox.Show($"Bảng '{table}' không tìm thấy trong database.\nKiểm tra __Connection.GetConnectionString()__ và cấu trúc DB.", "Bảng thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtv_Lop.DataSource = null;
                    return;
                }

                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();
                    // Sử dụng schema rõ ràng dbo để tránh nhầm lẫn schema
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaLop, TenLop, LopTruong, SoDienThoai, QuanSo FROM dbo.LopHoc", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtv_Lop.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error when loading classes: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= LOAD COMBOBOX =================
        void LoadComboBox()
        {
            try
            {
                const string table = "LopHoc";
                if (!TableExists(table))
                {
                    // already warned in LoadLop, just return
                    return;
                }

                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                {
                    conn.Open();

                    // Mã lớp
                    SqlDataAdapter daMa = new SqlDataAdapter("SELECT DISTINCT MaLop FROM dbo.LopHoc", conn);
                    DataTable dtMa = new DataTable();
                    daMa.Fill(dtMa);
                    cbx_maLop.DataSource = dtMa;
                    cbx_maLop.DisplayMember = "MaLop";
                    cbx_maLop.SelectedIndex = -1;

                    // Tên lớp
                    SqlDataAdapter daTen = new SqlDataAdapter("SELECT DISTINCT TenLop FROM dbo.LopHoc", conn);
                    DataTable dtTen = new DataTable();
                    daTen.Fill(dtTen);
                    cbx_tenLop.DataSource = dtTen;
                    cbx_tenLop.DisplayMember = "TenLop";
                    cbx_tenLop.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error when loading combobox: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= CLICK GRID =================
        private void dtv_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbx_maLop.Text = dtv_Lop.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                cbx_tenLop.Text = dtv_Lop.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
                txt_lopTruong.Text = dtv_Lop.Rows[e.RowIndex].Cells["LopTruong"].Value.ToString();
                txt_sdt.Text = dtv_Lop.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txt_quanSo.Text = dtv_Lop.Rows[e.RowIndex].Cells["QuanSo"].Value.ToString();
            }
        }

        // ================= TÌM THEO MÃ =================
        private void cbx_maLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // ================= TÌM THEO TÊN =================
        private void cbx_tenLop_SelectedIndexChanged(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LopHoc(MaLop,TenLop,LopTruong,SoDienThoai,QuanSo) VALUES (@MaLop,@TenLop,@LopTruong,@SoDienThoai,@QuanSo)", conn);

                    cmd.Parameters.AddWithValue("@MaLop", cbx_maLop.Text);
                    cmd.Parameters.AddWithValue("@TenLop", cbx_tenLop.Text);
                    cmd.Parameters.AddWithValue("@LopTruong", txt_lopTruong.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txt_sdt.Text);
                    cmd.Parameters.AddWithValue("@QuanSo", txt_quanSo.Text);

                    cmd.ExecuteNonQuery();
                }

                LoadLop();
                LoadComboBox();
                MessageBox.Show("Thêm lớp thành công");
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
                        @"UPDATE dbo.LopHoc SET
                            TenLop=@TenLop,
                            LopTruong=@LopTruong,
                            SoDienThoai=@SoDienThoai,
                            QuanSo=@QuanSo
                          WHERE MaLop=@MaLop", conn);

                    cmd.Parameters.AddWithValue("@MaLop", cbx_maLop.Text);
                    cmd.Parameters.AddWithValue("@TenLop", cbx_tenLop.Text);
                    cmd.Parameters.AddWithValue("@LopTruong", txt_lopTruong.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txt_sdt.Text);
                    cmd.Parameters.AddWithValue("@QuanSo", txt_quanSo.Text);

                    cmd.ExecuteNonQuery();
                }

                LoadLop();
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
                        SqlCommand cmd = new SqlCommand("DELETE FROM dbo.LopHoc WHERE MaLop=@MaLop", conn);
                        cmd.Parameters.AddWithValue("@MaLop", cbx_maLop.Text);
                        cmd.ExecuteNonQuery();
                    }

                    LoadLop();
                    LoadComboBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL error when deleting: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}