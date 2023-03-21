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
            if (dbconnection.KiemTraHonNhan(txtCMNDA.Text)==false && dbconnection.KiemTraHonNhan(txtCMNDB.Text)==false)
            {
                CongDan cdA = new CongDan(txtCMNDA.Text);
                cddao.CapNhatLyHon(cdA);
                CongDan cdB = new CongDan(txtCMNDB.Text);
                cddao.CapNhatLyHon(cdB);
            }
            else
                MessageBox.Show("Co nguoi dang o tinh trang Doc Than");
        }

        private void txtCMNDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbconnection.LapDayThongTinLyHon(txtCMNDA.Text, txtTenA, txtNamSinhA, txtCuTruA);
                txtCMNDB.Text = dbconnection.CMNDVoChong(txtCMNDA.Text);
                dbconnection.LapDayThongTinLyHon(txtCMNDB.Text, txtTenB, txtNamSinhB, txtCuTruB);
            }

        }



    }
}
