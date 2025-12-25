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
    public partial class QuenMatKhau : Form
    {
        public static string taikhoan;
        string matkhau;
        string sdt;
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_QMK_Click(object sender, EventArgs e)
        {
            GetMK();
        }

        private void GetMK()
        {
            taikhoan = txt_TenDangNhap.Text;
            sdt = txt_SDT.Text;

            bool is_Taikhoan = false;
            foreach (LoginInfo info in DataProvider.loginInfos)
            {
                if (info.TaiKhoan == taikhoan)
                {
                    is_Taikhoan = true;
                    matkhau = info.MatKhau;
                    break;
                }

            }
            if (is_Taikhoan)
            {
                MessageBox.Show(matkhau, "Mật khẩu nè", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}
