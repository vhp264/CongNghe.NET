using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach
{
    public partial class frmTrangChinh : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");       
        public int id = 0;
        public void showtt()
        {
            tspTuyChon.Enabled = true;
            DanhMucToolStripMenuItem.Enabled = true;
            QuanLyToolStripMenuItem.Enabled = true;
            BanHangToolStripMenuItem.Enabled = true;
            thốngKêToolStripMenuItem.Enabled = true;
        }
        public frmTrangChinh()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tslbPhieuMS_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmTrangChinh_Load(object sender, EventArgs e)
        {
            //PictureBox pb = new PictureBox();
            //pb.Image = Image.FromFile(@"D:\DuyThaiIT\Công Nghệ .NET\DeTaiNhom_QuanLyNhaSach\QuanLyNhaSach\QuanLyNhaSach\Icon\homeslide8.png");
            //pb.SizeMode = PictureBoxSizeMode.AutoSize;
            //this.Controls.Add(pb);
            //this.Size = pb.Size;
            dangxuatToolStripMenuItem.Enabled = false;
            pictureBox1.ImageLocation = @"C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\QuanLyNhaSach\QuanLyNhaSach\Icon\homeslide8.png";
            AnTT();
            panel2.Enabled = false; 
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSach formtts = new frmThongTinSach();
            formtts.Show();
        }

        private void loaisachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSach formls = new frmLoaiSach();
            formls.Show();
        }

        private void tslbNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap formncc = new frmNhaCungCap();
            formncc.Show();
        }

        private void tslbKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhSachKH formkh = new frmDanhSachKH();
            formkh.Show();
        }

        private void tslbPhieuBS_Click(object sender, EventArgs e)
        {
            frmPhieuBanSach formpbs = new frmPhieuBanSach();
            formpbs.Show();
        }

        private void tsbtDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                e.Cancel = true;
        }

        private void khachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachKH formkh = new frmDanhSachKH();
            formkh.Show();
        }

        private void nhacungcapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap formncc = new frmNhaCungCap();
            formncc.Show();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien formnv = new frmNhanVien();
            formnv.Show();
        }

        private void phieubansachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuBanSach formpbs = new frmPhieuBanSach();
            formpbs.Show();
        }

        private void tslbThongTinS_Click(object sender, EventArgs e)
        {
            frmThongTinSach formpbs = new frmThongTinSach();
            formpbs.Show();
        }

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            
        }

        public void AnTT()
        {
            tspTuyChon.Enabled = false;
            DanhMucToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            BanHangToolStripMenuItem.Enabled = false;
            thốngKêToolStripMenuItem.Enabled = false;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Nhập lại tên đăng nhập");
                txtID.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Nhập lại mật khẩu");
                txtPass.Focus();
                return;
            }
            string id = txtID.Text;
            string pass = txtPass.Text;
            if (String.Compare(id, "admin", true) == 0 && String.Compare(pass, "10101999", true) == 0)
            {
                showtt();

                txtID.Enabled = false;
                txtPass.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                Login.Enabled = false;
                dangxuatToolStripMenuItem.Enabled = true;
                MessageBox.Show("Bạn Đã Đăng Nhập Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else if (String.Compare(id, "nhanvien", true) == 0 && String.Compare(pass, "123456", true) == 0)
            {
                BanHangToolStripMenuItem.Enabled = true;
                tslbPhieuBS.Enabled = true;
                helpToolStripMenuItem1.Enabled = true;
                DanhMucToolStripMenuItem.Enabled = true;
                tslbThongTinS.Enabled = true;
                tslbPhieuBS.Enabled = true;

                txtID.Enabled = false;
                txtPass.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                Login.Enabled = false;
                dangxuatToolStripMenuItem.Enabled = true;
                MessageBox.Show("Bạn Đã Đăng Nhập Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else if (String.Compare(id, "kiemsach", true) == 0 && String.Compare(pass, "123456", true) == 0)
            {
                tslbThongTinS.Enabled = true;
                DanhMucToolStripMenuItem.Enabled = true;
                helpToolStripMenuItem1.Enabled = true;
                nhapsachToolStripMenuItem.Enabled = true;

                txtID.Enabled = false;
                txtPass.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                Login.Enabled = false;
                dangxuatToolStripMenuItem.Enabled = true;
                MessageBox.Show("Bạn Đã Đăng Nhập Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                txtID.Text = txtPass.Text = "";
                txtID.Focus();
            }

        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes) {
                frmTrangChinh a = new frmTrangChinh();
                a.Show();
                this.Dispose(false);
            }

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportHoaDon rpt = new frmReportHoaDon();
            rpt.Show();
        }

        private void nhapsachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhapSach formpns = new frmPhieuNhapSach();
            formpns.Show();
        }

        private void PNStoolStripLabel1_Click(object sender, EventArgs e)
        {
            frmPhieuNhapSach formpns = new frmPhieuNhapSach();
            formpns.Show();
        }
    }
}
