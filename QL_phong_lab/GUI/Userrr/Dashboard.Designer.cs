namespace QL_phong_lab
{
    partial class Dashboard
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
            this.pnl_Tongquan = new System.Windows.Forms.Panel();
            this.pnl_Thongbao = new System.Windows.Forms.Panel();
            this.pnl_Tacvunhanh = new System.Windows.Forms.Panel();
            this.lbl_Tongquan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_buoihoc = new System.Windows.Forms.Label();
            this.lbl_phong = new System.Windows.Forms.Label();
            this.lbl_suco = new System.Windows.Forms.Label();
            this.lbl_dangky = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_tacvu = new System.Windows.Forms.Label();
            this.pnl_Tongquan.SuspendLayout();
            this.pnl_Thongbao.SuspendLayout();
            this.pnl_Tacvunhanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Tongquan
            // 
            this.pnl_Tongquan.Controls.Add(this.lbl_dangky);
            this.pnl_Tongquan.Controls.Add(this.lbl_suco);
            this.pnl_Tongquan.Controls.Add(this.lbl_phong);
            this.pnl_Tongquan.Controls.Add(this.lbl_buoihoc);
            this.pnl_Tongquan.Controls.Add(this.lbl_Tongquan);
            this.pnl_Tongquan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tongquan.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tongquan.Name = "pnl_Tongquan";
            this.pnl_Tongquan.Size = new System.Drawing.Size(1217, 225);
            this.pnl_Tongquan.TabIndex = 0;
            // 
            // pnl_Thongbao
            // 
            this.pnl_Thongbao.Controls.Add(this.listView1);
            this.pnl_Thongbao.Controls.Add(this.label1);
            this.pnl_Thongbao.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Thongbao.Location = new System.Drawing.Point(0, 225);
            this.pnl_Thongbao.Name = "pnl_Thongbao";
            this.pnl_Thongbao.Size = new System.Drawing.Size(703, 509);
            this.pnl_Thongbao.TabIndex = 2;
            // 
            // pnl_Tacvunhanh
            // 
            this.pnl_Tacvunhanh.Controls.Add(this.lbl_tacvu);
            this.pnl_Tacvunhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tacvunhanh.Location = new System.Drawing.Point(703, 225);
            this.pnl_Tacvunhanh.Name = "pnl_Tacvunhanh";
            this.pnl_Tacvunhanh.Size = new System.Drawing.Size(514, 509);
            this.pnl_Tacvunhanh.TabIndex = 3;
            // 
            // lbl_Tongquan
            // 
            this.lbl_Tongquan.AutoSize = true;
            this.lbl_Tongquan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tongquan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Tongquan.Location = new System.Drawing.Point(26, 5);
            this.lbl_Tongquan.Name = "lbl_Tongquan";
            this.lbl_Tongquan.Size = new System.Drawing.Size(247, 33);
            this.lbl_Tongquan.TabIndex = 2;
            this.lbl_Tongquan.Text = "Tổng quan hôm nay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông báo:";
            // 
            // lbl_buoihoc
            // 
            this.lbl_buoihoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_buoihoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_buoihoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_buoihoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buoihoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_buoihoc.Location = new System.Drawing.Point(44, 45);
            this.lbl_buoihoc.Name = "lbl_buoihoc";
            this.lbl_buoihoc.Size = new System.Drawing.Size(229, 169);
            this.lbl_buoihoc.TabIndex = 3;
            this.lbl_buoihoc.Text = "Tổng số buổi học";
            this.lbl_buoihoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_phong
            // 
            this.lbl_phong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_phong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_phong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_phong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_phong.Location = new System.Drawing.Point(339, 45);
            this.lbl_phong.Name = "lbl_phong";
            this.lbl_phong.Size = new System.Drawing.Size(229, 169);
            this.lbl_phong.TabIndex = 4;
            this.lbl_phong.Text = "Tổng số phòng đang sử dụng";
            this.lbl_phong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_suco
            // 
            this.lbl_suco.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_suco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_suco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_suco.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_suco.Location = new System.Drawing.Point(634, 45);
            this.lbl_suco.Name = "lbl_suco";
            this.lbl_suco.Size = new System.Drawing.Size(229, 169);
            this.lbl_suco.TabIndex = 5;
            this.lbl_suco.Text = "Tổng số sự cố ghi nhận";
            this.lbl_suco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dangky
            // 
            this.lbl_dangky.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_dangky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_dangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_dangky.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangky.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_dangky.Location = new System.Drawing.Point(929, 45);
            this.lbl_dangky.Name = "lbl_dangky";
            this.lbl_dangky.Size = new System.Drawing.Size(229, 169);
            this.lbl_dangky.TabIndex = 6;
            this.lbl_dangky.Text = "Tổng số đăng ký chờ duyệt";
            this.lbl_dangky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 444);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_tacvu
            // 
            this.lbl_tacvu.AutoSize = true;
            this.lbl_tacvu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tacvu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_tacvu.Location = new System.Drawing.Point(41, 3);
            this.lbl_tacvu.Name = "lbl_tacvu";
            this.lbl_tacvu.Size = new System.Drawing.Size(204, 33);
            this.lbl_tacvu.TabIndex = 4;
            this.lbl_tacvu.Text = "Thống kê nhanh:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1217, 734);
            this.Controls.Add(this.pnl_Tacvunhanh);
            this.Controls.Add(this.pnl_Thongbao);
            this.Controls.Add(this.pnl_Tongquan);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnl_Tongquan.ResumeLayout(false);
            this.pnl_Tongquan.PerformLayout();
            this.pnl_Thongbao.ResumeLayout(false);
            this.pnl_Thongbao.PerformLayout();
            this.pnl_Tacvunhanh.ResumeLayout(false);
            this.pnl_Tacvunhanh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Tongquan;
        private System.Windows.Forms.Panel pnl_Thongbao;
        private System.Windows.Forms.Panel pnl_Tacvunhanh;
        private System.Windows.Forms.Label lbl_buoihoc;
        private System.Windows.Forms.Label lbl_Tongquan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dangky;
        private System.Windows.Forms.Label lbl_suco;
        private System.Windows.Forms.Label lbl_phong;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_tacvu;
    }
}