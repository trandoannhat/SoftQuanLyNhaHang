using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        public  bool IssuccessFull=false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Hãy nhập vào tên đăng nhập");
                txtTenDangNhap.Focus();
                //return;

            }
            else
            {
                if (string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show("Hãy nhập vào mật khẩu");
                    txtMatKhau.Focus();
                }
            }

            string check = "";
            string user = txtTenDangNhap.Text;
            string pass = Models.UserControl.SHA256(txtMatKhau.Text);
            check = Controllers.DangNhap.CheckDangNhap(user, pass);
            if (check == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");

            }
            else
            {
                IssuccessFull = true;
                //frmMain frm = new frmMain();
                //this.Hide();
                //frm.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
