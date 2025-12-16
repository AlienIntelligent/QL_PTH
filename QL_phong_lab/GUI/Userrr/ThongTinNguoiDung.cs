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
    public partial class ThongTinNguoiDung : Form
    {
        public ThongTinNguoiDung()
        {
            InitializeComponent();
            lbl_HoTen_TextChanged(this, new EventArgs());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lbl_HoTen_TextChanged(object sender, EventArgs e)
        {
            if (DangNhap.vaitro == "Giáo viên")
            {
                var giaoVien = DataProvider.giaoViens.FirstOrDefault(gv => gv.MaGiaoVien == DangNhap.maGV);

                if (giaoVien != null)
                {
                    lbl_HoTen.Text = giaoVien.HoTen;
                }
                else
                {
                    lbl_HoTen.Text = "Không tìm thấy giáo viên";
                }
            }
            else if (DangNhap.vaitro == "Nhân viên")
            {
                var nhanVien = DataProvider.nhanViens.FirstOrDefault(nv => nv.MaNhanVien == DangNhap.maNV);

                if (nhanVien != null)
                {
                    lbl_HoTen.Text = nhanVien.HoTen;
                }
                else
                {
                    lbl_HoTen.Text = "Không tìm thấy nhân viên";
                }
            }
            else if (DangNhap.vaitro == "Quản trị viên")
            {
                lbl_HoTen.Text = DangNhap.taikhoan;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
