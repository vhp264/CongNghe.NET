using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmReportHoaDon : Form
    {
        public frmReportHoaDon()
        {
            InitializeComponent();
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {
            ReportHoaDon rpt = new ReportHoaDon();
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa", "sql2012", "LAPTOP-GCD5IJT4\\SQLEXPRESS", "QL_NhaSach");
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();

        }
    }
}
