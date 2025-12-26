using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_phong_lab.BLL;

namespace QL_phong_lab
{
    public partial class XemLich : Form
    {
        public XemLich()
        {
            InitializeComponent();
        }

        private void XemLich_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_ngay.Format = DateTimePickerFormat.Custom;
                dtp_ngay.CustomFormat = " ";

                LichPhongThucHanh.Load_XemLichPhong(dtv_LichSD, null, cbx_phong.Text = null, cbx_Giaovien.Text = null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dtv_LichSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_LichSD.Rows[e.RowIndex];

                cbx_phong.Text = row.Cells["TenPhong"].Value.ToString();
                cbx_Giaovien.Text = row.Cells["GiaoVien"].Value.ToString();
                //dtp_ngay.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);

                txt_hocky.Text = row.Cells["HocKy"].Value.ToString();
                txt_namhoc.Text = row.Cells["NamHoc"].Value.ToString();
                txt_lop.Text = row.Cells["TenLop"].Value.ToString();
                txt_mon.Text = row.Cells["TenMonHoc"].Value.ToString();
                //txt_ngayBD.Text = Convert.ToDateTime(row.Cells["NgayBatDau"].Value).ToString("dd/MM/yyyy");
                //txt_ngayKT.Text = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value).ToString("dd/MM/yyyy");
                //txt_thu.Text = row.Cells["ThuTrongTuan"].Value.ToString();
                //txt_tietBD.Text = row.Cells["TietBatDau"].Value.ToString();
                //txt_tietKT.Text = row.Cells["TietKetThuc"].Value.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_Giaovien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbx_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            dtp_ngay.Format = DateTimePickerFormat.Short;
            LichPhongThucHanh.Load_XemLichPhong(dtv_LichSD, dtp_ngay.Value, cbx_phong.Text, cbx_Giaovien.Text);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }
    }
}
