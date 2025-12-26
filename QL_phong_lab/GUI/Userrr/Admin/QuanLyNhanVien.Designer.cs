namespace QL_phong_lab
{
    partial class QuanLyNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_gioitinh = new System.Windows.Forms.ComboBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_taotk = new FontAwesome.Sharp.IconButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_soDienthoai = new System.Windows.Forms.Label();
            this.lbl_gioiTinh = new System.Windows.Forms.Label();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.btn_Sua = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.cbx_tenNhanvien = new System.Windows.Forms.ComboBox();
            this.lbl_tenNhanvien = new System.Windows.Forms.Label();
            this.cbx_maNhanvien = new System.Windows.Forms.ComboBox();
            this.lbl_maNhanvien = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtv_danhsachNV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_danhsachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbl_NhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 88);
            this.panel1.TabIndex = 0;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_NhanVien.Location = new System.Drawing.Point(565, 2);
            this.lbl_NhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(481, 61);
            this.lbl_NhanVien.TabIndex = 0;
            this.lbl_NhanVien.Text = "Danh Sách Nhân Viên";
            this.lbl_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1014, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 773);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.cbx_gioitinh);
            this.groupBox2.Controls.Add(this.dtp_ngaysinh);
            this.groupBox2.Controls.Add(this.btn_taotk);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.lbl_email);
            this.groupBox2.Controls.Add(this.lbl_soDienthoai);
            this.groupBox2.Controls.Add(this.lbl_gioiTinh);
            this.groupBox2.Controls.Add(this.lbl_ngaySinh);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(519, 731);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cbx_gioitinh
            // 
            this.cbx_gioitinh.FormattingEnabled = true;
            this.cbx_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_gioitinh.Location = new System.Drawing.Point(279, 199);
            this.cbx_gioitinh.Name = "cbx_gioitinh";
            this.cbx_gioitinh.Size = new System.Drawing.Size(121, 44);
            this.cbx_gioitinh.TabIndex = 1;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(279, 118);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 44);
            this.dtp_ngaysinh.TabIndex = 1;
            // 
            // btn_taotk
            // 
            this.btn_taotk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_taotk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taotk.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_taotk.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_taotk.IconColor = System.Drawing.Color.Black;
            this.btn_taotk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_taotk.Location = new System.Drawing.Point(279, 509);
            this.btn_taotk.Margin = new System.Windows.Forms.Padding(4);
            this.btn_taotk.Name = "btn_taotk";
            this.btn_taotk.Size = new System.Drawing.Size(212, 60);
            this.btn_taotk.TabIndex = 15;
            this.btn_taotk.Text = "Tạo tài khoản";
            this.btn_taotk.UseVisualStyleBackColor = false;
            this.btn_taotk.Click += new System.EventHandler(this.btn_taotk_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(279, 375);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(211, 44);
            this.txt_email.TabIndex = 14;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(279, 284);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(211, 44);
            this.txt_sdt.TabIndex = 13;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(43, 394);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 31);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email";
            // 
            // lbl_soDienthoai
            // 
            this.lbl_soDienthoai.AutoSize = true;
            this.lbl_soDienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDienthoai.Location = new System.Drawing.Point(43, 302);
            this.lbl_soDienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soDienthoai.Name = "lbl_soDienthoai";
            this.lbl_soDienthoai.Size = new System.Drawing.Size(159, 31);
            this.lbl_soDienthoai.TabIndex = 9;
            this.lbl_soDienthoai.Text = "Số điện thoại";
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(43, 212);
            this.lbl_gioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(111, 31);
            this.lbl_gioiTinh.TabIndex = 8;
            this.lbl_gioiTinh.Text = "Giới tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(43, 121);
            this.lbl_ngaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(122, 31);
            this.lbl_ngaySinh.TabIndex = 7;
            this.lbl_ngaySinh.Text = "Ngày sinh";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.gr_timkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 126);
            this.panel3.TabIndex = 2;
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.gr_timkiem.Controls.Add(this.cbx_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.lbl_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.cbx_maNhanvien);
            this.gr_timkiem.Controls.Add(this.lbl_maNhanvien);
            this.gr_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_timkiem.ForeColor = System.Drawing.Color.MintCream;
            this.gr_timkiem.Location = new System.Drawing.Point(16, 8);
            this.gr_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Padding = new System.Windows.Forms.Padding(4);
            this.gr_timkiem.Size = new System.Drawing.Size(991, 111);
            this.gr_timkiem.TabIndex = 0;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm Kiếm";
            // 
            // cbx_tenNhanvien
            // 
            this.cbx_tenNhanvien.FormattingEnabled = true;
            this.cbx_tenNhanvien.Location = new System.Drawing.Point(679, 50);
            this.cbx_tenNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tenNhanvien.Name = "cbx_tenNhanvien";
            this.cbx_tenNhanvien.Size = new System.Drawing.Size(160, 44);
            this.cbx_tenNhanvien.TabIndex = 8;
            // 
            // lbl_tenNhanvien
            // 
            this.lbl_tenNhanvien.AutoSize = true;
            this.lbl_tenNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanvien.Location = new System.Drawing.Point(511, 66);
            this.lbl_tenNhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenNhanvien.Name = "lbl_tenNhanvien";
            this.lbl_tenNhanvien.Size = new System.Drawing.Size(169, 31);
            this.lbl_tenNhanvien.TabIndex = 7;
            this.lbl_tenNhanvien.Text = "Tên nhân viên";
            // 
            // cbx_maNhanvien
            // 
            this.cbx_maNhanvien.FormattingEnabled = true;
            this.cbx_maNhanvien.Location = new System.Drawing.Point(257, 50);
            this.cbx_maNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_maNhanvien.Name = "cbx_maNhanvien";
            this.cbx_maNhanvien.Size = new System.Drawing.Size(160, 44);
            this.cbx_maNhanvien.TabIndex = 6;
            // 
            // lbl_maNhanvien
            // 
            this.lbl_maNhanvien.AutoSize = true;
            this.lbl_maNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maNhanvien.Location = new System.Drawing.Point(95, 66);
            this.lbl_maNhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maNhanvien.Name = "lbl_maNhanvien";
            this.lbl_maNhanvien.Size = new System.Drawing.Size(163, 31);
            this.lbl_maNhanvien.TabIndex = 5;
            this.lbl_maNhanvien.Text = "Mã nhân viên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.dtv_danhsachNV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 214);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1014, 647);
            this.panel4.TabIndex = 3;
            // 
            // dtv_danhsachNV
            // 
            this.dtv_danhsachNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dtv_danhsachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_danhsachNV.Location = new System.Drawing.Point(16, 8);
            this.dtv_danhsachNV.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_danhsachNV.Name = "dtv_danhsachNV";
            this.dtv_danhsachNV.RowHeadersWidth = 62;
            this.dtv_danhsachNV.RowTemplate.Height = 28;
            this.dtv_danhsachNV.Size = new System.Drawing.Size(991, 636);
            this.dtv_danhsachNV.TabIndex = 0;
            this.dtv_danhsachNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_danhsachNV_CellClick);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1557, 861);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_danhsachNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gr_timkiem;
        private System.Windows.Forms.DataGridView dtv_danhsachNV;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btn_Sua;
        private FontAwesome.Sharp.IconButton btn_Them;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_soDienthoai;
        private System.Windows.Forms.Label lbl_gioiTinh;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.ComboBox cbx_tenNhanvien;
        private System.Windows.Forms.Label lbl_tenNhanvien;
        private System.Windows.Forms.ComboBox cbx_maNhanvien;
        private System.Windows.Forms.Label lbl_maNhanvien;
        private FontAwesome.Sharp.IconButton btn_taotk;
        private System.Windows.Forms.ComboBox cbx_gioitinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
    }
}