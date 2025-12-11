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
                btn_A.Text = "Quản Lý Lịch";
                btn_A.IconChar = IconChar.CalendarCheck;
                btn_B.Text = "Quản Lý Phòng";
                btn_C.Text = "Quản Lý Thiết Bị";
                btn_D.Text = "Báo Cáo Thống Kê";
                btn_E.Text = "Quản Lý Người Dùng";
                btn_F.Text = "Cài Đặt Hệ Thống";
            }
            else if (role == "Giáo viên")
            {
                btn_A.Text = "Đặt Lịch";
                btn_B.Text = "Xem Lịch";
                btn_C.Visible = false;
                btn_D.Visible = false;
                btn_E.Visible = false;
                btn_F.Visible = false;
            }
            else if (role == "Nhân viên")
            {
                btn_A.Text = "Quản Lý Lịch";
                btn_B.Text = "Quản Lý Phòng";
                btn_C.Text = "Quản Lý Thiết Bị";
                btn_D.Visible = false;
                btn_E.Visible = false;
                btn_F.Visible = false;
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
                    //childForm = new FormQLLich();
                    break;
                case "btn_B":
                    //childForm = new FormQLPhong();
                    break;
                case "btn_C":
                    //childForm = new FormQLThietBi();
                    break;
                case "btn_D":
                    //childForm = new FormBaoCaoThongKe();
                    break;
                case "btn_E":
                    //childForm = new FormQLNguoiDung();
                    break;
                case "btn_F":
                    //childForm = new FormCaiDatHeThong();
                    break;
            }
        }

        private void GiaovienForm(string btn_name)
        {
            switch (btn_name)
            {
                case "btn_A":
                    OpenChildForm(new DatLich());
                    break;
                case "btn_B":
                    OpenChildForm(new XemLich());
                    break;
            }
        }

        private void NhanvienForm(string btn_name)
        {
            switch (btn_name)
            {
                case "btn_A":
                    //childForm = new FormQLLich();
                    break;
                case "btn_B":
                    //childForm = new FormQLPhong();
                    break;
                case "btn_C":
                    //childForm = new FormQLThietBi();
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
    }
}
