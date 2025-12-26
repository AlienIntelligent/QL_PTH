namespace QL_phong_lab
{
    partial class QuanLyGiaoVien
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
            this.lbl_GiaoVien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_bomon = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cbx_gioitinh = new System.Windows.Forms.ComboBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_taotk = new FontAwesome.Sharp.IconButton();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxoa = new FontAwesome.Sharp.IconButton();
            this.btnsua = new FontAwesome.Sharp.IconButton();
            this.btnthem = new FontAwesome.Sharp.IconButton();
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
            this.cbx_tenGiaovien = new System.Windows.Forms.ComboBox();
            this.lbl_tenNhanvien = new System.Windows.Forms.Label();
            this.cbx_maGiaovien = new System.Windows.Forms.ComboBox();
            this.lbl_maGiaovien = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtv_danhsachGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_danhsachGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_GiaoVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 88);
            this.panel1.TabIndex = 0;
            // 
            // lbl_GiaoVien
            // 
            this.lbl_GiaoVien.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaoVien.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_GiaoVien.Location = new System.Drawing.Point(565, 14);
            this.lbl_GiaoVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GiaoVien.Name = "lbl_GiaoVien";
            this.lbl_GiaoVien.Size = new System.Drawing.Size(427, 61);
            this.lbl_GiaoVien.TabIndex = 1;
            this.lbl_GiaoVien.Text = "Danh Sách Giáo Viên";
            this.lbl_GiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_soDienthoai);
            this.panel2.Controls.Add(this.txt_gioiTinh);
            this.panel2.Controls.Add(this.txt_ngaySinh);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Controls.Add(this.lbl_soDienthoai);
            this.panel2.Controls.Add(this.lbl_gioiTinh);
            this.panel2.Controls.Add(this.lbl_ngaySinh);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
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
            this.groupBox2.Controls.Add(this.cbx_bomon);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.cbx_gioitinh);
            this.groupBox2.Controls.Add(this.dtp_ngaysinh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_taotk);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(519, 761);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbx_bomon
            // 
            this.cbx_bomon.FormattingEnabled = true;
            this.cbx_bomon.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_bomon.Location = new System.Drawing.Point(279, 235);
            this.cbx_bomon.Name = "cbx_bomon";
            this.cbx_bomon.Size = new System.Drawing.Size(121, 44);
            this.cbx_bomon.TabIndex = 17;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(279, 411);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(211, 44);
            this.txtemail.TabIndex = 2;
            // 
            // cbx_gioitinh
            // 
            this.cbx_gioitinh.FormattingEnabled = true;
            this.cbx_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_gioitinh.Location = new System.Drawing.Point(279, 151);
            this.cbx_gioitinh.Name = "cbx_gioitinh";
            this.cbx_gioitinh.Size = new System.Drawing.Size(121, 44);
            this.cbx_gioitinh.TabIndex = 3;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(279, 80);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 44);
            this.dtp_ngaysinh.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bộ môn";
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
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(279, 315);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(211, 44);
            this.txt_sdt.TabIndex = 13;
            this.txt_sdt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số điện thoại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnxoa.IconColor = System.Drawing.Color.Black;
            this.btnxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnxoa.Location = new System.Drawing.Point(279, 631);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(108, 60);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnsua.IconColor = System.Drawing.Color.Black;
            this.btnsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsua.Location = new System.Drawing.Point(87, 509);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(108, 60);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthem.IconColor = System.Drawing.Color.Black;
            this.btnthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthem.Location = new System.Drawing.Point(87, 631);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(108, 60);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(283, 499);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(212, 60);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.Text = "Tạo tài khoản";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(283, 365);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(211, 31);
            this.txt_email.TabIndex = 26;
            // 
            // txt_soDienthoai
            // 
            this.txt_soDienthoai.Location = new System.Drawing.Point(283, 274);
            this.txt_soDienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soDienthoai.Name = "txt_soDienthoai";
            this.txt_soDienthoai.Size = new System.Drawing.Size(211, 31);
            this.txt_soDienthoai.TabIndex = 25;
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.Location = new System.Drawing.Point(283, 184);
            this.txt_gioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(160, 31);
            this.txt_gioiTinh.TabIndex = 24;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.Location = new System.Drawing.Point(283, 92);
            this.txt_ngaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(160, 31);
            this.txt_ngaySinh.TabIndex = 23;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(47, 384);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 31);
            this.lbl_email.TabIndex = 22;
            this.lbl_email.Text = "Email";
            // 
            // lbl_soDienthoai
            // 
            this.lbl_soDienthoai.AutoSize = true;
            this.lbl_soDienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDienthoai.Location = new System.Drawing.Point(47, 292);
            this.lbl_soDienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soDienthoai.Name = "lbl_soDienthoai";
            this.lbl_soDienthoai.Size = new System.Drawing.Size(159, 31);
            this.lbl_soDienthoai.TabIndex = 21;
            this.lbl_soDienthoai.Text = "Số điện thoại";
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(47, 202);
            this.lbl_gioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(111, 31);
            this.lbl_gioiTinh.TabIndex = 20;
            this.lbl_gioiTinh.Text = "Giới tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(47, 111);
            this.lbl_ngaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(122, 31);
            this.lbl_ngaySinh.TabIndex = 19;
            this.lbl_ngaySinh.Text = "Ngày sinh";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Xoa.IconColor = System.Drawing.Color.Black;
            this.btn_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xoa.Location = new System.Drawing.Point(283, 621);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 60);
            this.btn_Xoa.TabIndex = 18;
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
            this.btn_Sua.Location = new System.Drawing.Point(91, 499);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 60);
            this.btn_Sua.TabIndex = 17;
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
            this.btn_Them.Location = new System.Drawing.Point(91, 621);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 60);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
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
            this.gr_timkiem.Controls.Add(this.cbx_tenGiaovien);
            this.gr_timkiem.Controls.Add(this.lbl_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.cbx_maGiaovien);
            this.gr_timkiem.Controls.Add(this.lbl_maGiaovien);
            this.gr_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_timkiem.ForeColor = System.Drawing.Color.MintCream;
            this.gr_timkiem.Location = new System.Drawing.Point(12, 8);
            this.gr_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Padding = new System.Windows.Forms.Padding(4);
            this.gr_timkiem.Size = new System.Drawing.Size(991, 111);
            this.gr_timkiem.TabIndex = 1;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm Kiếm";
            // 
            // cbx_tenGiaovien
            // 
            this.cbx_tenGiaovien.FormattingEnabled = true;
            this.cbx_tenGiaovien.Location = new System.Drawing.Point(679, 50);
            this.cbx_tenGiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tenGiaovien.Name = "cbx_tenGiaovien";
            this.cbx_tenGiaovien.Size = new System.Drawing.Size(160, 44);
            this.cbx_tenGiaovien.TabIndex = 8;
            // 
            // lbl_tenNhanvien
            // 
            this.lbl_tenNhanvien.AutoSize = true;
            this.lbl_tenNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanvien.Location = new System.Drawing.Point(511, 66);
            this.lbl_tenNhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenNhanvien.Name = "lbl_tenNhanvien";
            this.lbl_tenNhanvien.Size = new System.Drawing.Size(160, 31);
            this.lbl_tenNhanvien.TabIndex = 7;
            this.lbl_tenNhanvien.Text = "Tên giáo viên";
            // 
            // cbx_maGiaovien
            // 
            this.cbx_maGiaovien.FormattingEnabled = true;
            this.cbx_maGiaovien.Location = new System.Drawing.Point(257, 50);
            this.cbx_maGiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_maGiaovien.Name = "cbx_maGiaovien";
            this.cbx_maGiaovien.Size = new System.Drawing.Size(160, 44);
            this.cbx_maGiaovien.TabIndex = 6;
            // 
            // lbl_maGiaovien
            // 
            this.lbl_maGiaovien.AutoSize = true;
            this.lbl_maGiaovien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maGiaovien.Location = new System.Drawing.Point(95, 66);
            this.lbl_maGiaovien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maGiaovien.Name = "lbl_maGiaovien";
            this.lbl_maGiaovien.Size = new System.Drawing.Size(154, 31);
            this.lbl_maGiaovien.TabIndex = 5;
            this.lbl_maGiaovien.Text = "Mã giáo viên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.dtv_danhsachGV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 214);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1014, 647);
            this.panel4.TabIndex = 0;
            // 
            // dtv_danhsachGV
            // 
            this.dtv_danhsachGV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dtv_danhsachGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_danhsachGV.Location = new System.Drawing.Point(12, 6);
            this.dtv_danhsachGV.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_danhsachGV.Name = "dtv_danhsachGV";
            this.dtv_danhsachGV.RowHeadersWidth = 62;
            this.dtv_danhsachGV.RowTemplate.Height = 28;
            this.dtv_danhsachGV.Size = new System.Drawing.Size(991, 636);
            this.dtv_danhsachGV.TabIndex = 1;
            this.dtv_danhsachGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_danhsachGV_CellClick);
            // 
            // QuanLyGiaoVien
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
            this.Name = "QuanLyGiaoVien";
            this.Text = "QuanLyGiaoVien";
            this.Load += new System.EventHandler(this.QuanLyGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_danhsachGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_GiaoVien;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_soDienthoai;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.TextBox txt_ngaySinh;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_soDienthoai;
        private System.Windows.Forms.Label lbl_gioiTinh;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btn_Sua;
        private FontAwesome.Sharp.IconButton btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_taotk;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnxoa;
        private FontAwesome.Sharp.IconButton btnsua;
        private FontAwesome.Sharp.IconButton btnthem;
        private System.Windows.Forms.GroupBox gr_timkiem;
        private System.Windows.Forms.ComboBox cbx_tenGiaovien;
        private System.Windows.Forms.Label lbl_tenNhanvien;
        private System.Windows.Forms.ComboBox cbx_maGiaovien;
        private System.Windows.Forms.Label lbl_maGiaovien;
        private System.Windows.Forms.DataGridView dtv_danhsachGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbx_gioitinh;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cbx_bomon;
    }
}