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
    public partial class frmReportChiTietHoaDon : Form
    {
        string MaHD;
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-GCD5IJT4\SQLEXPRESS; Initial Catalog=QL_NhaSach;User ID=sa;Password=sql2012");
        public frmReportChiTietHoaDon(string MaHD)
        {
            this.MaHD = MaHD;
            InitializeComponent();
        }

        private void frmReportChiTietHoaDon_Load(object sender, EventArgs e)
        {
            ReportChiTietHoaDon rpt = new ReportChiTietHoaDon();
            conn.Open();
            string str = "SELECT * FROM CHITIETHOADON WHERE MaHD = '" + MaHD + "'";
            SqlDataAdapter dap = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
