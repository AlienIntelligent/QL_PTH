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
                BanDangKy.Load_DSChoduyet(dtv_choduyet, cbx_Giaovien.Text = null, cbx_maBDK.Text = null, cbx_phong.Text = null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
