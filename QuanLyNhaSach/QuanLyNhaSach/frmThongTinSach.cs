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
    public partial class frmThongTinSach : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        int chon = 0;
        public frmThongTinSach()
        {
            InitializeComponent();
        }

        private void pnThongTinSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            LoadDuLieuDataGSach();
            fixSize();
            dtrwDanhSach.ReadOnly = true; //Danh sach chi duoc doc
            dtrwDanhSach.AllowUserToAddRows = false;

            //Tat ca textbox bi vo hieu hoa
            vohieuhoatxt();

            //Các buuton xoa, sua, luu bi vo hieu hoa
            vohieuhoabtn();

            Databingding(ds_QLNS.Tables["SACH"]);
        }

        private void frmThongTinSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void LoadDuLieuDataGSach()
        {
            string strel = "SELECT * FROM SACH ORDER BY STT ASC";
            SqlDataAdapter da_SACH = new SqlDataAdapter(strel, conn);
            da_SACH.Fill(ds_QLNS, "SACH");
            dtrwDanhSach.DataSource = ds_QLNS.Tables["SACH"];
        }

        void fixSize()
        {
            dtrwDanhSach.Columns[0].FillWeight = 45;
            dtrwDanhSach.Columns[1].FillWeight = 70;
            dtrwDanhSach.Columns[2].FillWeight = 250;
            dtrwDanhSach.Columns[6].FillWeight = 70;

        }

        void vohieuhoatxt()
        {
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtTheLoai.Enabled = false;
            txtTacGia.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuongCon.Enabled = false;
            txtNamXB.Enabled = false;
            txtNhaXB.Enabled = false;
            txtDuongDan.Enabled= false;
        }

        void vohieuhoabtn()
        {
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false; btnUpLoad.Enabled = false;
        }

        void Databingding(DataTable pDT)
        {
            txtMaSach.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            txtTheLoai.DataBindings.Clear();
            txtTacGia.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtSoLuongCon.DataBindings.Clear();
            txtNamXB.DataBindings.Clear();
            txtNhaXB.DataBindings.Clear();
            txtDuongDan.DataBindings.Clear();

            txtMaSach.DataBindings.Add("Text", pDT, "MaSach");
            txtTenSach.DataBindings.Add("Text", pDT, "TenSach");
            txtTheLoai.DataBindings.Add("Text", pDT, "MaLoai");
            txtTacGia.DataBindings.Add("Text", pDT, "TacGia");
            txtDonGia.DataBindings.Add("Text", pDT, "DonGia");
            txtSoLuongCon.DataBindings.Add("Text", pDT, "SL");
            txtNamXB.DataBindings.Add("Text", pDT, "NamXuatBan");
            txtNhaXB.DataBindings.Add("Text", pDT, "NhaXuatBan");
            txtDuongDan.DataBindings.Add("Text", pDT, "Anh");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 1;
            btnLuu.Enabled = true;
            
            //Cho phep them cac dong tiep theo datagridview
            dtrwDanhSach.AllowUserToAddRows = true;
            dtrwDanhSach.ReadOnly = false;

            dtrwDanhSach.ClearSelection();
            
            //Khong duoc sua cac dong tren dtrw da co du lieu
            for (int i = 0; i < dtrwDanhSach.Rows.Count - 1; i++)
            {
                dtrwDanhSach.Rows[i].ReadOnly = true;
            }
            dtrwDanhSach.FirstDisplayedScrollingRowIndex = dtrwDanhSach.Rows.Count - 1;
            btnXoa.Enabled = false; btnSua.Enabled = false; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            foreach (DataGridViewCell oneCell in dtrwDanhSach.SelectedCells)
                if (oneCell.Selected)
                {
                        dtrwDanhSach.Rows.RemoveAt(oneCell.RowIndex);
                }
            chon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true; btnThem.Enabled = false; btnXoa.Enabled = false; btnUpLoad.Enabled = true;
            txtMaSach.Enabled = true; txtDonGia.Enabled = true; txtNamXB.Enabled = true; txtDuongDan.Enabled = true;
            txtNhaXB.Enabled = true; txtSoLuongCon.Enabled = true; txtTacGia.Enabled = true;
            txtTenSach.Enabled = true; txtTheLoai.Enabled = true; txtMaSach.Focus();

            //Cho phep sua cac thong tin tren datagrid
            dtrwDanhSach.ReadOnly = false;
            for (int i = 0; i < dtrwDanhSach.Rows.Count - 1; i++)
            {
                dtrwDanhSach.Rows[i].ReadOnly = false;
            }
            dtrwDanhSach.Columns[0].ReadOnly = true;

            chon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                try
                {

                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["SACH"]);
                    SqlDataAdapter da_Sach = new SqlDataAdapter("SELECT * FROM SACH ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_Sach);
                    da_Sach.Update(ds_QLNS, "SACH");
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
                    Databingding(ds_QLNS.Tables["SACH"]);
                    SqlDataAdapter da_Sach = new SqlDataAdapter("SELECT * FROM SACH ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_Sach);
                    da_Sach.Update(ds_QLNS, "SACH");
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
                    Databingding(ds_QLNS.Tables["SACH"]);
                    SqlDataAdapter da_Sach = new SqlDataAdapter("SELECT * FROM SACH ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_Sach);
                    da_Sach.Update(ds_QLNS, "SACH");
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
            dtrwDanhSach.ReadOnly = true;
            dtrwDanhSach.AllowUserToAddRows = false;

            chon = 0;
            
        }

        private void dtrwDanhSach_SelectionChanged(object sender, EventArgs e)
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
            frmThongTinSach newform = new frmThongTinSach();
            newform.Show();
            this.Dispose(false);
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*)";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
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
            image1.ImageLocation = txtDuongDan.Text;
        }
    }
}
