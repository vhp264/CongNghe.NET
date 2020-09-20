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
    public partial class frmDanhSachKH : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        int chon = 0;
        public frmDanhSachKH()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grpbThongTinKH_Enter(object sender, EventArgs e)
        {

        }

        private void frmDanhSachKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        void LoadDuLieuDataGKH()
        {
            string strel = "SELECT * FROM KHACHHANG ORDER BY STT ASC";
            SqlDataAdapter da_KHACHHANG = new SqlDataAdapter(strel, conn);
            da_KHACHHANG.Fill(ds_QLNS, "KHACHHANG");
            dtrwKhachHang.DataSource = ds_QLNS.Tables["KHACHHANG"];
        }

        void vohieuhoatxt()
        {
            txtDiaChi.Enabled = false;
            txtHoTenKH.Enabled = false;
            txtMaKH.Enabled = false;
            mtxtNgaySinh.Enabled = false;
            txtGioiTinh.Enabled = false;
        }

        void vohieuhoabtn()
        {
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        void Databingding(DataTable pDT)
        {
            txtDiaChi.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtHoTenKH.DataBindings.Clear();
            txtMaKH.DataBindings.Clear();
            mtxtNgaySinh.DataBindings.Clear();

            txtDiaChi.DataBindings.Add("Text", pDT, "DiaChi");
            txtGioiTinh.DataBindings.Add("Text", pDT, "GT");
            txtHoTenKH.DataBindings.Add("Text", pDT, "TenKH");
            txtMaKH.DataBindings.Add("Text", pDT, "MaKH");
            mtxtNgaySinh.DataBindings.Add("Text", pDT, "NgaySinh");
        }

        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            LoadDuLieuDataGKH();
            dtrwKhachHang.ReadOnly = true; //Danh sach chi duoc doc
            dtrwKhachHang.AllowUserToAddRows = false;

            //Tat ca textbox bi vo hieu hoa
            vohieuhoatxt();

            //Các buuton xoa, sua, luu bi vo hieu hoa
            vohieuhoabtn();

            Databingding(ds_QLNS.Tables["KHACHHANG"]);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtrwKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else if (chon == 3)
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else if (chon == 2)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 1;
            btnLuu.Enabled = true;

            //Cho phep them cac dong tiep theo datagridview
            dtrwKhachHang.AllowUserToAddRows = true;
            dtrwKhachHang.ReadOnly = false;

            dtrwKhachHang.ClearSelection();

            //Khong duoc sua cac dong tren dtrw da co du lieu
            for (int i = 0; i < dtrwKhachHang.Rows.Count - 1; i++)
            {
                dtrwKhachHang.Rows[i].ReadOnly = true;
            }
            dtrwKhachHang.FirstDisplayedScrollingRowIndex = dtrwKhachHang.Rows.Count - 1;
            btnXoa.Enabled = false; btnSua.Enabled = false; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            foreach (DataGridViewCell oneCell in dtrwKhachHang.SelectedCells)
                if (oneCell.Selected)
                {
                    dtrwKhachHang.Rows.RemoveAt(oneCell.RowIndex);
                }
            chon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true; btnThem.Enabled = false; btnXoa.Enabled = false;
            txtMaKH.Enabled = true; txtHoTenKH.Enabled = true; txtDiaChi.Enabled = true;
            txtGioiTinh.Enabled = true; mtxtNgaySinh.Enabled = true; 
            txtMaKH.Focus();

            //Cho phep sua cac thong tin tren datagrid
            dtrwKhachHang.ReadOnly = false;
            for (int i = 0; i < dtrwKhachHang.Rows.Count - 1; i++)
            {
                dtrwKhachHang.Rows[i].ReadOnly = false;
            }
            dtrwKhachHang.Columns[0].ReadOnly = true;

            chon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                try
                {

                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["KHACHHANG"]);
                    SqlDataAdapter da_KHACHHANG = new SqlDataAdapter("SELECT * FROM KHACHHANG ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_KHACHHANG);
                    da_KHACHHANG.Update(ds_QLNS, "KHACHHANG");
                    MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Đã tồn tại mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (chon == 2)
            {
                try
                {
                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["KHACHHANG"]);
                    SqlDataAdapter da_KHACHHANG = new SqlDataAdapter("SELECT * FROM KHACHHANG ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_KHACHHANG);
                    da_KHACHHANG.Update(ds_QLNS, "KHACHHANG");
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (chon == 3)
            {
                try
                {
                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["KHACHHANG"]);
                    SqlDataAdapter da_KHACHHANG = new SqlDataAdapter("SELECT * FROM KHACHHANG ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_KHACHHANG);
                    da_KHACHHANG.Update(ds_QLNS, "KHACHHANG");
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại, trùng mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            reload();
            vohieuhoatxt();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dtrwKhachHang.ReadOnly = true;
            dtrwKhachHang.AllowUserToAddRows = false;

            chon = 0;
        }

        public void reload()
        {
            frmDanhSachKH newform = new frmDanhSachKH();
            newform.Show();
            this.Dispose(false);
        }
    }
}
