using QL_phong_lab.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_phong_lab.GUI.Userrr.GiaoVien
{
    public partial class DatLich : Form
    {
        public DatLich()
        {
            InitializeComponent();
        }

        private void DatLich_Load(object sender, EventArgs e)
        {
            try
            {
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
                txt_trangthai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }
    }
}
