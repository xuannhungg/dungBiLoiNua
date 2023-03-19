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
    public partial class DangKi : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        TaiKhoanDAO tkdao = new TaiKhoanDAO();
        public DangKi()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Tai khoan hoac mat khau khong duoc de trong");
            else
            {
                TaiKhoan tk = new TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
                tkdao.DangKy(tk);
            }
        }
    }
}
