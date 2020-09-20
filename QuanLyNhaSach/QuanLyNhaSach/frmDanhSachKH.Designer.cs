namespace QuanLyNhaSach
{
    partial class frmDanhSachKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKH));
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnThan = new System.Windows.Forms.Panel();
            this.grpbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.dtrwKhachHang = new System.Windows.Forms.DataGridView();
            this.grpbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpbThongTinKH = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.mtxtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnTieuDe.SuspendLayout();
            this.pnThan.SuspendLayout();
            this.grpbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrwKhachHang)).BeginInit();
            this.grpbThaoTac.SuspendLayout();
            this.grpbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.Controls.Add(this.lblTieuDe);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(1503, 76);
            this.pnTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1503, 76);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DANH SÁCH KHÁCH HÀNG BOOKSTORE LUXURY";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnThan
            // 
            this.pnThan.Controls.Add(this.grpbDanhSachKH);
            this.pnThan.Controls.Add(this.grpbThaoTac);
            this.pnThan.Controls.Add(this.grpbThongTinKH);
            this.pnThan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThan.Location = new System.Drawing.Point(0, 76);
            this.pnThan.Name = "pnThan";
            this.pnThan.Size = new System.Drawing.Size(1503, 947);
            this.pnThan.TabIndex = 0;
            // 
            // grpbDanhSachKH
            // 
            this.grpbDanhSachKH.Controls.Add(this.dtrwKhachHang);
            this.grpbDanhSachKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbDanhSachKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDanhSachKH.ForeColor = System.Drawing.Color.Blue;
            this.grpbDanhSachKH.Location = new System.Drawing.Point(0, 320);
            this.grpbDanhSachKH.Name = "grpbDanhSachKH";
            this.grpbDanhSachKH.Size = new System.Drawing.Size(1503, 627);
            this.grpbDanhSachKH.TabIndex = 2;
            this.grpbDanhSachKH.TabStop = false;
            this.grpbDanhSachKH.Text = "Danh Sách Khách Hàng";
            // 
            // dtrwKhachHang
            // 
            this.dtrwKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtrwKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrwKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrwKhachHang.Location = new System.Drawing.Point(3, 30);
            this.dtrwKhachHang.Name = "dtrwKhachHang";
            this.dtrwKhachHang.RowTemplate.Height = 24;
            this.dtrwKhachHang.Size = new System.Drawing.Size(1497, 594);
            this.dtrwKhachHang.TabIndex = 1;
            this.dtrwKhachHang.SelectionChanged += new System.EventHandler(this.dtrwKhachHang_SelectionChanged);
            // 
            // grpbThaoTac
            // 
            this.grpbThaoTac.Controls.Add(this.btnSua);
            this.grpbThaoTac.Controls.Add(this.btnThoat);
            this.grpbThaoTac.Controls.Add(this.btnLuu);
            this.grpbThaoTac.Controls.Add(this.btnThem);
            this.grpbThaoTac.Controls.Add(this.btnXoa);
            this.grpbThaoTac.Controls.Add(this.btnTimKiem);
            this.grpbThaoTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbThaoTac.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbThaoTac.ForeColor = System.Drawing.Color.Blue;
            this.grpbThaoTac.Location = new System.Drawing.Point(0, 236);
            this.grpbThaoTac.Name = "grpbThaoTac";
            this.grpbThaoTac.Size = new System.Drawing.Size(1503, 711);
            this.grpbThaoTac.TabIndex = 1;
            this.grpbThaoTac.TabStop = false;
            this.grpbThaoTac.Text = "Thao Tác";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(708, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 45);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1086, 33);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 45);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(897, 33);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 45);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(330, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(519, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 45);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(6, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(259, 45);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "&Tìm Kiếm - Tra Cứu";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // grpbThongTinKH
            // 
            this.grpbThongTinKH.Controls.Add(this.txtGioiTinh);
            this.grpbThongTinKH.Controls.Add(this.mtxtNgaySinh);
            this.grpbThongTinKH.Controls.Add(this.lblNgaySinh);
            this.grpbThongTinKH.Controls.Add(this.lblDiaChi);
            this.grpbThongTinKH.Controls.Add(this.lblGioiTinh);
            this.grpbThongTinKH.Controls.Add(this.lblHoTenKH);
            this.grpbThongTinKH.Controls.Add(this.lblMaKH);
            this.grpbThongTinKH.Controls.Add(this.txtDiaChi);
            this.grpbThongTinKH.Controls.Add(this.txtHoTenKH);
            this.grpbThongTinKH.Controls.Add(this.txtMaKH);
            this.grpbThongTinKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbThongTinKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbThongTinKH.ForeColor = System.Drawing.Color.Blue;
            this.grpbThongTinKH.Location = new System.Drawing.Point(0, 0);
            this.grpbThongTinKH.Name = "grpbThongTinKH";
            this.grpbThongTinKH.Size = new System.Drawing.Size(1503, 236);
            this.grpbThongTinKH.TabIndex = 1;
            this.grpbThongTinKH.TabStop = false;
            this.grpbThongTinKH.Text = "Thông Tin Khách Hàng";
            this.grpbThongTinKH.Enter += new System.EventHandler(this.grpbThongTinKH_Enter);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(229, 165);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(373, 34);
            this.txtGioiTinh.TabIndex = 6;
            // 
            // mtxtNgaySinh
            // 
            this.mtxtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.mtxtNgaySinh.Location = new System.Drawing.Point(788, 103);
            this.mtxtNgaySinh.Mask = "00/00/0000";
            this.mtxtNgaySinh.Name = "mtxtNgaySinh";
            this.mtxtNgaySinh.Size = new System.Drawing.Size(375, 34);
            this.mtxtNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(653, 106);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(125, 26);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(653, 46);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(99, 26);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ:";
            this.lblDiaChi.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(9, 168);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(119, 26);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính:";
            this.lblGioiTinh.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHoTenKH
            // 
            this.lblHoTenKH.AutoSize = true;
            this.lblHoTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenKH.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenKH.Location = new System.Drawing.Point(9, 107);
            this.lblHoTenKH.Name = "lblHoTenKH";
            this.lblHoTenKH.Size = new System.Drawing.Size(195, 26);
            this.lblHoTenKH.TabIndex = 0;
            this.lblHoTenKH.Text = "Tên Khách Hàng:";
            this.lblHoTenKH.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.Color.Black;
            this.lblMaKH.Location = new System.Drawing.Point(9, 46);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(191, 26);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã Khách Hàng:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(788, 43);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(375, 34);
            this.txtDiaChi.TabIndex = 0;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenKH.Location = new System.Drawing.Point(228, 100);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(374, 34);
            this.txtHoTenKH.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.Location = new System.Drawing.Point(229, 46);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(374, 34);
            this.txtMaKH.TabIndex = 0;
            // 
            // frmDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 1023);
            this.Controls.Add(this.pnThan);
            this.Controls.Add(this.pnTieuDe);
            this.Name = "frmDanhSachKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachKH_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachKH_Load);
            this.pnTieuDe.ResumeLayout(false);
            this.pnThan.ResumeLayout(false);
            this.grpbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtrwKhachHang)).EndInit();
            this.grpbThaoTac.ResumeLayout(false);
            this.grpbThongTinKH.ResumeLayout(false);
            this.grpbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Panel pnThan;
        private System.Windows.Forms.GroupBox grpbThaoTac;
        private System.Windows.Forms.GroupBox grpbThongTinKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.DataGridView dtrwKhachHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpbDanhSachKH;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.MaskedTextBox mtxtNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTenKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}