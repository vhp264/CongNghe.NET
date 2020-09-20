namespace QuanLyNhaSach
{
    partial class frmLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSach));
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.pnDanhSachLoai = new System.Windows.Forms.Panel();
            this.grpbDanhSachLoai = new System.Windows.Forms.GroupBox();
            this.dtrwLoaiSach = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbThongTinLoai = new System.Windows.Forms.GroupBox();
            this.lblTenLoaiSach = new System.Windows.Forms.Label();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.lblMaLoaiSach = new System.Windows.Forms.Label();
            this.pnTieuDe.SuspendLayout();
            this.pnDanhSachLoai.SuspendLayout();
            this.grpbDanhSachLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrwLoaiSach)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpbThaoTac.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpbThongTinLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.Controls.Add(this.lblLoaiSach);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(1264, 76);
            this.pnTieuDe.TabIndex = 0;
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoaiSach.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSach.ForeColor = System.Drawing.Color.Blue;
            this.lblLoaiSach.Location = new System.Drawing.Point(0, 0);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(1264, 76);
            this.lblLoaiSach.TabIndex = 0;
            this.lblLoaiSach.Text = "DANH MỤC LOẠI SÁCH";
            this.lblLoaiSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDanhSachLoai
            // 
            this.pnDanhSachLoai.Controls.Add(this.grpbDanhSachLoai);
            this.pnDanhSachLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhSachLoai.Location = new System.Drawing.Point(0, 76);
            this.pnDanhSachLoai.Name = "pnDanhSachLoai";
            this.pnDanhSachLoai.Size = new System.Drawing.Size(1264, 470);
            this.pnDanhSachLoai.TabIndex = 0;
            // 
            // grpbDanhSachLoai
            // 
            this.grpbDanhSachLoai.Controls.Add(this.dtrwLoaiSach);
            this.grpbDanhSachLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDanhSachLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDanhSachLoai.ForeColor = System.Drawing.Color.Blue;
            this.grpbDanhSachLoai.Location = new System.Drawing.Point(0, 0);
            this.grpbDanhSachLoai.Name = "grpbDanhSachLoai";
            this.grpbDanhSachLoai.Size = new System.Drawing.Size(1264, 470);
            this.grpbDanhSachLoai.TabIndex = 0;
            this.grpbDanhSachLoai.TabStop = false;
            this.grpbDanhSachLoai.Text = "Danh Sách Loại Sách";
            // 
            // dtrwLoaiSach
            // 
            this.dtrwLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtrwLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrwLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrwLoaiSach.Location = new System.Drawing.Point(3, 30);
            this.dtrwLoaiSach.Name = "dtrwLoaiSach";
            this.dtrwLoaiSach.RowTemplate.Height = 24;
            this.dtrwLoaiSach.Size = new System.Drawing.Size(1258, 437);
            this.dtrwLoaiSach.TabIndex = 0;
            this.dtrwLoaiSach.SelectionChanged += new System.EventHandler(this.dtrwLoaiSach_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(720, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 470);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpbThaoTac);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 220);
            this.panel2.TabIndex = 0;
            // 
            // grpbThaoTac
            // 
            this.grpbThaoTac.Controls.Add(this.btnSua);
            this.grpbThaoTac.Controls.Add(this.btnLuu);
            this.grpbThaoTac.Controls.Add(this.btnThoat);
            this.grpbThaoTac.Controls.Add(this.btnTaoMoi);
            this.grpbThaoTac.Controls.Add(this.btnXoa);
            this.grpbThaoTac.Controls.Add(this.btnThem);
            this.grpbThaoTac.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbThaoTac.ForeColor = System.Drawing.Color.Blue;
            this.grpbThaoTac.Location = new System.Drawing.Point(3, 3);
            this.grpbThaoTac.Name = "grpbThaoTac";
            this.grpbThaoTac.Size = new System.Drawing.Size(530, 184);
            this.grpbThaoTac.TabIndex = 0;
            this.grpbThaoTac.TabStop = false;
            this.grpbThaoTac.Text = "Thao Tác";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(382, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 51);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(194, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 51);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(381, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 51);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.Black;
            this.btnTaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.Image")));
            this.btnTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoMoi.Location = new System.Drawing.Point(6, 127);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(157, 51);
            this.btnTaoMoi.TabIndex = 0;
            this.btnTaoMoi.Text = "Tạo &Mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(194, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 51);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(6, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpbThongTinLoai);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 238);
            this.panel1.TabIndex = 0;
            // 
            // grpbThongTinLoai
            // 
            this.grpbThongTinLoai.Controls.Add(this.lblTenLoaiSach);
            this.grpbThongTinLoai.Controls.Add(this.txtTenLoaiSach);
            this.grpbThongTinLoai.Controls.Add(this.txtMaLoaiSach);
            this.grpbThongTinLoai.Controls.Add(this.lblMaLoaiSach);
            this.grpbThongTinLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbThongTinLoai.ForeColor = System.Drawing.Color.Blue;
            this.grpbThongTinLoai.Location = new System.Drawing.Point(3, 3);
            this.grpbThongTinLoai.Name = "grpbThongTinLoai";
            this.grpbThongTinLoai.Size = new System.Drawing.Size(532, 184);
            this.grpbThongTinLoai.TabIndex = 0;
            this.grpbThongTinLoai.TabStop = false;
            this.grpbThongTinLoai.Text = "Thông Tin Loại Sách";
            // 
            // lblTenLoaiSach
            // 
            this.lblTenLoaiSach.AutoSize = true;
            this.lblTenLoaiSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.lblTenLoaiSach.Location = new System.Drawing.Point(23, 117);
            this.lblTenLoaiSach.Name = "lblTenLoaiSach";
            this.lblTenLoaiSach.Size = new System.Drawing.Size(167, 26);
            this.lblTenLoaiSach.TabIndex = 0;
            this.lblTenLoaiSach.Text = "Tên Loại Sách:";
            this.lblTenLoaiSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSach.Location = new System.Drawing.Point(196, 114);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(328, 34);
            this.txtTenLoaiSach.TabIndex = 1;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiSach.Location = new System.Drawing.Point(196, 46);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(328, 34);
            this.txtMaLoaiSach.TabIndex = 1;
            // 
            // lblMaLoaiSach
            // 
            this.lblMaLoaiSach.AutoSize = true;
            this.lblMaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.lblMaLoaiSach.Location = new System.Drawing.Point(27, 49);
            this.lblMaLoaiSach.Name = "lblMaLoaiSach";
            this.lblMaLoaiSach.Size = new System.Drawing.Size(163, 26);
            this.lblMaLoaiSach.TabIndex = 0;
            this.lblMaLoaiSach.Text = "Mã Loại Sách:";
            this.lblMaLoaiSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 546);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnDanhSachLoai);
            this.Controls.Add(this.pnTieuDe);
            this.Name = "frmLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiSach_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiSach_Load);
            this.pnTieuDe.ResumeLayout(false);
            this.pnDanhSachLoai.ResumeLayout(false);
            this.grpbDanhSachLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtrwLoaiSach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpbThaoTac.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpbThongTinLoai.ResumeLayout(false);
            this.grpbThongTinLoai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Panel pnDanhSachLoai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label lblMaLoaiSach;
        private System.Windows.Forms.GroupBox grpbDanhSachLoai;
        private System.Windows.Forms.GroupBox grpbThaoTac;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbThongTinLoai;
        private System.Windows.Forms.Label lblLoaiSach;
        private System.Windows.Forms.Label lblTenLoaiSach;
        private System.Windows.Forms.DataGridView dtrwLoaiSach;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
    }
}