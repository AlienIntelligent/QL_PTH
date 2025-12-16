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
            this.pnl_DS_duyet = new System.Windows.Forms.Panel();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.grd_choduyet = new System.Windows.Forms.DataGridView();
            this.pnl_Title_duyet_DS = new System.Windows.Forms.Panel();
            this.lbl_DS_duyet = new System.Windows.Forms.Label();
            this.btn_Xem = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Thoigian = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_Trangthai = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_MaDK = new System.Windows.Forms.Label();
            this.pnl_DS_duyet.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_choduyet)).BeginInit();
            this.pnl_Title_duyet_DS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DS_duyet
            // 
            this.pnl_DS_duyet.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_DS_duyet.Controls.Add(this.panel1);
            this.pnl_DS_duyet.Controls.Add(this.btn_Xem);
            this.pnl_DS_duyet.Controls.Add(this.pnl_data);
            this.pnl_DS_duyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_DS_duyet.Location = new System.Drawing.Point(0, 50);
            this.pnl_DS_duyet.Name = "pnl_DS_duyet";
            this.pnl_DS_duyet.Size = new System.Drawing.Size(1168, 639);
            this.pnl_DS_duyet.TabIndex = 4;
            this.pnl_DS_duyet.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Item_duyet_Paint);
            // 
            // pnl_data
            // 
            this.pnl_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_data.Controls.Add(this.grd_choduyet);
            this.pnl_data.Location = new System.Drawing.Point(12, 97);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(1144, 425);
            this.pnl_data.TabIndex = 10;
            // 
            // grd_choduyet
            // 
            this.grd_choduyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_choduyet.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.grd_choduyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_choduyet.Location = new System.Drawing.Point(3, 4);
            this.grd_choduyet.Name = "grd_choduyet";
            this.grd_choduyet.RowHeadersWidth = 62;
            this.grd_choduyet.RowTemplate.Height = 28;
            this.grd_choduyet.Size = new System.Drawing.Size(1138, 419);
            this.grd_choduyet.TabIndex = 0;
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
            this.lbl_DS_duyet.Location = new System.Drawing.Point(294, 7);
            this.lbl_DS_duyet.Name = "lbl_DS_duyet";
            this.lbl_DS_duyet.Size = new System.Drawing.Size(580, 36);
            this.lbl_DS_duyet.TabIndex = 0;
            this.lbl_DS_duyet.Text = "Danh Sách Chờ Duyệt Phòng Thực Hành";
            // 
            // btn_Xem
            // 
            this.btn_Xem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Xem.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Xem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Xem.IconColor = System.Drawing.Color.Black;
            this.btn_Xem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xem.Location = new System.Drawing.Point(830, 526);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(168, 56);
            this.btn_Xem.TabIndex = 11;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 78);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.lbl_Thoigian);
            this.panel5.Location = new System.Drawing.Point(789, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 43);
            this.panel5.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbl_Thoigian
            // 
            this.lbl_Thoigian.AutoSize = true;
            this.lbl_Thoigian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thoigian.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Thoigian.Location = new System.Drawing.Point(3, 10);
            this.lbl_Thoigian.Name = "lbl_Thoigian";
            this.lbl_Thoigian.Size = new System.Drawing.Size(114, 27);
            this.lbl_Thoigian.TabIndex = 0;
            this.lbl_Thoigian.Text = "Thời gian:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.lbl_Trangthai);
            this.panel4.Location = new System.Drawing.Point(457, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 43);
            this.panel4.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // lbl_Trangthai
            // 
            this.lbl_Trangthai.AutoSize = true;
            this.lbl_Trangthai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trangthai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Trangthai.Location = new System.Drawing.Point(3, 10);
            this.lbl_Trangthai.Name = "lbl_Trangthai";
            this.lbl_Trangthai.Size = new System.Drawing.Size(115, 27);
            this.lbl_Trangthai.TabIndex = 0;
            this.lbl_Trangthai.Text = "Giáo viên:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.lbl_MaDK);
            this.panel3.Location = new System.Drawing.Point(75, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 43);
            this.panel3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // lbl_MaDK
            // 
            this.lbl_MaDK.AutoSize = true;
            this.lbl_MaDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_MaDK.Location = new System.Drawing.Point(3, 10);
            this.lbl_MaDK.Name = "lbl_MaDK";
            this.lbl_MaDK.Size = new System.Drawing.Size(176, 27);
            this.lbl_MaDK.TabIndex = 0;
            this.lbl_MaDK.Text = "Mã bản đăng ký:";
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
            this.pnl_DS_duyet.ResumeLayout(false);
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_choduyet)).EndInit();
            this.pnl_Title_duyet_DS.ResumeLayout(false);
            this.pnl_Title_duyet_DS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DS_duyet;
        private System.Windows.Forms.Panel pnl_Title_duyet_DS;
        private System.Windows.Forms.Label lbl_DS_duyet;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.DataGridView grd_choduyet;
        private FontAwesome.Sharp.IconButton btn_Xem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Thoigian;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_Trangthai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_MaDK;
    }
}