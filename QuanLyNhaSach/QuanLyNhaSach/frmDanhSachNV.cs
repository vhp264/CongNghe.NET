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
    public partial class frmDanhSachNV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        int chon = 0;

        public frmDanhSachNV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmDanhSachNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        void LoadDuLieuDataGNV()
        {
            string strel = "SELECT * FROM NHANVIEN ORDER BY STT ASC";
            SqlDataAdapter da_NV = new SqlDataAdapter(strel, conn);
            da_NV.Fill(ds_QLNS, "NHANVIEN");
            dtgDSNV.DataSource = ds_QLNS.Tables["NHANVIEN"];
        }

        void vohieuhoatxt()
        {
            txtTenNV.Enabled = false;
            txtMaNV.Enabled = false;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtSĐT.Enabled = false;
            mtxtNgaySinh.Enabled = false;
        }

        void vohieuhoabtn()
        {
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        void Databingding(DataTable pDT)
        {
            txtTenNV.DataBindings.Clear();
            txtMaNV.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtSĐT.DataBindings.Clear();
            mtxtNgaySinh.DataBindings.Clear();

            txtTenNV.DataBindings.Add("Text", pDT, "TenNV");
            txtMaNV.DataBindings.Add("Text", pDT, "MaNV");
            txtChucVu.DataBindings.Add("Text", pDT, "ChucVu");
            txtDiaChi.DataBindings.Add("Text", pDT, "DiaChi");
            txtGioiTinh.DataBindings.Add("Text", pDT, "GT");
            txtSĐT.DataBindings.Add("Text", pDT, "SĐT");
            mtxtNgaySinh.DataBindings.Add("Text", pDT, "NgaySinh");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 1;
            btnLuu.Enabled = true;

            //Cho phep them cac dong tiep theo datagridview
            dtgDSNV.AllowUserToAddRows = true;
            dtgDSNV.ReadOnly = false;

            dtgDSNV.ClearSelection();

            //Khong duoc sua cac dong tren dtrw da co du lieu
            for (int i = 0; i < dtgDSNV.Rows.Count - 1; i++)
            {
                dtgDSNV.Rows[i].ReadOnly = true;
            }
            dtgDSNV.FirstDisplayedScrollingRowIndex = dtgDSNV.Rows.Count - 1;
            btnXoa.Enabled = false; btnSua.Enabled = false; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            foreach (DataGridViewCell oneCell in dtgDSNV.SelectedCells)
                if (oneCell.Selected)
                {
                    dtgDSNV.Rows.RemoveAt(oneCell.RowIndex);
                }
            chon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true; btnThem.Enabled = false; btnXoa.Enabled = false; 
            txtChucVu.Enabled = true; txtDiaChi.Enabled = true; txtGioiTinh.Enabled = true; txtMaNV.Enabled = true;
            txtSĐT.Enabled = true; txtTenNV.Enabled = true; mtxtNgaySinh.Enabled = true; txtMaNV.Focus();

            //Cho phep sua cac thong tin tren datagrid
            dtgDSNV.ReadOnly = false;
            for (int i = 0; i < dtgDSNV.Rows.Count - 1; i++)
            {
                dtgDSNV.Rows[i].ReadOnly = false;
            }
            dtgDSNV.Columns[0].ReadOnly = true;

            chon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                try
                {

                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["NHANVIEN"]);
                    SqlDataAdapter da_NV = new SqlDataAdapter("SELECT * FROM NHANVIEN ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_NV);
                    da_NV.Update(ds_QLNS, "NHANVIEN");
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
                    Databingding(ds_QLNS.Tables["NHANVIEN"]);
                    SqlDataAdapter da_NV = new SqlDataAdapter("SELECT * FROM NHANVIEN ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_NV);
                    da_NV.Update(ds_QLNS, "NHANVIEN");
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
                    Databingding(ds_QLNS.Tables["NHANVIEN"]);
                    SqlDataAdapter da_NV = new SqlDataAdapter("SELECT * FROM NHANVIEN ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_NV);
                    da_NV.Update(ds_QLNS, "NHANVIEN");
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
            dtgDSNV.ReadOnly = true;
            dtgDSNV.AllowUserToAddRows = false;

            chon = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgDSNV_SelectionChanged(object sender, EventArgs e)
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

        public void reload()
        {
            frmDanhSachNV newform = new frmDanhSachNV();
            newform.Show();
            this.Dispose(false);
        }

        private void frmDanhSachNV_Load(object sender, EventArgs e)
        {
            LoadDuLieuDataGNV();
            dtgDSNV.ReadOnly = true; //Danh sach chi duoc doc
            dtgDSNV.AllowUserToAddRows = false;

            //Tat ca textbox bi vo hieu hoa
            vohieuhoatxt();

            //Các buuton xoa, sua, luu bi vo hieu hoa
            vohieuhoabtn();

            Databingding(ds_QLNS.Tables["NHANVIEN"]);
        }

    }
}
