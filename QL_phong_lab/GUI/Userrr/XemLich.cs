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
                // Load existing data or setup defaults if necessary
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dtv_LichSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = cbx_phong.Text;
                DateTime ngayBatDau = dtp_ngay.Value;
                DateTime ngayKetThuc = dtp_ngayKetThuc.Value;
                int tietBatDau = int.Parse(txt_TietBatDau.Text);
                int tietKetThuc = int.Parse(txt_TietKetThuc.Text);
                int thuTrongTuan = (int)dtp_ngay.Value.DayOfWeek;

                // Assuming the method still exists in your BLL
                string result = LichPhongThucHanh.KiemTraPhongTrongTiet(maPhong, ngayBatDau, ngayKetThuc, tietBatDau, tietKetThuc, thuTrongTuan);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
