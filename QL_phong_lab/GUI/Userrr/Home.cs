using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QL_phong_lab
{
    public partial class Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Home()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            pnl_Menu.Controls.Add(leftBorderBtn);
            Update_btn();
            lbl_NguoiDung_TextChanged(this, new EventArgs());
        }

        public void Update_btn()
        {
            string role = PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro);

            if (role == "Quản trị viên")
            {
                btn_A.Text = "DashBoard";
                btn_A.IconChar = IconChar.Dashboard;
                btn_B.Text = "Duyệt lịch";
                btn_B.IconChar = IconChar.CalendarDay;
                btn_C.Text = "Thêm tài khoản mới";
                btn_C.IconChar = IconChar.PeopleGroup;
                btn_D.Text = "Phân Ca Trực";
                btn_D.IconChar = IconChar.PersonCircleCheck;
                btn_E.Text = "Xem Lịch";
                btn_E.IconChar = IconChar.Calendar;
                btn_F.Text = "Xem Phòng";
                btn_F.IconChar = IconChar.Computer;
            }
            else if (role == "Giáo viên")
            {
                btn_A.Text = "DashBoard";
                btn_A.IconChar = IconChar.Dashboard; 
                btn_B.Text = "Đặt Lịch";
                btn_B.IconChar = IconChar.CalendarDay;
                btn_C.Text = "Xem Lịch";
                btn_C.IconChar = IconChar.Calendar;
                btn_D.Text = "Xem Bản Đăng Ký";
                btn_D.IconChar = IconChar.CalendarAlt;
                btn_E.Text = "Xem Phòng";
                btn_E.IconChar = IconChar.Computer;
                btn_F.Visible = false;
            }
            else if (role == "Nhân viên")
            {
                btn_A.Text = "DashBoard";
                btn_A.IconChar = IconChar.Dashboard;
                btn_B.Text = "Chốt Lịch";
                btn_B.IconChar = IconChar.CalendarDay;
                btn_C.Text = "Cập Nhật Thiết Bị";
                btn_C.IconChar = IconChar.Calendar;
                btn_D.Text = "Báo Cáo Sự Cố";
                btn_D.IconChar = IconChar.CalendarAlt;
                btn_E.Text = "Xem Lịch";
                btn_E.IconChar = IconChar.Calendar;
                btn_F.Text = "Xem Phòng";
                btn_F.IconChar = IconChar.Computer;
            }
        }
        public void Menu_TheoVaitro(string quyen, string btn_name)
        {

            switch (quyen)
            {
                case "Quản trị viên":
                    AdminForm(btn_name);
                    break;
                case "Giáo viên":
                    GiaovienForm(btn_name);
                    break;
                case "Nhân viên":
                    NhanvienForm(btn_name);
                    break;
            }
        }

        private void AdminForm(string btn_name)
        {
            switch (btn_name)
            {
                case "btn_A":
                    OpenChildForm(new Dashboard());
                    break;
                case "btn_B":
                    OpenChildForm(new DuyetLich_DanhSach());
                    break;
                case "btn_C":
                    OpenChildForm(new TaoTaiKhoanMoi());
                    break;
                case "btn_D":
                    OpenChildForm(new PhanCaTruc());
                    break;
                case "btn_E":
                    OpenChildForm(new XemLich());
                    break;
                case "btn_F":
                    OpenChildForm(new ThongTinPhong());
                    break;
            }
        }

        private void GiaovienForm(string btn_name)
        {
            switch (btn_name)
            {
                case "btn_A":
                    OpenChildForm(new Dashboard());
                    break;
                case "btn_B":
                    OpenChildForm(new DatLich());
                    break;
                case "btn_C":
                    OpenChildForm(new XemLich());
                    break;
                case "btn_D":
                    OpenChildForm(new DanhSach_DangKy_GV());
                    break;
                case "btn_E":
                    OpenChildForm(new ThongTinPhong());
                    break;
            }
        }

        private void NhanvienForm(string btn_name)
        {
            switch (btn_name)
            {
                case "btn_A":
                    OpenChildForm(new Dashboard());
                    break;
                case "btn_B":
                    OpenChildForm(new XepLich());
                    break;
                case "btn_C":
                    OpenChildForm(new CapNhatThongTinPhong());
                    break;
                case "btn_D":
                    OpenChildForm(new BaoCao());
                    break;
                case "btn_E":
                    OpenChildForm(new XemLich());
                    break;
                case "btn_F":
                    OpenChildForm(new CaTruc());
                    break;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_Desktop.Controls.Add(childForm);
            this.pnl_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Navy;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                this.Controls.Add(leftBorderBtn);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.DarkBlue;
                currentBtn.ForeColor = Color.GhostWhite;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.GhostWhite;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            Menu_TheoVaitro(PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro), "btn_A");
        }

        private void pnl_Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            Menu_TheoVaitro(PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro), "btn_B");
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            Menu_TheoVaitro(PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro), "btn_C");
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            Menu_TheoVaitro(PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro), "btn_D");
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);
            Menu_TheoVaitro(PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro), "btn_E");
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            Menu_TheoVaitro(PhanQuyenTruyCap.GetVaiTro(DangNhap.vaitro), "btn_F");
        }

        private void lbl_NguoiDung_TextChanged(object sender, EventArgs e)
        {
            if (DangNhap.vaitro == "Giáo viên")
            {
                var giaoVien = DataProvider.giaoViens.FirstOrDefault(gv => gv.MaGiaoVien == DangNhap.maGV);

                if (giaoVien != null)
                {
                    lbl_NguoiDung.Text = giaoVien.HoTen;
                }
                else
                {
                    lbl_NguoiDung.Text = "Không tìm thấy giáo viên";
                }
            }
            else if (DangNhap.vaitro == "Nhân viên")
            {
                var nhanVien = DataProvider.nhanViens.FirstOrDefault(nv => nv.MaNhanVien == DangNhap.maNV);

                if (nhanVien != null)
                {
                    lbl_NguoiDung.Text = nhanVien.HoTen;
                }
                else
                {
                    lbl_NguoiDung.Text = "Không tìm thấy nhân viên";
                }
            }
            else if (DangNhap.vaitro == "Quản trị viên")
            {
                lbl_NguoiDung.Text = DangNhap.taikhoan;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinNguoiDung());
        }
    }
}
