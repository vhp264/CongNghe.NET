using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmPhieuBanSach : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        int tongtien = 0;
        public frmPhieuBanSach()
        {
            InitializeComponent();
        }

        private void lstVDSS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnDanhSachMua_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public void updateToDB(string strSQL)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            closeConnection();
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }

        private void frmPhieuBanSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        public void loadCombobox_MaKH()
        {         
            string strsel = "SELECT * FROM KHACHHANG";
            SqlDataAdapter da_KH = new SqlDataAdapter(strsel, conn);
            da_KH.Fill(ds_QLNS, "MaKH");
            cboMaKH.DataSource = ds_QLNS.Tables["MaKH"];
            cboMaKH.DisplayMember = "MaKH";
        }

        public void loadCombobox_NV()
        { 
            string strsel = "SELECT * FROM NHANVIEN WHERE ChucVu = N'Quản lý' OR ChucVu = N'Thu ngân'";
            SqlDataAdapter da_KH = new SqlDataAdapter(strsel, conn);
            da_KH.Fill(ds_QLNS, "MaNV");
            cboMaNV.DataSource = ds_QLNS.Tables["MaNV"];
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = 1;
        }

        private void frmPhieuBanSach_Load(object sender, EventArgs e)
        {
            loadCombobox_MaKH();
            loadCombobox_NV();
            vohieuhoatxt();
            vohieuhoabtn();
        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string strsel = "SELECT * FROM KHACHHANG WHERE MaKH = '" + cboMaKH.Text.ToString() + "'";
            SqlDataReader dr = getDataReader(strsel);
            while (dr.Read())
            {
                txtHoTenKH.Text = (dr["TenKH"]).ToString();
                txtGioiTinh.Text = (dr["GT"]).ToString();
                mtxtNgaySinh.Text = (dr["NgaySinh"]).ToString();
                txtDiaChi.Text = (dr["DiaChi"]).ToString();
                txtMaKH2.Text = (dr["MaKH"]).ToString();
            }       
            closeConnection();
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            string strsel = "SELECT * FROM SACH WHERE MaSach = '" + txtMaSH.Text.ToString() + "'";
            SqlDataReader dr = getDataReader(strsel);
            while (dr.Read())
            {
                txtTenSach.Text = (dr["TenSach"]).ToString();
                txtTacGia.Text = (dr["TacGia"]).ToString();
                imageLocation = (dr["Anh"]).ToString();
                txtDonGia.Text = (dr["DonGia"]).ToString();
            }
            image1.ImageLocation = imageLocation;
            closeConnection();
        }

        void vohieuhoatxt()
        {
            txtHoTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            txtGioiTinh.Enabled = false;
            mtxtNgaySinh.Enabled = false;
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtDonGia.Enabled = false;
            txtMaKH2.Enabled = false;
            txtTongTien.Enabled = false;
        }

        void vohieuhoabtn()
        {
            btnTinhTien.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string[] row = { txtMaHD.Text, txtMaSH.Text, txtDonGia.Text, txtSoLuong.Value.ToString() };
            int sl = int.Parse(txtSoLuong.Value.ToString());
            int dongia = int.Parse(txtDonGia.Text);
            tongtien += (sl * dongia);

            txtTongTien.Text = tongtien.ToString();

            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            btnThanhToan.Enabled = true;

        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Value > 0)
                btnTinhTien.Enabled = true;
            else
                btnTinhTien.Enabled = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Luu hoa don:
            string MaHD1, MaSach;
            int DonGia, SL;

            string MaHD = txtMaHD.Text;
            string MaKH = txtMaKH2.Text;
            string MaNV = cboMaNV.SelectedValue.ToString();
            string NgayBan = txtNgayBan.Value.ToString("MM-dd-yyyy");
            int TongTien = int.Parse(txtTongTien.Text);
            try
            {
                string strSQL = "INSERT INTO HOADON VALUES ('" + MaHD + "', '" + MaKH + "', '" + MaNV + "', '" + NgayBan + "', " + TongTien + ")";
                updateToDB(strSQL);

                foreach (ListViewItem li in listView1.Items)
                {
                    MaHD1 = li.SubItems[0].Text;
                    MaSach = li.SubItems[1].Text;
                    DonGia = int.Parse(li.SubItems[2].Text);
                    SL = int.Parse(li.SubItems[3].Text);
                    string strSQL2 = "INSERT INTO CHITIETHOADON VALUES ('" + MaHD1 + "', '" + MaSach + "', " + DonGia + ", " + SL + ")";
                    updateToDB(strSQL2);
                }
                MessageBox.Show("Đã thanh toán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void reload()
        {
            frmPhieuBanSach newform = new frmPhieuBanSach();
            newform.Show();
            this.Dispose(false);
        }

        private void btnKhachMoi_Click(object sender, EventArgs e)
        {
            frmDanhSachKH formnv = new frmDanhSachKH();
            formnv.Show();
        }
    }
}
