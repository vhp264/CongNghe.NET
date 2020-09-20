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
    public partial class frmNhaCungCap : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        int chon = 0;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        void LoadDuLieuDataGNCC()
        {
            string strel = "SELECT * FROM NHACUNGCAP ORDER BY STT ASC";
            SqlDataAdapter da_NCC = new SqlDataAdapter(strel, conn);
            da_NCC.Fill(ds_QLNS, "NHACUNGCAP");
            dtgvDSNCC.DataSource = ds_QLNS.Tables["NHACUNGCAP"];
        }

        void vohieuhoatxt()
        {
            txtDiaChi.Enabled = false;
            txtMaNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNCC.Enabled = false;
            txtEmail.Enabled = false;
            txtDuongDan.Enabled = false;
        }

        void hieuhoatxt()
        {
            txtDiaChi.Enabled = true;
            txtMaNCC.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNCC.Enabled = true;
            txtEmail.Enabled = true;
            txtDuongDan.Enabled = true;
        }

        void cleartxt()
        {
            txtDiaChi.Clear();
            txtMaNCC.Clear();
            txtSDT.Clear();
            txtTenNCC.Clear();
            txtEmail.Clear();
            txtDuongDan.Clear();
        }

        void vohieuhoabtn()
        {
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false; btnUpload.Enabled = false;
        }

        void Databingding(DataTable pDT)
        {
            txtDiaChi.DataBindings.Clear();
            txtMaNCC.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtTenNCC.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDuongDan.DataBindings.Clear();

            txtDiaChi.DataBindings.Add("Text", pDT, "DiaChi", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaNCC.DataBindings.Add("Text", pDT, "MaNhaCungCap");
            txtSDT.DataBindings.Add("Text", pDT, "DienThoai");
            txtTenNCC.DataBindings.Add("Text", pDT, "TenNhaCungCap");
            txtEmail.DataBindings.Add("Text", pDT, "Email");
            txtDuongDan.DataBindings.Add("Text", pDT, "Anh");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtgvDSNCC.Enabled = true;
            chon = 1;
            btnLuu.Enabled = true;        
            

            //Cho phep them cac dong tiep theo datagridview
            dtgvDSNCC.AllowUserToAddRows = true;
            dtgvDSNCC.ReadOnly = false;

            dtgvDSNCC.ClearSelection();

            //Khong duoc sua cac dong tren dtrw da co du lieu
            for (int i = 0; i < dtgvDSNCC.Rows.Count - 1; i++)
            {
                dtgvDSNCC.Rows[i].ReadOnly = true;
            }

            dtgvDSNCC.FirstDisplayedScrollingRowIndex = dtgvDSNCC.Rows.Count - 1;
            btnXoa.Enabled = false; btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            foreach (DataGridViewCell oneCell in dtgvDSNCC.SelectedCells)
                if (oneCell.Selected)
                {
                    dtgvDSNCC.Rows.RemoveAt(oneCell.RowIndex);
                }
            chon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true; btnThem.Enabled = false; btnXoa.Enabled = false; btnUpload.Enabled = true;
            txtDiaChi.Enabled = true; txtEmail.Enabled = true; txtMaNCC.Enabled = true;
            txtSDT.Enabled = true; txtTenNCC.Enabled = true; txtMaNCC.Focus();

            //Cho phep sua cac thong tin tren datagrid
            dtgvDSNCC.ReadOnly = false;
            for (int i = 0; i < dtgvDSNCC.Rows.Count - 1; i++)
            {
                dtgvDSNCC.Rows[i].ReadOnly = false;
            }
            dtgvDSNCC.Columns[0].ReadOnly = true;

            chon = 3;
        }

        public void reload()
        {
            frmNhaCungCap newform = new frmNhaCungCap();
            newform.Show();
            this.Dispose(false);
        }

        private void dtgvDSNCC_SelectionChanged(object sender, EventArgs e)
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*)";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                    txtDuongDan.Text = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi, không chèn được ảnh !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void txtDuongDan_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = txtDuongDan.Text;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieuDataGNCC();
            dtgvDSNCC.ReadOnly = true; //Danh sach chi duoc doc
            dtgvDSNCC.AllowUserToAddRows = false;

            //Tat ca textbox bi vo hieu hoa
            vohieuhoatxt();

            //Các buuton xoa, sua, luu bi vo hieu hoa
            vohieuhoabtn();

            Databingding(ds_QLNS.Tables["NHACUNGCAP"]);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                try
                {
                    //dtgvDSNCC.Enabled = true;
                    //dtgvDSNCC.ReadOnly = false;
                    //dtgvDSNCC.Rows.Add("1", txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtDuongDan.Text);
                    //btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["NHACUNGCAP"]);
                    SqlDataAdapter da_NCC = new SqlDataAdapter("SELECT * FROM NHACUNGCAP ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_NCC);
                    da_NCC.Update(ds_QLNS, "NHACUNGCAP");
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
                    Databingding(ds_QLNS.Tables["NHACUNGCAP"]);
                    SqlDataAdapter da_NCC = new SqlDataAdapter("SELECT * FROM NHACUNGCAP ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_NCC);
                    da_NCC.Update(ds_QLNS, "NHACUNGCAP");
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
                    Databingding(ds_QLNS.Tables["NHACUNGCAP"]);
                    SqlDataAdapter da_NCC = new SqlDataAdapter("SELECT * FROM NHACUNGCAP ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_NCC);
                    da_NCC.Update(ds_QLNS, "NHACUNGCAP");
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
            dtgvDSNCC.ReadOnly = true;
            dtgvDSNCC.AllowUserToAddRows = false;

            chon = 0;
        }
    }
}
