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
    public partial class DanhSachMonHoc : Form
    {
        public DanhSachMonHoc()
        {
            InitializeComponent();
        }

        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                dtv_Monhoc.DataSource = new MonHoc().TableMonHoc("SELECT * from MonHoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
