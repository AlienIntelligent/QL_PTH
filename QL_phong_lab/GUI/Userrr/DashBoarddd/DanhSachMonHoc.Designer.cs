namespace QL_phong_lab.GUI.Userrr
{
    partial class DanhSachMonHoc
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
            this.cbx_boMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.cbx_tenMonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_tenNhanvien = new System.Windows.Forms.Label();
            this.cbx_maMonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_maGiaovien = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtv_monHoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_monHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_GiaoVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 70);
            this.panel1.TabIndex = 1;
            // 
            // lbl_GiaoVien
            // 
            this.lbl_GiaoVien.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaoVien.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_GiaoVien.Location = new System.Drawing.Point(424, 11);
            this.lbl_GiaoVien.Name = "lbl_GiaoVien";
            this.lbl_GiaoVien.Size = new System.Drawing.Size(320, 49);
            this.lbl_GiaoVien.TabIndex = 2;
            this.lbl_GiaoVien.Text = "Danh Sách Môn Học";
            this.lbl_GiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(761, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 619);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.cbx_boMon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(9, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 609);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cbx_boMon
            // 
            this.cbx_boMon.FormattingEnabled = true;
            this.cbx_boMon.Location = new System.Drawing.Point(216, 164);
            this.cbx_boMon.Name = "cbx_boMon";
            this.cbx_boMon.Size = new System.Drawing.Size(121, 35);
            this.cbx_boMon.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bộ môn";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_xoa.IconColor = System.Drawing.Color.Black;
            this.btn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xoa.Location = new System.Drawing.Point(281, 407);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 48);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_sua.IconColor = System.Drawing.Color.Black;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.Location = new System.Drawing.Point(159, 407);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 48);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_them.IconColor = System.Drawing.Color.Black;
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.Location = new System.Drawing.Point(36, 407);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 48);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.gr_timkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 100);
            this.panel3.TabIndex = 4;
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.gr_timkiem.Controls.Add(this.cbx_tenMonHoc);
            this.gr_timkiem.Controls.Add(this.lbl_tenNhanvien);
            this.gr_timkiem.Controls.Add(this.cbx_maMonHoc);
            this.gr_timkiem.Controls.Add(this.lbl_maGiaovien);
            this.gr_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_timkiem.ForeColor = System.Drawing.Color.MintCream;
            this.gr_timkiem.Location = new System.Drawing.Point(9, 6);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Size = new System.Drawing.Size(743, 89);
            this.gr_timkiem.TabIndex = 2;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm Kiếm";
            // 
            // cbx_tenMonHoc
            // 
            this.cbx_tenMonHoc.FormattingEnabled = true;
            this.cbx_tenMonHoc.Location = new System.Drawing.Point(509, 46);
            this.cbx_tenMonHoc.Name = "cbx_tenMonHoc";
            this.cbx_tenMonHoc.Size = new System.Drawing.Size(121, 35);
            this.cbx_tenMonHoc.TabIndex = 8;
            // 
            // lbl_tenNhanvien
            // 
            this.lbl_tenNhanvien.AutoSize = true;
            this.lbl_tenNhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenNhanvien.Location = new System.Drawing.Point(383, 53);
            this.lbl_tenNhanvien.Name = "lbl_tenNhanvien";
            this.lbl_tenNhanvien.Size = new System.Drawing.Size(111, 22);
            this.lbl_tenNhanvien.TabIndex = 7;
            this.lbl_tenNhanvien.Text = "Tên môn học";
            // 
            // cbx_maMonHoc
            // 
            this.cbx_maMonHoc.FormattingEnabled = true;
            this.cbx_maMonHoc.Location = new System.Drawing.Point(193, 46);
            this.cbx_maMonHoc.Name = "cbx_maMonHoc";
            this.cbx_maMonHoc.Size = new System.Drawing.Size(121, 35);
            this.cbx_maMonHoc.TabIndex = 6;
            // 
            // lbl_maGiaovien
            // 
            this.lbl_maGiaovien.AutoSize = true;
            this.lbl_maGiaovien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maGiaovien.Location = new System.Drawing.Point(71, 53);
            this.lbl_maGiaovien.Name = "lbl_maGiaovien";
            this.lbl_maGiaovien.Size = new System.Drawing.Size(107, 22);
            this.lbl_maGiaovien.TabIndex = 5;
            this.lbl_maGiaovien.Text = "Mã môn học";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.dtv_monHoc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 519);
            this.panel4.TabIndex = 5;
            // 
            // dtv_monHoc
            // 
            this.dtv_monHoc.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dtv_monHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_monHoc.Location = new System.Drawing.Point(9, 5);
            this.dtv_monHoc.Name = "dtv_monHoc";
            this.dtv_monHoc.RowHeadersWidth = 62;
            this.dtv_monHoc.RowTemplate.Height = 28;
            this.dtv_monHoc.Size = new System.Drawing.Size(743, 509);
            this.dtv_monHoc.TabIndex = 2;
            this.dtv_monHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_monHoc_CellClick);
            // 
            // DanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1168, 689);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachMonHoc";
            this.Text = "DanhSachMonHoc";
            this.Load += new System.EventHandler(this.DanhSachMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_monHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_GiaoVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_them;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gr_timkiem;
        private System.Windows.Forms.ComboBox cbx_tenMonHoc;
        private System.Windows.Forms.Label lbl_tenNhanvien;
        private System.Windows.Forms.ComboBox cbx_maMonHoc;
        private System.Windows.Forms.Label lbl_maGiaovien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtv_monHoc;
        private System.Windows.Forms.ComboBox cbx_boMon;
        private System.Windows.Forms.Label label4;
    }
}