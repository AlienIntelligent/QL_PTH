namespace QL_phong_lab
{
    partial class DuyetLich_DanhSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_DS_duyet = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.cbx_phong = new System.Windows.Forms.ComboBox();
            this.lbl_phong = new System.Windows.Forms.Label();
            this.cbx_maBDK = new System.Windows.Forms.ComboBox();
            this.lbl_tenNhanvien = new System.Windows.Forms.Label();
            this.cbx_Giaovien = new System.Windows.Forms.ComboBox();
            this.lbl_maGiaovien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_duyet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_hocky = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_namhoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ngayKT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_thu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_duyet = new FontAwesome.Sharp.IconButton();
            this.txt_ngayBD = new System.Windows.Forms.TextBox();
            this.txt_mon = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_boqua = new FontAwesome.Sharp.IconButton();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.dtv_choduyet = new System.Windows.Forms.DataGridView();
            this.pnl_Title_duyet_DS = new System.Windows.Forms.Panel();
            this.lbl_DS_duyet = new System.Windows.Forms.Label();
            this.pnl_DS_duyet.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_choduyet)).BeginInit();
            this.pnl_Title_duyet_DS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DS_duyet
            // 
            this.pnl_DS_duyet.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_DS_duyet.Controls.Add(this.panel2);
            this.pnl_DS_duyet.Controls.Add(this.panel1);
            this.pnl_DS_duyet.Controls.Add(this.pnl_data);
            this.pnl_DS_duyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_DS_duyet.Location = new System.Drawing.Point(0, 50);
            this.pnl_DS_duyet.Name = "pnl_DS_duyet";
            this.pnl_DS_duyet.Size = new System.Drawing.Size(1168, 639);
            this.pnl_DS_duyet.TabIndex = 4;
            this.pnl_DS_duyet.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Item_duyet_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gr_timkiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 100);
            this.panel2.TabIndex = 13;
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.gr_timkiem.Controls.Add(this.cbx_phong);
            this.gr_timkiem.Controls.Add(this.lbl_phong);
            this.gr_timkiem.Controls.Add(this.cbx_maBDK);
            this.gr_timkiem.Controls.Add(this.lbl_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.cbx_Giaovien);
            this.gr_timkiem.Controls.Add(this.lbl_maGiaovien);
            this.gr_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_timkiem.ForeColor = System.Drawing.Color.MintCream;
            this.gr_timkiem.Location = new System.Drawing.Point(9, 6);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Size = new System.Drawing.Size(746, 89);
            this.gr_timkiem.TabIndex = 2;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm Kiếm";
            // 
            // cbx_phong
            // 
            this.cbx_phong.FormattingEnabled = true;
            this.cbx_phong.Location = new System.Drawing.Point(629, 46);
            this.cbx_phong.Name = "cbx_phong";
            this.cbx_phong.Size = new System.Drawing.Size(102, 35);
            this.cbx_phong.TabIndex = 10;
            // 
            // lbl_phong
            // 
            this.lbl_phong.AutoSize = true;
            this.lbl_phong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phong.Location = new System.Drawing.Point(534, 53);
            this.lbl_phong.Name = "lbl_phong";
            this.lbl_phong.Size = new System.Drawing.Size(89, 22);
            this.lbl_phong.TabIndex = 9;
            this.lbl_phong.Text = "Phòng TH";
            // 
            // cbx_maBDK
            // 
            this.cbx_maBDK.FormattingEnabled = true;
            this.cbx_maBDK.Location = new System.Drawing.Point(388, 46);
            this.cbx_maBDK.Name = "cbx_maBDK";
            this.cbx_maBDK.Size = new System.Drawing.Size(102, 35);
            this.cbx_maBDK.TabIndex = 8;
            // 
            // lbl_tenNhanvien
            // 
            this.lbl_tenNhanvien.AutoSize = true;
            this.lbl_tenNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanvien.Location = new System.Drawing.Point(247, 53);
            this.lbl_tenNhanvien.Name = "lbl_tenNhanvien";
            this.lbl_tenNhanvien.Size = new System.Drawing.Size(135, 22);
            this.lbl_tenNhanvien.TabIndex = 7;
            this.lbl_tenNhanvien.Text = "Mã bản đăng ký";
            // 
            // cbx_Giaovien
            // 
            this.cbx_Giaovien.FormattingEnabled = true;
            this.cbx_Giaovien.Location = new System.Drawing.Point(116, 46);
            this.cbx_Giaovien.Name = "cbx_Giaovien";
            this.cbx_Giaovien.Size = new System.Drawing.Size(97, 35);
            this.cbx_Giaovien.TabIndex = 6;
            // 
            // lbl_maGiaovien
            // 
            this.lbl_maGiaovien.AutoSize = true;
            this.lbl_maGiaovien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maGiaovien.Location = new System.Drawing.Point(22, 53);
            this.lbl_maGiaovien.Name = "lbl_maGiaovien";
            this.lbl_maGiaovien.Size = new System.Drawing.Size(88, 22);
            this.lbl_maGiaovien.TabIndex = 5;
            this.lbl_maGiaovien.Text = "Giáo viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(761, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 639);
            this.panel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.txt_duyet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_hocky);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_namhoc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_ngayKT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_thu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_duyet);
            this.groupBox2.Controls.Add(this.txt_ngayBD);
            this.groupBox2.Controls.Add(this.txt_mon);
            this.groupBox2.Controls.Add(this.txt_lop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_boqua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 630);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // txt_duyet
            // 
            this.txt_duyet.Location = new System.Drawing.Point(174, 392);
            this.txt_duyet.Name = "txt_duyet";
            this.txt_duyet.Size = new System.Drawing.Size(100, 35);
            this.txt_duyet.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Trạng thái duyệt";
            // 
            // txt_hocky
            // 
            this.txt_hocky.Location = new System.Drawing.Point(286, 61);
            this.txt_hocky.Name = "txt_hocky";
            this.txt_hocky.Size = new System.Drawing.Size(82, 35);
            this.txt_hocky.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Học kỳ";
            // 
            // txt_namhoc
            // 
            this.txt_namhoc.Location = new System.Drawing.Point(99, 61);
            this.txt_namhoc.Name = "txt_namhoc";
            this.txt_namhoc.Size = new System.Drawing.Size(100, 35);
            this.txt_namhoc.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Năm học";
            // 
            // txt_ngayKT
            // 
            this.txt_ngayKT.Location = new System.Drawing.Point(239, 322);
            this.txt_ngayKT.Name = "txt_ngayKT";
            this.txt_ngayKT.Size = new System.Drawing.Size(100, 35);
            this.txt_ngayKT.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "đến";
            // 
            // txt_thu
            // 
            this.txt_thu.Location = new System.Drawing.Point(218, 253);
            this.txt_thu.Name = "txt_thu";
            this.txt_thu.Size = new System.Drawing.Size(121, 35);
            this.txt_thu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thứ trong tuần";
            // 
            // btn_duyet
            // 
            this.btn_duyet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_duyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_duyet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_duyet.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_duyet.IconColor = System.Drawing.Color.Black;
            this.btn_duyet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_duyet.Location = new System.Drawing.Point(229, 519);
            this.btn_duyet.Name = "btn_duyet";
            this.btn_duyet.Size = new System.Drawing.Size(123, 48);
            this.btn_duyet.TabIndex = 15;
            this.btn_duyet.Text = "Duyệt";
            this.btn_duyet.UseVisualStyleBackColor = false;
            this.btn_duyet.Click += new System.EventHandler(this.btn_duyet_Click);
            // 
            // txt_ngayBD
            // 
            this.txt_ngayBD.Location = new System.Drawing.Point(89, 322);
            this.txt_ngayBD.Name = "txt_ngayBD";
            this.txt_ngayBD.Size = new System.Drawing.Size(100, 35);
            this.txt_ngayBD.TabIndex = 13;
            // 
            // txt_mon
            // 
            this.txt_mon.Location = new System.Drawing.Point(218, 185);
            this.txt_mon.Name = "txt_mon";
            this.txt_mon.Size = new System.Drawing.Size(121, 35);
            this.txt_mon.TabIndex = 12;
            // 
            // txt_lop
            // 
            this.txt_lop.Location = new System.Drawing.Point(218, 121);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(121, 35);
            this.txt_lop.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lớp";
            // 
            // btn_boqua
            // 
            this.btn_boqua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_boqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_boqua.ForeColor = System.Drawing.Color.Crimson;
            this.btn_boqua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_boqua.IconColor = System.Drawing.Color.Black;
            this.btn_boqua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_boqua.Location = new System.Drawing.Point(36, 519);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(120, 48);
            this.btn_boqua.TabIndex = 1;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = false;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.dtv_choduyet);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(1168, 639);
            this.pnl_data.TabIndex = 10;
            // 
            // dtv_choduyet
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtv_choduyet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtv_choduyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtv_choduyet.BackgroundColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_choduyet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtv_choduyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtv_choduyet.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtv_choduyet.Location = new System.Drawing.Point(3, 106);
            this.dtv_choduyet.Name = "dtv_choduyet";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_choduyet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtv_choduyet.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtv_choduyet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtv_choduyet.RowTemplate.Height = 28;
            this.dtv_choduyet.Size = new System.Drawing.Size(752, 530);
            this.dtv_choduyet.TabIndex = 0;
            this.dtv_choduyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_choduyet_CellClick);
            // 
            // pnl_Title_duyet_DS
            // 
            this.pnl_Title_duyet_DS.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Title_duyet_DS.Controls.Add(this.lbl_DS_duyet);
            this.pnl_Title_duyet_DS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title_duyet_DS.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title_duyet_DS.Name = "pnl_Title_duyet_DS";
            this.pnl_Title_duyet_DS.Size = new System.Drawing.Size(1168, 50);
            this.pnl_Title_duyet_DS.TabIndex = 3;
            this.pnl_Title_duyet_DS.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Title_duyet_Paint);
            // 
            // lbl_DS_duyet
            // 
            this.lbl_DS_duyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DS_duyet.AutoSize = true;
            this.lbl_DS_duyet.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DS_duyet.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_DS_duyet.Location = new System.Drawing.Point(165, 7);
            this.lbl_DS_duyet.Name = "lbl_DS_duyet";
            this.lbl_DS_duyet.Size = new System.Drawing.Size(838, 36);
            this.lbl_DS_duyet.TabIndex = 0;
            this.lbl_DS_duyet.Text = "Danh Sách Chờ Duyệt Đăng Ký Sử Dụng Phòng Thực Hành";
            // 
            // DuyetLich_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 689);
            this.Controls.Add(this.pnl_DS_duyet);
            this.Controls.Add(this.pnl_Title_duyet_DS);
            this.Name = "DuyetLich_DanhSach";
            this.Text = "DuyetLich_DanhSach";
            this.Load += new System.EventHandler(this.DuyetLich_DanhSach_Load);
            this.pnl_DS_duyet.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_choduyet)).EndInit();
            this.pnl_Title_duyet_DS.ResumeLayout(false);
            this.pnl_Title_duyet_DS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DS_duyet;
        private System.Windows.Forms.Panel pnl_Title_duyet_DS;
        private System.Windows.Forms.Label lbl_DS_duyet;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.DataGridView dtv_choduyet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gr_timkiem;
        private System.Windows.Forms.Label lbl_tenNhanvien;
        private System.Windows.Forms.ComboBox cbx_Giaovien;
        private System.Windows.Forms.Label lbl_maGiaovien;
        private System.Windows.Forms.Label lbl_phong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_thu;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_duyet;
        private System.Windows.Forms.TextBox txt_ngayBD;
        private System.Windows.Forms.TextBox txt_mon;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btn_boqua;
        private System.Windows.Forms.ComboBox cbx_phong;
        private System.Windows.Forms.TextBox txt_hocky;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_namhoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ngayKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_maBDK;
        private System.Windows.Forms.TextBox txt_duyet;
        private System.Windows.Forms.Label label10;
    }
}