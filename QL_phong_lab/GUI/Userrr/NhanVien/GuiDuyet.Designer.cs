namespace QL_phong_lab
{
    partial class GuiDuyet
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
            this.pnl_DScho = new System.Windows.Forms.Panel();
            this.lbl_DScho = new System.Windows.Forms.Label();
            this.pnl_view = new System.Windows.Forms.Panel();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.grd_choduyet = new System.Windows.Forms.DataGridView();
            this.btn_Send_duyet = new FontAwesome.Sharp.IconButton();
            this.pnl_DScho.SuspendLayout();
            this.pnl_view.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_choduyet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_DScho
            // 
            this.pnl_DScho.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_DScho.Controls.Add(this.lbl_DScho);
            this.pnl_DScho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DScho.Location = new System.Drawing.Point(0, 0);
            this.pnl_DScho.Name = "pnl_DScho";
            this.pnl_DScho.Size = new System.Drawing.Size(800, 80);
            this.pnl_DScho.TabIndex = 0;
            // 
            // lbl_DScho
            // 
            this.lbl_DScho.AutoSize = true;
            this.lbl_DScho.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DScho.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_DScho.Location = new System.Drawing.Point(132, 22);
            this.lbl_DScho.Name = "lbl_DScho";
            this.lbl_DScho.Size = new System.Drawing.Size(537, 36);
            this.lbl_DScho.TabIndex = 1;
            this.lbl_DScho.Text = "Danh Sách Phiếu Đăng Ký Chờ Duyệt";
            // 
            // pnl_view
            // 
            this.pnl_view.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_view.Controls.Add(this.pnl_data);
            this.pnl_view.Controls.Add(this.btn_Send_duyet);
            this.pnl_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_view.Location = new System.Drawing.Point(0, 80);
            this.pnl_view.Name = "pnl_view";
            this.pnl_view.Size = new System.Drawing.Size(800, 370);
            this.pnl_view.TabIndex = 1;
            // 
            // pnl_data
            // 
            this.pnl_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_data.Controls.Add(this.grd_choduyet);
            this.pnl_data.Location = new System.Drawing.Point(47, 17);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(702, 230);
            this.pnl_data.TabIndex = 9;
            // 
            // grd_choduyet
            // 
            this.grd_choduyet.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.grd_choduyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_choduyet.Location = new System.Drawing.Point(3, 3);
            this.grd_choduyet.Name = "grd_choduyet";
            this.grd_choduyet.RowHeadersWidth = 62;
            this.grd_choduyet.RowTemplate.Height = 28;
            this.grd_choduyet.Size = new System.Drawing.Size(696, 219);
            this.grd_choduyet.TabIndex = 0;
            // 
            // btn_Send_duyet
            // 
            this.btn_Send_duyet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Send_duyet.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Send_duyet.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Send_duyet.FlatAppearance.BorderSize = 2;
            this.btn_Send_duyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send_duyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send_duyet.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Send_duyet.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.btn_Send_duyet.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Send_duyet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Send_duyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Send_duyet.Location = new System.Drawing.Point(299, 270);
            this.btn_Send_duyet.Name = "btn_Send_duyet";
            this.btn_Send_duyet.Size = new System.Drawing.Size(203, 52);
            this.btn_Send_duyet.TabIndex = 8;
            this.btn_Send_duyet.Text = "Gửi lên PĐT";
            this.btn_Send_duyet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Send_duyet.UseVisualStyleBackColor = false;
            // 
            // GuiDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_view);
            this.Controls.Add(this.pnl_DScho);
            this.Name = "GuiDuyet";
            this.Text = "GuiDuyet";
            this.pnl_DScho.ResumeLayout(false);
            this.pnl_DScho.PerformLayout();
            this.pnl_view.ResumeLayout(false);
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_choduyet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DScho;
        private System.Windows.Forms.Panel pnl_view;
        private System.Windows.Forms.Label lbl_DScho;
        private FontAwesome.Sharp.IconButton btn_Send_duyet;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.DataGridView grd_choduyet;
    }
}