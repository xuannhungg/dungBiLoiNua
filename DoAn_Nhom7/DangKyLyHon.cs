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
    public partial class DangKyLyHon : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        CongDanDAO cddao = new CongDanDAO();
        DBConnection dbconnection = new DBConnection();
        public DangKyLyHon()
        {
            InitializeComponent();
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dbconnection.KiemTraHonNhan(txtCMNDA.Text) && dbconnection.KiemTraHonNhan(txtCMNDB.Text))
            {
                CongDan cdA = new CongDan(txtCMNDA.Text);
                cddao.CapNhatLyHon(cdA);
                CongDan cdB = new CongDan(txtCMNDB.Text);
                cddao.CapNhatLyHon(cdB);
            }
            else
                MessageBox.Show("Co nguoi dang o tinh trang CHUA KET HON");
        }

        private void txtCMNDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbconnection.LapDayThongTinLyHon(txtCMNDA, txtTenA, txtNamSinhA, txtCuTruA);
            }

        }

        private void txtCMNDB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbconnection.LapDayThongTinLyHon(txtCMNDB, txtTenB, txtNamSinhB, txtCuTruB);
            }
        }

    }
}
