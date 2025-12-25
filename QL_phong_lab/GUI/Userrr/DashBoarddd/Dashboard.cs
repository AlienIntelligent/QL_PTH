using QL_phong_lab.BLL;
using QL_phong_lab.GUI.Userrr;
using QL_phong_lab.GUI.Userrr.Admin;
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
    public partial class Dashboard : Form
    {
        private Form crrdashForm;
        Home home = Home.Current;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void OpenDashForm(Form dashForm)
        {
            if (crrdashForm != null)
            {
                crrdashForm.Close();
            }
            crrdashForm = dashForm;
            dashForm.TopLevel = false;
            dashForm.FormBorderStyle = FormBorderStyle.None;
            dashForm.Dock = DockStyle.Fill;
            home.pnl_Desktop.Controls.Add(dashForm);
            home.pnl_Desktop.Tag = dashForm;
            dashForm.BringToFront();
            dashForm.Show();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenDashForm(new XemLich());
        }

        private void btn_DSlop_Click(object sender, EventArgs e)
        {
            OpenDashForm(new DanhSachLop());
        }

        private void btn_DSmon_Click(object sender, EventArgs e)
        {
            OpenDashForm(new DanhSachMonHoc());
        }

        private void btn_DSbomon_Click(object sender, EventArgs e)
        {
            OpenDashForm(new DanhSachBoMon());
        }

        private void btn_DSphong_Click(object sender, EventArgs e)
        {
            OpenDashForm(new QuanLyPTH());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LichPhongThucHanh.Load_LichTrongNgay(dtv_LichHomnay, DateTime.Now);
        }

        private void lbl_das1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_das2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_das3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
