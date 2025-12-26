using QL_phong_lab.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_phong_lab.GUI.Userrr
{
    public partial class DanhSachMonHoc : Form
    {
        bool isLoading = false;

        public DanhSachMonHoc()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                LoadMonHoc();
                LoadComboBox();
                isLoading = false;

                if (DangNhap.vaitro == "Giáo viên" || DangNhap.vaitro == "Nhân viên")
                {
                    btn_them.Visible = false;
                    btn_sua.Visible = false;
                    btn_xoa.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= LOAD GRID =================
        void LoadMonHoc()
        {
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        MH.MaMonHoc,
                        MH.TenMonHoc,
                        BM.TenBoMon
                    FROM dbo.MonHoc MH
                    JOIN dbo.BoMon BM ON MH.MaBoMon = BM.MaBoMon", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv_monHoc.DataSource = dt;
            }
        }

        // ================= LOAD COMBOBOX =================
        void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
            {
                conn.Open();

                // Mã môn học
                SqlDataAdapter daMa = new SqlDataAdapter(
                    "SELECT DISTINCT MaMonHoc FROM dbo.MonHoc", conn);
                DataTable dtMa = new DataTable();
                daMa.Fill(dtMa);
                cbx_maMonHoc.DataSource = dtMa;
                cbx_maMonHoc.DisplayMember = "MaMonHoc";
                cbx_maMonHoc.SelectedIndex = -1;

                // Tên môn học
                SqlDataAdapter daTen = new SqlDataAdapter(
                    "SELECT DISTINCT TenMonHoc FROM dbo.MonHoc", conn);
                DataTable dtTen = new DataTable();
                daTen.Fill(dtTen);
                cbx_tenMonHoc.DataSource = dtTen;
                cbx_tenMonHoc.DisplayMember = "TenMonHoc";
                cbx_tenMonHoc.SelectedIndex = -1;

                // Bộ môn
                SqlDataAdapter daBM = new SqlDataAdapter(
                    "SELECT MaBoMon, TenBoMon FROM dbo.BoMon", conn);
                DataTable dtBM = new DataTable();
                daBM.Fill(dtBM);
                cbx_boMon.DataSource = dtBM;
                cbx_boMon.DisplayMember = "TenBoMon";
                cbx_boMon.ValueMember = "MaBoMon";
                cbx_boMon.SelectedIndex = -1;
            }
        }

        // ================= CLICK GRID =================
        private void dtv_monHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dtv_monHoc.Rows[e.RowIndex];

            cbx_maMonHoc.Text = row.Cells["MaMonHoc"].Value.ToString();
            cbx_tenMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
            cbx_boMon.Text = row.Cells["TenBoMon"].Value.ToString();
        }
        private void cbx_maMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ================= TÌM THEO TÊN =================
        private void cbx_tenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
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
                        @"INSERT INTO dbo.MonHoc(MaMonHoc, TenMonHoc, MaBoMon)
                      VALUES (@MaMonHoc, @TenMonHoc, @MaBoMon)", conn);

                    cmd.Parameters.AddWithValue("@MaMonHoc", cbx_maMonHoc.Text);
                    cmd.Parameters.AddWithValue("@TenMonHoc", cbx_tenMonHoc.Text);
                    cmd.Parameters.AddWithValue("@MaBoMon", cbx_boMon.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                LoadMonHoc();
                LoadComboBox();
                MessageBox.Show("Thêm môn học thành công");
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
                        @"UPDATE dbo.MonHoc
                      SET TenMonHoc=@TenMonHoc, MaBoMon=@MaBoMon
                      WHERE MaMonHoc=@MaMonHoc", conn);

                    cmd.Parameters.AddWithValue("@MaMonHoc", cbx_maMonHoc.Text);
                    cmd.Parameters.AddWithValue("@TenMonHoc", cbx_tenMonHoc.Text);
                    cmd.Parameters.AddWithValue("@MaBoMon", cbx_boMon.SelectedValue);

                    cmd.ExecuteNonQuery();
                }
                LoadMonHoc();
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
                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM dbo.MonHoc WHERE MaMonHoc=@MaMonHoc", conn);
                        cmd.Parameters.AddWithValue("@MaMonHoc", cbx_maMonHoc.Text);
                        cmd.ExecuteNonQuery();
                    }

                    LoadMonHoc();
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