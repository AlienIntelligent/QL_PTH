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

namespace QL_phong_lab
{
    public partial class DuyetLich_DanhSach : Form
    {
        public DuyetLich_DanhSach()
        {
            InitializeComponent();
        }

        private void pnl_Title_duyet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Item_duyet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DuyetLich_DanhSach_Load(object sender, EventArgs e)
        {
            try
            {
                BanDangKy.Load_DSChoduyet(dtv_choduyet, null, null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dtv_choduyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_choduyet.Rows[e.RowIndex];        

                cbx_maBDK.Text = row.Cells["MaDangKy"].Value?.ToString();
                cbx_Giaovien.Text = row.Cells["GiaoVien"].Value?.ToString();
                cbx_phong.Text = row.Cells["TenPhong"].Value?.ToString();
                txt_hocky.Text = row.Cells["Hocky"].Value?.ToString();
                txt_namhoc.Text = row.Cells["NamHoc"].Value?.ToString();
                txt_thu.Text = row.Cells["ThuTrongTuan"].Value?.ToString();
                txt_ngayBD.Text = row.Cells["NgayBatDau"].Value?.ToString();
                txt_ngayKT.Text = row.Cells["NgayKetThuc"].Value?.ToString();
                txt_lop.Text = row.Cells["TenLop"].Value?.ToString();
                txt_mon.Text = row.Cells["TenMonHoc"].Value?.ToString();
                txt_duyet.Text = row.Cells["Duyet"].Value?.ToString();
            }
        }

        private void btn_duyet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_maBDK.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần duyệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn duyệt lịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string maBDK = cbx_maBDK.Text;
                    DateTime ngayBatDau = DateTime.Parse(txt_ngayBD.Text);
                    DateTime ngayKetThuc = DateTime.Parse(txt_ngayKT.Text);
                    int tietBatDau = int.Parse(dtv_choduyet.SelectedRows[0].Cells["TietBatDau"].Value.ToString());
                    int tietKetThuc = int.Parse(dtv_choduyet.SelectedRows[0].Cells["TietKetThuc"].Value.ToString());
                    int thuTrongTuan = int.Parse(txt_thu.Text);

                    using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                    {
                        conn.Open();

                        // Update BanDangKy set Duyet = 1
                        using (SqlCommand command = new SqlCommand("UPDATE BanDangKy SET Duyet = 1 WHERE MaDangKy = @MaBDK", conn))
                        {
                            command.Parameters.AddWithValue("@MaBDK", maBDK);
                            command.ExecuteNonQuery();
                        }

                        // Insert into LichPhongThucHanh
                        using (SqlCommand command = new SqlCommand("sp_ThemLichPhongThucHanh", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaBDK", maBDK);
                            command.Parameters.AddWithValue("@TietBatDau", tietBatDau);
                            command.Parameters.AddWithValue("@TietKetThuc", tietKetThuc);
                            command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                            command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                            command.Parameters.AddWithValue("@ThuTrongTuan", thuTrongTuan);
                            command.Parameters.AddWithValue("@TrangThai", false);
                            command.Parameters.AddWithValue("@SuCoThietBi", false);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Duyệt lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload data
                    BanDangKy.Load_DSChoduyet(dtv_choduyet, cbx_Giaovien.Text, cbx_maBDK.Text, cbx_phong.Text);

                    // Clear fields
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi duyệt lịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_maBDK.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần từ chối.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn từ chối duyệt lịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string maBDK = cbx_maBDK.Text;

                    using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString()))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand("sp_TuChoiduyetLich", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaBDK", maBDK);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Từ chối duyệt lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload data
                    BanDangKy.Load_DSChoduyet(dtv_choduyet, cbx_Giaovien.Text, cbx_maBDK.Text, cbx_phong.Text);

                    // Clear fields
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi từ chối duyệt lịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            cbx_maBDK.Text = "";
            cbx_Giaovien.Text = "";
            cbx_phong.Text = "";
            txt_hocky.Text = "";
            txt_namhoc.Text = "";
            txt_thu.Text = "";
            txt_ngayBD.Text = "";
            txt_ngayKT.Text = "";
            txt_lop.Text = "";
            txt_mon.Text = "";
            txt_duyet.Text = "";
        }
    }
}
