using SoftQuanLyNhaHang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang
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
            frmDangNhap frm = new frmDangNhap();
            Application.Run(frm);
            if (frm.IssuccessFull == true)
                Application.Run(new Views.frmMain());
        }
    }
}
