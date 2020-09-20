namespace QuanLyNhaSach
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.pnThan = new System.Windows.Forms.Panel();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblHienThiMK = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.pnTieuDe.SuspendLayout();
            this.pnThan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.Controls.Add(this.lblDangKy);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(583, 70);
            this.pnTieuDe.TabIndex = 2;
            // 
            // lblDangKy
            // 
            this.lblDangKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDangKy.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKy.ForeColor = System.Drawing.Color.Blue;
            this.lblDangKy.Location = new System.Drawing.Point(0, 0);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(583, 70);
            this.lblDangKy.TabIndex = 2;
            this.lblDangKy.Text = "ĐĂNG NHẬP";
            this.lblDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnThan
            // 
            this.pnThan.Controls.Add(this.btnNhapLai);
            this.pnThan.Controls.Add(this.btnDangNhap);
            this.pnThan.Controls.Add(this.lblMatKhau);
            this.pnThan.Controls.Add(this.lblTenDN);
            this.pnThan.Controls.Add(this.lblHienThiMK);
            this.pnThan.Controls.Add(this.txtMatKhau);
            this.pnThan.Controls.Add(this.txtTenDN);
            this.pnThan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThan.Location = new System.Drawing.Point(0, 70);
            this.pnThan.Name = "pnThan";
            this.pnThan.Size = new System.Drawing.Size(583, 285);
            this.pnThan.TabIndex = 2;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Location = new System.Drawing.Point(326, 190);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(142, 48);
            this.btnNhapLai.TabIndex = 7;
            this.btnNhapLai.Text = "&Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(95, 190);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(142, 48);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng &Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(12, 93);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(126, 26);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(12, 16);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(180, 26);
            this.lblTenDN.TabIndex = 3;
            this.lblTenDN.Text = "Tên Đăng Nhập:";
            // 
            // lblHienThiMK
            // 
            this.lblHienThiMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiMK.Image = ((System.Drawing.Image)(resources.GetObject("lblHienThiMK.Image")));
            this.lblHienThiMK.Location = new System.Drawing.Point(528, 86);
            this.lblHienThiMK.Name = "lblHienThiMK";
            this.lblHienThiMK.Size = new System.Drawing.Size(38, 34);
            this.lblHienThiMK.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(207, 86);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(315, 34);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(207, 13);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(315, 34);
            this.txtTenDN.TabIndex = 6;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 355);
            this.Controls.Add(this.pnThan);
            this.Controls.Add(this.pnTieuDe);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.pnTieuDe.ResumeLayout(false);
            this.pnThan.ResumeLayout(false);
            this.pnThan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Panel pnThan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblHienThiMK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

