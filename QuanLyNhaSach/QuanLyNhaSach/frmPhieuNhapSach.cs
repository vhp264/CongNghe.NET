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
    public partial class frmPhieuNhapSach : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        DataSet ds_QLNS = new DataSet();
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }

        public void hienstt(ListView lv)
        {
            int soitem = lv.Items.Count;
            for (int i = 0; i < soitem; i++)
                lv.Items[i].Text = (i + 1).ToString();
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

        public void loadCombobox_MaNV()
        {
            string strsel = "SELECT * FROM NHANVIEN";
            SqlDataAdapter da_KH = new SqlDataAdapter(strsel, conn);
            da_KH.Fill(ds_QLNS, "MaNV");
            cboMaNV.DataSource = ds_QLNS.Tables["MaNV"];
            cboMaNCC.DisplayMember = "TenNV";
            cboMaNCC.ValueMember = "MaNV";
        }

        public void loadCombobox_MaNCC()
        {
            string strsel = "SELECT * FROM NHACUNGCAP";
            SqlDataAdapter da_KH = new SqlDataAdapter(strsel, conn);
            da_KH.Fill(ds_QLNS, "MaNCC");
            cboMaNV.DataSource = ds_QLNS.Tables["MaNCC"];
            cboMaNCC.DisplayMember = "TenNhaCungCap";
            cboMaNCC.ValueMember = "MaNhaCungCap";
        }

        public void loadlistview2()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUNHAP", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            int i = 0;
            foreach (DataRow row in tb.Rows)
            {
                listView2.Items.Add((i + 1).ToString());
                listView2.Items[i].SubItems.Add(row["MaPN"].ToString());
                listView2.Items[i].SubItems.Add(row["MaNV"].ToString());
                listView2.Items[i].SubItems.Add(row["MaNhaCungCap"].ToString());
                listView2.Items[i].SubItems.Add(row["NgayNhap"].ToString());
                listView2.Items[i].SubItems.Add(row["TongTien"].ToString());
                i++;
            }
        }
    }
}
