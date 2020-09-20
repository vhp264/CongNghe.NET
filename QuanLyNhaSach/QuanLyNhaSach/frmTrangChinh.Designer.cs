namespace QuanLyNhaSach
{
    partial class frmTrangChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaisachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhacungcapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieubansachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapsachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspTuyChon = new System.Windows.Forms.ToolStrip();
            this.tslbThongTinS = new System.Windows.Forms.ToolStripLabel();
            this.tslbNCC = new System.Windows.Forms.ToolStripLabel();
            this.tslbKhachHang = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslbPhieuBS = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtDong = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNStoolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tspTuyChon.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChuongTrinhToolStripMenuItem,
            this.DanhMucToolStripMenuItem,
            this.QuanLyToolStripMenuItem,
            this.BanHangToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.nhapsachToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChuongTrinhToolStripMenuItem
            // 
            this.ChuongTrinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangnhapToolStripMenuItem,
            this.dangxuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.ChuongTrinhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ChuongTrinhToolStripMenuItem.Image")));
            this.ChuongTrinhToolStripMenuItem.Name = "ChuongTrinhToolStripMenuItem";
            this.ChuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.ChuongTrinhToolStripMenuItem.Text = "Chương Trình";
            // 
            // dangnhapToolStripMenuItem
            // 
            this.dangnhapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangnhapToolStripMenuItem.Image")));
            this.dangnhapToolStripMenuItem.Name = "dangnhapToolStripMenuItem";
            this.dangnhapToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.dangnhapToolStripMenuItem.Text = "Đăng Nhập";
            this.dangnhapToolStripMenuItem.Click += new System.EventHandler(this.dangnhapToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangxuatToolStripMenuItem.Image")));
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.dangxuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem.Image")));
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // DanhMucToolStripMenuItem
            // 
            this.DanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sachToolStripMenuItem,
            this.loaisachToolStripMenuItem});
            this.DanhMucToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DanhMucToolStripMenuItem.Image")));
            this.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem";
            this.DanhMucToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.DanhMucToolStripMenuItem.Text = "Danh Mục";
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sachToolStripMenuItem.Image")));
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.sachToolStripMenuItem.Text = "Sách";
            this.sachToolStripMenuItem.Click += new System.EventHandler(this.sachToolStripMenuItem_Click);
            // 
            // loaisachToolStripMenuItem
            // 
            this.loaisachToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loaisachToolStripMenuItem.Image")));
            this.loaisachToolStripMenuItem.Name = "loaisachToolStripMenuItem";
            this.loaisachToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.loaisachToolStripMenuItem.Text = "Loại Sách";
            this.loaisachToolStripMenuItem.Click += new System.EventHandler(this.loaisachToolStripMenuItem_Click);
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachhangToolStripMenuItem,
            this.nhacungcapToolStripMenuItem,
            this.nhanvienToolStripMenuItem});
            this.QuanLyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("QuanLyToolStripMenuItem.Image")));
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.QuanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // khachhangToolStripMenuItem
            // 
            this.khachhangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khachhangToolStripMenuItem.Image")));
            this.khachhangToolStripMenuItem.Name = "khachhangToolStripMenuItem";
            this.khachhangToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.khachhangToolStripMenuItem.Text = "Khách Hàng";
            this.khachhangToolStripMenuItem.Click += new System.EventHandler(this.khachhangToolStripMenuItem_Click);
            // 
            // nhacungcapToolStripMenuItem
            // 
            this.nhacungcapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhacungcapToolStripMenuItem.Image")));
            this.nhacungcapToolStripMenuItem.Name = "nhacungcapToolStripMenuItem";
            this.nhacungcapToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.nhacungcapToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhacungcapToolStripMenuItem.Click += new System.EventHandler(this.nhacungcapToolStripMenuItem_Click);
            // 
            // nhanvienToolStripMenuItem
            // 
            this.nhanvienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanvienToolStripMenuItem.Image")));
            this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.nhanvienToolStripMenuItem.Text = "Nhân Viên";
            this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
            // 
            // BanHangToolStripMenuItem
            // 
            this.BanHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieubansachToolStripMenuItem});
            this.BanHangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BanHangToolStripMenuItem.Image")));
            this.BanHangToolStripMenuItem.Name = "BanHangToolStripMenuItem";
            this.BanHangToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.BanHangToolStripMenuItem.Text = "Bán Hàng";
            // 
            // phieubansachToolStripMenuItem
            // 
            this.phieubansachToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phieubansachToolStripMenuItem.Image")));
            this.phieubansachToolStripMenuItem.Name = "phieubansachToolStripMenuItem";
            this.phieubansachToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.phieubansachToolStripMenuItem.Text = "Phiếu Bán Sách";
            this.phieubansachToolStripMenuItem.Click += new System.EventHandler(this.phieubansachToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.registerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Image = global::QuanLyNhaSach.Properties.Resources.help;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::QuanLyNhaSach.Properties.Resources.help3;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeyDisplayString = "F1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Image = global::QuanLyNhaSach.Properties.Resources.register;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::QuanLyNhaSach.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // nhapsachToolStripMenuItem
            // 
            this.nhapsachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpSáchToolStripMenuItem});
            this.nhapsachToolStripMenuItem.Image = global::QuanLyNhaSach.Properties.Resources.add_bookmarks;
            this.nhapsachToolStripMenuItem.Name = "nhapsachToolStripMenuItem";
            this.nhapsachToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.nhapsachToolStripMenuItem.Text = "Nhập Sách";
            this.nhapsachToolStripMenuItem.Click += new System.EventHandler(this.nhapsachToolStripMenuItem_Click);
            // 
            // phiếuNhậpSáchToolStripMenuItem
            // 
            this.phiếuNhậpSáchToolStripMenuItem.Name = "phiếuNhậpSáchToolStripMenuItem";
            this.phiếuNhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.phiếuNhậpSáchToolStripMenuItem.Text = "Phiếu Nhập Sách";
            this.phiếuNhậpSáchToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpSáchToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Image = global::QuanLyNhaSach.Properties.Resources.statistics;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // tspTuyChon
            // 
            this.tspTuyChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbThongTinS,
            this.tslbNCC,
            this.tslbKhachHang,
            this.toolStripSeparator1,
            this.tslbPhieuBS,
            this.toolStripSeparator2,
            this.PNStoolStripLabel1,
            this.tsbtDong});
            this.tspTuyChon.Location = new System.Drawing.Point(0, 50);
            this.tspTuyChon.Name = "tspTuyChon";
            this.tspTuyChon.Size = new System.Drawing.Size(940, 73);
            this.tspTuyChon.TabIndex = 1;
            this.tspTuyChon.Text = "toolStrip1";
            // 
            // tslbThongTinS
            // 
            this.tslbThongTinS.Image = ((System.Drawing.Image)(resources.GetObject("tslbThongTinS.Image")));
            this.tslbThongTinS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslbThongTinS.Name = "tslbThongTinS";
            this.tslbThongTinS.Size = new System.Drawing.Size(110, 70);
            this.tslbThongTinS.Text = "Thông Tin Sách";
            this.tslbThongTinS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tslbThongTinS.Click += new System.EventHandler(this.tslbThongTinS_Click);
            // 
            // tslbNCC
            // 
            this.tslbNCC.Image = ((System.Drawing.Image)(resources.GetObject("tslbNCC.Image")));
            this.tslbNCC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslbNCC.Name = "tslbNCC";
            this.tslbNCC.Size = new System.Drawing.Size(104, 70);
            this.tslbNCC.Text = "Nhà Cung Cấp";
            this.tslbNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tslbNCC.Click += new System.EventHandler(this.tslbNCC_Click);
            // 
            // tslbKhachHang
            // 
            this.tslbKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tslbKhachHang.Image")));
            this.tslbKhachHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslbKhachHang.Name = "tslbKhachHang";
            this.tslbKhachHang.Size = new System.Drawing.Size(89, 70);
            this.tslbKhachHang.Text = "Khách Hàng";
            this.tslbKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tslbKhachHang.Click += new System.EventHandler(this.tslbKhachHang_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // tslbPhieuBS
            // 
            this.tslbPhieuBS.Image = ((System.Drawing.Image)(resources.GetObject("tslbPhieuBS.Image")));
            this.tslbPhieuBS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslbPhieuBS.Name = "tslbPhieuBS";
            this.tslbPhieuBS.Size = new System.Drawing.Size(109, 70);
            this.tslbPhieuBS.Text = "Phiếu Bán Sách";
            this.tslbPhieuBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tslbPhieuBS.Click += new System.EventHandler(this.tslbPhieuBS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // tsbtDong
            // 
            this.tsbtDong.AutoSize = false;
            this.tsbtDong.Image = ((System.Drawing.Image)(resources.GetObject("tsbtDong.Image")));
            this.tsbtDong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtDong.Name = "tsbtDong";
            this.tsbtDong.Size = new System.Drawing.Size(110, 60);
            this.tsbtDong.Text = "Đóng";
            this.tsbtDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtDong.Click += new System.EventHandler(this.tsbtDong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(43, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pass:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Crimson;
            this.txtID.Location = new System.Drawing.Point(128, 75);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 30);
            this.txtID.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Crimson;
            this.txtPass.Location = new System.Drawing.Point(128, 130);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(204, 30);
            this.txtPass.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Crimson;
            this.Login.Location = new System.Drawing.Point(128, 200);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(94, 34);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.Login);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 293);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(435, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 293);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PNStoolStripLabel1
            // 
            this.PNStoolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("PNStoolStripLabel1.Image")));
            this.PNStoolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PNStoolStripLabel1.Name = "PNStoolStripLabel1";
            this.PNStoolStripLabel1.Size = new System.Drawing.Size(120, 70);
            this.PNStoolStripLabel1.Text = "Phiếu Nhập Sách";
            this.PNStoolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PNStoolStripLabel1.Click += new System.EventHandler(this.PNStoolStripLabel1_Click);
            // 
            // frmTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tspTuyChon);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangChinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChinh_FormClosing);
            this.Load += new System.EventHandler(this.frmTrangChinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tspTuyChon.ResumeLayout(false);
            this.tspTuyChon.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChuongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangnhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaisachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachhangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhacungcapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieubansachToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tspTuyChon;
        private System.Windows.Forms.ToolStripLabel tslbThongTinS;
        private System.Windows.Forms.ToolStripLabel tslbNCC;
        private System.Windows.Forms.ToolStripLabel tslbKhachHang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslbPhieuBS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtDong;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapsachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel PNStoolStripLabel1;
    }
}