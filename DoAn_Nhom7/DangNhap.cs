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

namespace DoAn_Nhom7
{
    public partial class DangNhap : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        TaiKhoanDAO tkdao = new TaiKhoanDAO();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Tai khoan hoac mat khau khong duoc de trong");
            else
            {
                TaiKhoan tk = new TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
                tkdao.DangNhap(tk);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKi fDangKi = new DangKi();
            fDangKi.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
