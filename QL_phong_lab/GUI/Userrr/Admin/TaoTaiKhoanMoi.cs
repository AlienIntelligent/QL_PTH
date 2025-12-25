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

        }

        private void TaoTaiKhoanMoi_Load(object sender, EventArgs e)
        {
            try
            {
                dtv_Taikhoan.DataSource = new LoginInfo().TableTaiKhoan("SELECT * from TaiKhoan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
