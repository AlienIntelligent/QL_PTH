namespace QL_phong_lab
{
    partial class TaoTaiKhoanMoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_ThemTaiKhoan = new System.Windows.Forms.Panel();
            this.lbl_TaoTaiKhoan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtv_Taikhoan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.cbx_tenNhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tenGiaovien = new System.Windows.Forms.ComboBox();
            this.lbl_tenNhanvien = new System.Windows.Forms.Label();
            this.cbx_maTaikhoan = new System.Windows.Forms.ComboBox();
            this.lbl_maGiaovien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_vaiTro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_BanAcc = new FontAwesome.Sharp.IconButton();
            this.txt_trangThai = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.btn_Sua = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.pnl_ThemTaiKhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Taikhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ThemTaiKhoan
            // 
            this.pnl_ThemTaiKhoan.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_ThemTaiKhoan.Controls.Add(this.lbl_TaoTaiKhoan);
            this.pnl_ThemTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ThemTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.pnl_ThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ThemTaiKhoan.Name = "pnl_ThemTaiKhoan";
            this.pnl_ThemTaiKhoan.Size = new System.Drawing.Size(1557, 64);
            this.pnl_ThemTaiKhoan.TabIndex = 0;
            // 
            // lbl_TaoTaiKhoan
            // 
            this.lbl_TaoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TaoTaiKhoan.AutoSize = true;
            this.lbl_TaoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaoTaiKhoan.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_TaoTaiKhoan.Location = new System.Drawing.Point(611, 6);
            this.lbl_TaoTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TaoTaiKhoan.Name = "lbl_TaoTaiKhoan";
            this.lbl_TaoTaiKhoan.Size = new System.Drawing.Size(342, 43);
            this.lbl_TaoTaiKhoan.TabIndex = 0;
            this.lbl_TaoTaiKhoan.Text = "Tạo Tài Khoản Mới";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 797);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtv_Taikhoan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 125);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 672);
            this.panel4.TabIndex = 2;
            // 
            // dtv_Taikhoan
            // 
            this.dtv_Taikhoan.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dtv_Taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Taikhoan.Location = new System.Drawing.Point(4, 4);
            this.dtv_Taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_Taikhoan.Name = "dtv_Taikhoan";
            this.dtv_Taikhoan.RowHeadersWidth = 62;
            this.dtv_Taikhoan.RowTemplate.Height = 28;
            this.dtv_Taikhoan.Size = new System.Drawing.Size(1011, 659);
            this.dtv_Taikhoan.TabIndex = 2;
            this.dtv_Taikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Taikhoan_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gr_timkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 125);
            this.panel3.TabIndex = 1;
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.gr_timkiem.Controls.Add(this.cbx_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.label1);
            this.gr_timkiem.Controls.Add(this.cbx_tenGiaovien);
            this.gr_timkiem.Controls.Add(this.lbl_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.cbx_maTaikhoan);
            this.gr_timkiem.Controls.Add(this.lbl_maGiaovien);
            this.gr_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_timkiem.ForeColor = System.Drawing.Color.MintCream;
            this.gr_timkiem.Location = new System.Drawing.Point(4, 8);
            this.gr_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Padding = new System.Windows.Forms.Padding(4);
            this.gr_timkiem.Size = new System.Drawing.Size(1011, 111);
            this.gr_timkiem.TabIndex = 2;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm Kiếm";
            this.gr_timkiem.Enter += new System.EventHandler(this.gr_timkiem_Enter);
            // 
            // cbx_tenNhanvien
            // 
            this.cbx_tenNhanvien.FormattingEnabled = true;
            this.cbx_tenNhanvien.Location = new System.Drawing.Point(841, 60);
            this.cbx_tenNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tenNhanvien.Name = "cbx_tenNhanvien";
            this.cbx_tenNhanvien.Size = new System.Drawing.Size(160, 44);
            this.cbx_tenNhanvien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên nhân viên";
            // 
            // cbx_tenGiaovien
            // 
            this.cbx_tenGiaovien.FormattingEnabled = true;
            this.cbx_tenGiaovien.Location = new System.Drawing.Point(505, 58);
            this.cbx_tenGiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tenGiaovien.Name = "cbx_tenGiaovien";
            this.cbx_tenGiaovien.Size = new System.Drawing.Size(160, 44);
            this.cbx_tenGiaovien.TabIndex = 8;
            this.cbx_tenGiaovien.SelectedIndexChanged += new System.EventHandler(this.cbx_tenGiaovien_SelectedIndexChanged);
            // 
            // lbl_tenNhanvien
            // 
            this.lbl_tenNhanvien.AutoSize = true;
            this.lbl_tenNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanvien.Location = new System.Drawing.Point(340, 66);
            this.lbl_tenNhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenNhanvien.Name = "lbl_tenNhanvien";
            this.lbl_tenNhanvien.Size = new System.Drawing.Size(160, 31);
            this.lbl_tenNhanvien.TabIndex = 7;
            this.lbl_tenNhanvien.Text = "Tên giáo viên";
            // 
            // cbx_maTaikhoan
            // 
            this.cbx_maTaikhoan.FormattingEnabled = true;
            this.cbx_maTaikhoan.Location = new System.Drawing.Point(172, 58);
            this.cbx_maTaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_maTaikhoan.Name = "cbx_maTaikhoan";
            this.cbx_maTaikhoan.Size = new System.Drawing.Size(160, 44);
            this.cbx_maTaikhoan.TabIndex = 6;
            // 
            // lbl_maGiaovien
            // 
            this.lbl_maGiaovien.AutoSize = true;
            this.lbl_maGiaovien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maGiaovien.Location = new System.Drawing.Point(12, 66);
            this.lbl_maGiaovien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maGiaovien.Name = "lbl_maGiaovien";
            this.lbl_maGiaovien.Size = new System.Drawing.Size(158, 31);
            this.lbl_maGiaovien.TabIndex = 5;
            this.lbl_maGiaovien.Text = "Mã tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1022, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 797);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.cbx_vaiTro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_BanAcc);
            this.groupBox2.Controls.Add(this.txt_trangThai);
            this.groupBox2.Controls.Add(this.txt_matKhau);
            this.groupBox2.Controls.Add(this.txt_tenDangNhap);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(511, 784);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cbx_vaiTro
            // 
            this.cbx_vaiTro.FormattingEnabled = true;
            this.cbx_vaiTro.Items.AddRange(new object[] {
            "Giáo viên",
            "Nhân viên"});
            this.cbx_vaiTro.Location = new System.Drawing.Point(280, 295);
            this.cbx_vaiTro.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_vaiTro.Name = "cbx_vaiTro";
            this.cbx_vaiTro.Size = new System.Drawing.Size(160, 44);
            this.cbx_vaiTro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vai trò";
            // 
            // btn_BanAcc
            // 
            this.btn_BanAcc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_BanAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanAcc.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_BanAcc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_BanAcc.IconColor = System.Drawing.Color.Black;
            this.btn_BanAcc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BanAcc.Location = new System.Drawing.Point(279, 509);
            this.btn_BanAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BanAcc.Name = "btn_BanAcc";
            this.btn_BanAcc.Size = new System.Drawing.Size(161, 60);
            this.btn_BanAcc.TabIndex = 15;
            this.btn_BanAcc.Text = "Ban acc";
            this.btn_BanAcc.UseVisualStyleBackColor = false;
            this.btn_BanAcc.Click += new System.EventHandler(this.btn_BanAcc_Click);
            // 
            // txt_trangThai
            // 
            this.txt_trangThai.Location = new System.Drawing.Point(279, 405);
            this.txt_trangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trangThai.Name = "txt_trangThai";
            this.txt_trangThai.Size = new System.Drawing.Size(160, 44);
            this.txt_trangThai.TabIndex = 13;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(279, 194);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(160, 44);
            this.txt_matKhau.TabIndex = 12;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(279, 94);
            this.txt_tenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(160, 44);
            this.txt_tenDangNhap.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên đăng nhập";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Xoa.IconColor = System.Drawing.Color.Black;
            this.btn_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xoa.Location = new System.Drawing.Point(279, 631);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 60);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Sua.IconColor = System.Drawing.Color.Black;
            this.btn_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sua.Location = new System.Drawing.Point(87, 509);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 60);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Them.IconColor = System.Drawing.Color.Black;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.Location = new System.Drawing.Point(87, 631);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 60);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // TaoTaiKhoanMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1557, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_ThemTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaoTaiKhoanMoi";
            this.Text = "TaoTaiKhoanMoi";
            this.Load += new System.EventHandler(this.TaoTaiKhoanMoi_Load);
            this.pnl_ThemTaiKhoan.ResumeLayout(false);
            this.pnl_ThemTaiKhoan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Taikhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ThemTaiKhoan;
        private System.Windows.Forms.Label lbl_TaoTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gr_timkiem;
        private System.Windows.Forms.ComboBox cbx_tenGiaovien;
        private System.Windows.Forms.Label lbl_tenNhanvien;
        private System.Windows.Forms.ComboBox cbx_maTaikhoan;
        private System.Windows.Forms.Label lbl_maGiaovien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_BanAcc;
        private System.Windows.Forms.TextBox txt_trangThai;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btn_Sua;
        private FontAwesome.Sharp.IconButton btn_Them;
        private System.Windows.Forms.DataGridView dtv_Taikhoan;
        private System.Windows.Forms.ComboBox cbx_tenNhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_vaiTro;
    }
}