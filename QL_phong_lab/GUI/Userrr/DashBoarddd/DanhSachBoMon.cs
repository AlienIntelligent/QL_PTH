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

namespace QL_phong_lab.GUI.Userrr
{
    public partial class DanhSachBoMon : Form
    {
        public DanhSachBoMon()
        {
            InitializeComponent();
        }

        private void DanhSachBoMon_Load(object sender, EventArgs e)
        {
            try
            {
                dtv_Bomon.DataSource = new BoMon().TableBoMon("SELECT * from BoMon");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
