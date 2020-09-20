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
    public partial class frmLoaiSach : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        int chon = 0;
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoaiSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        void fixsize()
        {
            dtrwLoaiSach.Columns[0].FillWeight = 25;
            dtrwLoaiSach.Columns[1].FillWeight = 40;
        }

        void loadDuLieuDataGLoaiSach()
        {
            string strel = "SELECT * FROM LOAISACH ORDER BY STT ASC";
            SqlDataAdapter da_LOAISACH = new SqlDataAdapter(strel, conn);
            da_LOAISACH.Fill(ds_QLNS, "LOAISACH");
            dtrwLoaiSach.DataSource = ds_QLNS.Tables["LOAISACH"];
        }

        void vohieuhoatxt()
        {
            txtMaLoaiSach.Enabled = false;
            txtTenLoaiSach.Enabled = false;
        }

        void vohieuhoabtn()
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void Databingding(DataTable pDT)
        {
            txtTenLoaiSach.DataBindings.Clear();
            txtMaLoaiSach.DataBindings.Clear();

            txtMaLoaiSach.DataBindings.Add("Text", pDT, "MaLoai");
            txtTenLoaiSach.DataBindings.Add("Text", pDT, "TenLoai");
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            loadDuLieuDataGLoaiSach();
            fixsize();
            vohieuhoatxt();
            vohieuhoabtn();
            dtrwLoaiSach.ReadOnly = true;
            dtrwLoaiSach.AllowUserToAddRows = false;

            Databingding(ds_QLNS.Tables["LOAISACH"]);
        }

        private void dtrwLoaiSach_SelectionChanged(object sender, EventArgs e)
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
            dtrwLoaiSach.AllowUserToAddRows = true;
            dtrwLoaiSach.ReadOnly = false;

            dtrwLoaiSach.ClearSelection();

            //Khong duoc sua cac dong tren dtrw da co du lieu
            for (int i = 0; i < dtrwLoaiSach.Rows.Count - 1; i++)
            {
                dtrwLoaiSach.Rows[i].ReadOnly = true;
            }
            dtrwLoaiSach.FirstDisplayedScrollingRowIndex = dtrwLoaiSach.Rows.Count - 1;
            btnXoa.Enabled = false; btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {        
            btnLuu.Enabled = true;
            foreach (DataGridViewCell oneCell in dtrwLoaiSach.SelectedCells)
                if (oneCell.Selected)
                    {
                        try
                        {
                            dtrwLoaiSach.Rows.RemoveAt(oneCell.RowIndex);
                        }
                        catch {
                            MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            chon = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {          
            btnLuu.Enabled = true; btnThem.Enabled = false; btnXoa.Enabled = false;
            txtMaLoaiSach.Enabled = true; txtTenLoaiSach.Enabled = true; txtMaLoaiSach.Focus();

            dtrwLoaiSach.ReadOnly = false;
            for (int i = 0; i < dtrwLoaiSach.Rows.Count - 1; i++)
            {
                dtrwLoaiSach.Rows[i].ReadOnly = false;
            }
            dtrwLoaiSach.Columns[0].ReadOnly = true;
            chon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                try
                {

                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["LOAISACH"]);
                    SqlDataAdapter da_LoaiSach = new SqlDataAdapter("SELECT * FROM LOAISACH ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_LoaiSach);
                    da_LoaiSach.Update(ds_QLNS, "LOAISACH");
                    MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                catch {
                    MessageBox.Show("Đã tồn tại mã loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (chon == 2)
            {
                try
                {
                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["LOAISACH"]);
                    SqlDataAdapter da_LoaiSach = new SqlDataAdapter("SELECT * FROM LOAISACH ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_LoaiSach);
                    da_LoaiSach.Update(ds_QLNS, "LOAISACH");
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                     MessageBox.Show("Xóa thất bại, đang có sách thuộc loại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (chon == 3)
            {
                try
                {
                    btnLuu.Enabled = false;
                    Databingding(ds_QLNS.Tables["LOAISACH"]);
                    SqlDataAdapter da_LoaiSach = new SqlDataAdapter("SELECT * FROM LOAISACH ORDER BY STT ASC", conn);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_LoaiSach);
                    da_LoaiSach.Update(ds_QLNS, "LOAISACH");
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại, trùng mã hoặc tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            vohieuhoatxt();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            dtrwLoaiSach.ReadOnly = true;
            dtrwLoaiSach.AllowUserToAddRows = false;
     
            chon = 0;
            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmLoaiSach newform = new frmLoaiSach();
            newform.Show();
            this.Dispose(false);
            //int dem = dtrwLoaiSach.Rows.Count;
            //for (int i = 0; i < dem; i++)
            //    dtrwLoaiSach.Rows.RemoveAt(0);
            //////dtrwLoaiSach.DataSource = null;
            //////dtrwLoaiSach.Rows.Clear();
            ////dtrwLoaiSach.Refresh();
            //loadDuLieuDataGLoaiSach();
            ////fixsize();
            ////vohieuhoatxt();
            ////vohieuhoabtn();
            ////dtrwLoaiSach.ReadOnly = true;
            ////dtrwLoaiSach.AllowUserToAddRows = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
