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

namespace QL_phong_lab.GUI.Userrr.Admin
{
    public partial class QuanLyPTH : Form
    {
        public QuanLyPTH()
        {
            InitializeComponent();
        }

        private void QuanLyPTH_Load(object sender, EventArgs e)
        {
            try
            {
                dtv_Phong.DataSource = new PhongThucHanh().TablePhong("SELECT * from PhongThucHanh");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
