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
    public partial class ThongTinPhong : Form
    {
        public ThongTinPhong()
        {
            InitializeComponent();
        }

        private void ThongTinPhong_Load(object sender, EventArgs e)
        {
            try
            {
                dtv_Thietbi.DataSource = new ThietBiPhong().TableThietBiPhong("SELECT * from ThietBiPhong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
