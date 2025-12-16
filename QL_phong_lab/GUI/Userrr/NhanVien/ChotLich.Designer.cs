namespace QL_phong_lab
{
    partial class ChotLich
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Chot = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Chot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 407);
            this.panel2.TabIndex = 1;
            // 
            // lbl_Chot
            // 
            this.lbl_Chot.AutoSize = true;
            this.lbl_Chot.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chot.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_Chot.Location = new System.Drawing.Point(281, 5);
            this.lbl_Chot.Name = "lbl_Chot";
            this.lbl_Chot.Size = new System.Drawing.Size(238, 32);
            this.lbl_Chot.TabIndex = 0;
            this.lbl_Chot.Text = "Chi Tiết Lịch Chốt";
            // 
            // ChotLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChotLich";
            this.Text = "ChotLich";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Chot;
        private System.Windows.Forms.Panel panel2;
    }
}