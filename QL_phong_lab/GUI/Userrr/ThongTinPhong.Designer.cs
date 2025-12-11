namespace QL_phong_lab
{
    partial class ThongTinPhong
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
            this.pnl_DS_duyet.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_choduyet)).BeginInit();
            this.pnl_Title_duyet_DS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DS_duyet
            // 
            this.pnl_DS_duyet.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_DS_duyet.Controls.Add(this.pnl_data);
            this.pnl_DS_duyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_DS_duyet.Location = new System.Drawing.Point(0, 50);
            this.pnl_DS_duyet.Name = "pnl_DS_duyet";
            this.pnl_DS_duyet.Size = new System.Drawing.Size(928, 563);
            this.pnl_DS_duyet.TabIndex = 6;
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.grd_choduyet);
            this.pnl_data.Location = new System.Drawing.Point(12, 28);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(904, 523);
            this.pnl_data.TabIndex = 10;
            // 
            // grd_choduyet
            // 
            this.grd_choduyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_choduyet.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.grd_choduyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_choduyet.Location = new System.Drawing.Point(3, 3);
            this.grd_choduyet.Name = "grd_choduyet";
            this.grd_choduyet.RowHeadersWidth = 62;
            this.grd_choduyet.RowTemplate.Height = 28;
            this.grd_choduyet.Size = new System.Drawing.Size(898, 517);
            this.grd_choduyet.TabIndex = 0;
            // 
            // pnl_Title_duyet_DS
            // 
            this.pnl_Title_duyet_DS.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Title_duyet_DS.Controls.Add(this.lbl_DS_duyet);
            this.pnl_Title_duyet_DS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title_duyet_DS.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title_duyet_DS.Name = "pnl_Title_duyet_DS";
            this.pnl_Title_duyet_DS.Size = new System.Drawing.Size(928, 50);
            this.pnl_Title_duyet_DS.TabIndex = 5;
            // 
            // lbl_DS_duyet
            // 
            this.lbl_DS_duyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DS_duyet.AutoSize = true;
            this.lbl_DS_duyet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DS_duyet.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DS_duyet.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_DS_duyet.Location = new System.Drawing.Point(177, 7);
            this.lbl_DS_duyet.Name = "lbl_DS_duyet";
            this.lbl_DS_duyet.Size = new System.Drawing.Size(574, 36);
            this.lbl_DS_duyet.TabIndex = 0;
            this.lbl_DS_duyet.Text = "Danh Sách Thông Tin Phòng Thực Hành";
            // 
            // ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 613);
            this.Controls.Add(this.pnl_DS_duyet);
            this.Controls.Add(this.pnl_Title_duyet_DS);
            this.Name = "ThongTinPhong";
            this.Text = "ThongTinPhong";
            this.pnl_DS_duyet.ResumeLayout(false);
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_choduyet)).EndInit();
            this.pnl_Title_duyet_DS.ResumeLayout(false);
            this.pnl_Title_duyet_DS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DS_duyet;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.DataGridView grd_choduyet;
        private System.Windows.Forms.Panel pnl_Title_duyet_DS;
        private System.Windows.Forms.Label lbl_DS_duyet;
    }
}