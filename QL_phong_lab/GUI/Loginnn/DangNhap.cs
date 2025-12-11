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
    public partial class DangNhap : Form
    {
        Login parentForm;
        Home homeForm;
        public static string taikhoan;
        string matkhau;
        public static string vaitro;
        public static string maGV;
        public static string maNV;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void NextForm()
        {
            parentForm = (Login)this.ParentForm;
            parentForm.Hide();

            homeForm = new Home();
            homeForm.ShowDialog();
        }
        private void lbl_QMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parentForm = (Login)this.ParentForm;
            parentForm.OpenChildForm(new QuenMatKhau());
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap_TextChanged(sender, e);
            txt_MatKhau_TextChanged(sender, e);
            bool is_Taikhoan = false;
            foreach (LoginInfo info in DataProvider.loginInfos)
            {
                if (info.TaiKhoan == taikhoan && info.MatKhau == matkhau && info.TrangThai == true)
                {
                    is_Taikhoan = true;
                    vaitro = info.VaiTro;
                    if (vaitro == "Nhân viên") maNV = info.MaNV;
                    if (vaitro == "Giáo viên") maGV = info.MaGV;
                    break;
                }
                
            }
            if (is_Taikhoan)
            {
                NextForm();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text.Trim();
            taikhoan = txt_TenDangNhap.Text;
        }
        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            txt_Matkhau.Text.Trim();
            matkhau = txt_Matkhau.Text;
        }

        private void pnl_TenDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
