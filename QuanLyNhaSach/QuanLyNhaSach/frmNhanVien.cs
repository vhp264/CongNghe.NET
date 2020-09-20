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
    public partial class frmNhanVien : Form
    {
        int chon = 0;
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadlistView();
            vohieuhoatxt();
            vohieuhoabtn();
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

        public int getCount(string strSQL)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSQL;
            cmd.Connection = conn;
            int count = (int)cmd.ExecuteScalar();

            closeConnection();

            return count;
        }

        public bool checkForExistence(string tableName, string primaryKeyName, string primaryKeyValue)
        {
            string strSQL = "SELECT Count(*) FROM " + tableName + " WHERE " + primaryKeyName + "='" + primaryKeyValue + "'";
            int count = getCount(strSQL);
            if (count > 0)
                return true; //tồn tại
            return false; // không tồn tại
        }

        public void loadcbChucVu()
        {
            string [] cv = {"Quản lý", "Thu ngân", "Kiểm sách", "Bảo vệ"};
            foreach (string s in cv)
            {
                cboChucVu.Items.Add(s);
            }
            cboChucVu.SelectedIndex = 0;
        }

        public void vohieuhoatxt()
        {
            txtDiaChi.Enabled = false;
            txtHoTenNV.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            cboChucVu.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        public void hieuhoatxt()
        {
            txtDiaChi.Enabled = true;
            txtHoTenNV.Enabled = true;
            txtMaNV.Enabled = true;
            txtSDT.Enabled = true;
            cboChucVu.Enabled = true;
            dateTimePicker1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        public void cleartxt()
        {
            txtDiaChi.Clear();
            txtHoTenNV.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        public void vohieuhoabtn()
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }

        public void loadlistView()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            int i = 0;
            foreach (DataRow row in tb.Rows)
            {
                listView1.Items.Add((i + 1).ToString());
                listView1.Items[i].SubItems.Add(row["MaNV"].ToString());
                listView1.Items[i].SubItems.Add(row["TenNV"].ToString());
                listView1.Items[i].SubItems.Add(row["NgaySinh"].ToString());
                listView1.Items[i].SubItems.Add(row["GT"].ToString());
                listView1.Items[i].SubItems.Add(row["SĐT"].ToString());
                listView1.Items[i].SubItems.Add(row["DiaChi"].ToString());
                listView1.Items[i].SubItems.Add(row["ChucVu"].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String MaNV = listView1.SelectedItems[0].SubItems[1].Text;
            txtMaNV.Text = MaNV;
            String TenNV = listView1.SelectedItems[0].SubItems[2].Text;
            txtHoTenNV.Text = TenNV;            
            String NgaySinh = listView1.SelectedItems[0].SubItems[3].Text;            
            dateTimePicker1.Text = NgaySinh;
            String GT = listView1.SelectedItems[0].SubItems[4].Text;
            if (String.Compare(GT, "Nam", true) == 0)
            {
                radioButton1.Checked = true;
            }
            else if (String.Compare(GT, "Nữ", true) == 0)
            {
                radioButton2.Checked = true;
            }
            String SDT = listView1.SelectedItems[0].SubItems[5].Text;
            txtSDT.Text = SDT;
            String DC = listView1.SelectedItems[0].SubItems[6].Text;
            txtDiaChi.Text = DC;
            String ChucVu = listView1.SelectedItems[0].SubItems[7].Text;
            cboChucVu.Text = ChucVu;
        }

        private void btmThem_Click(object sender, EventArgs e)
        {
            if (String.Compare(btmThem.Text, "Hủy") == 0)
            {
                reload();
            }
            if (String.Compare(btmThem.Text, "Thêm") == 0)
            {
                btmThem.Text = "Hủy";
            }
            hieuhoatxt();
            cleartxt();
            loadcbChucVu();
            cboChucVu.Text = "Chọn chức vụ";
            txtMaNV.Focus();
            listView1.Enabled = false;

            btnLuu.Enabled = true;
            chon = 1;
        }

        public void reload()
        {
            frmNhanVien newform = new frmNhanVien();
            newform.Show();
            this.Dispose(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = txtMaNV.Text.Trim();
                string HoTenNV = txtHoTenNV.Text.Trim();
                string DiaChi = txtDiaChi.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string ChucVu = cboChucVu.Text.Trim();
                string NgaySinh = dateTimePicker1.Text.Trim();
                string GT;
                if (radioButton1.Checked == true)
                    GT = "Nam";
                else if (radioButton2.Checked == true)
                    GT = "Nữ";
                string strSQL = "DELETE dbo.NHANVIEN WHERE MaNV='" + MaNV + "'";
                updateToDB(strSQL);
                MessageBox.Show("Xóa thành công nhân viên mã: " + MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.Compare(btmThem.Text, "Hủy") == 0)
            {
                reload();
            }
            hieuhoatxt();
            chon = 2;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            { 
                
            }
            else if (chon == 2)
            {
                try
                {

                    string MaNV = txtMaNV.Text.Trim();
                    string HoTenNV = txtHoTenNV.Text.Trim();
                    string DiaChi = txtDiaChi.Text.Trim();
                    string SDT = txtSDT.Text.Trim();
                    string ChucVu = cboChucVu.Text.Trim();
                    string NgaySinh = dateTimePicker1.Text.Trim();
                    string GT = "";
                    if (radioButton1.Checked == true)
                        GT = "Nam";
                    else if (radioButton2.Checked == true)
                        GT = "Nữ";
                    bool kq = checkForExistence("NHANVIEN", "MaNV", MaNV);
                    if (kq == false)
                    {
                        MessageBox.Show("Không tồn tại mã nv: " + MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string strSQL = "UPDATE dbo.NHANVIEN SET MaNV='" + MaNV + "'," + "TenNV=N'" + HoTenNV + "'," + "DiaChi=N'" + DiaChi + "'," + "SĐT='" + SDT + "'," + "ChucVu=N'" + ChucVu + "'," + "NgaySinh='" + NgaySinh + "'," + "GT=N'" + GT + "' WHERE MaNV ='" + MaNV + "'";
                    updateToDB(strSQL);
                    MessageBox.Show("Sửa thành công nv mã: " + MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
