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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_soDienthoai = new System.Windows.Forms.TextBox();
            this.txt_gioiTinh = new System.Windows.Forms.TextBox();
            this.txt_ngaySinh = new System.Windows.Forms.TextBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 70);
            this.panel1.TabIndex = 0;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_NhanVien.Location = new System.Drawing.Point(424, 2);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(320, 49);
            this.lbl_NhanVien.TabIndex = 0;
            this.lbl_NhanVien.Text = "Danh Sách Nhân Viên";
            this.lbl_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(761, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 619);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_soDienthoai);
            this.groupBox2.Controls.Add(this.txt_gioiTinh);
            this.groupBox2.Controls.Add(this.txt_ngaySinh);
            this.groupBox2.Controls.Add(this.lbl_email);
            this.groupBox2.Controls.Add(this.lbl_soDienthoai);
            this.groupBox2.Controls.Add(this.lbl_gioiTinh);
            this.groupBox2.Controls.Add(this.lbl_ngaySinh);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 585);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(209, 407);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(159, 48);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "Tạo tài khoản";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(209, 300);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(159, 35);
            this.txt_email.TabIndex = 14;
            // 
            // txt_soDienthoai
            // 
            this.txt_soDienthoai.Location = new System.Drawing.Point(209, 227);
            this.txt_soDienthoai.Name = "txt_soDienthoai";
            this.txt_soDienthoai.Size = new System.Drawing.Size(159, 35);
            this.txt_soDienthoai.TabIndex = 13;
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.Location = new System.Drawing.Point(209, 155);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(121, 35);
            this.txt_gioiTinh.TabIndex = 12;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.Location = new System.Drawing.Point(209, 82);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(121, 35);
            this.txt_ngaySinh.TabIndex = 11;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(32, 315);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 22);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email";
            // 
            // lbl_soDienthoai
            // 
            this.lbl_soDienthoai.AutoSize = true;
            this.lbl_soDienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDienthoai.Location = new System.Drawing.Point(32, 242);
            this.lbl_soDienthoai.Name = "lbl_soDienthoai";
            this.lbl_soDienthoai.Size = new System.Drawing.Size(114, 22);
            this.lbl_soDienthoai.TabIndex = 9;
            this.lbl_soDienthoai.Text = "Số điện thoại";
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(32, 170);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(81, 22);
            this.lbl_gioiTinh.TabIndex = 8;
            this.lbl_gioiTinh.Text = "Giới tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(32, 97);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(88, 22);
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
            this.btn_Xoa.Location = new System.Drawing.Point(209, 505);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(81, 48);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Sua.IconColor = System.Drawing.Color.Black;
            this.btn_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sua.Location = new System.Drawing.Point(65, 407);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(81, 48);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Them.IconColor = System.Drawing.Color.Black;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.Location = new System.Drawing.Point(65, 505);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 48);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.gr_timkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 101);
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
            this.gr_timkiem.Location = new System.Drawing.Point(12, 6);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Size = new System.Drawing.Size(743, 89);
            this.gr_timkiem.TabIndex = 0;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm Kiếm";
            // 
            // cbx_tenNhanvien
            // 
            this.cbx_tenNhanvien.FormattingEnabled = true;
            this.cbx_tenNhanvien.Location = new System.Drawing.Point(509, 40);
            this.cbx_tenNhanvien.Name = "cbx_tenNhanvien";
            this.cbx_tenNhanvien.Size = new System.Drawing.Size(121, 35);
            this.cbx_tenNhanvien.TabIndex = 8;
            // 
            // lbl_tenNhanvien
            // 
            this.lbl_tenNhanvien.AutoSize = true;
            this.lbl_tenNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanvien.Location = new System.Drawing.Point(383, 53);
            this.lbl_tenNhanvien.Name = "lbl_tenNhanvien";
            this.lbl_tenNhanvien.Size = new System.Drawing.Size(120, 22);
            this.lbl_tenNhanvien.TabIndex = 7;
            this.lbl_tenNhanvien.Text = "Tên nhân viên";
            // 
            // cbx_maNhanvien
            // 
            this.cbx_maNhanvien.FormattingEnabled = true;
            this.cbx_maNhanvien.Location = new System.Drawing.Point(193, 40);
            this.cbx_maNhanvien.Name = "cbx_maNhanvien";
            this.cbx_maNhanvien.Size = new System.Drawing.Size(121, 35);
            this.cbx_maNhanvien.TabIndex = 6;
            // 
            // lbl_maNhanvien
            // 
            this.lbl_maNhanvien.AutoSize = true;
            this.lbl_maNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maNhanvien.Location = new System.Drawing.Point(71, 53);
            this.lbl_maNhanvien.Name = "lbl_maNhanvien";
            this.lbl_maNhanvien.Size = new System.Drawing.Size(116, 22);
            this.lbl_maNhanvien.TabIndex = 5;
            this.lbl_maNhanvien.Text = "Mã nhân viên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.dtv_danhsachNV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 518);
            this.panel4.TabIndex = 3;
            // 
            // dtv_danhsachNV
            // 
            this.dtv_danhsachNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dtv_danhsachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_danhsachNV.Location = new System.Drawing.Point(12, 6);
            this.dtv_danhsachNV.Name = "dtv_danhsachNV";
            this.dtv_danhsachNV.RowHeadersWidth = 62;
            this.dtv_danhsachNV.RowTemplate.Height = 28;
            this.dtv_danhsachNV.Size = new System.Drawing.Size(743, 509);
            this.dtv_danhsachNV.TabIndex = 0;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1168, 689);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.TextBox txt_ngaySinh;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_soDienthoai;
        private System.Windows.Forms.Label lbl_gioiTinh;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_soDienthoai;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.ComboBox cbx_tenNhanvien;
        private System.Windows.Forms.Label lbl_tenNhanvien;
        private System.Windows.Forms.ComboBox cbx_maNhanvien;
        private System.Windows.Forms.Label lbl_maNhanvien;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}