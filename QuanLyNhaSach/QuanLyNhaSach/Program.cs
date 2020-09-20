using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmReportHoaDon());
            Application.Run(new frmTrangChinh());
            //Application.Run(new frmThongTinSach());
            //Application.Run(new frmLoaiSach());
            //Application.Run(new frmDanhSachKH());
            //Application.Run(new frmNhaCungCap());
            //Application.Run(new frmDanhSachNV());
            //Application.Run(new frmPhieuBanSach());
            //Application.Run(new frmPhieuNhapSach());
            //Application.Run(new frmNhanVien());
        }
    }
}
